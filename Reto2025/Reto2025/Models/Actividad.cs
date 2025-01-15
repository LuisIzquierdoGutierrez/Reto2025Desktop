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
        
        public int id;
        public string titulo;
        public TipoActividad tipo;
        public string descripcion;
        public DateTime fini;
        public DateTime ffin;
        public DateTime hini;
        public DateTime hfin;
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




        public Actividad() { }
    }
}
