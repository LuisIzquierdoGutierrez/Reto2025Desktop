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
    public partial class FrmLogin : Form
    {
        private  ControlProfesores controlProfesores;
        public FrmLogin()
        {
            InitializeComponent();
            controlProfesores = new ControlProfesores();
        }

        private async void btn_inicio_Click(object sender, EventArgs e)
        {
            Profesor profesor = await controlProfesores.GetLogin(txt_correo.Text,txt_pass.Text);
            if(profesor != null){
                if (profesor.activo)
                {
                    this.Hide();
                    FrmInicio inicio = new FrmInicio(profesor);

                    // añade al form inicio que cierre este form cuando se cierre
                    inicio.Closed += (s, args) => this.Close();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("usuario no activo");
                }

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAutorizacion frm = new FrmAutorizacion();
            frm.ShowDialog();
        }
    }
}
