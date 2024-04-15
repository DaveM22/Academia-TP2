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
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 426F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.53384F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.4661655F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1143, 1050);
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
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(361, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(420, 835);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.Location = new System.Drawing.Point(3, 3);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new System.Drawing.Size(416, 102);
            btnEspecialidades.TabIndex = 0;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = true;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // btnPlanes
            // 
            btnPlanes.Location = new System.Drawing.Point(3, 111);
            btnPlanes.Name = "btnPlanes";
            btnPlanes.Size = new System.Drawing.Size(416, 95);
            btnPlanes.TabIndex = 1;
            btnPlanes.Text = "Planes";
            btnPlanes.UseVisualStyleBackColor = true;
            btnPlanes.Visible = false;
            btnPlanes.Click += btnPlanes_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new System.Drawing.Point(3, 212);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new System.Drawing.Size(416, 100);
            btnCursos.TabIndex = 2;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnComisiones
            // 
            btnComisiones.Location = new System.Drawing.Point(3, 318);
            btnComisiones.Name = "btnComisiones";
            btnComisiones.Size = new System.Drawing.Size(416, 95);
            btnComisiones.TabIndex = 3;
            btnComisiones.Text = "Comisiones";
            btnComisiones.UseVisualStyleBackColor = true;
            btnComisiones.Click += btnComisiones_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new System.Drawing.Point(3, 419);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new System.Drawing.Size(416, 100);
            btnProfesores.TabIndex = 4;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new System.Drawing.Point(3, 525);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new System.Drawing.Size(416, 102);
            btnAlumnos.TabIndex = 5;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new System.Drawing.Point(3, 633);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new System.Drawing.Size(416, 102);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCatedras
            // 
            btnCatedras.Location = new System.Drawing.Point(3, 741);
            btnCatedras.Name = "btnCatedras";
            btnCatedras.Size = new System.Drawing.Size(416, 85);
            btnCatedras.TabIndex = 7;
            btnCatedras.Text = "Catedras";
            btnCatedras.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}