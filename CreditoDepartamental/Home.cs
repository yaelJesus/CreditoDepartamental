﻿using CreditoDepartamental.Properties;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public event Action<int> CambiarFormularioEvent;

        #region Dama
        private void panel2_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(0);
        }
        #endregion
        #region Deportes
        private void panel1_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(1);
        }
        #endregion
        #region Electronicos
        private void panel3_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(2);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(2);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(2);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(2);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(2);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CambiarFormularioEvent?.Invoke(2);
        }
        #endregion
    }
}
