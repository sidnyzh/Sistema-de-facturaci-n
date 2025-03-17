using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BillingSystem
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            // Asignar eventos a los botones
            btnPrincipal.Click += (s, ev) => { TbpMenu.SelectedTab = Principal; HighlightButton(btnPrincipal); };
            btnTables.Click += (s, ev) => { TbpMenu.SelectedTab = Tablas; HighlightButton(btnTables); };
            btnBilling.Click += (s, ev) => { TbpMenu.SelectedTab = Facturación; HighlightButton(btnBilling); };
            btnSecurity.Click += (s, ev) => { TbpMenu.SelectedTab = Seguridad; HighlightButton(btnSecurity); };
            btnAbout.Click += (s, ev) => { TbpMenu.SelectedTab = Acerca; HighlightButton(btnAbout); };

            HighlightButton(btnPrincipal);
        }

        private void HighlightButton(Button activeButton)
        {
            foreach (Control ctrl in PanelTop.Controls)
            {
                if (ctrl is Button btn)
                    btn.BackColor = Color.LightGray; // Color normal
            }
            activeButton.BackColor = Color.Gray; // Resaltar el botón activo
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void PnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClientsList frmClientsList = new FrmClientsList();
            OpenForm(frmClientsList);
        }

        private void OpenForm(Form formHijo)
        {
            if (this.pnlContainer.Controls.Count > 0)
                this.pnlContainer.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.pnlContainer.Controls.Add(formHijo);
            this.pnlContainer.Tag = formHijo;

            formHijo.Show();
        }

        private void Tablas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProductsList frmProductsList = new FrmProductsList();
            OpenForm(frmProductsList);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategoriesList frmCategoriesList = new FrmCategoriesList();
            OpenForm(frmCategoriesList);
        }
    }
}
