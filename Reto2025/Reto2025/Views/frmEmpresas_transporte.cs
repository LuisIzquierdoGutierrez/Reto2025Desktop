using Reto2025.Controls;
using Reto2025.Models;
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

    public partial class frmEmpresas_transporte : Form
    {
        public static List<EmpTransporte> empTransportes;
        private ControlEmpTransporte controlEmpTransporte = new ControlEmpTransporte();
        public frmEmpresas_transporte()
        {
            InitializeComponent();
            if (empTransportes == null)
            {
                loadEmpTransportes();
            }
            else
            {
                putEmpTransportes();
            }
        }

        private void putEmpTransportes()
        {
            ListViewItem item;
            foreach (EmpTransporte empTransporte in empTransportes)
            {
                item = new ListViewItem();
                string[] row = { empTransporte.nombre,empTransporte.contacto,empTransporte.localidad, empTransporte.direccion, empTransporte.cp, empTransporte.cif };
                item = new ListViewItem(row);
                lwEmpTransporte.Items.Add(item);
            }
            lwEmpTransporte.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private async void loadEmpTransportes()
        {
            empTransportes = await controlEmpTransporte.GetAllEmpTransporte();
            putEmpTransportes();
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
    }
}
