using Reto2025.Controls;
using Reto2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Views
{
    public partial class FrmInicio : Form
    {
        private readonly ControlActividades controlAct = new ControlActividades();

        public static List<Actividad> actividades;
        static DateTime inicioMES = DateTime.Now;

        public static Profesor user;

        private FrmCrearActividad frmActividades;
        private FrmVerActividades frmVerActividades;
        private FrmCursos frmCursos;
        private FrmProfesores frmProfesores;
        private FrmDepartamentos frmDepartamentos;
        private FrmEmpresasTransporte frmEmpresasTransporte;
        private FrmPerfil frmPerfil;
        private FrmAgregarEmpresas frmAgregarEmpresas;
        private FrmContratoActividad frmContratoActividad;

        public FrmInicio(Profesor profesor)
        {
            this.BackColor = Color.FromArgb(0xFF, 0x9F, 0xD3, 0x56);
            InitializeComponent();
            user = profesor;
            inicioMES = new DateTime(inicioMES.Year, inicioMES.Month, 1);
            

        }
        private async void frmInicio_Load(object sender, EventArgs e)
        {

            actividades = await controlAct.GetAllActividades();

            dias_de_mierda(null, actividades);

        }


        private void tsmi_crearActividades_Click(object sender, EventArgs e)
        {
            if (frmActividades != null)
            {
                frmActividades.Close();
            }

            frmActividades = new FrmCrearActividad();
            frmActividades.Show();

        }

        private void tsmi_verCursos_Click(object sender, EventArgs e)
        {
            
            if(frmCursos != null)
            {
                frmCursos.Close();
            }
            frmCursos = new FrmCursos();
            frmCursos.Show();
        }

        private void tsmi_verProfesores_Click(object sender, EventArgs e)
        {
            
            if(frmProfesores != null)
            {
                frmProfesores.Close();
            }
            frmProfesores = new FrmProfesores();
            frmProfesores.Show();
        }

        private void tsmi_verDepartamentos_Click(object sender, EventArgs e)
        {
            
            if( frmDepartamentos != null)
            {
                frmDepartamentos.Close();
            }
            frmDepartamentos = new FrmDepartamentos();
            frmDepartamentos.Show();
        }

        private void tsmi_verEmpresas_Click(object sender, EventArgs e)
        {
            
            if(frmEmpresasTransporte != null)
            {
                frmEmpresasTransporte.Close();
            }
            frmEmpresasTransporte = new FrmEmpresasTransporte();
            frmEmpresasTransporte.Show();
        }

        private void tsmi_perfil_Click(object sender, EventArgs e)
        {
            if (frmPerfil != null)
            {
                frmPerfil.Close();
            }
            frmPerfil = new FrmPerfil();
          frmPerfil.Show();
        }

        private void dias_de_mierda(int? opMes, List<Actividad> actividades)
        {

            switch (opMes)
            {
                case 1:
                    inicioMES = inicioMES.AddMonths(-1);
                    break;

                case 2:
                    inicioMES = inicioMES.AddMonths(1);
                    break;

                default:
                    break;
            }

            String mesletras = DateTimeFormatInfo.CurrentInfo.GetMonthName(inicioMES.Month);
            lbl_mes.Text = mesletras + "    " + inicioMES.Year;

            List<Actividad> actividades_mes = new List<Actividad>();

            foreach (Actividad actividad in actividades)
            {
                if (DateTime.Parse(actividad.fini).Month == inicioMES.Month)
                {
                    actividades_mes.Add(actividad);
                }
            }

            int dias = DateTime.DaysInMonth(inicioMES.Year, inicioMES.Month);
            int dias_semana = Convert.ToInt32(inicioMES.DayOfWeek.ToString("d"));
            daycontainer.Controls.Clear();

            if (dias_semana == 0)
            {
                dias_semana = 7;
            }


            for (int i = 2; i <= dias_semana; i++)
            {
                FrmControlCalendarioBlanco controlCalendarioBlanco = new FrmControlCalendarioBlanco();
                controlCalendarioBlanco.Text = i.ToString();
                daycontainer.Controls.Add(controlCalendarioBlanco);
            }


            for (int i = 1; i <= dias; i++)
            {
                FrmControlCalendario controlCalendario = new FrmControlCalendario();

                controlCalendario.FormularioPadre = this;

               if (i == DateTime.Today.Day && inicioMES.Month == DateTime.Today.Month && inicioMES.Year == DateTime.Today.Year)
                {
                    controlCalendario.ResaltarDiaActual(true);
                }
                else
                {
                    controlCalendario.ResaltarDiaActual(false);
                }


                foreach (Actividad actividadMes in actividades_mes)
                {
                    if (i == DateTime.Parse(actividadMes.fini).Day)
                    {                       
                        controlCalendario.setNombreActividades(actividadMes);
                    }
                }

                controlCalendario.Text = i.ToString();
                controlCalendario.diaSemana(i);


                daycontainer.Controls.Add(controlCalendario);
            }

        }

        private void btn_mesAnterior_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            dias_de_mierda(1, actividades);
        }

        private void btn_mesSiguiente_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            dias_de_mierda(2, actividades);
        }

        private void normativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNormativa().Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmFAQ().Show();
        }
        public void mostrarActividades(List<Actividad> actividadesDelDia)
        {

            activityContainer.Controls.Clear();


            foreach (Actividad actividad in actividadesDelDia)
            {
                FrmControlActividades controlActividades = new FrmControlActividades();
                controlActividades.setDatos(actividad);
                activityContainer.Controls.Add(controlActividades);
            }
        }

        private void verActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmVerActividades != null)
            {
                frmVerActividades.Close();
            }
            frmVerActividades = new FrmVerActividades(user);
            frmVerActividades.Show();
        }

        private void añadirEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAgregarEmpresas != null)
            {
                frmAgregarEmpresas.Close();
            }
            frmAgregarEmpresas = new FrmAgregarEmpresas(user);
            frmAgregarEmpresas.Show();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmContratoActividad != null)
            {
                frmContratoActividad.Close();
            }
            frmContratoActividad = new FrmContratoActividad();
            frmContratoActividad.Show();
        }
    }
}




