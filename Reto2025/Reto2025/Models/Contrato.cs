using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class Contrato
    {
        public Nullable<int> id;
        public Actividad actividad;
        public EmpTransporte empTransporte;
        public bool contratada;
        public double importe;
        public string urlPresupuesto;
        public string urlFactura;

        public Contrato(Actividad actividad, EmpTransporte empTransporte)
        {
            this.id = null;
            this.actividad = actividad;
            this.empTransporte = empTransporte;
            this.contratada = false;
        }

        public Contrato()
        {
        }
    }
}
