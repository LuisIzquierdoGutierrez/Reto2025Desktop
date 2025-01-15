using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Views
{
    public partial class frmInicio : Form
    {
      static DateTime inicioMES = DateTime.Now;
        public frmInicio()
        {
            InitializeComponent();
            
            inicioMES = new DateTime(inicioMES.Year, inicioMES.Month, 1);
            dias_de_mierda(null);

        }

        private void tsmi_crearActividades_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmActividades actividades = new frmActividades();
                Application.Run(actividades);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void tsmi_verCursos_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmCursos cursos = new frmCursos();
                Application.Run(cursos);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void tsmi_verProfesores_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmProfesores profesores = new frmProfesores();
                Application.Run(profesores);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void tsmi_verDepartamentos_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmDepartamentos departamentos = new frmDepartamentos();
                Application.Run(departamentos);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void tsmi_verEmpresas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmEmpresas_transporte empresas = new frmEmpresas_transporte();
                Application.Run(empresas);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void tsmi_perfil_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmPerfil perfil = new frmPerfil();
                Application.Run(perfil);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void dias_de_mierda(int? opMes)
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




            int dias = DateTime.DaysInMonth(inicioMES.Year, inicioMES.Month);

            int dias_semana =Convert.ToInt32(inicioMES.DayOfWeek.ToString("d"));
            daycontainer.Controls.Clear();
            if (dias_semana==0)
            {
                dias_semana = 7;
            }

            label1.Text = dias_semana.ToString();

            for (int i = 2; i <= dias_semana; i++)
            {
                frmControlCalendarioBlanco controlCalendarioBlanco = new frmControlCalendarioBlanco();
                controlCalendarioBlanco.Text = i.ToString();  
                daycontainer.Controls.Add(controlCalendarioBlanco);
            }
                        if (inicioMES.Month == 2)
            {
                dias = 28;
            }
            for (int i = 1; i <= dias; i++)
            {
                frmControlCalendario controlCalendario = new frmControlCalendario();
                controlCalendario.Text = i.ToString();
                controlCalendario.diaSemana(i);
                daycontainer.Controls.Add(controlCalendario);
            }


        }

        private void btn_mesAnterior_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            dias_de_mierda(1);
        }

        private void btn_mesSiguiente_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            dias_de_mierda(2);
        }
    }
}
