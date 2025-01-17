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
    public partial class frmLogin : Form
    {
        private  ControlProfesores controlProfesores;
        public frmLogin()
        {
            InitializeComponent();
            controlProfesores = new ControlProfesores();
        }

        private async void btn_inicio_Click(object sender, EventArgs e)
        {
            Profesor profesor = await controlProfesores.GetLogin(txt_correo.Text,txt_pass.Text);
            if(profesor != null){

                this.Hide();
                frmInicio inicio = new frmInicio();

                // añade al form inicio que cierre este form cuando se cierre
                inicio.Closed += (s, args) => this.Close();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
            

        }

        private void btn_registarse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("registro no se va ha usar y se tendria que quitar");
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmRegistro registro = new frmRegistro();
                Application.Run(registro);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
    }
}
