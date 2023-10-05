namespace UI.Desktop
{
    partial class PlanSearchForm
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
            tscPlan = new System.Windows.Forms.ToolStripContainer();
            tlpPlanes = new System.Windows.Forms.TableLayoutPanel();
            dgvPlanes = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PlanDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnCancelar = new System.Windows.Forms.Button();
            btnSeleccionar = new System.Windows.Forms.Button();
            cbEspecialides = new System.Windows.Forms.ComboBox();
            lblEspecialidades = new System.Windows.Forms.Label();
            Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            tscPlan.ContentPanel.SuspendLayout();
            tscPlan.SuspendLayout();
            tlpPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // tscPlan
            // 
            // 
            // tscPlan.ContentPanel
            // 
            tscPlan.ContentPanel.Controls.Add(tlpPlanes);
            tscPlan.ContentPanel.Size = new System.Drawing.Size(1040, 435);
            tscPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            tscPlan.Location = new System.Drawing.Point(0, 0);
            tscPlan.Name = "tscPlan";
            tscPlan.Size = new System.Drawing.Size(1040, 460);
            tscPlan.TabIndex = 0;
            tscPlan.Text = "toolStripContainer1";
            // 
            // tlpPlanes
            // 
            tlpPlanes.ColumnCount = 4;
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5185184F));
            tlpPlanes.Controls.Add(dgvPlanes, 2, 1);
            tlpPlanes.Controls.Add(btnCancelar, 3, 3);
            tlpPlanes.Controls.Add(btnSeleccionar, 2, 3);
            tlpPlanes.Controls.Add(cbEspecialides, 2, 0);
            tlpPlanes.Controls.Add(lblEspecialidades, 1, 0);
            tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPlanes.Location = new System.Drawing.Point(0, 0);
            tlpPlanes.Name = "tlpPlanes";
            tlpPlanes.RowCount = 3;
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            tlpPlanes.Size = new System.Drawing.Size(1040, 435);
            tlpPlanes.TabIndex = 0;
            // 
            // dgvPlanes
            // 
            dgvPlanes.AllowUserToAddRows = false;
            dgvPlanes.AllowUserToDeleteRows = false;
            dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, PlanDescripcion });
            tlpPlanes.SetColumnSpan(dgvPlanes, 4);
            dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPlanes.Location = new System.Drawing.Point(3, 64);
            dgvPlanes.MultiSelect = false;
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowHeadersWidth = 62;
            dgvPlanes.RowTemplate.Height = 33;
            dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPlanes.Size = new System.Drawing.Size(1034, 317);
            dgvPlanes.TabIndex = 2;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // PlanDescripcion
            // 
            PlanDescripcion.DataPropertyName = "Descripcion";
            PlanDescripcion.HeaderText = "Plan";
            PlanDescripcion.MinimumWidth = 8;
            PlanDescripcion.Name = "PlanDescripcion";
            PlanDescripcion.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(919, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(111, 43);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionar.BackColor = System.Drawing.Color.Green;
            btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSeleccionar.Location = new System.Drawing.Point(802, 387);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(111, 43);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // cbEspecialides
            // 
            cbEspecialides.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cbEspecialides.FormattingEnabled = true;
            cbEspecialides.Location = new System.Drawing.Point(375, 14);
            cbEspecialides.Name = "cbEspecialides";
            cbEspecialides.Size = new System.Drawing.Size(341, 33);
            cbEspecialides.TabIndex = 3;
            cbEspecialides.SelectionChangeCommitted += cbEspecialides_SelectionChangeCommitted;
            cbEspecialides.ValueMemberChanged += cbEspecialides_ValueMemberChanged;
            // 
            // lblEspecialidades
            // 
            lblEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblEspecialidades.AutoSize = true;
            lblEspecialidades.Location = new System.Drawing.Point(239, 18);
            lblEspecialidades.Name = "lblEspecialidades";
            lblEspecialidades.Size = new System.Drawing.Size(130, 25);
            lblEspecialidades.TabIndex = 4;
            lblEspecialidades.Text = "Especialidades:";
            // 
            // Plan
            // 
            Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Plan.DataPropertyName = "Descripcion";
            Plan.Frozen = true;
            Plan.HeaderText = "Plan";
            Plan.MinimumWidth = 8;
            Plan.Name = "Plan";
            Plan.Width = 342;
            // 
            // Especialidad
            // 
            Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Especialidad.DataPropertyName = "EspecialidadDescripcion";
            Especialidad.Frozen = true;
            Especialidad.HeaderText = "Especialidad";
            Especialidad.MinimumWidth = 8;
            Especialidad.Name = "Especialidad";
            Especialidad.Width = 342;
            // 
            // Acciones
            // 
            Acciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Acciones.Frozen = true;
            Acciones.HeaderText = "";
            Acciones.MinimumWidth = 8;
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Text = "Seleccionar";
            Acciones.Width = 150;
            // 
            // PlanSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new System.Drawing.Size(1040, 460);
            Controls.Add(tscPlan);
            ForeColor = System.Drawing.SystemColors.ControlText;
            MaximizeBox = false;
            Name = "PlanSearchForm";
            Text = "Seleccione un plan";
            Load += PlanSearchForm_Load;
            tscPlan.ContentPanel.ResumeLayout(false);
            tscPlan.ResumeLayout(false);
            tscPlan.PerformLayout();
            tlpPlanes.ResumeLayout(false);
            tlpPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscPlan;
        private System.Windows.Forms.TableLayoutPanel tlpPlanes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.ComboBox cbEspecialides;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanDescripcion;
    }
}