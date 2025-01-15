using Reto2025.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2025.Models
{
    public class Profesor
    {
        public string uuid;
        public string dni;
        public string nombre;
        public string apellidos;
        public string correo;
        public string password;
        public RolProfesor rol;
        public bool activo;
        public string url_foto;
        public Departamento departamento;

    }
}
