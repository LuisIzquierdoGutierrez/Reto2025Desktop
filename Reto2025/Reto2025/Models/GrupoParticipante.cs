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
        public Actividad actividad;
        public Grupo grupo;
        public int num_participantes;
        public string comentario;
    }
}
