using Capa.Entidad;
using Capa_Negocio;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteAsignacion : Form
    {
        public int ID_Estudiantes { get; set; }
        public string Periodo { get; set; }
        public string Anio { get; set; }

        public frmReporteAsignacion(int idEstudiante,string periodo,string anio)
        {
            InitializeComponent();
            ID_Estudiantes = idEstudiante;
            Periodo = periodo;
            Anio = anio;
        }

        private EstudianteBL bL = new EstudianteBL();

        private void frmReporteAsignacion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            DataTable dt = bL.Reporte(ID_Estudiantes, Periodo, Anio);

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds =
                new ReportDataSource("MateriaP", dt);

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
