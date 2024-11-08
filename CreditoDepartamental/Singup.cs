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

namespace CreditoDepartamental.Properties
{
    public partial class Singup : Form
    {
        public Singup()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
            txtCPass.UseSystemPasswordChar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtMail.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtCPass.Text))
            {
                if (IsMail(txtMail.Text))
                {
                    if (txtPass.TextLength <= 5)
                    {
                        MessageBox.Show("Las contraseñas debe tener mas de 6 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtCPass.Text == txtPass.Text)
                    {
                        MessageBox.Show("Registro Exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("El correo no posee la estructura adecuada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Llene todos los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool IsMail(string mail)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isEmail = Regex.IsMatch(mail, pattern);
            return isEmail;
        }
    }
}
