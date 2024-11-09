namespace CreditoDepartamental
{
    partial class FechaCorte
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
            this.lblFechaCorte = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.lblDiasRestantes = new System.Windows.Forms.Label();
            this.panelAdvertencias = new System.Windows.Forms.Panel();
            this.panelAdvertencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaCorte
            // 
            this.lblFechaCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaCorte.AutoSize = true;
            this.lblFechaCorte.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCorte.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFechaCorte.Location = new System.Drawing.Point(140, 105);
            this.lblFechaCorte.Name = "lblFechaCorte";
            this.lblFechaCorte.Size = new System.Drawing.Size(363, 27);
            this.lblFechaCorte.TabIndex = 0;
            this.lblFechaCorte.Text = "Fecha de corte: 30/[Mes]/[Año]";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvertencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.lblAdvertencia.Location = new System.Drawing.Point(47, 10);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(488, 62);
            this.lblAdvertencia.TabIndex = 1;
            // 
            // lblDiasRestantes
            // 
            this.lblDiasRestantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiasRestantes.AutoSize = true;
            this.lblDiasRestantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasRestantes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDiasRestantes.Location = new System.Drawing.Point(140, 152);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(170, 23);
            this.lblDiasRestantes.TabIndex = 2;
            this.lblDiasRestantes.Text = "Días restantes: X";
            // 
            // panelAdvertencias
            // 
            this.panelAdvertencias.Controls.Add(this.lblAdvertencia);
            this.panelAdvertencias.Location = new System.Drawing.Point(108, 271);
            this.panelAdvertencias.Name = "panelAdvertencias";
            this.panelAdvertencias.Size = new System.Drawing.Size(618, 151);
            this.panelAdvertencias.TabIndex = 3;
            // 
            // FechaCorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.panelAdvertencias);
            this.Controls.Add(this.lblDiasRestantes);
            this.Controls.Add(this.lblFechaCorte);
            this.Name = "FechaCorte";
            this.Text = "FechaCorte";
            this.panelAdvertencias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaCorte;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Label lblDiasRestantes;
        private System.Windows.Forms.Panel panelAdvertencias;
    }
}