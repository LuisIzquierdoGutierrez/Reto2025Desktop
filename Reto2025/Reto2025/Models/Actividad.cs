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
        public bool prevista_ini;
        public bool transporte_req;
        public string coment_transporte;
        public bool alojamiento_req;
        public string coment_alojamiento;
        public string comentarios;
        public EstadoActividad estado;
        public string coment_estado;
        public string incidencias;
        public string url_folleto;
        public Profesor solicitante;
        public float importe_por_alumno;




        public Actividad() { }
    }
}
