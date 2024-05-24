namespace UI.Desktop
{
    partial class Inicio
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnEspecialidades = new System.Windows.Forms.Button();
            btnPlanes = new System.Windows.Forms.Button();
            btnCursos = new System.Windows.Forms.Button();
            btnComisiones = new System.Windows.Forms.Button();
            btnProfesores = new System.Windows.Forms.Button();
            btnAlumnos = new System.Windows.Forms.Button();
            btnUsuarios = new System.Windows.Forms.Button();
            btnCatedras = new System.Windows.Forms.Button();
            btnInscripciones = new System.Windows.Forms.Button();
            btnInscribirse = new System.Windows.Forms.Button();
            btnDocenteNotas = new System.Windows.Forms.Button();
            btnInscripcionDocente = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.2477F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.75229359F));
            tableLayoutPanel1.Size = new System.Drawing.Size(844, 940);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnEspecialidades);
            flowLayoutPanel1.Controls.Add(btnPlanes);
            flowLayoutPanel1.Controls.Add(btnCursos);
            flowLayoutPanel1.Controls.Add(btnComisiones);
            flowLayoutPanel1.Controls.Add(btnProfesores);
            flowLayoutPanel1.Controls.Add(btnAlumnos);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnCatedras);
            flowLayoutPanel1.Controls.Add(btnInscripciones);
            flowLayoutPanel1.Controls.Add(btnInscribirse);
            flowLayoutPanel1.Controls.Add(btnDocenteNotas);
            flowLayoutPanel1.Controls.Add(btnInscripcionDocente);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(275, 42);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(294, 871);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.Location = new System.Drawing.Point(2, 2);
            btnEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new System.Drawing.Size(291, 61);
            btnEspecialidades.TabIndex = 0;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = true;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // btnPlanes
            // 
            btnPlanes.Location = new System.Drawing.Point(2, 67);
            btnPlanes.Margin = new System.Windows.Forms.Padding(2);
            btnPlanes.Name = "btnPlanes";
            btnPlanes.Size = new System.Drawing.Size(291, 57);
            btnPlanes.TabIndex = 1;
            btnPlanes.Text = "Planes";
            btnPlanes.UseVisualStyleBackColor = true;
            btnPlanes.Visible = false;
            btnPlanes.Click += btnPlanes_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new System.Drawing.Point(2, 128);
            btnCursos.Margin = new System.Windows.Forms.Padding(2);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new System.Drawing.Size(291, 60);
            btnCursos.TabIndex = 2;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnComisiones
            // 
            btnComisiones.Location = new System.Drawing.Point(2, 192);
            btnComisiones.Margin = new System.Windows.Forms.Padding(2);
            btnComisiones.Name = "btnComisiones";
            btnComisiones.Size = new System.Drawing.Size(291, 57);
            btnComisiones.TabIndex = 3;
            btnComisiones.Text = "Comisiones";
            btnComisiones.UseVisualStyleBackColor = true;
            btnComisiones.Click += btnComisiones_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new System.Drawing.Point(2, 253);
            btnProfesores.Margin = new System.Windows.Forms.Padding(2);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new System.Drawing.Size(291, 60);
            btnProfesores.TabIndex = 4;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new System.Drawing.Point(2, 317);
            btnAlumnos.Margin = new System.Windows.Forms.Padding(2);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new System.Drawing.Size(291, 61);
            btnAlumnos.TabIndex = 5;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new System.Drawing.Point(2, 382);
            btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new System.Drawing.Size(291, 61);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCatedras
            // 
            btnCatedras.Location = new System.Drawing.Point(2, 447);
            btnCatedras.Margin = new System.Windows.Forms.Padding(2);
            btnCatedras.Name = "btnCatedras";
            btnCatedras.Size = new System.Drawing.Size(291, 51);
            btnCatedras.TabIndex = 7;
            btnCatedras.Text = "Estado academico";
            btnCatedras.UseVisualStyleBackColor = true;
            btnCatedras.Click += btnCatedras_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.Location = new System.Drawing.Point(3, 503);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new System.Drawing.Size(290, 55);
            btnInscripciones.TabIndex = 9;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnInscribirse
            // 
            btnInscribirse.Location = new System.Drawing.Point(3, 564);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new System.Drawing.Size(290, 53);
            btnInscribirse.TabIndex = 8;
            btnInscribirse.Text = "Inscribirse a nueva materia";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // btnDocenteNotas
            // 
            btnDocenteNotas.Location = new System.Drawing.Point(3, 623);
            btnDocenteNotas.Name = "btnDocenteNotas";
            btnDocenteNotas.Size = new System.Drawing.Size(290, 50);
            btnDocenteNotas.TabIndex = 11;
            btnDocenteNotas.Text = "Docente notas";
            btnDocenteNotas.UseVisualStyleBackColor = true;
            btnDocenteNotas.Click += btnDocenteNotas_Click;
            // 
            // btnInscripcionDocente
            // 
            btnInscripcionDocente.Location = new System.Drawing.Point(3, 679);
            btnInscripcionDocente.Name = "btnInscripcionDocente";
            btnInscripcionDocente.Size = new System.Drawing.Size(290, 58);
            btnInscripcionDocente.TabIndex = 12;
            btnInscripcionDocente.Text = "Inscripcion de docente a curso";
            btnInscripcionDocente.UseVisualStyleBackColor = true;
            btnInscripcionDocente.Click += btnInscripcionDocente_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(844, 940);
            Controls.Add(tableLayoutPanel1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCatedras;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.Button btnDocenteNotas;
        private System.Windows.Forms.Button btnInscripcionDocente;
    }
}