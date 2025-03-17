namespace BillingSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTittle = new Krypton.Toolkit.KryptonLabel();
            kryptonFontDialog1 = new Krypton.Toolkit.KryptonFontDialog();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            checkBox1 = new CheckBox();
            btnLogin = new Button();
            lnkForgotPassword = new Krypton.Toolkit.KryptonLinkLabel();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTittle
            // 
            lblTittle.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            lblTittle.Location = new Point(130, 33);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(144, 29);
            lblTittle.TabIndex = 0;
            lblTittle.Values.Text = "Validar usuario";
            lblTittle.Click += kryptonLabel1_Click;
            // 
            // kryptonFontDialog1
            // 
            kryptonFontDialog1.DisplayExtendedColorsButton = false;
            kryptonFontDialog1.Icon = (Icon)resources.GetObject("kryptonFontDialog1.Icon");
            kryptonFontDialog1.Title = null;
            // 
            // txtUsername
            // 
            txtUsername.AccessibleDescription = "Ingrese su usuario";
            txtUsername.CueHint.CueHintText = "Usuario";
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Location = new Point(100, 284);
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.CueHint.CueHintText = "Contraseña";
            txtPassword.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Location = new Point(100, 345);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AccessibleDescription = "Mostrar Contraseña";
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(130, 395);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 128, 255);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(100, 446);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.Location = new Point(130, 539);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(136, 20);
            lnkForgotPassword.TabIndex = 8;
            lnkForgotPassword.Values.Text = "¿Olvidó su contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.elevator_user_man_ui_round_login_512;
            pictureBox1.Location = new Point(122, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGray;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(100, 488);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(400, 600);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            Controls.Add(lnkForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblTittle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTittle;
        private Krypton.Toolkit.KryptonFontDialog kryptonFontDialog1;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private CheckBox checkBox1;
        private Button btnLogin;
        private Krypton.Toolkit.KryptonLinkLabel lnkForgotPassword;
        private PictureBox pictureBox1;
        private Button btnCancel;
    }
}
