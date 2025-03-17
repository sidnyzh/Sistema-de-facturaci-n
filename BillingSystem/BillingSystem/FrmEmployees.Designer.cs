namespace BillingSystem
{
    partial class FrmEmployees
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
            gpbClientInfo = new GroupBox();
            txtIngreso = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtRetiro = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtAditionalData = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtRol = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtAddress = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnExit = new Button();
            txtName = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtPhone = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnUpdate = new Button();
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
            lblTitulo.Location = new Point(287, 76);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 20);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "ACTUALIZACIÓN DE EMPLEADOS";
            // 
            // gpbClientInfo
            // 
            gpbClientInfo.BackColor = Color.Transparent;
            gpbClientInfo.Controls.Add(txtIngreso);
            gpbClientInfo.Controls.Add(txtRetiro);
            gpbClientInfo.Controls.Add(txtAditionalData);
            gpbClientInfo.Controls.Add(txtRol);
            gpbClientInfo.Controls.Add(txtAddress);
            gpbClientInfo.Controls.Add(btnExit);
            gpbClientInfo.Controls.Add(txtName);
            gpbClientInfo.Controls.Add(txtPhone);
            gpbClientInfo.Controls.Add(btnUpdate);
            gpbClientInfo.Controls.Add(txtEmail);
            gpbClientInfo.Controls.Add(txtDocument);
            gpbClientInfo.Location = new Point(161, 99);
            gpbClientInfo.Name = "gpbClientInfo";
            gpbClientInfo.Size = new Size(494, 543);
            gpbClientInfo.TabIndex = 16;
            gpbClientInfo.TabStop = false;
            // 
            // txtIngreso
            // 
            txtIngreso.BeepOnError = true;
            txtIngreso.Cursor = Cursors.IBeam;
            txtIngreso.Hint = "Fecha ingreso";
            txtIngreso.Location = new Point(72, 306);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtIngreso.Size = new Size(360, 21);
            txtIngreso.StateActive.Content.Color1 = Color.DimGray;
            txtIngreso.StateCommon.Back.Color1 = SystemColors.Control;
            txtIngreso.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtIngreso.StateCommon.Content.Color1 = SystemColors.Control;
            txtIngreso.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIngreso.TabIndex = 14;
            // 
            // txtRetiro
            // 
            txtRetiro.BeepOnError = true;
            txtRetiro.Cursor = Cursors.IBeam;
            txtRetiro.Hint = "Fecha de retiro";
            txtRetiro.Location = new Point(72, 354);
            txtRetiro.Name = "txtRetiro";
            txtRetiro.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtRetiro.Size = new Size(151, 21);
            txtRetiro.StateActive.Content.Color1 = Color.DimGray;
            txtRetiro.StateCommon.Back.Color1 = SystemColors.Control;
            txtRetiro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtRetiro.StateCommon.Content.Color1 = SystemColors.Control;
            txtRetiro.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRetiro.TabIndex = 13;
            // 
            // txtAditionalData
            // 
            txtAditionalData.BeepOnError = true;
            txtAditionalData.Cursor = Cursors.IBeam;
            txtAditionalData.Hint = "Datos adicionales";
            txtAditionalData.Location = new Point(72, 404);
            txtAditionalData.Name = "txtAditionalData";
            txtAditionalData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtAditionalData.Size = new Size(360, 21);
            txtAditionalData.StateActive.Content.Color1 = Color.DimGray;
            txtAditionalData.StateCommon.Back.Color1 = SystemColors.Control;
            txtAditionalData.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtAditionalData.StateCommon.Content.Color1 = Color.DimGray;
            txtAditionalData.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAditionalData.TabIndex = 12;
            txtAditionalData.ToolTipValues.ImageTransparentColor = Color.Transparent;
            txtAditionalData.ToolTipValues.ToolTipShadow = false;
            txtAditionalData.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            // 
            // txtRol
            // 
            txtRol.BeepOnError = true;
            txtRol.Cursor = Cursors.IBeam;
            txtRol.Hint = "Rol";
            txtRol.Location = new Point(72, 256);
            txtRol.Name = "txtRol";
            txtRol.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtRol.Size = new Size(183, 21);
            txtRol.StateActive.Content.Color1 = Color.DimGray;
            txtRol.StateCommon.Back.Color1 = SystemColors.Control;
            txtRol.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtRol.StateCommon.Content.Color1 = SystemColors.Control;
            txtRol.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRol.TabIndex = 11;
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
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(322, 472);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 10;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.BeepOnError = true;
            txtName.Cursor = Cursors.IBeam;
            txtName.Hint = "Nombre del empleado";
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
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(69, 90, 100);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(55, 472);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 747);
            Controls.Add(lblTitulo);
            Controls.Add(gpbClientInfo);
            Name = "FrmEmployees";
            Load += FrmEmployees_Load;
            gpbClientInfo.ResumeLayout(false);
            gpbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gpbClientInfo;
        private Krypton.Toolkit.KryptonMaskedTextBox txtIngreso;
        private Krypton.Toolkit.KryptonMaskedTextBox txtRetiro;
        private Krypton.Toolkit.KryptonMaskedTextBox txtAditionalData;
        private Krypton.Toolkit.KryptonMaskedTextBox txtRol;
        private Krypton.Toolkit.KryptonMaskedTextBox txtAddress;
        private Button btnExit;
        private Krypton.Toolkit.KryptonMaskedTextBox txtName;
        private Krypton.Toolkit.KryptonMaskedTextBox txtPhone;
        private Button btnUpdate;
        private Krypton.Toolkit.KryptonMaskedTextBox txtEmail;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDocument;
        private ErrorProvider errorMessage;
    }
}