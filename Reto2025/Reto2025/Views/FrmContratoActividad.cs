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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.Collections.Specialized;

namespace Reto2025.Views
{
    public partial class FrmContratoActividad : Form
    {
        private ControlEmpTransporte controlEmpTransporte;
        private ControlActividades controlActividades;
        private ControlContratos controlContratos;
        public FrmContratoActividad()
        {
            
            controlEmpTransporte = new ControlEmpTransporte();
            controlActividades = new ControlActividades();
            controlContratos = new ControlContratos();  
            InitializeComponent();

            cargaActividades(controlActividades);
            cargaEmpresas(controlEmpTransporte);

        }
        private async void cargaEmpresas(ControlEmpTransporte controlEmpTransporte)
        {
            List<EmpTransporte> empresas =  await controlEmpTransporte.GetAllEmpTransporte();

            foreach (var emp in empresas)
            {
                cmbEmpresas.Items.Add(emp.nombre); 
                cmbIdEmpresas.Items.Add(emp.id);
            }
        }
        private async void cargaActividades(ControlActividades controlActividades)
        {
            List<Actividad> actividad = await controlActividades.GetAllActividades();
            foreach (var act in actividad)
            {
                cmbActividades.Items.Add(act.titulo);
                cmbIdActividades.Items.Add(act.id);
            }
        }

        private int idEmpresa()
        {
            cmbIdEmpresas.SelectedIndex=cmbEmpresas.SelectedIndex;
            MessageBox.Show(cmbIdEmpresas.SelectedIndex+"");
                return 0;
        }
        private int idActividad()
        {
            cmbIdActividades.SelectedIndex = cmbActividades.SelectedIndex;

            String texto =""+ cmbIdActividades.Items.IndexOf(cmbEmpresas.SelectedIndex);
            MessageBox.Show(texto);
            return 0;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {

            idActividad();

           // idEmpresa();

            Contrato contrato = new Contrato();



        /*    if( await controlContratos.GuardarContrato(contrato))
            {
                MessageBox.Show("furrula coño",
                "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("pta bihda tete",
                "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void FrmContratoActividad_Load(object sender, EventArgs e)
        {

        }
    }
}
