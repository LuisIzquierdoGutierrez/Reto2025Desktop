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
using Reto2025.Controls;
using Reto2025.Models;

namespace Reto2025.Views
{
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {         
            InitializeComponent();
            CargarDatos(FrmInicio.user);
        }

        private async void CargarDatos(Profesor profesor)
        {
            lblNombre.Text += profesor.nombre;
            lblApellidos.Text += profesor.apellidos;
            lblCorreo.Text += profesor.correo;
            lblDepartamento.Text += profesor.depart.nombre;
            lblRol.Text += profesor.rol.ToString();
            ControlFotos fotos = new ControlFotos();
            try
            {
                picFoto.Load(fotos.GetFotoUrl(profesor));
            }
            catch (Exception e)
            {
                picFoto.Load("https://i.pinimg.com/originals/dc/ab/b7/dcabb7fbb2f763d680d20a3d228cc6f9.jpg");
            }
        }
    }
}
