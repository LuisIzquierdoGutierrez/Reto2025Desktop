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
    public partial class frmAutorizacion : Form
    {
        public frmAutorizacion()
        {
            InitializeComponent();
        }

        Bitmap bitmap;

        private void CaptureFormShot()
        {
            bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap,new Rectangle(0,0,this.Width,this.Height-40));
        }

        



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = e.PageBounds;
            e.Graphics.DrawImage(bitmap, m);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CaptureFormShot();
            printPreviewDialog1.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
