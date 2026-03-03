using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidad;
using System.Data;


namespace Capa_Dato
{
    public class Conexion
    {
        protected SqlConnection conectar = new SqlConnection(
           "Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"
       );
    }

    public class EstudianteDAL : Conexion
    {
        public void Insertar(Estudiante e)
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Estundiantes
                (Nombre, Apellido, Edad, Direccion, Telefono, Email, ID_Area_Tecnica)
                VALUES
                (@Nombre, @Apellido, @Edad, @Direccion, @Telefono, @Email, @ID_Area_Tecnica)",
                conectar
            );

            cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", e.Apellido);
            cmd.Parameters.AddWithValue("@Edad", e.Edad);
            cmd.Parameters.AddWithValue("@Direccion", e.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", e.Telefono);
            cmd.Parameters.AddWithValue("@Email", e.Email);
            cmd.Parameters.AddWithValue("@ID_Area_Tecnica", e.ID_Area_Tecnica);

            conectar.Open();
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Estundiantes",
                conectar
            );

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Actualizar(Estudiante est)
        {
            SqlCommand cmd;

            if (est.ID_Estudiantes > 0)
            {
                // 🔁 ACTUALIZAR
                cmd = new SqlCommand(
                @"UPDATE Estundiantes 
          SET Nombre = @Nombre,
              Apellido = @Apellido,
              Edad = @Edad,
              Direccion = @Direccion,
              Telefono = @Telefono,
              Email = @Email,
              ID_Area_Tecnica = @Area,
              Estado = @Estado
          WHERE ID_Estudiantes = @ID", conectar);

                cmd.Parameters.AddWithValue("@ID", est.ID_Estudiantes);
            }
            else
            {
                // ➕ INSERTAR
                cmd = new SqlCommand(
                @"INSERT INTO Estundiantes
          (Nombre, Apellido, Edad, Direccion, Telefono, Email, ID_Area_Tecnica, Estado)
          VALUES
          (@Nombre, @Apellido, @Edad, @Direccion, @Telefono, @Email, @Area, @Estado)", conectar);
            }

            cmd.Parameters.AddWithValue("@Nombre", est.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", est.Apellido);
            cmd.Parameters.AddWithValue("@Edad", est.Edad);
            cmd.Parameters.AddWithValue("@Direccion", est.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", est.Telefono);
            cmd.Parameters.AddWithValue("@Email", est.Email);
            cmd.Parameters.AddWithValue("@Area", est.ID_Area_Tecnica);
            cmd.Parameters.AddWithValue("@Estado", est.Estado);

            conectar.Open();
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public void EliminarLogico(int idEstudiante)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Estundiantes SET Estado = 0 WHERE ID_Estudiantes = @id", conectar);

                cmd.Parameters.AddWithValue("@id", idEstudiante);

                conectar.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public DataTable ReporteAsignacion(int idEstudiante, string periodo, string anio)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection("Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("sp_ReporteAsignacionEstudiante", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Estudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@Periodo", periodo);
                cmd.Parameters.AddWithValue("@Anio", anio);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }


    }

}
