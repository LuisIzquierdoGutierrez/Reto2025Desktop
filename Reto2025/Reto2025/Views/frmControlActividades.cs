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
            lbl_fechainicio.Text += actividad.fini + " " + actividad.hini;
            lbl_fechafin.Text += actividad.ffin + " " + actividad.hfin;
        }
    }
}
