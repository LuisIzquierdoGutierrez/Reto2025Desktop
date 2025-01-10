using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Models
{
    internal class Grupo
    {
        public int id_grupo;
        public Curso curso;
        public string cod_grupo;
        public int num_alumnos;
        public bool activo;
        public Profesor tutor;

    }
}
