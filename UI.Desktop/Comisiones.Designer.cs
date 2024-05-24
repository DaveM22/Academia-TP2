namespace UI.Desktop
{
    partial class Comisiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            tscComisiones = new System.Windows.Forms.ToolStripContainer();
            tlComisiones = new System.Windows.Forms.TableLayoutPanel();
            btnActualizar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            dgvComisiones = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AnioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            label1 = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsNuevo = new System.Windows.Forms.ToolStripButton();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            tscComisiones.ContentPanel.SuspendLayout();
            tscComisiones.TopToolStripPanel.SuspendLayout();
            tscComisiones.SuspendLayout();
            tlComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscComisiones
            // 
            // 
            // tscComisiones.ContentPanel
            // 
            tscComisiones.ContentPanel.Controls.Add(tlComisiones);
            tscComisiones.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            tscComisiones.ContentPanel.Size = new System.Drawing.Size(1102, 546);
            tscComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            tscComisiones.Location = new System.Drawing.Point(0, 0);
            tscComisiones.Margin = new System.Windows.Forms.Padding(2);
            tscComisiones.Name = "tscComisiones";
            tscComisiones.Size = new System.Drawing.Size(1102, 571);
            tscComisiones.TabIndex = 0;
            tscComisiones.Text = "toolStripContainer1";
            // 
            // tscComisiones.TopToolStripPanel
            // 
            tscComisiones.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlComisiones
            // 
            tlComisiones.BackColor = System.Drawing.Color.CornflowerBlue;
            tlComisiones.ColumnCount = 2;
            tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlComisiones.Controls.Add(btnActualizar, 0, 2);
            tlComisiones.Controls.Add(btnSalir, 1, 2);
            tlComisiones.Controls.Add(dgvComisiones, 0, 1);
            tlComisiones.Controls.Add(label1, 0, 0);
            tlComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            tlComisiones.Location = new System.Drawing.Point(0, 0);
            tlComisiones.Margin = new System.Windows.Forms.Padding(2);
            tlComisiones.Name = "tlComisiones";
            tlComisiones.RowCount = 3;
            tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlComisiones.Size = new System.Drawing.Size(1102, 546);
            tlComisiones.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(886, 515);
            btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(78, 29);
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
            btnSalir.Location = new System.Drawing.Point(968, 515);
            btnSalir.Margin = new System.Windows.Forms.Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(132, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Volver al inicio";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvComisiones
            // 
            dgvComisiones.AllowUserToAddRows = false;
            dgvComisiones.AllowUserToDeleteRows = false;
            dgvComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Descripcion, Plan, AnioEspecialidad, Editar, Borrar });
            tlComisiones.SetColumnSpan(dgvComisiones, 2);
            dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvComisiones.Location = new System.Drawing.Point(2, 38);
            dgvComisiones.Margin = new System.Windows.Forms.Padding(2);
            dgvComisiones.MultiSelect = false;
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.ReadOnly = true;
            dgvComisiones.RowHeadersWidth = 62;
            dgvComisiones.RowTemplate.Height = 33;
            dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvComisiones.Size = new System.Drawing.Size(1098, 473);
            dgvComisiones.TabIndex = 0;
            dgvComisiones.CellContentClick += dgvComisiones_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            Descripcion.DefaultCellStyle = dataGridViewCellStyle1;
            Descripcion.FillWeight = 40F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Plan
            // 
            Plan.DataPropertyName = "Plan.Descripcion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            Plan.DefaultCellStyle = dataGridViewCellStyle2;
            Plan.FillWeight = 30F;
            Plan.HeaderText = "Plan";
            Plan.MinimumWidth = 8;
            Plan.Name = "Plan";
            Plan.ReadOnly = true;
            // 
            // AnioEspecialidad
            // 
            AnioEspecialidad.DataPropertyName = "AnioEspecialidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            AnioEspecialidad.DefaultCellStyle = dataGridViewCellStyle3;
            AnioEspecialidad.FillWeight = 10F;
            AnioEspecialidad.HeaderText = "Año Especialidad";
            AnioEspecialidad.MinimumWidth = 8;
            AnioEspecialidad.Name = "AnioEspecialidad";
            AnioEspecialidad.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Editar";
            Editar.DefaultCellStyle = dataGridViewCellStyle4;
            Editar.FillWeight = 10F;
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            // 
            // Borrar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "Borrar";
            Borrar.DefaultCellStyle = dataGridViewCellStyle5;
            Borrar.FillWeight = 10F;
            Borrar.HeaderText = "";
            Borrar.MinimumWidth = 8;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            tlComisiones.SetColumnSpan(label1, 2);
            label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1096, 27);
            label1.TabIndex = 3;
            label1.Text = "Comisiones";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevo });
            toolStrip1.Location = new System.Drawing.Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(109, 25);
            toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (System.Drawing.Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new System.Drawing.Size(97, 22);
            tsNuevo.Text = "Nueva comisión";
            tsNuevo.Click += tsNuevo_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Comisiones
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1102, 571);
            ControlBox = false;
            Controls.Add(tscComisiones);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Comisiones";
            Text = "Comisiones";
            tscComisiones.ContentPanel.ResumeLayout(false);
            tscComisiones.TopToolStripPanel.ResumeLayout(false);
            tscComisiones.TopToolStripPanel.PerformLayout();
            tscComisiones.ResumeLayout(false);
            tscComisiones.PerformLayout();
            tlComisiones.ResumeLayout(false);
            tlComisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscComisiones;
        private System.Windows.Forms.TableLayoutPanel tlComisiones;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioEspecialidad;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.Label label1;
    }
}