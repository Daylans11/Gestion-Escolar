using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dato;
using Capa.Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class EstudianteBL
    {
        // ✅ UNA SOLA DAL
        private EstudianteDAL dal = new EstudianteDAL();

        // INSERTAR
        public void Guardar(Estudiante est)
        {
            dal.Insertar(est);
        }

        // ACTUALIZAR
        public void Actualizar(Estudiante est)
        {
            dal.Actualizar(est);
        }

        // DECIDE SI INSERTA O ACTUALIZA
        public void GuardarActualizar(Estudiante est)
        {
            if (est.ID_Estudiantes > 0)
                dal.Actualizar(est);
            else
                dal.Insertar(est);
        }

        // LISTAR
        public DataTable Listar()
        {
            return dal.Listar();
        }


        public void Eliminar(int idEstudiante)
        {
            dal.EliminarLogico(idEstudiante);
        }

        public DataTable Reporte(int idEstudiante, string periodo, string anio)
        {
            return dal.ReporteAsignacion(idEstudiante, periodo, anio);
        }
    }
}
