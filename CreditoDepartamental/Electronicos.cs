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
    public partial class Electronicos : Form
    {
        public Electronicos()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Task.Delay(rnd.Next(10000));
            MessageBox.Show("Tu compra se proceso correctamente.", "Compra Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
