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
    public partial class PagosVencidos : Form
    {
        public PagosVencidos()
        {
            InitializeComponent();
        }

        private void PagosVencidos_Load(object sender, EventArgs e)
        {
            CargarPagosVencidos();
        }

        private void CargarPagosVencidos()
        {
            dgvPagosVencidos.Rows.Clear();

            var pagos = new List<dynamic>
            {
                new { NumeroPago = 1, MontoVencido = 1500.0, FechaVencimiento = DateTime.Today.AddDays(-10) },
                new { NumeroPago = 2, MontoVencido = 2000.0, FechaVencimiento = DateTime.Today.AddDays(-15) },
                new { NumeroPago = 3, MontoVencido = 500.0, FechaVencimiento = DateTime.Today.AddDays(-5) },
            };

            foreach (var pago in pagos)
            {
                int diasRetraso = (DateTime.Today - pago.FechaVencimiento).Days;
                double montoConMulta = pago.MontoVencido * 1.05;

                dgvPagosVencidos.Rows.Add(
                    pago.NumeroPago,
                    pago.MontoVencido,
                    pago.FechaVencimiento.ToShortDateString(),
                    diasRetraso,
                    montoConMulta,
                    "Pagar ahora");
            }
        }

        private void dgvPagosVencidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPagosVencidos.Columns["Pagar"].Index && e.RowIndex >= 0)
            {
                var numeroPago = dgvPagosVencidos.Rows[e.RowIndex].Cells["NumeroPago"].Value;
                MessageBox.Show($"El pago número {numeroPago} ha sido procesado.", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvPagosVencidos.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
