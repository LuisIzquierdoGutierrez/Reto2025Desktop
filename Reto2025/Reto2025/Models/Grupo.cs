using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Models
{
    public class Grupo
    {
        public int id;
        public Curso curso;
        public string codGrupo;
        public int numAlumnos;
        public bool activo;
        public Profesor tutor;

    }
}
