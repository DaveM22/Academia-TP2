namespace UI.Desktop
{
    partial class CursoAlumnos
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
            components = new System.ComponentModel.Container();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            tlpCursoAlumnos = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            dgvCursoAlumnos = new System.Windows.Forms.DataGridView();
            IdInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            Estado = new System.Windows.Forms.DataGridViewButtonColumn();
            lblTitulo = new System.Windows.Forms.Label();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tlpCursoAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursoAlumnos).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tlpCursoAlumnos);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tlpCursoAlumnos
            // 
            tlpCursoAlumnos.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpCursoAlumnos.ColumnCount = 2;
            tlpCursoAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursoAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpCursoAlumnos.Controls.Add(button1, 0, 2);
            tlpCursoAlumnos.Controls.Add(button2, 1, 2);
            tlpCursoAlumnos.Controls.Add(dgvCursoAlumnos, 0, 1);
            tlpCursoAlumnos.Controls.Add(lblTitulo, 0, 0);
            tlpCursoAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpCursoAlumnos.Location = new System.Drawing.Point(0, 0);
            tlpCursoAlumnos.Name = "tlpCursoAlumnos";
            tlpCursoAlumnos.RowCount = 3;
            tlpCursoAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpCursoAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursoAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpCursoAlumnos.Size = new System.Drawing.Size(800, 425);
            tlpCursoAlumnos.TabIndex = 0;
            tlpCursoAlumnos.Paint += tlpCursoAlumnos_Paint;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Location = new System.Drawing.Point(641, 390);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Firebrick;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            button2.Location = new System.Drawing.Point(722, 390);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 32);
            button2.TabIndex = 1;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvCursoAlumnos
            // 
            dgvCursoAlumnos.AllowUserToAddRows = false;
            dgvCursoAlumnos.AllowUserToDeleteRows = false;
            dgvCursoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursoAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdInscripcion, Legajo, Apellido, Nombre, Condicion, Nota, Actualizar, Estado });
            tlpCursoAlumnos.SetColumnSpan(dgvCursoAlumnos, 2);
            dgvCursoAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCursoAlumnos.Location = new System.Drawing.Point(3, 29);
            dgvCursoAlumnos.MultiSelect = false;
            dgvCursoAlumnos.Name = "dgvCursoAlumnos";
            dgvCursoAlumnos.ReadOnly = true;
            dgvCursoAlumnos.RowTemplate.Height = 25;
            dgvCursoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCursoAlumnos.Size = new System.Drawing.Size(794, 355);
            dgvCursoAlumnos.TabIndex = 2;
            dgvCursoAlumnos.CellClick += dgvCursoAlumnos_CellClick;
            // 
            // IdInscripcion
            // 
            IdInscripcion.DataPropertyName = "Id";
            IdInscripcion.FillWeight = 10F;
            IdInscripcion.HeaderText = "IdInscripcion";
            IdInscripcion.Name = "IdInscripcion";
            IdInscripcion.ReadOnly = true;
            IdInscripcion.Visible = false;
            // 
            // Legajo
            // 
            Legajo.DataPropertyName = "Alumno.Legajo";
            Legajo.FillWeight = 20F;
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Alumno.Apellido";
            Apellido.FillWeight = 30F;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Alumno.Nombre";
            Nombre.FillWeight = 30F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.DataPropertyName = "Condicion";
            Condicion.FillWeight = 8F;
            Condicion.HeaderText = "Condicion";
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "Nota";
            Nota.FillWeight = 8F;
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // Actualizar
            // 
            Actualizar.FillWeight = 8F;
            Actualizar.HeaderText = "";
            Actualizar.Name = "Actualizar";
            Actualizar.ReadOnly = true;
            Actualizar.Text = "Actualizar";
            Actualizar.UseColumnTextForButtonValue = true;
            // 
            // Estado
            // 
            Estado.FillWeight = 8F;
            Estado.HeaderText = "";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Text = "Estado";
            Estado.UseColumnTextForButtonValue = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlpCursoAlumnos.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Location = new System.Drawing.Point(3, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(794, 15);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "label1";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // CursoAlumnos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "CursoAlumnos";
            Text = "CursoAlumnos";
            Load += CursoAlumnos_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tlpCursoAlumnos.ResumeLayout(false);
            tlpCursoAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursoAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpCursoAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCursoAlumnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Estado;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}