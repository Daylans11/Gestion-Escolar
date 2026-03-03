using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidad;

namespace Capa_Dato
{
    internal class D_Profesor
    {
        SqlConnection cn = new SqlConnection(
            "Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"
        );


        public void Insertar(Capa.Entidad.Profesor p)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarProfesor", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
            cmd.Parameters.AddWithValue("@Email", p.Email);
            cmd.Parameters.AddWithValue("@Especialidad", p.Especialidad);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter(
        "SELECT * FROM Profesor", cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 🔥 ESTUDIANTES QUE RECIBEN CLASE DE ESE PROFESOR
        public DataTable EstudiantesPorProfesor(int idProfesor)
        {
            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT E.Nombre, E.Apellido, M.Nombre_Materia
              FROM Profesor P
              INNER JOIN Profesor_Materia PM ON P.ID_Profesor = PM.ID_Profesor
              INNER JOIN Materias M ON PM.ID_Materia = M.ID_Materias
              INNER JOIN Estudiante_Materia EM ON M.ID_Materias = EM.ID_Materias
              INNER JOIN Estundiantes E ON EM.ID_Estudiantes = E.ID_Estudiantes
              WHERE P.ID_Profesor = @id", cn);

            da.SelectCommand.Parameters.AddWithValue("@id", idProfesor);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
