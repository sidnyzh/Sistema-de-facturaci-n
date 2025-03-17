namespace BillingSystem
{
    partial class FrmClients 
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            gpbClientInfo = new GroupBox();
            txtAddress = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtName = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtPhone = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtEmail = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtDocument = new Krypton.Toolkit.KryptonMaskedTextBox();
            errorMessage = new ErrorProvider(components);
            gpbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessage).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(173, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(224, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ACTUALIZACIÓN DE CLIENTES";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(69, 90, 100);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(94, 299);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(296, 299);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 10;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // gpbClientInfo
            // 
            gpbClientInfo.BackColor = Color.Transparent;
            gpbClientInfo.Controls.Add(txtAddress);
            gpbClientInfo.Controls.Add(btnExit);
            gpbClientInfo.Controls.Add(txtName);
            gpbClientInfo.Controls.Add(txtPhone);
            gpbClientInfo.Controls.Add(btnUpdate);
            gpbClientInfo.Controls.Add(txtEmail);
            gpbClientInfo.Controls.Add(txtDocument);
            gpbClientInfo.Location = new Point(38, 92);
            gpbClientInfo.Name = "gpbClientInfo";
            gpbClientInfo.Size = new Size(494, 389);
            gpbClientInfo.TabIndex = 14;
            gpbClientInfo.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.BeepOnError = true;
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Hint = "Dirección";
            txtAddress.Location = new Point(72, 117);
            txtAddress.Name = "txtAddress";
            txtAddress.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtAddress.Size = new Size(360, 21);
            txtAddress.StateActive.Content.Color1 = Color.DimGray;
            txtAddress.StateCommon.Back.Color1 = SystemColors.Control;
            txtAddress.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtAddress.StateCommon.Content.Color1 = SystemColors.Control;
            txtAddress.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.BeepOnError = true;
            txtName.Cursor = Cursors.IBeam;
            txtName.Hint = "Nombre del cliente";
            txtName.Location = new Point(72, 22);
            txtName.Name = "txtName";
            txtName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtName.Size = new Size(360, 21);
            txtName.StateActive.Content.Color1 = Color.DimGray;
            txtName.StateCommon.Back.Color1 = SystemColors.Control;
            txtName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtName.StateCommon.Content.Color1 = SystemColors.Control;
            txtName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.BeepOnError = true;
            txtPhone.Cursor = Cursors.IBeam;
            txtPhone.Hint = "Teléfono";
            txtPhone.Location = new Point(72, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtPhone.Size = new Size(151, 21);
            txtPhone.StateActive.Content.Color1 = Color.DimGray;
            txtPhone.StateCommon.Back.Color1 = SystemColors.Control;
            txtPhone.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtPhone.StateCommon.Content.Color1 = SystemColors.Control;
            txtPhone.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BeepOnError = true;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Hint = "Email";
            txtEmail.Location = new Point(72, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtEmail.Size = new Size(360, 21);
            txtEmail.StateActive.Content.Color1 = Color.DimGray;
            txtEmail.StateCommon.Back.Color1 = SystemColors.Control;
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtEmail.StateCommon.Content.Color1 = Color.DimGray;
            txtEmail.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.TabIndex = 5;
            txtEmail.ToolTipValues.ImageTransparentColor = Color.Transparent;
            txtEmail.ToolTipValues.ToolTipShadow = false;
            txtEmail.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            // 
            // txtDocument
            // 
            txtDocument.BeepOnError = true;
            txtDocument.Cursor = Cursors.IBeam;
            txtDocument.Hint = "Documento";
            txtDocument.Location = new Point(72, 67);
            txtDocument.Name = "txtDocument";
            txtDocument.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtDocument.Size = new Size(183, 21);
            txtDocument.StateActive.Content.Color1 = Color.DimGray;
            txtDocument.StateCommon.Back.Color1 = SystemColors.Control;
            txtDocument.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtDocument.StateCommon.Content.Color1 = SystemColors.Control;
            txtDocument.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocument.TabIndex = 4;
            // 
            // errorMessage
            // 
            errorMessage.ContainerControl = this;
            // 
            // FrmUpdateClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 510);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(gpbClientInfo);
            Name = "FrmUpdateClients";
            ShowInTaskbar = false;
            Load += FrmClients_Load;
            gpbClientInfo.ResumeLayout(false);
            gpbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnUpdate;
        private Button btnExit;
        private GroupBox gpbClientInfo;
        private Krypton.Toolkit.KryptonMaskedTextBox txtName;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDocument;
        private Krypton.Toolkit.KryptonMaskedTextBox txtPhone;
        private Krypton.Toolkit.KryptonMaskedTextBox txtAddress;
        private Krypton.Toolkit.KryptonMaskedTextBox txtEmail;
        private ErrorProvider errorMessage;
    }
}