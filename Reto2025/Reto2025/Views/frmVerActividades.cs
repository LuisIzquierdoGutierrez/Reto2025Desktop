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
    public partial class frmVerActividades : Form
    {
        private static List<Actividad> actividades;
        private ControlActividades controlActividades=new ControlActividades();
        public frmVerActividades()
        {
            InitializeComponent();
            if (actividades == null)
            {
                loadActividades();
            }
            else
            {
                putActividades();
            }
        }
    private async void loadActividades()
    {
        actividades = await controlActividades.GetAllActividades();
            putActividades();
    }
    private void putActividades()
    {
        ListViewItem item;
        foreach (Actividad actividad in actividades)
        {
            item = new ListViewItem();
                string[] row = { actividad.titulo, actividad.tipo.ToString(), actividad.descripcion, actividad.fini.ToString(), actividad.ffin.ToString(), actividad.hini.ToString(), actividad.hfin.ToString(), actividad.previstaIni.ToString(),actividad.transporteReq.ToString(),actividad.comentTransporte,actividad.alojamientoReq.ToString(),actividad.comentAlojamiento,actividad.comentarios,actividad.estado.ToString(),actividad.comentEstado,actividad.incidencias,actividad.urlFolleto,actividad.solicitante.uuid.ToString(),actividad.importePorAlumno.ToString()};
            item = new ListViewItem(row);
            lwActividades.Items.Add(item);
        }
        lwActividades.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

        private void btnVolver_Click(object sender, EventArgs e)
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
