using Reto2025.Controls;
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
    public partial class FrmVerActividad : Form
    {
        private List<Grupo> grupos;
        private List<Profesor> profesores;
        public FrmVerActividad(Actividad actividad)
        {
            InitializeComponent();
            CargarTablas();

            lblAlojamiento.Enabled = actividad.alojamientoReq;
            lblTransporte.Enabled = actividad.transporteReq;
            rtxAlojamiento.Enabled = actividad.alojamientoReq;
            rtxTransporte.Enabled = actividad.transporteReq;

            RellenarActividad(actividad);
        }

        private async void CargarTablas()
        {
            grupos = await new ControlGrupos().GetAllGrupos();
            profesores = await new ControlProfesores().GetAllProfesores();
        }

        private void RellenarActividad(Actividad actividad)
        {
            lblTitulo.Text = actividad.titulo;
            if (actividad.previstaIni)
            {
                lblTipo.Text = "Actividad " + actividad.tipo.ToString().ToLower() + " prevista en la programacion";
            }
            else
            {
                lblTipo.Text = "Actividad " + actividad.tipo.ToString().ToLower() + " no prevista en la programacion";
            }

            lblSolicitante.Text = "Solicitante: " + actividad.solicitante.nombre + " " + actividad.solicitante.apellidos;

            rtxDescripcion.Text = actividad.descripcion;
            rtxComentarios.Text = actividad.comentarios;

            lblEstado.Text = "Estado: " + actividad.estado.ToString().ToLower();
            rtxEstado.Text = actividad.comentEstado;

            lblFini.Text = "Fecha Inicio: " + DateTime.Parse(actividad.fini).ToString("dd/MM/yy");
            lblFfni.Text = "Fecha Fin: " + DateTime.Parse(actividad.ffin).ToString("dd/MM/yy");
            lblHini.Text = actividad.hini.Substring(0, 5);
            lblHfni.Text = actividad.hfin.Substring(0, 5);

            rtxTransporte.Text = rtxTransporte.Enabled ? actividad.comentTransporte : "Transporte no requerido";
            rtxAlojamiento.Text = rtxAlojamiento.Enabled ? actividad.comentAlojamiento : "Alojamiento no requerido";
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
    }
}
