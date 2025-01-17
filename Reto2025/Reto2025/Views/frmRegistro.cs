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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }


        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmInicio inicio = new frmInicio();
                Application.Run(inicio);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmLogin login = new frmLogin();
                Application.Run(login);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        public void validadCampos()
        {

            List<String> campos = new List<string>();

            campos.Add(txt_nombre.Text);
            campos.Add(txt_apellidos.Text);
            campos.Add(txt_correo.Text);
            campos.Add(txt_pass1.Text);
            campos.Add(txt_pass2.Text);

            List<String> nombrecampos = new List<string>();

            nombrecampos.Add(lbl_nombre.Text);
            nombrecampos.Add(lbl_apellidos.Text);
            nombrecampos.Add(lbl_correo.Text);
            nombrecampos.Add(lbl_pass1.Text);
            nombrecampos.Add(lbl_pass2.Text);

            String mensaje_error = "";
            int num_errores = 0;

            List <String> errores = new List<String>();

            foreach (String campo in campos) { 

                if (string.IsNullOrWhiteSpace(campo))
                {
                   // errores.Add(nombrecampos.);
                    num_errores++;


                }
            }

        }
        public void validadCampos2()
        {

            List<String> campos = new List<string>();

            campos.Add(txt_nombre.Text);
            campos.Add(txt_apellidos.Text);
            campos.Add(txt_correo.Text);
            campos.Add(txt_pass1.Text);
            campos.Add(txt_pass2.Text);

            List<String> nombrecampos = new List<string>();

            nombrecampos.Add(lbl_nombre.Text);
            nombrecampos.Add(lbl_apellidos.Text);
            nombrecampos.Add(lbl_correo.Text);
            nombrecampos.Add(lbl_pass1.Text);
            nombrecampos.Add(lbl_pass2.Text);

            String mensaje_error = "";
            int num_errores = 0;

            List<String> errores = new List<String>();

            for (int i = 0; i < campos.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(campos[i]))
                {
                    errores.Add(nombrecampos[i]);
                    num_errores++;

                }
            }

            if (num_errores == 1)
            {
                mensaje_error = "el campo " + errores[0] + " esta vacio";
            }
            if (num_errores > 1)
            {
                mensaje_error = "Los campos ";

                for (int i = 0; i < errores.Count; i++)
                {
                    if (i < errores.Count - 1)
                    {
                        mensaje_error += errores[i] + ",";
                    }
                    else
                    {
                        mensaje_error += errores[i];
                    }
                }
                mensaje_error += " estan vacios";
            }

            MessageBox.Show(mensaje_error);
        }
    }
}
