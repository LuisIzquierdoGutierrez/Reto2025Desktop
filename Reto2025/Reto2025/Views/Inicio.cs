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
    public partial class Inicio : Form
    {
      static DateTime inicioMES = DateTime.Now;
        public Inicio()
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
                Actividades actividades = new Actividades();
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
                Cursos cursos = new Cursos();
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
                Profesores profesores = new Profesores();
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
                Departamentos departamentos = new Departamentos();
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
                Empresas_transporte empresas = new Empresas_transporte();
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
                Perfil perfil = new Perfil();
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
                ControlCalendarioBlanco controlCalendarioBlanco = new ControlCalendarioBlanco();
                controlCalendarioBlanco.Text = i.ToString();  
                daycontainer.Controls.Add(controlCalendarioBlanco);
            }

            for (int i = 1; i <= dias; i++)
            {
                ControlCalendario controlCalendario = new ControlCalendario();
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
