namespace CreditoDepartamental
{
    partial class PagosVencidos
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
            this.dgvPagosVencidos = new System.Windows.Forms.DataGridView();
            this.NumeroPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasRetraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoConMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagosVencidos
            // 
            this.dgvPagosVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPago,
            this.MontoVencido,
            this.FechaVencimiento,
            this.DiasRetraso,
            this.MontoConMulta,
            this.btnPagar});
            this.dgvPagosVencidos.Location = new System.Drawing.Point(33, 38);
            this.dgvPagosVencidos.Name = "dgvPagosVencidos";
            this.dgvPagosVencidos.RowHeadersWidth = 51;
            this.dgvPagosVencidos.RowTemplate.Height = 24;
            this.dgvPagosVencidos.Size = new System.Drawing.Size(766, 376);
            this.dgvPagosVencidos.TabIndex = 0;
            this.dgvPagosVencidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagosVencidos_CellClick);
            // 
            // NumeroPago
            // 
            this.NumeroPago.HeaderText = "Numero de Pago ";
            this.NumeroPago.MinimumWidth = 6;
            this.NumeroPago.Name = "NumeroPago";
            // 
            // MontoVencido
            // 
            this.MontoVencido.HeaderText = "Monto Vencido";
            this.MontoVencido.MinimumWidth = 6;
            this.MontoVencido.Name = "MontoVencido";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Fecha de Vencimiento ";
            this.FechaVencimiento.MinimumWidth = 6;
            this.FechaVencimiento.Name = "FechaVencimiento";
            // 
            // DiasRetraso
            // 
            this.DiasRetraso.HeaderText = "Dias de Retraso";
            this.DiasRetraso.MinimumWidth = 6;
            this.DiasRetraso.Name = "DiasRetraso";
            // 
            // MontoConMulta
            // 
            this.MontoConMulta.HeaderText = "Monto con Multa ";
            this.MontoConMulta.MinimumWidth = 6;
            this.MontoConMulta.Name = "MontoConMulta";
            // 
            // btnPagar
            // 
            this.btnPagar.HeaderText = "Pagar ahora";
            this.btnPagar.MinimumWidth = 6;
            this.btnPagar.Name = "btnPagar";
            // 
            // PagosVencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.dgvPagosVencidos);
            this.Name = "PagosVencidos";
            this.Text = "PagosVencidos";
            this.Load += new System.EventHandler(this.PagosVencidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosVencidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagosVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasRetraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoConMulta;
        private System.Windows.Forms.DataGridViewButtonColumn btnPagar;
    }
}