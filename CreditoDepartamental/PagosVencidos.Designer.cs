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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagosVencidos
            // 
            this.dgvPagosVencidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPagosVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPago,
            this.MontoVencido,
            this.FechaVencimiento,
            this.DiasRetraso,
            this.MontoConMulta,
            this.btnPagar});
            this.dgvPagosVencidos.Location = new System.Drawing.Point(33, 65);
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(279, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pagos Vencidos";
            // 
            // PagosVencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPagosVencidos);
            this.Name = "PagosVencidos";
            this.Text = "PagosVencidos";
            this.Load += new System.EventHandler(this.PagosVencidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosVencidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagosVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasRetraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoConMulta;
        private System.Windows.Forms.DataGridViewButtonColumn btnPagar;
        private System.Windows.Forms.Label label3;
    }
}