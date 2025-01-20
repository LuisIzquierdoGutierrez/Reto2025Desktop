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
            nombrecampos.Add(lbl_importe.Text);

            String mensaje_error = "";
            int num_errores = 0;

            List<String> errores = new List<String>();

            for (int i = 0; i < campos.Count; i++)
            {

                if (string.IsNullOrWhiteSpace(campos[i]))
                {
                    errores.Add(nombrecampos[i]);
                    num_errores++;
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

    }
}
