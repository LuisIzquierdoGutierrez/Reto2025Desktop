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
            EmpTransporte empTransporte = new EmpTransporte();
            empTransporte.id = null;
            empTransporte.nombre = txtNombreEmp.Text;
            empTransporte.cif = txtCif.Text;
            empTransporte.direccion = txtDireccion.Text;
            empTransporte.cp = txtCp.Text;
            empTransporte.localidad = txtLocalidad.Text;
            empTransporte.contacto = "tlf: " + txtNumContacto.Text + " mail: " + txtMailContacto.Text;
 

            if (await controlEmpTransporte.GuardarEmpresa(empTransporte))
            {
                MessageBox.Show("Empresa agregada correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar empresa, porfavor compruebe los datos");
            } 
        }

        private void FrmAgregarEmpresas_Load(object sender, EventArgs e)
        {

        }
    }
}
