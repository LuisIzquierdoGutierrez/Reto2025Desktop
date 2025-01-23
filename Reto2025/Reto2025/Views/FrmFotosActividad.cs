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
    public partial class FrmFotosActividad : Form
    {
        private Actividad actividad;
        private ControlFotos controlFotos;
        private List<Foto> fotos;
        public static List<String> urls;
        public FrmFotosActividad(Actividad actividad)
        {
            InitializeComponent();
            urls = new List<String>();
            this.actividad = actividad;
            controlFotos = new ControlFotos();
            CargarFotos();

        }

        private async void CargarFotos()
        {
            List<Foto> fotos = await controlFotos.GetAllFotosActividad(actividad);
            FrmControlFoto frmFoto;
            String url;
            foreach (Foto foto in fotos)
            {
                // url = controlFotos.GetFotoUrl(foto);
                url = "https://cdn-images.dzcdn.net/images/cover/c6774b1a84273d54cdc7ee2031503bfd/0x1900-000000-80-0-0.jpg";

                urls.Add(url);
                frmFoto = new FrmControlFoto(url);
                flpFotosNube.Controls.Add(frmFoto);
            }
        }
    }
}
