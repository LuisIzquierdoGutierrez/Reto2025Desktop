using Reto2025.Models;
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

namespace Reto2025.Views
{
    public partial class frmControlCalendario : UserControl
    {
        public frmControlCalendario()
        {
            InitializeComponent();
        }
        public void diaSemana(int dias)
        {
            lbl_dia.Text = dias + "";
        }

        public void setNombreActividades(Actividad actividad)
        {
            if (actividad != null) { 
            lbl_evento.Text = actividad.titulo.ToString();
            }
            else
            {
                lbl_evento.Text = "";
            }
        }
        private void frmControlCalendario_Click(object sender, EventArgs e)
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
        }
    }
}
