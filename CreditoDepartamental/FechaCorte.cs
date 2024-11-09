using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreditoDepartamental
{
    public partial class FechaCorte : Form
    {
        public FechaCorte()
        {
            InitializeComponent();
            ConfigurarFechaCorte();
            ConfigurarAdvertencias();
        }

        private void ConfigurarFechaCorte()
        {
            lblFechaCorte.Text = "Fecha de Corte: " + new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30).ToShortDateString();
            lblFechaCorte.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            lblFechaCorte.AutoSize = false;
            lblFechaCorte.Size = new Size(400, 30);
            lblFechaCorte.Location = new Point(50, 20);

            int diasRestantes = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30) - DateTime.Now.Date).Days;
            lblDiasRestantes.Text = "Días restantes para la fecha de corte: " + diasRestantes;
            lblDiasRestantes.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            lblDiasRestantes.ForeColor = diasRestantes <= 5 ? Color.Red : Color.Green;
            lblDiasRestantes.AutoSize = false;
            lblDiasRestantes.Size = new Size(400, 30);
            lblDiasRestantes.Location = new Point(50, 60);

            this.Controls.Add(lblFechaCorte);
            this.Controls.Add(lblDiasRestantes);
        }

        private void ConfigurarAdvertencias()
        {
            panelAdvertencias.Size = new Size(500, 150);
            panelAdvertencias.Location = new Point(50, 120);
            panelAdvertencias.BackColor = Color.LightYellow;
            panelAdvertencias.BorderStyle = BorderStyle.FixedSingle;

            string[] advertencias = {
                "Recuerda realizar tu pago antes de la fecha de corte.",
                "Evita cargos adicionales por retraso.",
                "Para más información, contacta a servicio al cliente."
            };

            int yOffset = 10;
            foreach (string mensaje in advertencias)
            {
                lblAdvertencia.Text = mensaje;
                lblAdvertencia.Font = new Font("Century Gothic", 12, FontStyle.Italic);
                lblAdvertencia.ForeColor = Color.DarkRed;
                lblAdvertencia.AutoSize = false;
                lblAdvertencia.Size = new Size(480, 30);
                lblAdvertencia.Location = new Point(10, yOffset);
                yOffset += 40;

                panelAdvertencias.Controls.Add(lblAdvertencia);
            }

            this.Controls.Add(panelAdvertencias);
        }

    }
}
