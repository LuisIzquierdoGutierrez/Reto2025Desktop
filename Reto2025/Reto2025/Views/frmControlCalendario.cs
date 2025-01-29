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
    public partial class FrmControlCalendario : UserControl
    {
        public FrmInicio FormularioPadre { get; set; }
        public List<Actividad> ActividadesDelDia { get; set; } = new List<Actividad>();
        private FrmControlCalendario diaSeleccionado;
        public static FrmControlCalendario controlCalendario = null;
        public FrmControlCalendario()
        {
            InitializeComponent();
        }

        public void diaSemana(int dias)
        {
            lblDia.Text = dias.ToString();
        }

        public void setNombreActividades(Actividad actividad)
        {
            if (actividad != null)
            {
                lblActividad.Text += actividad.titulo.ToString() + "\n";
               
                ActividadesDelDia.Add(actividad);
            }
            else
            {
                lblActividad.Text = "";
            }
        }

        private void frmControlCalendario_Click(object sender, EventArgs e)
        {


            FrmControlCalendario diaActual = this;
            if (diaActual != null && diaActual.ActividadesDelDia.Count > 0)
            {

                if (controlCalendario != null)
                {
                    if (controlCalendario.lblDia.Text == DateTime.Now.Day.ToString())
                    {
                        controlCalendario.BackColor = Color.FromArgb(0xFF, 0xB2, 0xDF, 0x7A);
                    }
                    else
                    {
                        controlCalendario.BackColor = Color.LightGray;
                    }
                    

                }
                controlCalendario = diaActual;
                controlCalendario.BackColor = Color.LightCoral;




                FormularioPadre.mostrarActividades(diaActual.ActividadesDelDia);
            }
        }
        public void ResaltarDiaActual(bool esHoy)
        {
            if (esHoy)
            {
                this.BackColor = Color.FromArgb(0xFF, 0xB2, 0xDF, 0x7A); ;
                lblDia.ForeColor = Color.Black;
                lblDia.Font = new Font(lblDia.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.LightGray;
                lblDia.ForeColor = Color.Black;
                lblDia.Font = new Font(lblDia.Font, FontStyle.Regular);
            }
        }

    }
}

