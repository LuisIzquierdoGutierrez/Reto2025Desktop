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
    public partial class FrmControlFoto : UserControl
    {
        private String url;
        public FrmControlFoto(String url)
        {
            this.url = url;
            InitializeComponent();
            picFoto.Load(url);
        }

        private void picFoto_DoubleClick(object sender, EventArgs e)
        {
            new FrmFoto(FrmFotosActividad.urls, url).ShowDialog();
        }
    }
}
