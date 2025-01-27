using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class ProfParticipante : IEquatable<ProfParticipante>
    {
        public Nullable<int> id;
        public Actividad actividad;
        public Profesor profesor;

        public ProfParticipante()
        {
        }

        public ProfParticipante(Actividad actividad, Profesor profesor)
        {

            id = null;
            this.actividad = actividad;
            this.profesor = profesor;

        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ProfParticipante);
        }

        public bool Equals(ProfParticipante other)
        {
            return !(other is null) &&
                   EqualityComparer<Actividad>.Default.Equals(actividad, other.actividad) &&
                   EqualityComparer<Profesor>.Default.Equals(profesor, other.profesor);
        }

        public override int GetHashCode()
        {
            int hashCode = -1181082521;
            hashCode = hashCode * -1521134295 + EqualityComparer<Actividad>.Default.GetHashCode(actividad);
            hashCode = hashCode * -1521134295 + EqualityComparer<Profesor>.Default.GetHashCode(profesor);
            return hashCode;
        }

        public static bool operator ==(ProfParticipante left, ProfParticipante right)
        {
            return EqualityComparer<ProfParticipante>.Default.Equals(left, right);
        }

        public static bool operator !=(ProfParticipante left, ProfParticipante right)
        {
            return !(left == right);
        }

    }


}
