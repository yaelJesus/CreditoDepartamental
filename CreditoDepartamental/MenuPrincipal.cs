using CreditoDepartamental.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditoDepartamental
{
    public partial class MenuPrincipal : Form
    {
        #region Importaciones
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region Variables
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        private int lx, ly;
        private int sw, sh;
        #endregion

        public MenuPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Controles de Sistema
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Metodos
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
                                                                                     
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;

                if (formulario is Home home)
                {
                    home.CambiarFormularioEvent += CambiarFormularioHandler;
                }
                else if (formulario is ApplyForCredit apply)
                {
                    apply.BackToMenu += BackToMenu;
                }

                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void BackToMenu()
        {
            hideSubMenu();
            btnSolicitud.Visible = false;
            btnAumentar.Visible = true;
            AbrirFormulario<Home>();
        }

        private void CambiarFormularioHandler(int formIndex)
        {
            switch (formIndex)
            {
                default:
                    AbrirFormulario<Dama>();
                    break;
                case 1:
                    AbrirFormulario<Deportes>();
                    break;
                case 2:
                    AbrirFormulario<Electronicos>();
                    break;
            }
        }

        private void CustomizeDesing()
        {
            PanelCategoriaSubMenu.Visible = false;
            PanelCreditoSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            PanelCategoriaSubMenu.Visible = false;
            PanelCreditoSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region SubMenus
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelCategoriaSubMenu);
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelCreditoSubMenu);
        }
        #endregion

        #region Navegacion
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario<Home>();
        }

        private void btnDamas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Dama>();
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Deportes>();
        }

        private void btnElectronicos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Electronicos>();
        }

        private void btnVencidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PagosVencidos>();
        }

        private void btnProximos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProximosPagos>();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CreditIncrease>();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FechaCorte>();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Home>();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ApplyForCredit>();
        }
        #endregion
    }
}
