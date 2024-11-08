using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CreditoDepartamental
{
    public partial class ApplyForCredit : Form
    {
        public event Action BackToMenu;

        public ApplyForCredit()
        {
            InitializeComponent();
            ConfigurarDateTimePicker();

            txtFullName.TextChanged += (s, e) => ValidarCampos();
            txtPhone.TextChanged += (s, e) => ValidarCampos();
            txtMail.TextChanged += (s, e) => ValidarCampos();
            txtSalary.TextChanged += (s, e) => ValidarCampos();
            dtpBornDate.ValueChanged += (s, e) => ValidarCampos();
            pbPDF.VisibleChanged += (s, e) => ValidarCampos();
            pbINE.VisibleChanged += (s, e) => ValidarCampos();
            btnSolicitud.Enabled = false;
        }
        private bool isActive = false;

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                isActive = true;
            else
                isActive = false;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                isActive = true;
            else
                isActive = false;
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                string email = txtMail.Text;
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                bool isEmail = Regex.IsMatch(email, pattern);

                if (isEmail)
                    isActive = true;
                else
                    isActive = false;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                isActive = true;
            else
                isActive = false;
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void ConfigurarDateTimePicker()
        {
            dtpBornDate.Value = DateTime.Now.AddYears(-18);
            dtpBornDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBornDate.MinDate = DateTime.Now.AddYears(-100);
        }

        private void btnINE_Click(object sender, EventArgs e)
        {
            ofdArchivo.InitialDirectory = "C:\\Users\\AcerVero\\Downloads";
            ofdArchivo.Filter = "Imagenes|*.jpg;*.jpeg;*.png;";

            if (ofdArchivo.ShowDialog() == DialogResult.OK)
            {
                pbINE.Visible = true;
                btnQuitarINE.Visible = true;
            }
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            ofdArchivo.InitialDirectory = "C:\\Users\\AcerVero\\Downloads";
            ofdArchivo.Filter = "PDF|*.pdf;";

            if (ofdArchivo.ShowDialog() == DialogResult.OK)
            {
                pbPDF.Visible = true;
                lblDomicilio.Visible = true;
                btnQutarPDF.Visible = true;
            }
        }

        private void btnQutarPDF_Click(object sender, EventArgs e)
        {
            pbPDF.Visible = false;
            lblDomicilio.Visible = false;
            btnQutarPDF.Visible = false;
        }

        private void btnQuitarINE_Click(object sender, EventArgs e)
        {
            pbINE.Visible = false;
            btnQuitarINE.Visible = false;
        }

        private void ValidarCampos()
        {
            bool nombreValido = !string.IsNullOrWhiteSpace(txtFullName.Text);
            bool telefonoValido = !string.IsNullOrWhiteSpace(txtPhone.Text);
            bool correoValido = !string.IsNullOrWhiteSpace(txtMail.Text) && txtMail.Text.Contains("@");
            bool salarioValido = !string.IsNullOrWhiteSpace(txtSalary.Text) && decimal.TryParse(txtSalary.Text, out _);
            bool edadValida = dtpBornDate.Value <= DateTime.Now.AddYears(-18);
            bool pdfValido = pbPDF.Visible;
            bool ineValido = pbINE.Visible;

            btnSolicitud.Enabled = nombreValido && telefonoValido && correoValido && salarioValido && edadValida && pdfValido && ineValido;
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Nombre Completo")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.LightGray;
                lblLineU.ForeColor = Color.LightGray;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Nombre Completo";
                txtFullName.ForeColor = Color.Gainsboro;
                lblLineU.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Telefono")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.LightGray;
                lblLineU.ForeColor = Color.LightGray;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Telefono";
                txtPhone.ForeColor = Color.Gainsboro;
                lblLineU.ForeColor = Color.Gainsboro;
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if(txtMail.Text == "Correo")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.LightGray;
                lblLineU.ForeColor = Color.LightGray;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Correo";
                txtMail.ForeColor = Color.Gainsboro;
                lblLineU.ForeColor = Color.Gainsboro;
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (txtSalary.Text == "Salario")
            {
                txtSalary.Text = "";
                txtSalary.ForeColor = Color.LightGray;
                lblLineU.ForeColor = Color.LightGray;
                lblSalary.Visible = true;
            }
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (txtSalary.Text == "")
            {
                txtSalary.Text = "Salario";
                txtSalary.ForeColor = Color.Gainsboro;
                lblLineU.ForeColor = Color.Gainsboro;
                lblSalary.Visible = false;
            }
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            using (FormProcesando formProcesando = new FormProcesando())
            {
                formProcesando.ShowDialog();
            }

            if(MessageBox.Show("Solicitud aceptada. Usted tiene un crédito de $3000.", "Solicitud Aprobada", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                BackToMenu?.Invoke();
        }
    }
}
