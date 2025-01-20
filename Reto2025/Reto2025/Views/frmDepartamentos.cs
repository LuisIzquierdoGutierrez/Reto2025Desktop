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
    public partial class FrmDepartamentos : Form
    {
        public static List<Departamento> departamentos;
        private ControlDepartamentos controlDepartamentos = new ControlDepartamentos();
        public FrmDepartamentos()
        {
            InitializeComponent();

            if (departamentos == null)
            {
                loadDepartamentos();
            }
            else
            {
                putDepartamentos();
            }
        }

        private async void loadDepartamentos()
        {
            departamentos = await controlDepartamentos.GetAllDepartamentos();
            putDepartamentos();
        }

        private void putDepartamentos()
        {
            ListViewItem item;
            foreach (Departamento departamento in departamentos)
            {
                item = new ListViewItem();
                string[] row = { departamento.codigo, departamento.nombre };
                item = new ListViewItem(row);
                lwDepartamentos.Items.Add(item);
            }
            lwDepartamentos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


    }
}
