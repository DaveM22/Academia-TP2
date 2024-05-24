namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            tscCursos = new System.Windows.Forms.ToolStripContainer();
            tlCursos = new System.Windows.Forms.TableLayoutPanel();
            dgvCursos = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Reporte = new System.Windows.Forms.DataGridViewButtonColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            btnActualizar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            tsCursos = new System.Windows.Forms.ToolStrip();
            tsNuevo = new System.Windows.Forms.ToolStripButton();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            lblTitulo = new System.Windows.Forms.Label();
            tscCursos.ContentPanel.SuspendLayout();
            tscCursos.TopToolStripPanel.SuspendLayout();
            tscCursos.SuspendLayout();
            tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            tsCursos.SuspendLayout();
            SuspendLayout();
            // 
            // tscCursos
            // 
            // 
            // tscCursos.ContentPanel
            // 
            tscCursos.ContentPanel.Controls.Add(tlCursos);
            tscCursos.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            tscCursos.ContentPanel.Size = new System.Drawing.Size(883, 491);
            tscCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tscCursos.Location = new System.Drawing.Point(0, 0);
            tscCursos.Margin = new System.Windows.Forms.Padding(2);
            tscCursos.Name = "tscCursos";
            tscCursos.Size = new System.Drawing.Size(883, 516);
            tscCursos.TabIndex = 0;
            tscCursos.Text = "toolStripContainer1";
            // 
            // tscCursos.TopToolStripPanel
            // 
            tscCursos.TopToolStripPanel.Controls.Add(tsCursos);
            // 
            // tlCursos
            // 
            tlCursos.BackColor = System.Drawing.Color.CornflowerBlue;
            tlCursos.ColumnCount = 2;
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlCursos.Controls.Add(btnActualizar, 0, 2);
            tlCursos.Controls.Add(btnSalir, 1, 2);
            tlCursos.Controls.Add(dgvCursos, 0, 1);
            tlCursos.Controls.Add(lblTitulo, 0, 0);
            tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlCursos.Location = new System.Drawing.Point(0, 0);
            tlCursos.Margin = new System.Windows.Forms.Padding(2);
            tlCursos.Name = "tlCursos";
            tlCursos.RowCount = 3;
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlCursos.Size = new System.Drawing.Size(883, 491);
            tlCursos.TabIndex = 0;
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Materia, Comision, AnioCalendario, Cupo, Reporte, Editar, Eliminar });
            tlCursos.SetColumnSpan(dgvCursos, 2);
            dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCursos.Location = new System.Drawing.Point(2, 42);
            dgvCursos.Margin = new System.Windows.Forms.Padding(2);
            dgvCursos.MultiSelect = false;
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 62;
            dgvCursos.RowTemplate.Height = 33;
            dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new System.Drawing.Size(879, 412);
            dgvCursos.TabIndex = 0;
            dgvCursos.CellClick += dgvCursos_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "ComisionDescripcion";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "Materia.Descripcion";
            Materia.FillWeight = 30F;
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 8;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "Comision.Descripcion";
            Comision.FillWeight = 30F;
            Comision.HeaderText = "Comisión";
            Comision.MinimumWidth = 8;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            AnioCalendario.DataPropertyName = "AnioCalendario";
            AnioCalendario.FillWeight = 10F;
            AnioCalendario.HeaderText = "Año Calendario";
            AnioCalendario.MinimumWidth = 8;
            AnioCalendario.Name = "AnioCalendario";
            AnioCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            Cupo.DataPropertyName = "Cupo";
            Cupo.FillWeight = 10F;
            Cupo.HeaderText = "Cupo";
            Cupo.MinimumWidth = 8;
            Cupo.Name = "Cupo";
            Cupo.ReadOnly = true;
            // 
            // Reporte
            // 
            Reporte.FillWeight = 10F;
            Reporte.HeaderText = "";
            Reporte.Name = "Reporte";
            Reporte.ReadOnly = true;
            Reporte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Reporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Reporte.Text = "Generar reporte";
            Reporte.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            Editar.FillWeight = 8F;
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.FillWeight = 8F;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(689, 458);
            btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(78, 31);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.Firebrick;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSalir.Location = new System.Drawing.Point(771, 458);
            btnSalir.Margin = new System.Windows.Forms.Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(110, 31);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Volver al inicio";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsCursos
            // 
            tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            tsCursos.ImageScalingSize = new System.Drawing.Size(24, 24);
            tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevo });
            tsCursos.Location = new System.Drawing.Point(4, 0);
            tsCursos.Name = "tsCursos";
            tsCursos.Size = new System.Drawing.Size(83, 25);
            tsCursos.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (System.Drawing.Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new System.Drawing.Size(71, 22);
            tsNuevo.Text = "Crear curso";
            tsNuevo.Click += tsNuevo_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlCursos.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(3, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(877, 27);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Cursos";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cursos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(883, 516);
            Controls.Add(tscCursos);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Cursos";
            Text = "Cursos";
            Load += Cursos_Load;
            tscCursos.ContentPanel.ResumeLayout(false);
            tscCursos.TopToolStripPanel.ResumeLayout(false);
            tscCursos.TopToolStripPanel.PerformLayout();
            tscCursos.ResumeLayout(false);
            tscCursos.PerformLayout();
            tlCursos.ResumeLayout(false);
            tlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            tsCursos.ResumeLayout(false);
            tsCursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscCursos;
        private System.Windows.Forms.TableLayoutPanel tlCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewButtonColumn Reporte;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label lblTitulo;
    }
}