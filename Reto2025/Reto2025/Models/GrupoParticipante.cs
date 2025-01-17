using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class GrupoParticipante
    {
        public int id;
        public Actividad actividades;
        public Grupo grupo;
        public int numParticipantes;
        public string comentario;
    }
}
