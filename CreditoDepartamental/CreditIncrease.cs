using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditoDepartamental
{
    public partial class CreditIncrease : Form
    {
        public CreditIncrease()
        {
            InitializeComponent();
            txtDireccion.TextChanged += (s, e) => ValidarCampos();
            txtSalary.TextChanged += (s, e) => ValidarCampos();
            pbPDF.VisibleChanged += (s, e) => ValidarCampos();
            pbINE.VisibleChanged += (s, e) => ValidarCampos();
            btnSolicitud.Enabled = false;
        }

        private void ValidarCampos()
        {
            bool direccionValida = !string.IsNullOrWhiteSpace(txtDireccion.Text);
            bool salarioValido = !string.IsNullOrWhiteSpace(txtSalary.Text) ;
            bool pdfValido = pbPDF.Visible;
            bool ineValido = pbINE.Visible;

            btnSolicitud.Enabled = direccionValida && salarioValido &&  pdfValido && ineValido;
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            using (FormProcesando formProcesando = new FormProcesando())
            {
                formProcesando.ShowDialog();
            }

            MessageBox.Show("Solicitud aceptada. Usted tiene ahora un crédito de $3000.", "Solicitud Aprobada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (txtSalary.Text == "Salario Mensual Neto")
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
                txtSalary.Text = "Salario Mensual Neto";
                txtSalary.ForeColor = Color.Gainsboro;
                lblLineU.ForeColor = Color.Gainsboro;
                lblSalary.Visible = false;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.LightGray;
                lblLineU.ForeColor = Color.LightGray;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.Gainsboro;
                lblLineU.ForeColor = Color.Gainsboro;
                lblSalary.Visible = false;
            }

        }
    }
}
