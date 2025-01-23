using Reto2025.Controls;
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
    public partial class FrmAgregarEmpresas : Form
    {
        private Profesor user;
        private ControlEmpTransporte controlEmpTransporte;
        public FrmAgregarEmpresas(Profesor user)
        {
            controlEmpTransporte = new ControlEmpTransporte();
            InitializeComponent();
            this.user = user;

        }
        private async void btnCrear_Click(object sender, EventArgs e)
        {

            string patronmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string patrontelefono = "^(\\d{7,10}|\\d{10,10})$";
            EmpTransporte empTransporte = new EmpTransporte();
            empTransporte.id = null;
            empTransporte.nombre = txtNombreEmp.Text;
            empTransporte.cif = txtCif.Text;
            empTransporte.direccion = txtDireccion.Text;
            empTransporte.cp = txtCp.Text;
            empTransporte.localidad = txtLocalidad.Text;
            empTransporte.contacto = "tlf: " + txtNumContacto.Text + " mail: " + txtMailContacto.Text;
            /*
                if (string.IsNullOrEmpty(txtNombreEmp.Text))
                {
                    MessageBox.Show("El nombre de la empresa esta vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("El campo direccion esta vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(txtLocalidad.Text))
                {
                    MessageBox.Show("El campo localidad esta vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtCp.Text.Length != 5)
                {
                    MessageBox.Show("Formato del codigo postal incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (!Regex.IsMatch(txtNumContacto.Text, patrontelefono))
                {
                    MessageBox.Show("El formato del cif es incorrecto.",
                    "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (!Regex.IsMatch(txtMailContacto.Text, patronmail))
                {
                    MessageBox.Show("El correo es incorrecto.",
                                    "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              */ 

            if (await controlEmpTransporte.GuardarEmpresa(empTransporte))
            {
                MessageBox.Show("furrula coño",
                "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("pta bihda tete",
                "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void FrmAgregarEmpresas_Load(object sender, EventArgs e)
        {

        }
    }
}
