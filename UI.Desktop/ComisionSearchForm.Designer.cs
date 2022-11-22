namespace UI.Desktop
{
    partial class ComisionSearchForm
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
            this.tscComisiones = new System.Windows.Forms.ToolStripContainer();
            this.tlpComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscComisiones.ContentPanel.SuspendLayout();
            this.tscComisiones.SuspendLayout();
            this.tlpComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // tscComisiones
            // 
            // 
            // tscComisiones.ContentPanel
            // 
            this.tscComisiones.ContentPanel.Controls.Add(this.tlpComisiones);
            this.tscComisiones.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tscComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscComisiones.Location = new System.Drawing.Point(0, 0);
            this.tscComisiones.Name = "tscComisiones";
            this.tscComisiones.Size = new System.Drawing.Size(800, 450);
            this.tscComisiones.TabIndex = 0;
            this.tscComisiones.Text = "toolStripContainer1";
            // 
            // tlpComisiones
            // 
            this.tlpComisiones.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlpComisiones.ColumnCount = 2;
            this.tlpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.25F));
            this.tlpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.75F));
            this.tlpComisiones.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlpComisiones.Controls.Add(this.btnCancelar, 1, 1);
            this.tlpComisiones.Controls.Add(this.dgvComisiones, 0, 0);
            this.tlpComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComisiones.Location = new System.Drawing.Point(0, 0);
            this.tlpComisiones.Name = "tlpComisiones";
            this.tlpComisiones.RowCount = 2;
            this.tlpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisiones.Size = new System.Drawing.Size(800, 425);
            this.tlpComisiones.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeleccionar.Location = new System.Drawing.Point(567, 374);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 48);
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
            this.btnCancelar.Location = new System.Drawing.Point(685, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 48);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Comision,
            this.AnioEspecialidad,
            this.Plan});
            this.tlpComisiones.SetColumnSpan(this.dgvComisiones, 2);
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.RowHeadersWidth = 62;
            this.dgvComisiones.RowTemplate.Height = 33;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(794, 365);
            this.dgvComisiones.TabIndex = 2;
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
            // Comision
            // 
            this.Comision.DataPropertyName = "Descripcion";
            this.Comision.HeaderText = "Comisión";
            this.Comision.MinimumWidth = 8;
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // AnioEspecialidad
            // 
            this.AnioEspecialidad.DataPropertyName = "AnioEspecialidad";
            this.AnioEspecialidad.HeaderText = "Año especialidad";
            this.AnioEspecialidad.MinimumWidth = 8;
            this.AnioEspecialidad.Name = "AnioEspecialidad";
            this.AnioEspecialidad.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "PlanDescripcion";
            this.Plan.HeaderText = "Plan";
            this.Plan.MinimumWidth = 8;
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // ComisionSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscComisiones);
            this.Name = "ComisionSearchForm";
            this.Text = "ComisionSearchForm";
            this.Load += new System.EventHandler(this.ComisionSearchForm_Load);
            this.tscComisiones.ContentPanel.ResumeLayout(false);
            this.tscComisiones.ResumeLayout(false);
            this.tscComisiones.PerformLayout();
            this.tlpComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscComisiones;
        private System.Windows.Forms.TableLayoutPanel tlpComisiones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
    }
}