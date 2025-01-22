using Reto2025.Controls;
using Reto2025.Enums;
using Reto2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Views
{
    public partial class FrmVerActividadAdmin : Form
    {
        private List<Grupo> grupos;
        private List<Profesor> profesores;
        private Actividad actividad;
        public FrmVerActividadAdmin(Actividad actividad)
        {
            InitializeComponent();
            CargarTablas();

            chkAlojamiento.Checked = actividad.alojamientoReq;
            chkTransporte.Checked = actividad.transporteReq;
            rtxAlojamientoFalso.Visible = !actividad.alojamientoReq;
            rtxTransporteFalso.Visible = !actividad.transporteReq;
            this.actividad = actividad;
            RellenarActividad();
        }

        private async void CargarTablas()
        {
            grupos = await new ControlGrupos().GetAllGrupos();
            profesores = await new ControlProfesores().GetAllProfesores();
        }

        private void RellenarActividad()
        {
            txtTitulo.Text = actividad.titulo;

            cmbTipo.Text = actividad.tipo.ToString().ToLower();
            lblTipo.Text = actividad.previstaIni ? "Actividad                                  prevista en la programacion" : "Actividad                                no prevista en la programacion";


            lblSolicitante.Text = "Solicitante: " + actividad.solicitante.nombre + " " + actividad.solicitante.apellidos;

            rtxDescripcion.Text = actividad.descripcion;
            rtxComentarios.Text = actividad.comentarios;

            cmbEstado.Text = actividad.estado.ToString().ToLower();
            rtxEstado.Text = actividad.comentEstado;

            dtpFini.Value = DateTime.Parse(actividad.fini);
            dtpFfin.Value = DateTime.Parse(actividad.ffin);
            dtpHini.Text = actividad.hini.Substring(0, 5);
            dtpHfin.Text = actividad.hfin.Substring(0, 5);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            lvwGeneral.Clear();
            lvwGeneral.Columns.Add("Nombre");
            lvwGeneral.Columns.Add("Numero alumnos");
            ListViewItem item;
            foreach (Grupo grupo in grupos)
            {
                item = new ListViewItem();
                string[] row = { grupo.codGrupo, grupo.numAlumnos.ToString() };
                item = new ListViewItem(row);
                lvwGeneral.Items.Add(item);

            }
            lvwGeneral.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            MessageBox.Show("falta hacer que solo meta los grupos que participan");
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            lvwGeneral.Clear();
            lvwGeneral.Columns.Add("Nombre completo");
            lvwGeneral.Columns.Add("Departamento");
            ListViewItem item;
            foreach (Profesor profesor in profesores)
            {
                item = new ListViewItem();
                string[] row = { profesor.nombre + " " + profesor.apellidos, profesor.depart.codigo };
                item = new ListViewItem(row);
                lvwGeneral.Items.Add(item);

            }



            lvwGeneral.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            MessageBox.Show("falta hacer que solo meta los profesores que participan y que salga si son responsables o no");
        }

        private void chkTransporte_CheckedChanged(object sender, EventArgs e)
        {
            rtxTransporteFalso.Visible = !chkTransporte.Checked;
        }

        private void chkAlojamiento_CheckedChanged(object sender, EventArgs e)
        {
            rtxAlojamientoFalso.Visible = !chkAlojamiento.Checked;
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            actividad.titulo = txtTitulo.Text;
            Enum.TryParse(cmbTipo.Text, true, out TipoActividad tipo);
            actividad.tipo = tipo;


            actividad.fini = dtpFini.Value.ToString("yyyy-MM-dd");
            actividad.ffin = dtpFfin.Value.ToString("yyyy-MM-dd");
            actividad.hini = dtpHini.Text;
            actividad.hfin = dtpHfin.Text;


            actividad.comentarios = rtxComentarios.Text;
            actividad.descripcion = rtxDescripcion.Text;
            actividad.importePorAlumno = (float)nudImporte.Value;

            Enum.TryParse(cmbEstado.Text, true, out EstadoActividad estado);
            actividad.estado = estado;
            if (chkAlojamiento.Checked)
            {
                actividad.alojamientoReq = true;
                actividad.comentAlojamiento = rtxAlojamiento.Text;
            }
            else
            {
                actividad.alojamientoReq = false;
            }

            if (chkTransporte.Checked)
            {
                actividad.transporteReq = true;
                actividad.comentTransporte = rtxTransporte.Text;
            }
            else
            {
                actividad.transporteReq = false;
            }


            bool completada = await new ControlActividades().ActualizarActividad(actividad);
            if (completada)
            {
                MessageBox.Show("actividad creada con exito");
            }
            else
            {
                MessageBox.Show("No se a podido crear la actividad \n Si este fallo contina por favor contacte al administrador");
            }

        }
    }
}
