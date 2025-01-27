using Reto2025.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class Profesor : IEquatable<Profesor>
    {
        public string uuid;
        public string dni;
        public string nombre;
        public string apellidos;
        public string correo;
        public string password;
        public RolProfesor rol;
        public bool activo;
        public string urlFoto;
        public bool esJefeDep;
        public Departamento depart;

        public override bool Equals(object obj)
        {
            return Equals(obj as Profesor);
        }

        public bool Equals(Profesor other)
        {
            return !(other is null) &&
                   uuid == other.uuid;
        }

        public override int GetHashCode()
        {
            return 1907758594 + EqualityComparer<string>.Default.GetHashCode(uuid);
        }

        public static bool operator ==(Profesor left, Profesor right)
        {
            return EqualityComparer<Profesor>.Default.Equals(left, right);
        }

        public static bool operator !=(Profesor left, Profesor right)
        {
            return !(left == right);
        }
    }


}
