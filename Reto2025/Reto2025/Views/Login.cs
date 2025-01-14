using Reto2025.Controls;
using Reto2025.Models;
using Reto2025.Views;
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

namespace Reto2025
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }


        private void btn_inicio_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Inicio inicio = new Inicio();
                Application.Run(inicio);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();

        }

        private void btn_registarse_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Registro registro = new Registro();
                Application.Run(registro);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
    }
}
