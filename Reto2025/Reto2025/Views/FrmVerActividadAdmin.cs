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
        private List<GrupoParticipante> gruposParticipantes;
        private List<ProfParticipante> profParticipantes;
        private Actividad actividad;
        private ControlProfParticipantes controlProfParticipantes;
        private ControlGruposParticipantes controlGruposParticipantes;
        private List<Profesor> profesores;
        private List<Grupo> grupos;
        public FrmVerActividadAdmin(Actividad actividad)
        {
            InitializeComponent();
            this.actividad = actividad;
            controlProfParticipantes =  new ControlProfParticipantes();
            controlGruposParticipantes = new ControlGruposParticipantes();
            CargarTablas();
            CargarProfesores();
            CargarGrupos();
            chkAlojamiento.Checked = actividad.alojamientoReq;
            chkTransporte.Checked = actividad.transporteReq;
            rtxAlojamientoFalso.Visible = !actividad.alojamientoReq;
            rtxTransporteFalso.Visible = !actividad.transporteReq;
            
            RellenarActividad();
        }

        private async void CargarGrupos()
        {
            grupos = await new ControlGrupos().GetAllGrupos();

            foreach (Grupo grupo in grupos)
            {
                cmbGrupos.Items.Add(grupo.codGrupo);
            }
            cmbGrupos.SelectedIndex = 0;
        }
        private async void CargarProfesores()
        {
            profesores = await new ControlProfesores().GetAllProfesores();

            foreach (Profesor prof in profesores)
            {
                cmbProfesores.Items.Add(prof.nombre+" "+prof.apellidos);
            }
            cmbProfesores.SelectedIndex = 0;
        }

        private async void CargarTablas()
        {
            await AgregarTablaGrupos();
            await AgregarTablaProfesores();
        }

        private async Task AgregarTablaGrupos()
        {
            gruposParticipantes = await controlGruposParticipantes.GetGruposActividad(actividad);

            if (gruposParticipantes != null)
            {
                IniciarTablaGrupos();
            }
            else
            {
                gruposParticipantes = new List<GrupoParticipante>();
                IniciarTablaGrupos();
            }
        }

        private async Task AgregarTablaProfesores()
        {
            profParticipantes = await controlProfParticipantes.GetProfParticipanteActividad(actividad);
            if (profParticipantes != null)
            {
                IniciarTablaProfesores();
            }
            else
            {
                profParticipantes = new List<ProfParticipante>();
                IniciarTablaProfesores();
            }
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
            rtxIncidencias.Text = actividad.incidencias;
            nudImporte.Value = (decimal)actividad.importePorAlumno;

            dtpFini.Value = DateTime.Parse(actividad.fini);
            dtpFfin.Value = DateTime.Parse(actividad.ffin);
            dtpHini.Text = actividad.hini.Substring(0, 5);
            dtpHfin.Text = actividad.hfin.Substring(0, 5);
        }

        private void IniciarTablaGrupos()
        {
            lvwgrupos.Clear();
            lvwgrupos.Columns.Add("Nombre");
            lvwgrupos.Columns.Add("Numero participantes");
            ListViewItem item;
            foreach (GrupoParticipante grupo in gruposParticipantes)
            {
                item = new ListViewItem();
                string[] row = { grupo.grupo.codGrupo, grupo.numParticipantes.ToString() };
                item = new ListViewItem(row);
                lvwgrupos.Items.Add(item);

            }
            lvwgrupos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void IniciarTablaProfesores()
        {
            lvwProfesores.Clear();
            lvwProfesores.Columns.Add("Nombre completo");
            lvwProfesores.Columns.Add("Departamento");
            ListViewItem item;
            foreach (ProfParticipante profesor in profParticipantes)
            {
                item = new ListViewItem();
                string[] row = { profesor.profesor.nombre + " " + profesor.profesor.apellidos, profesor.profesor.depart.codigo };
                item = new ListViewItem(row);
                lvwProfesores.Items.Add(item);

            }



            lvwProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
            actividad.incidencias = rtxIncidencias.Text;

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
            new FrmFotosActividad(actividad).Show();
        }

        private async void btnAddProfesor_Click(object sender, EventArgs e)
        {

            ProfParticipante prof = new ProfParticipante(actividad, profesores[cmbProfesores.SelectedIndex]);

            if (profParticipantes.Contains(prof)) { 
            
                await controlProfParticipantes.QuitarProfParticipante((int)profParticipantes[profParticipantes.IndexOf(prof)].id);
            }
            else
            {
                await controlProfParticipantes.GuardarProfParticipante(prof);
            }
           

            await AgregarTablaProfesores();
        }

        private async void btnAddGrupo_Click(object sender, EventArgs e)
        {
            int numAlumnos = (int)nudAlumnos.Value;
            GrupoParticipante grupo = new GrupoParticipante(actividad, grupos[cmbGrupos.SelectedIndex], numAlumnos);
            
            if (gruposParticipantes.Contains(grupo))
            {
                grupo = gruposParticipantes[gruposParticipantes.IndexOf(grupo)];
                if (numAlumnos > 0)
                {
                    
                    grupo.numParticipantes = numAlumnos;
                    await controlGruposParticipantes.ActualizarGrupoParticipante(grupo);
                }
                else
                {
                    await controlGruposParticipantes.QuitarGrupoParticipante((int)grupo.id);
                }
            }
            else if(numAlumnos > 0)
            {
                await controlGruposParticipantes.GuardarGrupoParticipante(grupo);
            }

            await AgregarTablaGrupos();
        }
    }
}
