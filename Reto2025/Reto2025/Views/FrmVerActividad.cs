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
        private List<GrupoParticipante> grupos;
        private List<ProfParticipante> profesores;
        private Actividad actividad;
        public FrmVerActividad(Actividad actividad)
        {
            InitializeComponent();
            this.actividad = actividad;
            CargarTablas();
            lblAlojamiento.Enabled = actividad.alojamientoReq;
            lblTransporte.Enabled = actividad.transporteReq;
            rtxAlojamiento.Enabled = actividad.alojamientoReq;
            rtxTransporte.Enabled = actividad.transporteReq;

            RellenarActividad();
        }

        private async void CargarTablas()
        {
            grupos = await new ControlGruposParticipantes().GetGruposActividad(actividad);
            profesores = await new ControlProfParticipantes().GetProfParticipanteActividad(actividad);
            if (profesores != null)
            {
                IniciarProfesores();
            }
            if (grupos != null)
            {
                IniciarGrupos();
            }
           
        
        }

        private void RellenarActividad()
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
            rtxIncidencias.Text = actividad.incidencias;

            lblImporte.Text += actividad.importePorAlumno;

            lblEstado.Text = "Estado: " + actividad.estado.ToString().ToLower();
            rtxEstado.Text = actividad.comentEstado;

            lblFini.Text = "Fecha Inicio: " + DateTime.Parse(actividad.fini).ToString("dd/MM/yy");
            lblFfni.Text = "Fecha Fin: " + DateTime.Parse(actividad.ffin).ToString("dd/MM/yy");
            lblHini.Text = actividad.hini.Substring(0, 5);
            lblHfni.Text = actividad.hfin.Substring(0, 5);

            rtxTransporte.Text = rtxTransporte.Enabled ? actividad.comentTransporte : "Transporte no requerido";
            rtxAlojamiento.Text = rtxAlojamiento.Enabled ? actividad.comentAlojamiento : "Alojamiento no requerido";
        }

        private void IniciarGrupos()
        {
            lvwgrupos.Clear();
            lvwgrupos.Columns.Add("Nombre");
            lvwgrupos.Columns.Add("Numero alumnos");
            ListViewItem item;
            foreach (GrupoParticipante grupo in grupos)
            {
                item = new ListViewItem();
                string[] row = { grupo.grupo.codGrupo, grupo.grupo.numAlumnos.ToString() };
                item = new ListViewItem(row);
                lvwgrupos.Items.Add(item);

            }
            lvwgrupos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void IniciarProfesores()
        {
            lvwProfesores.Clear();
            lvwProfesores.Columns.Add("Nombre completo");
            lvwProfesores.Columns.Add("Departamento");
            ListViewItem item;
            foreach (ProfParticipante profesor in profesores)
            {
                item = new ListViewItem();
                string[] row = { profesor.profesor.nombre + " " + profesor.profesor.apellidos, profesor.profesor.depart.codigo };
                item = new ListViewItem(row);
                lvwProfesores.Items.Add(item);

            }



            lvwProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
   
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //metodo para iniciar el buscador por defecto con la pagina web señalada

            string target = $"http://localhost:8080/acex/actividades/excel?actividad={actividad.id}";
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void btnFotos_Click(object sender, EventArgs e)
        {
            new FrmFotosActividad(actividad).ShowDialog();
        }
    }
}
