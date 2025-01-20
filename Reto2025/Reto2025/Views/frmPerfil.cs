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
using Reto2025.Models;

namespace Reto2025.Views
{
    public partial class FrmPerfil : Form
    {
        public FrmPerfil(Profesor profesor)
        {
            InitializeComponent();
            CargarDatos(profesor);
        }

        private void CargarDatos(Profesor profesor)
        {
            lblNombre.Text += profesor.nombre;
            lblApellidos.Text += profesor.apellidos;
            lblCorreo.Text += profesor.correo;
            lblDepartamento.Text += profesor.depart.nombre;
            lblRol.Text += profesor.rol.ToString();
        }



        //       public void validadCampos()
        //       {

        //           List<String> campos = new List<string>();

        //           campos.Add(txt_dni.Text);
        //           campos.Add(txt_nombre.Text);
        //           campos.Add(txt_apellidos.Text);
        //           campos.Add(txt_departamento.Text);
        //           campos.Add(txt_correo.Text);
        //           campos.Add(cmb_rol.Text);
        //           campos.Add(txt_contraseña.Text);


        //           List<String> nombrecampos = new List<string>();

        //           nombrecampos.Add(lbl_dni.Text);
        //           nombrecampos.Add(lbl_nombre.Text);
        //           nombrecampos.Add(lbl_apellidos.Text);
        //           nombrecampos.Add(lbl_departamento.Text);
        //           nombrecampos.Add(lbl_correo.Text);
        //           nombrecampos.Add(lbl_rol.Text);
        //           nombrecampos.Add(lbl_pass.Text);

        //           String mensaje_error = "";
        //           int num_errores = 0;

        //           List<String> errores = new List<String>();

        //           for (int i = 0; i < campos.Count; i++)
        //           {
        //               if (string.IsNullOrWhiteSpace(campos[i]))
        //               {
        //                   errores.Add(nombrecampos[i]);
        //                   num_errores++;

        //               }
        //           }

        //           if (num_errores == 1)
        //           {
        //               mensaje_error = "el campo " + errores[0] + " esta vacio";
        //           }
        //           if (num_errores > 1)
        //           {
        //               mensaje_error = "Los campos ";

        //               for (int i = 0; i < errores.Count; i++)
        //               {
        //                   if (i < errores.Count - 1)
        //                   {
        //                       mensaje_error += errores[i] + ",";
        //                   }
        //                   else
        //                   {
        //                       mensaje_error += errores[i];
        //                   }
        //               }
        //               mensaje_error += " estan vacios";
        //           }

        //           MessageBox.Show(mensaje_error);
        //       }

        //       private void btn_modificar_Click(object sender, EventArgs e)
        //       {

        //       }
        //       /*  public void validadCampos()
        //{
        //    if (string.IsNullOrWhiteSpace(txt_dni.Text))
        //    {
        //        MessageBox.Show("el campo dni esta vacio");
        //    }
        //    if (string.IsNullOrWhiteSpace(txt_nombre.Text))
        //    {
        //        MessageBox.Show("el campo nombre esta vacio");
        //    }
        //    if (string.IsNullOrWhiteSpace(txt_apellidos.Text))
        //    {
        //        MessageBox.Show("el campo apellidos esta vacio");
        //    }

        //    if (string.IsNullOrWhiteSpace(cmb_rol.Text))
        //    {
        //        MessageBox.Show("el campo rol esta vacio");
        //    }
        //    if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
        //    {
        //        MessageBox.Show("el campo contraseña esta vacio");
        //    }
        //}*/
        //   }

    }
}
