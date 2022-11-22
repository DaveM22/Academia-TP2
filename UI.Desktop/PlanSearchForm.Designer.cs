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
            this.tscPlan = new System.Windows.Forms.ToolStripContainer();
            this.tlpPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscPlan.ContentPanel.SuspendLayout();
            this.tscPlan.SuspendLayout();
            this.tlpPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // tscPlan
            // 
            // 
            // tscPlan.ContentPanel
            // 
            this.tscPlan.ContentPanel.Controls.Add(this.tlpPlanes);
            this.tscPlan.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tscPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscPlan.Location = new System.Drawing.Point(0, 0);
            this.tscPlan.Name = "tscPlan";
            this.tscPlan.Size = new System.Drawing.Size(800, 450);
            this.tscPlan.TabIndex = 0;
            this.tscPlan.Text = "toolStripContainer1";
            // 
            // tlpPlanes
            // 
            this.tlpPlanes.ColumnCount = 2;
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.875F));
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.125F));
            this.tlpPlanes.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlpPlanes.Controls.Add(this.btnCancelar, 1, 1);
            this.tlpPlanes.Controls.Add(this.dgvPlanes, 0, 0);
            this.tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlanes.Location = new System.Drawing.Point(0, 0);
            this.tlpPlanes.Name = "tlpPlanes";
            this.tlpPlanes.RowCount = 2;
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanes.Size = new System.Drawing.Size(800, 425);
            this.tlpPlanes.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeleccionar.Location = new System.Drawing.Point(564, 378);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 44);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(682, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 44);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Plan,
            this.Especialidad});
            this.tlpPlanes.SetColumnSpan(this.dgvPlanes, 2);
            this.dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanes.Location = new System.Drawing.Point(3, 3);
            this.dgvPlanes.MultiSelect = false;
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.RowHeadersWidth = 62;
            this.dgvPlanes.RowTemplate.Height = 33;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(794, 369);
            this.dgvPlanes.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "Descripcion";
            this.Plan.HeaderText = "Plan";
            this.Plan.MinimumWidth = 8;
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "EspecialidadDescripcion";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 8;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // PlanSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscPlan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PlanSearchForm";
            this.Text = "Seleccione un plan";
            this.Load += new System.EventHandler(this.PlanSearchForm_Load);
            this.tscPlan.ContentPanel.ResumeLayout(false);
            this.tscPlan.ResumeLayout(false);
            this.tscPlan.PerformLayout();
            this.tlpPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscPlan;
        private System.Windows.Forms.TableLayoutPanel tlpPlanes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}