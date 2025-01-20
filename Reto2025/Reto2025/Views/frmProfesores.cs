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
    public partial class FrmProfesores : Form
    {
        private static List<Profesor> profesores;
        private ControlProfesores controlProfesores = new ControlProfesores();
        public FrmProfesores()
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
            foreach (Profesor profesor in profesores)
            {
                if (profesor.activo)
                {
                    item = new ListViewItem();
                    string[] row = { profesor.nombre, profesor.apellidos, profesor.correo, profesor.rol.ToString(), profesor.esJefeDep ? "si" : "no", profesor.depart.nombre };
                    item = new ListViewItem(row);
                    lwProfesores.Items.Add(item);
                }

            }
            lwProfesores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
