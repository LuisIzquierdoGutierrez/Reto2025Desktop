using Reto2025.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class Actividad
    {
        
        public Nullable<int> id;
        public string titulo;
        public TipoActividad tipo;
        public string descripcion;
        public string fini;
        public string ffin;
        public string hini;
        public string hfin;
        public bool previstaIni;
        public bool transporteReq;
        public string comentTransporte;
        public bool alojamientoReq;
        public string comentAlojamiento;
        public string comentarios;
        public EstadoActividad estado;
        public string comentEstado;
        public string incidencias;
        public string urlFolleto;
        public Profesor solicitante;
        public float importePorAlumno;
        public string longitud;
        public string latitud;




        public Actividad() { }

        public override bool Equals(object obj)
        {
            return obj is Actividad actividad &&
                   id == actividad.id;
        }
    }
}
