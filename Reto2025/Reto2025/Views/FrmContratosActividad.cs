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
    public partial class FrmContratosActividad : Form
    {
        private Actividad actividad;
        private ControlContratos controlContratos;
        private List<Contrato> contratos;
        public FrmContratosActividad(Actividad actividad)
        {
            InitializeComponent();
            controlContratos = new ControlContratos();
            this.actividad = actividad;
            CargarTabla();
        }

        private async void CargarTabla()
        {
            lvwContratos.Items.Clear();

            contratos = await controlContratos.GetContratosActividad(actividad);
            if (contratos != null)
            {

                ListViewItem item;
                foreach (Contrato contrato in contratos)
                {
                    item = new ListViewItem();
                    string[] row = { contrato.empTransporte.nombre, contrato.importe.ToString(), contrato.contratada ? "si" : "no" };
                    item = new ListViewItem(row);
                    item.Tag = contrato;
                    lvwContratos.Items.Add(item);
                }
                lvwContratos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
      


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             new FrmContratoTransporte(actividad).ShowDialog();
            CargarTabla();
        }

        private async void lvwContratos_DoubleClickAsync(object sender, EventArgs e)
        {
            
            if(lvwContratos.SelectedItems[0] != null)
            {
                Contrato contrato;

                contrato =(Contrato)lvwContratos.SelectedItems[0].Tag;

                contrato.contratada = !contrato.contratada;

                await controlContratos.ActualizarContrato(contrato);
                CargarTabla();
            }
        }
    }
}
