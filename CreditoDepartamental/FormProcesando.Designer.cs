namespace CreditoDepartamental
{
    partial class FormProcesando
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
            this.label1 = new System.Windows.Forms.Label();
            this.customProgressBar1 = new CreditoDepartamental.CustomControlers.CustomProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(213, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesando...";
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.customProgressBar1.ChannelHeight = 6;
            this.customProgressBar1.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.customProgressBar1.ForeColor = System.Drawing.Color.White;
            this.customProgressBar1.Location = new System.Drawing.Point(39, 115);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.ShowMaximun = false;
            this.customProgressBar1.ShowValue = CreditoDepartamental.CustomControlers.TextPosition.None;
            this.customProgressBar1.Size = new System.Drawing.Size(548, 30);
            this.customProgressBar1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.customProgressBar1.SliderHeight = 30;
            this.customProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.customProgressBar1.SymbolAfter = "";
            this.customProgressBar1.SymbolBefore = "";
            this.customProgressBar1.TabIndex = 1;
            // 
            // FormProcesando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(620, 211);
            this.ControlBox = false;
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormProcesando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesando solicitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControlers.CustomProgressBar customProgressBar1;
    }
}