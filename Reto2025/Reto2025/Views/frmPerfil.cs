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
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
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
        public void validadCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("el campo dni esta vacio");
            }
            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("el campo nombre esta vacio");
            }
            if (string.IsNullOrWhiteSpace(txt_apellidos.Text))
            {
                MessageBox.Show("el campo apellidos esta vacio");
            }
            if (string.IsNullOrWhiteSpace(pictureBox1.Text))
            {
                MessageBox.Show("el campo imagen esta vacio");
            }
            if (string.IsNullOrWhiteSpace(cmb_rol.Text))
            {
                MessageBox.Show("el campo rol esta vacio");
            }
            if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                MessageBox.Show("el campo contraseña esta vacio");
            }
        }
    }
   
}
