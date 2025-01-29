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

    public partial class FrmEmpresasTransporte : Form
    {
        public static List<EmpTransporte> empTransportes;
        private ControlEmpTransporte controlEmpTransporte = new ControlEmpTransporte();
        public FrmEmpresasTransporte()
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
            bool par = false;
            foreach (EmpTransporte empTransporte in empTransportes)
            {
                item = new ListViewItem();
                string[] row = { empTransporte.nombre,empTransporte.contacto,empTransporte.localidad, empTransporte.direccion, empTransporte.cp, empTransporte.cif };
                item = new ListViewItem(row);
                lwEmpTransporte.Items.Add(item);
                item.BackColor = par ? Color.DarkGray : Color.LightGray;
                par = !par;
            }
            lwEmpTransporte.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private async void loadEmpTransportes()
        {
            empTransportes = await controlEmpTransporte.GetAllEmpTransporte();
            putEmpTransportes();
        }

    }
}
