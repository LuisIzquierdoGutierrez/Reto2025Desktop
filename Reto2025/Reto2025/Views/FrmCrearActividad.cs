using Reto2025.Controls;
using Reto2025.Enums;
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
    public partial class FrmCrearActividad : Form
    {
        private ControlActividades controlActividades;
        public FrmCrearActividad()
        {
            InitializeComponent();
            controlActividades = new ControlActividades();     
        }


        private void chck_transporte_CheckedChanged(object sender, EventArgs e)
        {
            lblComentTransp.Enabled = chkTransporte.Checked;
            txtComentTransp.Enabled= chkTransporte.Checked;
        }

        private void chkAlojamiento_CheckedChanged(object sender, EventArgs e)
        {
            lblComentAloj.Enabled = chkAlojamiento.Checked;
            txtComentAloj.Enabled = chkAlojamiento.Checked;
        }

        private async void btnCrear_ClickAsync(object sender, EventArgs e)
        {

            if (txtTitulo.Text.Length > 0)
            {
                Models.Actividad actividad = new Models.Actividad();
                actividad.id = null;
                actividad.solicitante = FrmInicio.user;
                actividad.titulo = txtTitulo.Text;

                Enum.TryParse(cmbTipo.Text.ToUpper(), true, out TipoActividad result);
                actividad.tipo = result;
                MessageBox.Show(actividad.tipo.ToString());
                actividad.previstaIni = chkInicioPrevisto.Checked;
                
                actividad.fini = dtpFini.Value.ToString("yyyy-MM-dd");
                actividad.ffin = dtpFfin.Value.ToString("yyyy-MM-dd");
                actividad.hini = dtpHini.Text;
                actividad.hfin = dtpHfin.Text;

                actividad.comentarios = txtCometariosGenerales.Text;
                actividad.descripcion = txtDescripcion.Text;
                actividad.importePorAlumno = (float)nudImporte.Value;
                actividad.estado = EstadoActividad.SOLICITADA;
                if (chkAlojamiento.Checked)
                {
                    actividad.alojamientoReq = true;
                    actividad.comentAlojamiento = txtComentAloj.Text;
                }
                else
                {
                    actividad.alojamientoReq = false;
                }

                if (chkTransporte.Checked)
                {
                    actividad.transporteReq = true;
                    actividad.comentTransporte = txtComentTransp.Text;
                }
                else
                {
                    actividad.transporteReq = false;
                }


                bool completada = await controlActividades.GuardarActividad(actividad);
                if (completada)
                {
                    MessageBox.Show("actividad creada con exito");
                }
                else
                {
                    MessageBox.Show("No se a podido crear la actividad \n Si este fallo contina por favor contacte al administrador");
                }
            }
            else
            {
                MessageBox.Show("La actividad necesita un titulo");
            }



            //Actividad actividad = await controlActividades.GetActividadId(11);

            //MessageBox.Show(actividad.titulo);
            //MessageBox.Show(actividad.tipo.ToString());
            //controlActividades.GuardarActividad(actividad);

        }
    }
}
