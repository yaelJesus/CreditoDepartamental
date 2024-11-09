namespace CreditoDepartamental
{
    partial class ProximosPagos
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
            this.dgvPagosProximos = new System.Windows.Forms.DataGridView();
            this.NumeroPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasRestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosProximos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagosProximos
            // 
            this.dgvPagosProximos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPagosProximos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosProximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosProximos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPago,
            this.Monto,
            this.FechaVencimiento,
            this.DiasRestantes});
            this.dgvPagosProximos.Location = new System.Drawing.Point(29, 67);
            this.dgvPagosProximos.Name = "dgvPagosProximos";
            this.dgvPagosProximos.RowHeadersWidth = 51;
            this.dgvPagosProximos.RowTemplate.Height = 24;
            this.dgvPagosProximos.Size = new System.Drawing.Size(766, 376);
            this.dgvPagosProximos.TabIndex = 1;
            this.dgvPagosProximos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPagosProximos_RowPrePaint);
            // 
            // NumeroPago
            // 
            this.NumeroPago.HeaderText = "Numero de Pago ";
            this.NumeroPago.MinimumWidth = 6;
            this.NumeroPago.Name = "NumeroPago";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento ";
            this.FechaVencimiento.MinimumWidth = 6;
            this.FechaVencimiento.Name = "FechaVencimiento";
            // 
            // DiasRestantes
            // 
            this.DiasRestantes.HeaderText = "Dias Restantes";
            this.DiasRestantes.MinimumWidth = 6;
            this.DiasRestantes.Name = "DiasRestantes";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(284, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pagos Proximos";
            // 
            // ProximosPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPagosProximos);
            this.Name = "ProximosPagos";
            this.Text = "ProximosPagos";
            this.Load += new System.EventHandler(this.ProximosPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosProximos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagosProximos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasRestantes;
        private System.Windows.Forms.Label label3;
    }
}