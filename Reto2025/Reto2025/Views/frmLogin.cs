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

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            Profesor profesor = await controlProfesores.GetLogin("alicia.fernandez@educantabria.es", "1234");
            if (profesor != null)
            {
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







            //metodo para iniciar el buscador por defecto con la pagina web señalada

            //string target = "http://www.microsoft.com";
            ////Use no more than one assignment when you test this code.
            ////string target = "ftp://ftp.microsoft.com";
            ////string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            //try
            //{
            //    System.Diagnostics.Process.Start(target);
            //}
            //catch (System.ComponentModel.Win32Exception noBrowser)
            //{
            //    if (noBrowser.ErrorCode == -2147467259)
            //        MessageBox.Show(noBrowser.Message);
            //}
            //catch (System.Exception other)
            //{
            //    MessageBox.Show(other.Message);
            //}





        }
    }
}
