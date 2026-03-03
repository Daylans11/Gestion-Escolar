using Capa_Negocio;
using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }
        EstudianteBL negocio = new EstudianteBL();

        private void CargarEstudiantes()
        {
            dgvEstudiantes.DataSource = negocio.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Crear el objeto estudiante
                Estudiante est = new Estudiante();

                // 2. Llenar el objeto con los datos del formulario
                est.Nombre = txtNombre.Text;
                est.Apellido = txtApellido.Text;
                est.Edad = int.Parse(txtEdad.Text);
                est.Direccion = txtDireccion.Text;
                est.Telefono = txtTelefono.Text;
                est.Email = txtEmail.Text;
                est.ID_Area_Tecnica = int.Parse(txtAreaTecnica.Text);

                // 3. Enviar a la capa negocio
                negocio.Guardar(est);

                // 4. Mensaje de confirmación
                MessageBox.Show("Registro guardado correctamente");



                // 6. Actualizar el DataGridView
                CargarEstudiantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        // 👇 AQUÍ VA, NO ARRIBA, NO AFUERA
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtAreaTecnica.Text = "";
        }

        private void CargarEstudiante()
        {
            dgvEstudiantes.DataSource = negocio.Listar();
        }

        int idSeleccionado = 0;

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                {
                    if (e.RowIndex >= 0)
                    {
                        idSeleccionado = Convert.ToInt32(
                            dgvEstudiantes.Rows[e.RowIndex].Cells["ID_Estudiantes"].Value);

                        txtNombre.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                        txtApellido.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                        txtEdad.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["Edad"].Value.ToString();
                        txtDireccion.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                        txtTelefono.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                        txtEmail.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                        txtAreaTecnica.Text = dgvEstudiantes.Rows[e.RowIndex].Cells["ID_Area_Tecnica"].Value.ToString();
                    }
                }

            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEstudiantes.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    bool estado = Convert.ToBoolean(e.Value);
                    e.Value = estado ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un registro primero",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Seguro que desea actualizar este registro?",
                    "Confirmar actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (r == DialogResult.Yes)
                {
                    Estudiante est = new Estudiante
                    {
                        ID_Estudiantes = idSeleccionado,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Edad = Convert.ToInt32(txtEdad.Text),
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text,
                        ID_Area_Tecnica = Convert.ToInt32(txtAreaTecnica.Text)
                    };
                    negocio.Actualizar(est);   // 🔥 ESTA LÍNEA ES CLAVE

                    MessageBox.Show("Actualizado correctamente");

                    CargarEstudiantes();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtAreaTecnica.Clear();

                // 🔁 Resetear ID
                idSeleccionado = 0;

                // ❌ Quitar selección del DataGridView
                dgvEstudiantes.ClearSelection();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un estudiante");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Desea desactivar este estudiante?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                negocio.Eliminar(idSeleccionado);
                CargarEstudiantes();
                LimpiarCampos();   // ✅ AQUÍ ESTÁ LA CORRECCIÓN
                idSeleccionado = 0;
                dgvEstudiantes.ClearSelection();
            }
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmProfesores frm = new frmProfesores();
            frm.Show();
        }
    }
}
