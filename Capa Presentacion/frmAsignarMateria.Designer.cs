namespace Capa_Presentacion
{
    partial class frmAsignarMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.lblEstudianteM = new System.Windows.Forms.Label();
            this.lblProfesorM = new System.Windows.Forms.Label();
            this.lblAñoM = new System.Windows.Forms.Label();
            this.txtAñoM = new System.Windows.Forms.TextBox();
            this.lblPeriodoM = new System.Windows.Forms.Label();
            this.cbPeriodoM = new System.Windows.Forms.ComboBox();
            this.dgvMateriasA = new System.Windows.Forms.DataGridView();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosAsignacion = new System.Windows.Forms.GroupBox();
            this.gbMateriasDisponibles = new System.Windows.Forms.GroupBox();
            this.btnQuitar1 = new System.Windows.Forms.Button();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbMateriasSeleccionadas = new System.Windows.Forms.GroupBox();
            this.btnQuitar2 = new System.Windows.Forms.Button();
            this.dgbMateriasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.btnGuardarAsignacion = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasA)).BeginInit();
            this.gbDatosAsignacion.SuspendLayout();
            this.gbMateriasDisponibles.SuspendLayout();
            this.gbMateriasSeleccionadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMateriasSeleccionadas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(147, 35);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(167, 28);
            this.cbEstudiante.TabIndex = 0;
            this.cbEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbEstudiante_SelectedIndexChanged);
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(433, 32);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(169, 28);
            this.cbProfesor.TabIndex = 1;
            // 
            // lblEstudianteM
            // 
            this.lblEstudianteM.AutoSize = true;
            this.lblEstudianteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudianteM.Location = new System.Drawing.Point(12, 36);
            this.lblEstudianteM.Name = "lblEstudianteM";
            this.lblEstudianteM.Size = new System.Drawing.Size(121, 25);
            this.lblEstudianteM.TabIndex = 2;
            this.lblEstudianteM.Text = "Estudiante:";
            // 
            // lblProfesorM
            // 
            this.lblProfesorM.AutoSize = true;
            this.lblProfesorM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorM.Location = new System.Drawing.Point(320, 35);
            this.lblProfesorM.Name = "lblProfesorM";
            this.lblProfesorM.Size = new System.Drawing.Size(100, 25);
            this.lblProfesorM.TabIndex = 3;
            this.lblProfesorM.Text = "Profesor:";
            // 
            // lblAñoM
            // 
            this.lblAñoM.AutoSize = true;
            this.lblAñoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoM.Location = new System.Drawing.Point(630, 31);
            this.lblAñoM.Name = "lblAñoM";
            this.lblAñoM.Size = new System.Drawing.Size(58, 25);
            this.lblAñoM.TabIndex = 4;
            this.lblAñoM.Text = "Año:";
            // 
            // txtAñoM
            // 
            this.txtAñoM.Location = new System.Drawing.Point(708, 35);
            this.txtAñoM.Name = "txtAñoM";
            this.txtAñoM.Size = new System.Drawing.Size(116, 26);
            this.txtAñoM.TabIndex = 5;
            // 
            // lblPeriodoM
            // 
            this.lblPeriodoM.AutoSize = true;
            this.lblPeriodoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoM.Location = new System.Drawing.Point(848, 31);
            this.lblPeriodoM.Name = "lblPeriodoM";
            this.lblPeriodoM.Size = new System.Drawing.Size(93, 25);
            this.lblPeriodoM.TabIndex = 6;
            this.lblPeriodoM.Text = "Periodo:";
            // 
            // cbPeriodoM
            // 
            this.cbPeriodoM.FormattingEnabled = true;
            this.cbPeriodoM.Location = new System.Drawing.Point(971, 32);
            this.cbPeriodoM.Name = "cbPeriodoM";
            this.cbPeriodoM.Size = new System.Drawing.Size(143, 28);
            this.cbPeriodoM.TabIndex = 7;
            // 
            // dgvMateriasA
            // 
            this.dgvMateriasA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasA.Location = new System.Drawing.Point(16, 86);
            this.dgvMateriasA.Name = "dgvMateriasA";
            this.dgvMateriasA.RowHeadersWidth = 62;
            this.dgvMateriasA.RowTemplate.Height = 28;
            this.dgvMateriasA.Size = new System.Drawing.Size(604, 193);
            this.dgvMateriasA.TabIndex = 8;
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLista.Location = new System.Drawing.Point(28, 119);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(196, 37);
            this.btnAgregarLista.TabIndex = 10;
            this.btnAgregarLista.Text = "Agregar a Lista";
            this.btnAgregarLista.UseVisualStyleBackColor = false;
            this.btnAgregarLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Materias Seleccionadas";
            // 
            // gbDatosAsignacion
            // 
            this.gbDatosAsignacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDatosAsignacion.Controls.Add(this.lblEstudianteM);
            this.gbDatosAsignacion.Controls.Add(this.cbEstudiante);
            this.gbDatosAsignacion.Controls.Add(this.lblProfesorM);
            this.gbDatosAsignacion.Controls.Add(this.cbProfesor);
            this.gbDatosAsignacion.Controls.Add(this.lblAñoM);
            this.gbDatosAsignacion.Controls.Add(this.cbPeriodoM);
            this.gbDatosAsignacion.Controls.Add(this.txtAñoM);
            this.gbDatosAsignacion.Controls.Add(this.lblPeriodoM);
            this.gbDatosAsignacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatosAsignacion.Location = new System.Drawing.Point(0, 0);
            this.gbDatosAsignacion.Name = "gbDatosAsignacion";
            this.gbDatosAsignacion.Size = new System.Drawing.Size(1252, 100);
            this.gbDatosAsignacion.TabIndex = 12;
            this.gbDatosAsignacion.TabStop = false;
            // 
            // gbMateriasDisponibles
            // 
            this.gbMateriasDisponibles.Controls.Add(this.btnQuitar1);
            this.gbMateriasDisponibles.Controls.Add(this.btnAgregar1);
            this.gbMateriasDisponibles.Controls.Add(this.dgvMateriasA);
            this.gbMateriasDisponibles.Controls.Add(this.checkBox1);
            this.gbMateriasDisponibles.Location = new System.Drawing.Point(28, 171);
            this.gbMateriasDisponibles.Name = "gbMateriasDisponibles";
            this.gbMateriasDisponibles.Size = new System.Drawing.Size(635, 304);
            this.gbMateriasDisponibles.TabIndex = 13;
            this.gbMateriasDisponibles.TabStop = false;
            // 
            // btnQuitar1
            // 
            this.btnQuitar1.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuitar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitar1.Location = new System.Drawing.Point(157, 25);
            this.btnQuitar1.Name = "btnQuitar1";
            this.btnQuitar1.Size = new System.Drawing.Size(102, 45);
            this.btnQuitar1.TabIndex = 11;
            this.btnQuitar1.Text = "Quitar";
            this.btnQuitar1.UseVisualStyleBackColor = false;
            this.btnQuitar1.Click += new System.EventHandler(this.btnQuitar1_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar1.Location = new System.Drawing.Point(27, 25);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(113, 45);
            this.btnAgregar1.TabIndex = 10;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = false;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbMateriasSeleccionadas
            // 
            this.gbMateriasSeleccionadas.Controls.Add(this.btnQuitar2);
            this.gbMateriasSeleccionadas.Controls.Add(this.dgbMateriasSeleccionadas);
            this.gbMateriasSeleccionadas.Location = new System.Drawing.Point(28, 531);
            this.gbMateriasSeleccionadas.Name = "gbMateriasSeleccionadas";
            this.gbMateriasSeleccionadas.Size = new System.Drawing.Size(635, 279);
            this.gbMateriasSeleccionadas.TabIndex = 14;
            this.gbMateriasSeleccionadas.TabStop = false;
            // 
            // btnQuitar2
            // 
            this.btnQuitar2.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuitar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitar2.Location = new System.Drawing.Point(27, 25);
            this.btnQuitar2.Name = "btnQuitar2";
            this.btnQuitar2.Size = new System.Drawing.Size(113, 44);
            this.btnQuitar2.TabIndex = 2;
            this.btnQuitar2.Text = "Quitar";
            this.btnQuitar2.UseVisualStyleBackColor = false;
            this.btnQuitar2.Click += new System.EventHandler(this.btnQuitar2_Click);
            // 
            // dgbMateriasSeleccionadas
            // 
            this.dgbMateriasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMateriasSeleccionadas.Location = new System.Drawing.Point(16, 75);
            this.dgbMateriasSeleccionadas.Name = "dgbMateriasSeleccionadas";
            this.dgbMateriasSeleccionadas.RowHeadersWidth = 62;
            this.dgbMateriasSeleccionadas.RowTemplate.Height = 28;
            this.dgbMateriasSeleccionadas.Size = new System.Drawing.Size(604, 184);
            this.dgbMateriasSeleccionadas.TabIndex = 0;
            // 
            // btnGuardarAsignacion
            // 
            this.btnGuardarAsignacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsignacion.Location = new System.Drawing.Point(28, 832);
            this.btnGuardarAsignacion.Name = "btnGuardarAsignacion";
            this.btnGuardarAsignacion.Size = new System.Drawing.Size(221, 48);
            this.btnGuardarAsignacion.TabIndex = 15;
            this.btnGuardarAsignacion.Text = "Guardar Asignación";
            this.btnGuardarAsignacion.UseVisualStyleBackColor = false;
            this.btnGuardarAsignacion.Click += new System.EventHandler(this.btnGuardarAsignacion_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Olive;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(307, 832);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(221, 48);
            this.btnGenerarReporte.TabIndex = 16;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Brown;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(1099, 832);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 48);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmAsignarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1252, 892);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnGuardarAsignacion);
            this.Controls.Add(this.gbMateriasSeleccionadas);
            this.Controls.Add(this.gbMateriasDisponibles);
            this.Controls.Add(this.gbDatosAsignacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarLista);
            this.Name = "frmAsignarMateria";
            this.Text = "frmAsignarMateria";
            this.Load += new System.EventHandler(this.frmAsignarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasA)).EndInit();
            this.gbDatosAsignacion.ResumeLayout(false);
            this.gbDatosAsignacion.PerformLayout();
            this.gbMateriasDisponibles.ResumeLayout(false);
            this.gbMateriasDisponibles.PerformLayout();
            this.gbMateriasSeleccionadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbMateriasSeleccionadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.Label lblEstudianteM;
        private System.Windows.Forms.Label lblProfesorM;
        private System.Windows.Forms.Label lblAñoM;
        private System.Windows.Forms.TextBox txtAñoM;
        private System.Windows.Forms.Label lblPeriodoM;
        private System.Windows.Forms.ComboBox cbPeriodoM;
        private System.Windows.Forms.DataGridView dgvMateriasA;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosAsignacion;
        private System.Windows.Forms.GroupBox gbMateriasDisponibles;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.GroupBox gbMateriasSeleccionadas;
        private System.Windows.Forms.DataGridView dgbMateriasSeleccionadas;
        private System.Windows.Forms.Button btnQuitar1;
        private System.Windows.Forms.Button btnQuitar2;
        private System.Windows.Forms.Button btnGuardarAsignacion;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}