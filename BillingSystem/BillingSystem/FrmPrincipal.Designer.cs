namespace BillingSystem
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnlMenu = new Panel();
            TbpMenu = new TabControl();
            Principal = new TabPage();
            plnCover = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            Tablas = new TabPage();
            btnEmployees = new Button();
            btnBills = new Button();
            button2 = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnClients = new Button();
            pictureBox3 = new PictureBox();
            Facturación = new TabPage();
            pictureBox4 = new PictureBox();
            Seguridad = new TabPage();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            Acerca = new TabPage();
            button4 = new Button();
            pictureBox5 = new PictureBox();
            PnlPrincipal = new Panel();
            pnlContainer = new Panel();
            PanelTop = new Krypton.Toolkit.KryptonPanel();
            btnSecurity = new Button();
            btnTables = new Button();
            btnAbout = new Button();
            btnBilling = new Button();
            btnPrincipal = new Button();
            PnlMenu.SuspendLayout();
            TbpMenu.SuspendLayout();
            Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            PnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelTop).BeginInit();
            PanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMenu
            // 
            PnlMenu.Controls.Add(TbpMenu);
            PnlMenu.Dock = DockStyle.Left;
            PnlMenu.Location = new Point(0, 0);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(200, 623);
            PnlMenu.TabIndex = 0;
            // 
            // TbpMenu
            // 
            TbpMenu.Controls.Add(Principal);
            TbpMenu.Controls.Add(Tablas);
            TbpMenu.Controls.Add(Facturación);
            TbpMenu.Controls.Add(Seguridad);
            TbpMenu.Controls.Add(Acerca);
            TbpMenu.Dock = DockStyle.Fill;
            TbpMenu.Location = new Point(0, 0);
            TbpMenu.Name = "TbpMenu";
            TbpMenu.SelectedIndex = 0;
            TbpMenu.Size = new Size(200, 623);
            TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            Principal.BackColor = Color.White;
            Principal.BackgroundImageLayout = ImageLayout.Center;
            Principal.Controls.Add(pictureBox2);
            Principal.Controls.Add(button1);
            Principal.Location = new Point(4, 30);
            Principal.Name = "Principal";
            Principal.Padding = new Padding(3);
            Principal.Size = new Size(192, 589);
            Principal.TabIndex = 0;
            Principal.Text = "Principal";
            // 
            // plnCover
            // 
            plnCover.BackColor = SystemColors.ButtonHighlight;
            plnCover.Location = new Point(0, 64);
            plnCover.Name = "plnCover";
            plnCover.Size = new Size(193, 31);
            plnCover.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(-3, 148);
            button1.Name = "button1";
            button1.Size = new Size(196, 36);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnExit_Click;
            // 
            // Tablas
            // 
            Tablas.BackColor = Color.White;
            Tablas.Controls.Add(btnEmployees);
            Tablas.Controls.Add(btnBills);
            Tablas.Controls.Add(button2);
            Tablas.Controls.Add(btnProducts);
            Tablas.Controls.Add(btnCategories);
            Tablas.Controls.Add(btnClients);
            Tablas.Controls.Add(pictureBox3);
            Tablas.ForeColor = SystemColors.ButtonFace;
            Tablas.Location = new Point(4, 30);
            Tablas.Name = "Tablas";
            Tablas.Padding = new Padding(3);
            Tablas.Size = new Size(192, 589);
            Tablas.TabIndex = 1;
            Tablas.Text = "Admin Tablas";
            Tablas.Click += Tablas_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = SystemColors.ButtonShadow;
            btnEmployees.FlatAppearance.BorderColor = Color.White;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatAppearance.MouseDownBackColor = Color.White;
            btnEmployees.FlatAppearance.MouseOverBackColor = Color.Black;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = SystemColors.Window;
            btnEmployees.Image = Properties.Resources.clients_icon;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(1, 307);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(191, 36);
            btnEmployees.TabIndex = 9;
            btnEmployees.Text = "Empleados";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnBills
            // 
            btnBills.BackColor = SystemColors.ButtonShadow;
            btnBills.FlatAppearance.BorderColor = Color.White;
            btnBills.FlatAppearance.BorderSize = 0;
            btnBills.FlatAppearance.MouseDownBackColor = Color.White;
            btnBills.FlatAppearance.MouseOverBackColor = Color.Black;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBills.ForeColor = SystemColors.Window;
            btnBills.Image = Properties.Resources.clients_icon;
            btnBills.ImageAlign = ContentAlignment.MiddleLeft;
            btnBills.Location = new Point(1, 265);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(191, 36);
            btnBills.TabIndex = 8;
            btnBills.Text = "Facturas";
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(1, 442);
            button2.Name = "button2";
            button2.Size = new Size(190, 36);
            button2.TabIndex = 7;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ButtonShadow;
            btnProducts.FlatAppearance.BorderColor = Color.White;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.MouseDownBackColor = Color.White;
            btnProducts.FlatAppearance.MouseOverBackColor = Color.Black;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = SystemColors.Window;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(-4, 181);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(193, 36);
            btnProducts.TabIndex = 6;
            btnProducts.Text = "Productos";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = SystemColors.ButtonShadow;
            btnCategories.FlatAppearance.BorderColor = Color.White;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.White;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = SystemColors.Window;
            btnCategories.Image = (Image)resources.GetObject("btnCategories.Image");
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(-3, 223);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(192, 36);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "Categorias";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnClients
            // 
            btnClients.BackColor = SystemColors.ButtonShadow;
            btnClients.FlatAppearance.BorderColor = Color.White;
            btnClients.FlatAppearance.BorderSize = 0;
            btnClients.FlatAppearance.MouseDownBackColor = Color.White;
            btnClients.FlatAppearance.MouseOverBackColor = Color.Black;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClients.ForeColor = SystemColors.Window;
            btnClients.Image = Properties.Resources.clients_icon;
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.Location = new Point(0, 139);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(191, 36);
            btnClients.TabIndex = 4;
            btnClients.Text = "Clientes";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // Facturación
            // 
            Facturación.BackColor = Color.White;
            Facturación.Controls.Add(pictureBox4);
            Facturación.Location = new Point(4, 30);
            Facturación.Name = "Facturación";
            Facturación.Size = new Size(192, 589);
            Facturación.TabIndex = 2;
            Facturación.Text = "Facturación";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-1, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(196, 146);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Seguridad
            // 
            Seguridad.BackColor = Color.White;
            Seguridad.Controls.Add(button3);
            Seguridad.Controls.Add(pictureBox1);
            Seguridad.Location = new Point(4, 30);
            Seguridad.Name = "Seguridad";
            Seguridad.Size = new Size(192, 589);
            Seguridad.TabIndex = 3;
            Seguridad.Text = "Seguridad";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(0, 161);
            button3.Name = "button3";
            button3.Size = new Size(190, 36);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Acerca
            // 
            Acerca.BackColor = Color.White;
            Acerca.Controls.Add(button4);
            Acerca.Controls.Add(pictureBox5);
            Acerca.ForeColor = SystemColors.ButtonHighlight;
            Acerca.Location = new Point(4, 30);
            Acerca.Name = "Acerca";
            Acerca.Size = new Size(192, 589);
            Acerca.TabIndex = 4;
            Acerca.Text = "Acerca de..";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonShadow;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(0, 171);
            button4.Name = "button4";
            button4.Size = new Size(192, 36);
            button4.TabIndex = 4;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(192, 142);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // PnlPrincipal
            // 
            PnlPrincipal.Controls.Add(pnlContainer);
            PnlPrincipal.Controls.Add(PnlMenu);
            PnlPrincipal.Font = new Font("Segoe UI", 12F);
            PnlPrincipal.Location = new Point(-4, 64);
            PnlPrincipal.Name = "PnlPrincipal";
            PnlPrincipal.Size = new Size(1189, 623);
            PnlPrincipal.TabIndex = 0;
            PnlPrincipal.Paint += PnlPrincipal_Paint;
            // 
            // pnlContainer
            // 
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(200, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(989, 623);
            pnlContainer.TabIndex = 1;
            pnlContainer.Paint += panel1_Paint_1;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(btnSecurity);
            PanelTop.Controls.Add(btnTables);
            PanelTop.Controls.Add(btnAbout);
            PanelTop.Controls.Add(btnBilling);
            PanelTop.Controls.Add(btnPrincipal);
            PanelTop.Location = new Point(241, 26);
            PanelTop.Name = "PanelTop";
            PanelTop.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.TabLowProfile;
            PanelTop.Size = new Size(844, 41);
            PanelTop.TabIndex = 1;
            // 
            // btnSecurity
            // 
            btnSecurity.BackColor = Color.Transparent;
            btnSecurity.BackgroundImageLayout = ImageLayout.None;
            btnSecurity.Cursor = Cursors.Hand;
            btnSecurity.FlatAppearance.BorderSize = 0;
            btnSecurity.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSecurity.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSecurity.FlatStyle = FlatStyle.Flat;
            btnSecurity.Font = new Font("Segoe UI", 12F);
            btnSecurity.ForeColor = SystemColors.HighlightText;
            btnSecurity.ImageAlign = ContentAlignment.BottomCenter;
            btnSecurity.Location = new Point(551, 0);
            btnSecurity.Margin = new Padding(0);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(148, 35);
            btnSecurity.TabIndex = 4;
            btnSecurity.Text = "Seguridad";
            btnSecurity.UseVisualStyleBackColor = false;
            // 
            // btnTables
            // 
            btnTables.BackColor = Color.Transparent;
            btnTables.BackgroundImageLayout = ImageLayout.None;
            btnTables.Cursor = Cursors.Hand;
            btnTables.FlatAppearance.BorderSize = 0;
            btnTables.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTables.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTables.FlatStyle = FlatStyle.Flat;
            btnTables.Font = new Font("Segoe UI", 12F);
            btnTables.ForeColor = SystemColors.HighlightText;
            btnTables.ImageAlign = ContentAlignment.BottomCenter;
            btnTables.Location = new Point(238, 0);
            btnTables.Margin = new Padding(0);
            btnTables.Name = "btnTables";
            btnTables.Size = new Size(148, 35);
            btnTables.TabIndex = 2;
            btnTables.Text = "Tablas";
            btnTables.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.BackgroundImageLayout = ImageLayout.None;
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 12F);
            btnAbout.ForeColor = SystemColors.HighlightText;
            btnAbout.ImageAlign = ContentAlignment.BottomCenter;
            btnAbout.Location = new Point(704, 0);
            btnAbout.Margin = new Padding(0);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(148, 35);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "Acerca de..";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.Transparent;
            btnBilling.BackgroundImageLayout = ImageLayout.None;
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBilling.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 12F);
            btnBilling.ForeColor = SystemColors.HighlightText;
            btnBilling.ImageAlign = ContentAlignment.BottomCenter;
            btnBilling.Location = new Point(393, 0);
            btnBilling.Margin = new Padding(0);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(148, 35);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Facturación";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += button1_Click;
            // 
            // btnPrincipal
            // 
            btnPrincipal.BackColor = Color.Transparent;
            btnPrincipal.BackgroundImageLayout = ImageLayout.None;
            btnPrincipal.Cursor = Cursors.Hand;
            btnPrincipal.FlatAppearance.BorderSize = 0;
            btnPrincipal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrincipal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPrincipal.FlatStyle = FlatStyle.Flat;
            btnPrincipal.Font = new Font("Segoe UI", 12F);
            btnPrincipal.ForeColor = SystemColors.HighlightText;
            btnPrincipal.ImageAlign = ContentAlignment.BottomCenter;
            btnPrincipal.Location = new Point(85, 0);
            btnPrincipal.Margin = new Padding(0);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(148, 35);
            btnPrincipal.TabIndex = 1;
            btnPrincipal.Text = "Principal";
            btnPrincipal.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(plnCover);
            Controls.Add(PanelTop);
            Controls.Add(PnlPrincipal);
            Name = "FrmPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE FACTURACIÓN";
            Load += FrmPrincipal_Load_1;
            PnlMenu.ResumeLayout(false);
            TbpMenu.ResumeLayout(false);
            Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Facturación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            PnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelTop).EndInit();
            PanelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMenu;
        private TabControl TbpMenu;
        private TabPage Tablas;
        private TabPage Facturación;
        private TabPage Seguridad;
        private TabPage Acerca;
        private Panel PnlPrincipal;
        private Krypton.Toolkit.KryptonPanel PanelTop;
        private Button btnPrincipal;
        private Button btnSecurity;
        private Button btnTables;
        private Button btnAbout;
        private Button btnBilling;
        private PictureBox pictureBox1;
        private Button btnExit;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnClients;
        private Panel pnlContainer;
        private TabPage Principal;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel plnCover;
        private PictureBox pictureBox5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnEmployees;
        private Button btnBills;
    }
}