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
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            validarCampos();

           /* Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                frmInicio inicio = new frmInicio();
                Application.Run(inicio);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();*/
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

        private void btn_verGrupos_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Grupos_Participantes grupos_Participantes = new Grupos_Participantes();
                Application.Run(grupos_Participantes);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void btn_fotos_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Fotos_actividades fotos_Actividades = new Fotos_actividades();
                Application.Run(fotos_Actividades);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        public void validarCampos()
        {

            if (chk_alojamiento.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_comentAloj.Text))
                {
                    MessageBox.Show("el campo comentario de alojamiento esta vacio");
                }
            }

            if (chck_transporte.Checked)
            {
                if (string.IsNullOrWhiteSpace(cmb_tipo_transporte.Text))
                {
                    MessageBox.Show("el campo tipo de transporte esta vacio");
                }
            }

            if (string.IsNullOrWhiteSpace(txt_titulo.Text))
            { 
                 MessageBox.Show("el campo titulo esta vacio");
            }

            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("el campo descripcion esta vacio");
            }

            if (string.IsNullOrWhiteSpace(txt_cometariosGenerales.Text))
            {
                MessageBox.Show("el campo comentarios generales esta vacio");
            }

            if (string.IsNullOrWhiteSpace(txt_comentTransp.Text))
            {
                MessageBox.Show("el campo comentarios del transporte esta vacio");
            }

            if (string.IsNullOrWhiteSpace(txt_importe.Text))
            {
                MessageBox.Show("el campo importe esta vacio");
            }

            if (string.IsNullOrWhiteSpace(txt_incidencias.Text))
            {
                MessageBox.Show("el campo incidencias esta vacio");
            }

            if (string.IsNullOrWhiteSpace(cmb_tipos.Text))
            {
                MessageBox.Show("el campo tipos esta vacio");
            }

            if (string.IsNullOrWhiteSpace(dtp_fechaIni.Text))
            {
                MessageBox.Show("el campo fecha inicio esta vacio");
            }

            if (string.IsNullOrWhiteSpace(dtp_fechafin.Text))
            {
                MessageBox.Show("el campo fecha fim esta vacio");
            }

            if (string.IsNullOrWhiteSpace(dtp_horaini.Text))
            {
                MessageBox.Show("el campo hora inicio esta vacio");
            }

            if (string.IsNullOrWhiteSpace(dtp_horafin.Text))
            {
                MessageBox.Show("el campo hora fin esta vacio");
            }

            if (string.IsNullOrWhiteSpace(dtp_fechaProvista.Text))
            {
                MessageBox.Show("el campo fecha provista esta vacio");
            }
            
        }
    }
}
