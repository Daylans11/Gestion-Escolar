using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Capa_Presentacion
{
    public partial class frmAsignarMateria : Form
    {
        DataTable dtSeleccionadas = new DataTable();

        public frmAsignarMateria()
        {
            InitializeComponent();
        }

        private void frmAsignarMateria_Load(object sender, EventArgs e)
        {
            dtSeleccionadas.Columns.Add("ID_Materias", typeof(int));
            dtSeleccionadas.Columns.Add("Nombre_Materia", typeof(string));

            dgbMateriasSeleccionadas.DataSource = dtSeleccionadas;

            CargarEstudiantes();
            CargarProfesores();
            CargarPeriodo();
            CargarMateriasGrid();
        }

        private void CargarEstudiantes()
        {
            using (SqlConnection cn = new SqlConnection("Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("sp_CargarEstudiantes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbEstudiante.DataSource = dt;
                cbEstudiante.DisplayMember = "NombreCompleto";
                cbEstudiante.ValueMember = "ID_Estudiantes";
                cbEstudiante.SelectedIndex = -1;
            }
        }

        private void CargarProfesores()
        {
            using (SqlConnection cn = new SqlConnection("Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("sp_CargarProfesores", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbProfesor.DataSource = dt;
                cbProfesor.DisplayMember = "NombreCompleto";
                cbProfesor.ValueMember = "ID_Profesor";
                cbProfesor.SelectedIndex = -1;
            }
        }

        private void CargarPeriodo()
        {
            cbPeriodoM.Items.Clear();

            cbPeriodoM.Items.Add("1er Cuatrimestre");
            cbPeriodoM.Items.Add("2do Cuatrimestre");
            cbPeriodoM.Items.Add("Verano");

            cbPeriodoM.SelectedIndex = 0;
        }

        private void CargarMateriasGrid()
        {
            using (SqlConnection con = new SqlConnection("Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("sp_CargarMaterias", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMateriasA.DataSource = dt;
            }

            if (!dgvMateriasA.Columns.Contains("Seleccionar"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.Name = "Seleccionar";
                chk.HeaderText = "Seleccionar";
                dgvMateriasA.Columns.Insert(0, chk);
            }

            dgvMateriasA.MultiSelect = true;
        }

        private void dgvMateriasA_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMateriasA.IsCurrentCellDirty)
            {
                dgvMateriasA.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMateriasA.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccionar"].Value) == true)
                {
                    int id = Convert.ToInt32(row.Cells["ID_Materias"].Value);
                    string nombre = row.Cells["Nombre_Materia"].Value.ToString();

                    bool existe = dtSeleccionadas.AsEnumerable()
                        .Any(r => r.Field<int>("ID_Materias") == id);

                    if (!existe)
                        dtSeleccionadas.Rows.Add(id, nombre);
                }
            }
        }

        private void btnGuardarAsignacion_Click(object sender, EventArgs e)
        {
            if (dtSeleccionadas.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una materia.");
                return;
            }

            if (cbEstudiante.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un estudiante.");
                return;
            }

            if (cbProfesor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un profesor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lblAñoM.Text))
            {
                MessageBox.Show("Ingrese el año escolar.");
                return;
            }

            int idEstudiante = Convert.ToInt32(cbEstudiante.SelectedValue);
            int idProfesor = Convert.ToInt32(cbProfesor.SelectedValue);
            string periodo = cbPeriodoM.Text;
            string anio = lblAñoM.Text;

            using (SqlConnection cn = new SqlConnection("Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"))
            {
                cn.Open();

                foreach (DataRow row in dtSeleccionadas.Rows)
                {
                    int idMateria = Convert.ToInt32(row["ID_Materias"]);

                    string insertar = @"INSERT INTO Estudiante_Materia
                        (ID_Estudiantes, ID_Materias, Fecha_Asignacion, Periodo, Anio_Escolar, Estado)
                        VALUES (@Estudiante, @Materia, GETDATE(), @Periodo, @Anio, 1)";

                    SqlCommand cmdInsertar = new SqlCommand(insertar, cn);
                    cmdInsertar.Parameters.AddWithValue("@Estudiante", idEstudiante);
                    cmdInsertar.Parameters.AddWithValue("@Materia", idMateria);
                    cmdInsertar.Parameters.AddWithValue("@Periodo", periodo);
                    cmdInsertar.Parameters.AddWithValue("@Anio", anio);

                    cmdInsertar.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Materias asignadas correctamente.");
            dtSeleccionadas.Clear();
        }

        private void cbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMateriasA.Rows)
            {
                if (row.Cells["Seleccionar"].Value != null &&
                    Convert.ToBoolean(row.Cells["Seleccionar"].Value) == true)
                {
                    int id = Convert.ToInt32(row.Cells["ID_Materias"].Value);
                    string nombre = row.Cells["Nombre_Materia"].Value.ToString();

                    bool existe = dtSeleccionadas.AsEnumerable()
                        .Any(r => r.Field<int>("ID_Materias") == id);

                    if (!existe)
                    {
                        dtSeleccionadas.Rows.Add(id, nombre);
                    }

                    // 🔹 Desmarcar después de agregar
                    row.Cells["Seleccionar"].Value = false;
                }
            }
        }

        private void btnQuitar2_Click(object sender, EventArgs e)
        {
            if (dgbMateriasSeleccionadas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgbMateriasSeleccionadas.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ID_Materias"].Value);

                    DataRow fila = dtSeleccionadas.AsEnumerable()
                        .FirstOrDefault(r => r.Field<int>("ID_Materias") == id);

                    if (fila != null)
                    {
                        dtSeleccionadas.Rows.Remove(fila);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una materia para quitar.");
            }
        }

        private void btnQuitar1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMateriasA.Rows)
            {
                if (row.Cells["Seleccionar"].Value != null &&
                    Convert.ToBoolean(row.Cells["Seleccionar"].Value) == true)
                {
                    row.Cells["Seleccionar"].Value = false;
                }
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cbEstudiante.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un estudiante.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lblAñoM.Text))
            {
                MessageBox.Show("Ingrese el año escolar.");
                return;
            }

            int idEstudiante = Convert.ToInt32(cbEstudiante.SelectedValue);
            string periodo = cbPeriodoM.Text;
            string anio = lblAñoM.Text;

            frmReporteAsignacion frm = new frmReporteAsignacion(idEstudiante, periodo, anio);
            frm.ShowDialog();
        }

    }
}

