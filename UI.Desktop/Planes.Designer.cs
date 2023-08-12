namespace UI.Desktop
{
    partial class Planes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planes));
            tscPlanes = new System.Windows.Forms.ToolStripContainer();
            tlPlanes = new System.Windows.Forms.TableLayoutPanel();
            dgvPlanes = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            btnActualizar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsNuevo = new System.Windows.Forms.ToolStripButton();
            niPlanes = new System.Windows.Forms.NotifyIcon(components);
            tscPlanes.ContentPanel.SuspendLayout();
            tscPlanes.TopToolStripPanel.SuspendLayout();
            tscPlanes.SuspendLayout();
            tlPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscPlanes
            // 
            // 
            // tscPlanes.ContentPanel
            // 
            tscPlanes.ContentPanel.Controls.Add(tlPlanes);
            tscPlanes.ContentPanel.Size = new System.Drawing.Size(1072, 416);
            tscPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tscPlanes.Location = new System.Drawing.Point(0, 0);
            tscPlanes.Name = "tscPlanes";
            tscPlanes.Size = new System.Drawing.Size(1072, 450);
            tscPlanes.TabIndex = 0;
            tscPlanes.Text = "tscPlanes";
            // 
            // tscPlanes.TopToolStripPanel
            // 
            tscPlanes.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlPlanes
            // 
            tlPlanes.BackColor = System.Drawing.Color.CornflowerBlue;
            tlPlanes.ColumnCount = 2;
            tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlPlanes.Controls.Add(dgvPlanes, 0, 0);
            tlPlanes.Controls.Add(btnActualizar, 0, 1);
            tlPlanes.Controls.Add(btnCancelar, 1, 1);
            tlPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tlPlanes.Location = new System.Drawing.Point(0, 0);
            tlPlanes.Name = "tlPlanes";
            tlPlanes.RowCount = 2;
            tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlPlanes.Size = new System.Drawing.Size(1072, 416);
            tlPlanes.TabIndex = 0;
            // 
            // dgvPlanes
            // 
            dgvPlanes.AllowUserToAddRows = false;
            dgvPlanes.AllowUserToDeleteRows = false;
            dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Descripcion, Especialidad, Editar, dataGridViewButtonColumn1 });
            tlPlanes.SetColumnSpan(dgvPlanes, 2);
            dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPlanes.Location = new System.Drawing.Point(3, 3);
            dgvPlanes.MultiSelect = false;
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPlanes.RowTemplate.Height = 33;
            dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPlanes.Size = new System.Drawing.Size(1066, 359);
            dgvPlanes.TabIndex = 0;
            dgvPlanes.CellClick += dgvPlanes_CellClick;
            // 
            // Id
            // 
            Id.FillWeight = 4F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.FillWeight = 40F;
            Descripcion.HeaderText = "Plan";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.ToolTipText = "Nombre del plan";
            // 
            // Especialidad
            // 
            Especialidad.DataPropertyName = "EspecialidadDescripcion";
            Especialidad.FillWeight = 40F;
            Especialidad.HeaderText = "Especialidad";
            Especialidad.MinimumWidth = 8;
            Especialidad.Name = "Especialidad";
            Especialidad.ReadOnly = true;
            Especialidad.ToolTipText = "Nombre de especialidad";
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Editar";
            Editar.DefaultCellStyle = dataGridViewCellStyle1;
            Editar.FillWeight = 8F;
            Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.FillWeight = 8F;
            dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.MinimumWidth = 8;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Eliminar";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.Location = new System.Drawing.Point(839, 368);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(112, 45);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(957, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(112, 45);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevo });
            toolStrip1.Location = new System.Drawing.Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(160, 34);
            toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (System.Drawing.Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new System.Drawing.Size(96, 29);
            tsNuevo.Text = "Crear plan";
            tsNuevo.Click += tsNuevo_Click;
            // 
            // niPlanes
            // 
            niPlanes.Visible = true;
            // 
            // Planes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1072, 450);
            Controls.Add(tscPlanes);
            Name = "Planes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Planes";
            tscPlanes.ContentPanel.ResumeLayout(false);
            tscPlanes.TopToolStripPanel.ResumeLayout(false);
            tscPlanes.TopToolStripPanel.PerformLayout();
            tscPlanes.ResumeLayout(false);
            tscPlanes.PerformLayout();
            tlPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscPlanes;
        private System.Windows.Forms.TableLayoutPanel tlPlanes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.NotifyIcon niPlanes;
    }
}