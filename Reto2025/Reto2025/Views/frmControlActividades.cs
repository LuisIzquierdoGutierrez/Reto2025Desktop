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
    public partial class FrmControlActividades : UserControl
    {
        public FrmControlActividades()
        {
            InitializeComponent();
        }
        public void setDatos(Actividad actividad)
        {
            lbl_titulo.Text = actividad.titulo;
            lblHoraInicio.Text = "Hora inicio: " + actividad.hini.Substring(0, 5);
            if (actividad.fini == actividad.ffin)
            {
                lblFechaFin.Text = "Hora fin " + actividad.hfin.Substring(0, 5);

            }
            else
            {
                lblFechaFin.Text += DateTime.Parse(actividad.ffin).ToString("dd/MM/yy") + " " + actividad.hfin.Substring(0, 5);

            }
        }



        private void FrmControlActividades_Click(object sender, MouseEventArgs e)
        {
            FrmCursos cursos = new FrmCursos();
            cursos.Show();
        }
    }
}
