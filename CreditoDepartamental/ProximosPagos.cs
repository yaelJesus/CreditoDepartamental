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
    public partial class ProximosPagos : Form
    {
        public ProximosPagos()
        {
            InitializeComponent();
        }

        private void ProximosPagos_Load(object sender, EventArgs e)
        {
            CargarPagosProximos();
        }

        private void CargarPagosProximos()
        {
            dgvPagosProximos.Rows.Clear();

            var pagosProximos = new List<dynamic>
            {
                new { NumeroPago = 4, Monto = 1200.0, FechaVencimiento = DateTime.Today.AddDays(5) },
                new { NumeroPago = 5, Monto = 1800.0, FechaVencimiento = DateTime.Today.AddDays(10) },
                new { NumeroPago = 6, Monto = 2500.0, FechaVencimiento = DateTime.Today.AddDays(15) },
            };

            foreach (var pago in pagosProximos)
            {
                int diasRestantes = (pago.FechaVencimiento - DateTime.Today).Days;

                dgvPagosProximos.Rows.Add(
                    pago.NumeroPago,
                    pago.Monto,
                    pago.FechaVencimiento.ToShortDateString(),
                    diasRestantes);
            }
        }

        private void dgvPagosProximos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int diasRestantes = Convert.ToInt32(dgvPagosProximos.Rows[e.RowIndex].Cells["DiasRestantes"].Value);

            if (diasRestantes < 5)
                dgvPagosProximos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            else if (diasRestantes <= 10)
                dgvPagosProximos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            else
                dgvPagosProximos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
        }
    }
}
