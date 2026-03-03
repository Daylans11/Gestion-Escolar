using Capa.Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Capa_Presentacion.frmProfesores;





namespace Capa_Presentacion
{
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Materia");

            // Ejemplo de datos iniciales
            dt.Rows.Add(1, "Juan", "Pérez", "Matemáticas");
            dt.Rows.Add(2, "María", "Gómez", "Historia");

            dgvProfesores.DataSource = dt;
        }


        public class DataProfesor
        {
            public DataTable Listar()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Materia");

                dt.Rows.Add("Juan Pérez", "Matemáticas");
                dt.Rows.Add("María Gómez", "Historia");

                return dt;
            }
        }
        private void frmdeProfesores_Load(object sender, EventArgs e)
        {
            DataProfesor dataProfesor = new DataProfesor();
            var dt = dataProfesor.Listar();
            dgvProfesores.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se guardó correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se actualizó correctamente.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            // Si tienes más controles, los reseteas aquí
            MessageBox.Show("Los campos se limpiaron.", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                // Aquí iría la lógica para eliminar el registro
                MessageBox.Show("El registro se eliminó correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

