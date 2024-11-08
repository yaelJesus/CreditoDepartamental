namespace CreditoDepartamental
{
    partial class ApplyForCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyForCredit));
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblLineU = new System.Windows.Forms.Label();
            this.lblLineP = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbINE = new System.Windows.Forms.PictureBox();
            this.btnINE = new System.Windows.Forms.Button();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.pbPDF = new System.Windows.Forms.PictureBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.btnQutarPDF = new System.Windows.Forms.PictureBox();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnQuitarINE = new System.Windows.Forms.PictureBox();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.dtpBornDate = new CreditoDepartamental.Properties.CustomDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbINE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQutarPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitarINE)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(581, 72);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 25);
            this.txtPhone.TabIndex = 18;
            this.txtPhone.Text = "Telefono";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFullName.Location = new System.Drawing.Point(47, 73);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(513, 25);
            this.txtFullName.TabIndex = 17;
            this.txtFullName.Text = "Nombre Completo";
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // lblLineU
            // 
            this.lblLineU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLineU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.lblLineU.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLineU.Location = new System.Drawing.Point(43, 84);
            this.lblLineU.Name = "lblLineU";
            this.lblLineU.Size = new System.Drawing.Size(518, 16);
            this.lblLineU.TabIndex = 19;
            this.lblLineU.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // lblLineP
            // 
            this.lblLineP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLineP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.lblLineP.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLineP.Location = new System.Drawing.Point(578, 84);
            this.lblLineP.Name = "lblLineP";
            this.lblLineP.Size = new System.Drawing.Size(201, 16);
            this.lblLineP.TabIndex = 20;
            this.lblLineP.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSalary.Location = new System.Drawing.Point(623, 164);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(154, 25);
            this.txtSalary.TabIndex = 22;
            this.txtSalary.Text = "Salario";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMail.Location = new System.Drawing.Point(47, 123);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(362, 25);
            this.txtMail.TabIndex = 21;
            this.txtMail.Text = "Correo";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(43, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(627, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Solicitud de Credito";
            // 
            // pbINE
            // 
            this.pbINE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbINE.Image = global::CreditoDepartamental.Properties.Resources.ine;
            this.pbINE.Location = new System.Drawing.Point(60, 175);
            this.pbINE.Name = "pbINE";
            this.pbINE.Size = new System.Drawing.Size(276, 142);
            this.pbINE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbINE.TabIndex = 27;
            this.pbINE.TabStop = false;
            this.pbINE.Visible = false;
            // 
            // btnINE
            // 
            this.btnINE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnINE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.btnINE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.btnINE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnINE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(126)))));
            this.btnINE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINE.ForeColor = System.Drawing.Color.LightGray;
            this.btnINE.Location = new System.Drawing.Point(107, 338);
            this.btnINE.Name = "btnINE";
            this.btnINE.Size = new System.Drawing.Size(182, 40);
            this.btnINE.TabIndex = 28;
            this.btnINE.Text = "Cargar INE";
            this.btnINE.UseVisualStyleBackColor = false;
            this.btnINE.Click += new System.EventHandler(this.btnINE_Click);
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.btnDomicilio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.btnDomicilio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDomicilio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(126)))));
            this.btnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomicilio.ForeColor = System.Drawing.Color.LightGray;
            this.btnDomicilio.Location = new System.Drawing.Point(417, 322);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(250, 67);
            this.btnDomicilio.TabIndex = 29;
            this.btnDomicilio.Text = "Cargar Comprobante de domicilio";
            this.btnDomicilio.UseVisualStyleBackColor = false;
            this.btnDomicilio.Click += new System.EventHandler(this.btnDomicilio_Click);
            // 
            // pbPDF
            // 
            this.pbPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPDF.Image = ((System.Drawing.Image)(resources.GetObject("pbPDF.Image")));
            this.pbPDF.Location = new System.Drawing.Point(509, 181);
            this.pbPDF.Name = "pbPDF";
            this.pbPDF.Size = new System.Drawing.Size(62, 75);
            this.pbPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPDF.TabIndex = 30;
            this.pbPDF.TabStop = false;
            this.pbPDF.Visible = false;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSalary.Location = new System.Drawing.Point(639, 161);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(21, 23);
            this.lblSalary.TabIndex = 31;
            this.lblSalary.Text = "$";
            this.lblSalary.Visible = false;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.lblDomicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDomicilio.Location = new System.Drawing.Point(391, 269);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(276, 23);
            this.lblDomicilio.TabIndex = 32;
            this.lblDomicilio.Text = "Comprobante de domicilio";
            this.lblDomicilio.Visible = false;
            // 
            // btnQutarPDF
            // 
            this.btnQutarPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQutarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQutarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnQutarPDF.Image")));
            this.btnQutarPDF.Location = new System.Drawing.Point(684, 272);
            this.btnQutarPDF.Name = "btnQutarPDF";
            this.btnQutarPDF.Size = new System.Drawing.Size(22, 19);
            this.btnQutarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQutarPDF.TabIndex = 33;
            this.btnQutarPDF.TabStop = false;
            this.btnQutarPDF.Visible = false;
            this.btnQutarPDF.Click += new System.EventHandler(this.btnQutarPDF_Click);
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // btnQuitarINE
            // 
            this.btnQuitarINE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitarINE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarINE.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarINE.Image")));
            this.btnQuitarINE.Location = new System.Drawing.Point(314, 175);
            this.btnQuitarINE.Name = "btnQuitarINE";
            this.btnQuitarINE.Size = new System.Drawing.Size(22, 19);
            this.btnQuitarINE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuitarINE.TabIndex = 34;
            this.btnQuitarINE.TabStop = false;
            this.btnQuitarINE.Visible = false;
            this.btnQuitarINE.Click += new System.EventHandler(this.btnQuitarINE_Click);
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.btnSolicitud.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(181)))));
            this.btnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitud.ForeColor = System.Drawing.Color.LightGray;
            this.btnSolicitud.Location = new System.Drawing.Point(527, 414);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(276, 40);
            this.btnSolicitud.TabIndex = 35;
            this.btnSolicitud.Text = "Solicitar";
            this.btnSolicitud.UseVisualStyleBackColor = false;
            this.btnSolicitud.Click += new System.EventHandler(this.btnSolicitud_Click);
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBornDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpBornDate.BorderSize = 0;
            this.dtpBornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpBornDate.Location = new System.Drawing.Point(417, 117);
            this.dtpBornDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(362, 35);
            this.dtpBornDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dtpBornDate.TabIndex = 25;
            this.dtpBornDate.TextColor = System.Drawing.Color.White;
            // 
            // ApplyForCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.btnSolicitud);
            this.Controls.Add(this.btnQuitarINE);
            this.Controls.Add(this.btnQutarPDF);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.pbPDF);
            this.Controls.Add(this.btnDomicilio);
            this.Controls.Add(this.btnINE);
            this.Controls.Add(this.pbINE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBornDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblLineU);
            this.Controls.Add(this.lblLineP);
            this.Name = "ApplyForCredit";
            this.Text = "ApplyForCredit";
            ((System.ComponentModel.ISupportInitialize)(this.pbINE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQutarPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitarINE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblLineU;
        private System.Windows.Forms.Label lblLineP;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Properties.CustomDatePicker dtpBornDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbINE;
        private System.Windows.Forms.Button btnINE;
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.PictureBox pbPDF;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.PictureBox btnQutarPDF;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.PictureBox btnQuitarINE;
        private System.Windows.Forms.Button btnSolicitud;
    }
}