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
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
            // 🔹 Llamamos al método aquí para cargar el dashboard al iniciar el formulario
            CargarDashboard();
        }

        // 🔹 MÉTODO PARA CARGAR DATOS DEL DASHBOARD
        private void CargarDashboard()
        {
            using (SqlConnection cn = new SqlConnection("Server=.;Database=Gestion_Escolar;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("sp_DashboardTotales", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                

                dr.Close();
            }
        }

        // 🔹 MÉTODO PARA ABRIR FORMULARIOS
        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEstudiantes());
        }

        private void btnProfesoress_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProfesores());
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAsignarMateria());
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
