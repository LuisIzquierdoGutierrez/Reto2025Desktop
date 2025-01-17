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
                lbl_idsActividades.Text = actividad.id.ToString() + ",";
            }
            else
            {
                lbl_evento.Text = "";
            }
        }
        private void frmControlCalendario_Click(object sender, EventArgs e)
        {
            if (lbl_evento.Text != "")
            {

                frmInicio inicio = new frmInicio();
                inicio.mostrarActividades(lbl_idsActividades.Text);

            }
        }
        public void ResaltarDiaActual(bool esHoy)
        {
            if (esHoy)
            {
                this.BackColor = Color.LightBlue;
                lbl_dia.ForeColor = Color.White;
                lbl_dia.Font = new Font(lbl_dia.Font, FontStyle.Bold); 
            }
            else
            {
                this.BackColor = Color.White; 
                lbl_dia.ForeColor = Color.Black;
                lbl_dia.Font = new Font(lbl_dia.Font, FontStyle.Regular); 
            }
        }
       
        }
}
