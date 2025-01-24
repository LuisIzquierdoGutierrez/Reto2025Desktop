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
    public partial class FrmContrato_transporte : Form
    {
        private ControlActividades controlActividades;
        private ControlEmpTransporte controlEmpresa;
        private ControlContratos controlContratos;
        private List<Actividad> actividades;
        private List<EmpTransporte> empresas;
        public FrmContrato_transporte()
        {
            controlActividades = new ControlActividades();
            controlEmpresa = new ControlEmpTransporte();
            controlContratos = new ControlContratos();
            cargarListaActividades();
            cargarListaContratos();
            InitializeComponent();
            
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
            Actividad idactividad =null;
            EmpTransporte idempresa =null;



                foreach (var actividad in actividades)
                {
                    if (actividad.titulo==cmbActividad.SelectedItem.ToString())
                    {
                        
                        idactividad = actividad;
                    }
                }

                foreach (var empresa in empresas)
                {
                    if (empresa.nombre == cmbEmpresa.SelectedItem.ToString())
                    {
                    
                    
                    idempresa = empresa;

                    
                }
                }
            if (idactividad == null) {

                MessageBox.Show("actividad vacia");
            }
            if (idempresa == null) {
                MessageBox.Show("empresa vacia");
            }

            Contrato contrato = new Contrato();
            contrato.id = null;
            contrato.actividad = idactividad;
            contrato.empTransporte = idempresa;

            
            contrato.contratada = false;
            contrato.importe =0;
            contrato.urlFactura = null;
            contrato.urlPresupuesto =null;


            bool completada = await controlContratos.GuardarContrato(contrato);


            this.Close();
        }
    }
}
