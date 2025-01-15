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

    }
}
