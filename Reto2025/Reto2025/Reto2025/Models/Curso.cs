using Reto2025.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class Curso
    {
        public int id;
        public string codCurso;
        public string titulo;
        public EtapaCurso etapa;
        public char nivel;
        public bool activo;
    }
}
