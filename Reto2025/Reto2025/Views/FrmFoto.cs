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
    public partial class FrmFoto : Form
    {
        private List<String> fotos;
        private int posicion;
        public FrmFoto(List<string> urls, string url)
        {
            fotos = urls;
            posicion = fotos.IndexOf(url);
            InitializeComponent();
            picFoto.Load(url);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (posicion < fotos.Count - 1)
            {
                posicion++;
            }
            else
            {
                posicion = 0;
            }
            picFoto.Load(fotos[posicion]);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
            }
            else
            {
                posicion = fotos.Count - 1;
            }
            picFoto.Load(fotos[posicion]);
        }
    }
}
