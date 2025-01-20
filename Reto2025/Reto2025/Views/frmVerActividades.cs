using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reto2025.Controls;
using Reto2025.Models;

namespace Reto2025.Views
{
    public partial class FrmVerActividades : Form
    {
        private Profesor user;

        private static List<Actividad> actividades;
        private static List<GrupoParticipante> grupoParticipantes;
        private static List<ProfParticipante> profParticipantes;
        private static List<ProfResponsable> profResponsables;
        private ControlActividades controlActividades = new ControlActividades();
        public FrmVerActividades(Profesor user)
        {
            InitializeComponent();
            this.user = user;
            if (actividades == null)
            {
                loadActividades();
            }
            else
            {
                putActividades(actividades);
            }
        }
        private async void loadActividades()
        {
            actividades = FrmInicio.actividades;
            grupoParticipantes = await new ControlGruposParticipantes().GetAllGruposParticipantes();
            profParticipantes = await new ControlProfParticipantes().GetAllProfParticipantes();
            profResponsables = await new ControlProfResponsables().GetAllProfResponsables();
            putActividades(actividades);
        }
        private void putActividades(List<Actividad> actividadesTmp)
        {
            lwActividades.Items.Clear();
            ListViewItem item;
            foreach (Actividad actividad in actividadesTmp)
            {
                item = new ListViewItem();
                string[] row = { actividad.titulo, actividad.tipo.ToString(), actividad.descripcion, actividad.fini.ToString(), actividad.ffin.ToString(), actividad.hini.ToString(), actividad.hfin.ToString(), actividad.previstaIni.ToString(), actividad.transporteReq.ToString(), actividad.comentTransporte, actividad.alojamientoReq.ToString(), actividad.comentAlojamiento, actividad.comentarios, actividad.estado.ToString(), actividad.comentEstado, actividad.incidencias, actividad.urlFolleto, actividad.solicitante.uuid.ToString(), actividad.importePorAlumno.ToString() };
                item = new ListViewItem(row);
                lwActividades.Items.Add(item);
            }
            lwActividades.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void filtrado(object sender, EventArgs e)
        {
            List<Actividad> actividadesTmp = actividades;
            List<Actividad> tmp = new List<Actividad>();
            List<Actividad> grupoParticipantesTmp = new List<Actividad>();
            List<Actividad> profParticipacion = new List<Actividad>();
            bool filtroEstado = cmbEstado.Text.Equals("Cualquiera") ? false : true;
            bool filtroCurso = cmbCurso.Text.Equals("Cualquiera") ? false : true;
            bool filtroParticipacion = cmbParticipacion.Text.Equals("Cualquiera") ? false : true;
            bool filtroTipo = cmbTipo.Text.Equals("Cualquiera") ? false : true;

            if (filtroCurso)
            {
                
                foreach (GrupoParticipante grupo in grupoParticipantes)
                {
                    if (grupo.grupo.curso.codCurso.Equals(cmbCurso.Text))
                    {
                        grupoParticipantesTmp.Add(grupo.actividades);
                    }
                }

                foreach (Actividad actividad in actividadesTmp)
                {

                    if (grupoParticipantesTmp.Contains(actividad))
                    {
                        tmp.Add(actividad);
                    }
                }

                actividadesTmp = tmp.ToList();
                tmp.Clear();
            }

            if (filtroEstado)
            {
                
                foreach (Actividad actividad in actividadesTmp)
                {

                    if (actividad.estado.ToString().Equals(cmbEstado.Text.ToUpper()))
                    {
                      
                        tmp.Add(actividad);
                    }
                }

                actividadesTmp = tmp.ToList();
                tmp.Clear();
                putActividades(actividadesTmp);
            }



            if (filtroTipo)
            {

                foreach (Actividad actividad in actividadesTmp)
                {

                    if (actividad.tipo.ToString().Equals(cmbTipo.Text.ToLower()))
                    {

                        tmp.Add(actividad);
                    }
                }

                actividadesTmp = tmp.ToList();
                tmp.Clear();
                putActividades(actividadesTmp);
            }

            if (filtroParticipacion)
            {
                if (cmbParticipacion.Text.Equals("Participante"))
                {
                    foreach (ProfParticipante profesor in profParticipantes)
                    {
                        if (profesor.profesor.uuid.Equals(user.uuid))
                        {
                            profParticipacion.Add(profesor.actividad);
                        }
                    }

                    foreach (Actividad actividad in actividadesTmp)
                    {

                        if (profParticipacion.Contains(actividad))
                        {
                            tmp.Add(actividad);
                        }
                    }
                }
                else
                {
                    foreach (ProfResponsable profesor in profResponsables)
                    {
                        if (profesor.profesor.uuid.Equals(user.uuid))
                        {
                            profParticipacion.Add(profesor.actividad);
                        }
                    }

                    foreach (Actividad actividad in actividadesTmp)
                    {

                        if (profParticipacion.Contains(actividad))
                        {
                            tmp.Add(actividad);
                        }
                    }
                }
                

                actividadesTmp = tmp.ToList();
                tmp.Clear();
            }




            putActividades(actividadesTmp);
            
            
        }
    }
}
