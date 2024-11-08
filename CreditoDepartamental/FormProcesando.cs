using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreditoDepartamental
{
    public partial class FormProcesando : Form
    {
        private Timer timer;

        public FormProcesando()
        {
            InitializeComponent();

            customProgressBar1.Minimum = 0;
            customProgressBar1.Maximum = 100;
            customProgressBar1.Value = 0;

            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (customProgressBar1.Value < customProgressBar1.Maximum)
            {
                customProgressBar1.Value += 1;
            }
            else
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
