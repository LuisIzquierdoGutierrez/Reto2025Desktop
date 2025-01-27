using Reto2025.Controls;
using Reto2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Reto2025.Views
{
    public partial class FrmContratoTransporte : Form
    {
        private ControlActividades controlActividades;
        private ControlEmpTransporte controlEmpresa;
        private ControlContratos controlContratos;
        private List<Actividad> actividades;
        private List<EmpTransporte> empresas;
        private string urlfactura = "";
        private string urlpresupuesto = "";
        private Actividad actividad;
        public FrmContratoTransporte(Actividad actividad)
        {
            InitializeComponent();
            this.actividad = actividad;
            //controlActividades = new ControlActividades();
            controlEmpresa = new ControlEmpTransporte();
            controlContratos = new ControlContratos();
           // cargarListaActividades();
            cargarListaContratos();
            
            
            
        }

        private async void cargarListaActividades()
        {
           actividades = await controlActividades.GetAllActividades();
            foreach (var actividad in actividades)
            {
                cmbActividad.Items.Add(actividad.titulo);
            }

        }
        private async void cargarListaContratos()
        {
            empresas = await controlEmpresa.GetAllEmpTransporte();
            foreach(var empresa in empresas)
            {
                cmbEmpresa.Items.Add(empresa.nombre);
            }
        }


        private async void btn_crear_Click(object sender, EventArgs e)
        {
           // Actividad actividad =null;
            EmpTransporte empTransporte =null;




                foreach (var empresa in empresas)
                {
                    if (empresa.nombre == cmbEmpresa.Text)
                    {
                    
                    
                    empTransporte = empresa;

                    
                }
                }

            if (empTransporte == null) {
                MessageBox.Show("empresa vacia");
            }
            else
            {
                Contrato contrato = new Contrato(actividad, empTransporte);

                contrato.importe = Convert.ToDouble(mudImporte.Value);
                contrato.urlFactura = urlfactura;
                contrato.urlPresupuesto = urlpresupuesto;


                bool completada = await controlContratos.GuardarContrato(contrato);


                this.Close();
            }


        }



        private void btnFactura_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofdFactura = new OpenFileDialog();
            if (ofdFactura.ShowDialog() == DialogResult.OK)
            {
                urlfactura = Path.GetFileName(ofdFactura.FileName);
            }



        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFactura = new OpenFileDialog();
            if (ofdFactura.ShowDialog() == DialogResult.OK)
            {
                urlpresupuesto = Path.GetFileName(ofdFactura.FileName);
            }

        }
    }
}
