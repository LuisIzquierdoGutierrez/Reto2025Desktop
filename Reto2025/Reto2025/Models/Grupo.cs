using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto2025.Models
{
    public class Grupo : IEquatable<Grupo>
    {
        public int id;
        public Curso curso;
        public string codGrupo;
        public int numAlumnos;
        public bool activo;
        public Profesor tutor;

        public override bool Equals(object obj)
        {
            return Equals(obj as Grupo);
        }

        public bool Equals(Grupo other)
        {
            return !(other is null) &&
                   id == other.id;
        }

        public static bool operator ==(Grupo left, Grupo right)
        {
            return EqualityComparer<Grupo>.Default.Equals(left, right);
        }

        public static bool operator !=(Grupo left, Grupo right)
        {
            return !(left == right);
        }
    }
}
