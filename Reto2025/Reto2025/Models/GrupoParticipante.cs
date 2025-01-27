using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class GrupoParticipante : IEquatable<GrupoParticipante>
    {
        public Nullable<int> id;
        public Actividad actividades;
        public Grupo grupo;
        public int numParticipantes;
        public string comentario;

        public GrupoParticipante(Actividad actividades, Grupo grupo, int numParticipantes)
        {
            this.id = null;
            this.actividades = actividades;
            this.grupo = grupo;
            this.numParticipantes = numParticipantes;
        }
        public GrupoParticipante() { }



        public override int GetHashCode()
        {
            int hashCode = -1381863698;
            hashCode = hashCode * -1521134295 + EqualityComparer<Actividad>.Default.GetHashCode(actividades);
            hashCode = hashCode * -1521134295 + EqualityComparer<Grupo>.Default.GetHashCode(grupo);
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as GrupoParticipante);
        }

        public bool Equals(GrupoParticipante other)
        {
            return !(other is null) &&
                   EqualityComparer<Actividad>.Default.Equals(actividades, other.actividades) &&
                   EqualityComparer<Grupo>.Default.Equals(grupo, other.grupo);
        }

        public static bool operator ==(GrupoParticipante left, GrupoParticipante right)
        {
            return EqualityComparer<GrupoParticipante>.Default.Equals(left, right);
        }

        public static bool operator !=(GrupoParticipante left, GrupoParticipante right)
        {
            return !(left == right);
        }
    }
}
