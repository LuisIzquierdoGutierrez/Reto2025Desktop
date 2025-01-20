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
    public partial class FrmActividades : Form
    {
        public FrmActividades()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            validadCampos();

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

        public void validadCampos()
        {

            List<String> campos = new List<string>();
            campos.Add(txt_titulo.Text);
            campos.Add(cmb_tipos.Text);
            campos.Add(txt_descripcion.Text);
            campos.Add(dtp_fechaIni.Text);
            campos.Add(dtp_fechafin.Text);
            campos.Add(dtp_horaini.Text);
            campos.Add(dtp_horafin.Text);
            campos.Add(dtp_fechaProvista.Text);
            campos.Add(txt_cometariosGenerales.Text);
            campos.Add(txt_comentTransp.Text);
            campos.Add(txt_comentAloj.Text);
            campos.Add(txt_incidencias.Text);
            campos.Add(txt_importe.Text);
            

            List<String> nombrecampos = new List<string>();
            nombrecampos.Add(lbl_titulo.Text);
            nombrecampos.Add(lbl_tipo.Text);
            nombrecampos.Add(lblDescripcion.Text);
            nombrecampos.Add(lblFechaini.Text);
            nombrecampos.Add(lblFechafin.Text);
            nombrecampos.Add(lblHoraini.Text);
            nombrecampos.Add(lblHorafin.Text);
            nombrecampos.Add(lbl_fechaProv.Text);
            nombrecampos.Add(lbl_comentGen.Text);
            nombrecampos.Add(lbl_comentTransp.Text);
            nombrecampos.Add(lbl_comentAloj.Text);
            nombrecampos.Add(lbl_incidencias.Text);
            nombrecampos.Add(lbl_importe.Text);

            String mensaje_error = "";
            int num_errores = 0;

            List<String> errores = new List<String>();

            for (int i = 0; i < campos.Count; i++)
            {

                if (string.IsNullOrWhiteSpace(campos[i]))
                {
                    if (!chck_transporte.Checked && string.IsNullOrWhiteSpace(cmb_tipo_transporte.Text) && string.IsNullOrWhiteSpace(txt_comentTransp.Text))
                    {

                    }
                    else
                    {
                        errores.Add(nombrecampos[i]);
                        num_errores++;
                    }

                }
            }

            if (num_errores == 1)
            {
                mensaje_error = "el campo " + errores[0] + " esta vacio";
            }
            if (num_errores > 1)
            {
                mensaje_error = "Los campos ";

                for (int i = 0; i < errores.Count; i++)
                {
                    if (i < errores.Count - 1)
                    {
                        mensaje_error += errores[i] + ",";
                    }
                    else
                    {
                        mensaje_error += errores[i];
                    }
                }
                mensaje_error += " estan vacios";
            }

            MessageBox.Show(mensaje_error);
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
