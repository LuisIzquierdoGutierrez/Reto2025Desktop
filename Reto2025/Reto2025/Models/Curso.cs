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
        public int id_curso;
        public string cod_curso;
        public string titulo;
        public EtapaCurso curso;
        public char nivel;
        public bool activo;
    }
}
