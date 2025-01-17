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
    public partial class frmProfesores : Form
    {
        private static List<Profesor> profesores;
        private ControlProfesores controlProfesores = new ControlProfesores();
        public frmProfesores()
        {
            InitializeComponent();
            if (profesores == null)
            {
                loadProfesores();
            }
            else
            {
                putProfesores();
            }
        }
        private async void loadProfesores()
        {
            profesores = await controlProfesores.GetAllProfesores();
            putProfesores();
        }
        private void putProfesores()
        {
            ListViewItem item;
            foreach (Profesor profesor in profesores) {
                {
                    item = new ListViewItem();
                    string[] row = {profesor.dni,profesor.nombre,profesor.apellidos,profesor.correo,profesor.password,profesor.rol.ToString(),profesor.activo.ToString(),profesor.urlFoto,profesor.esJefeDep.ToString(),profesor.depart.id.ToString()};
                    item = new ListViewItem(row);
                    lwProfesores.Items.Add(item);
                }
                lwProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
    }
}
