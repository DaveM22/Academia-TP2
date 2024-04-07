namespace UI.Desktop
{
    partial class MasterForm
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tsmAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            tsmProfesores = new System.Windows.Forms.ToolStripMenuItem();
            usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmPlanes = new System.Windows.Forms.ToolStripMenuItem();
            tsmAlumnado = new System.Windows.Forms.ToolStripMenuItem();
            tsmComisiones = new System.Windows.Forms.ToolStripMenuItem();
            tsmCursos = new System.Windows.Forms.ToolStripMenuItem();
            tsInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            tsProfesoresCursos = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, tsmAlumnado });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            menuStrip1.Size = new System.Drawing.Size(560, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmAlumnos, tsmProfesores, usuarioToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(66, 22);
            toolStripMenuItem1.Text = "Personas";
            // 
            // tsmAlumnos
            // 
            tsmAlumnos.Name = "tsmAlumnos";
            tsmAlumnos.Size = new System.Drawing.Size(180, 22);
            tsmAlumnos.Text = "Alumnos";
            tsmAlumnos.Click += tsmAlumnos_Click;
            // 
            // tsmProfesores
            // 
            tsmProfesores.Name = "tsmProfesores";
            tsmProfesores.Size = new System.Drawing.Size(180, 22);
            tsmProfesores.Text = "Profesores";
            tsmProfesores.Click += tsmProfesores_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { especialidadesToolStripMenuItem, tsmPlanes });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(57, 22);
            toolStripMenuItem2.Text = "Carrera";
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click_1;
            // 
            // tsmPlanes
            // 
            tsmPlanes.Name = "tsmPlanes";
            tsmPlanes.Size = new System.Drawing.Size(150, 22);
            tsmPlanes.Text = "Planes";
            tsmPlanes.Click += tsmPlanes_Click;
            // 
            // tsmAlumnado
            // 
            tsmAlumnado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmComisiones, tsmCursos, tsInscripciones, tsProfesoresCursos });
            tsmAlumnado.Name = "tsmAlumnado";
            tsmAlumnado.Size = new System.Drawing.Size(75, 22);
            tsmAlumnado.Text = "Alumnado";
            // 
            // tsmComisiones
            // 
            tsmComisiones.Name = "tsmComisiones";
            tsmComisiones.Size = new System.Drawing.Size(170, 22);
            tsmComisiones.Text = "Comisiones";
            tsmComisiones.Click += tsmComisiones_Click;
            // 
            // tsmCursos
            // 
            tsmCursos.Name = "tsmCursos";
            tsmCursos.Size = new System.Drawing.Size(170, 22);
            tsmCursos.Text = "Cursos";
            tsmCursos.Click += tsmCursos_Click;
            // 
            // tsInscripciones
            // 
            tsInscripciones.Name = "tsInscripciones";
            tsInscripciones.Size = new System.Drawing.Size(170, 22);
            tsInscripciones.Text = "Inscripciones";
            tsInscripciones.Click += tsInscripciones_Click;
            // 
            // tsProfesoresCursos
            // 
            tsProfesoresCursos.Name = "tsProfesoresCursos";
            tsProfesoresCursos.Size = new System.Drawing.Size(170, 22);
            tsProfesoresCursos.Text = "Profesores/Cursos";
            tsProfesoresCursos.Click += tsProfesoresCursos_Click;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 270);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "MasterForm";
            Text = "Academia";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MasterForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsmAlumnos;
        private System.Windows.Forms.ToolStripMenuItem tsmProfesores;
        private System.Windows.Forms.ToolStripMenuItem tsmAlumnado;
        private System.Windows.Forms.ToolStripMenuItem tsmComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmCursos;
        private System.Windows.Forms.ToolStripMenuItem tsInscripciones;
        private System.Windows.Forms.ToolStripMenuItem tsProfesoresCursos;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}