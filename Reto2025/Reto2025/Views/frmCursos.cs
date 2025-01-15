using Reto2025.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reto2025.Views
{

    public partial class frmCursos : Form
    {
        private static List<Curso> cursos;
        private ControlCursos controlCursos = new ControlCursos();
        
        public frmCursos()
        {
            InitializeComponent();
            if(cursos == null)
            {
                loadCursos();
                
            }
            else
            {
                putCursos();
            }
            
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

        private async void loadCursos()
        {
            cursos = await controlCursos.GetAllCursos();
            putCursos();
        }
        private void putCursos()
        {
            ListViewItem item;
            foreach (Curso curso in cursos)
            {
                item  = new ListViewItem();
                string[] row = { curso.codCurso.ToString(), curso.titulo, curso.etapa.ToString(), curso.nivel.ToString() };
                item = new ListViewItem(row);
                lwCursos.Items.Add(item);
            }
            lwCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
