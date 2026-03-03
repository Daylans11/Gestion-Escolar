using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class Estudiante
    {
        public int ID_Estudiantes { get; set; }  // 👈 ESTA ES LA QUE FALTABA

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public int ID_Area_Tecnica { get; set; }
        public int Estado { get; set; }
    }
}


