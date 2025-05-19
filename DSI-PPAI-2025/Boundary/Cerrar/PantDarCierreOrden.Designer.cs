namespace DSI_PPAI_2025.Boundary.Cerrar
{
    partial class PantDarCierreOrden
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
            this.grillaDatosOrden = new System.Windows.Forms.DataGridView();
            this.SelectOrden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.númerodeorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadefinalización = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estación_sismológica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_estación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatosOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDatosOrden
            // 
            this.grillaDatosOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDatosOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.númerodeorden,
            this.fechadefinalización,
            this.estación_sismológica,
            this.Nro_estación});
            this.grillaDatosOrden.Location = new System.Drawing.Point(43, 87);
            this.grillaDatosOrden.Name = "grillaDatosOrden";
            this.grillaDatosOrden.Size = new System.Drawing.Size(645, 120);
            this.grillaDatosOrden.TabIndex = 0;
            // 
            // SelectOrden
            // 
            this.SelectOrden.Location = new System.Drawing.Point(727, 108);
            this.SelectOrden.Name = "SelectOrden";
            this.SelectOrden.Size = new System.Drawing.Size(75, 23);
            this.SelectOrden.TabIndex = 1;
            this.SelectOrden.Text = "Seleccionar";
            this.SelectOrden.UseVisualStyleBackColor = true;
            this.SelectOrden.Click += new System.EventHandler(this.SelectOrden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de las Ordenes de Inspeccion";
            // 
            // númerodeorden
            // 
            this.númerodeorden.HeaderText = "número de orden";
            this.númerodeorden.Name = "númerodeorden";
            this.númerodeorden.Width = 150;
            // 
            // fechadefinalización
            // 
            this.fechadefinalización.HeaderText = "fecha de finalización";
            this.fechadefinalización.Name = "fechadefinalización";
            this.fechadefinalización.Width = 150;
            // 
            // estación_sismológica
            // 
            this.estación_sismológica.HeaderText = "estación sismológica";
            this.estación_sismológica.Name = "estación_sismológica";
            this.estación_sismológica.Width = 150;
            // 
            // Nro_estación
            // 
            this.Nro_estación.HeaderText = "nro_estación";
            this.Nro_estación.Name = "Nro_estación";
            this.Nro_estación.Width = 150;
            // 
            // PantDarCierreOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectOrden);
            this.Controls.Add(this.grillaDatosOrden);
            this.Name = "PantDarCierreOrden";
            this.Text = "PantDarCierreOrden";
            ((System.ComponentModel.ISupportInitialize)(this.grillaDatosOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDatosOrden;
        private System.Windows.Forms.Button SelectOrden;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn númerodeorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadefinalización;
        private System.Windows.Forms.DataGridViewTextBoxColumn estación_sismológica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_estación;
    }
}