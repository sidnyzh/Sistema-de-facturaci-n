namespace BillingSystem
{
    partial class FrmBilling
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
            txtStatusId = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtClientId = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtIdEmployee = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtTotalValue = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnExit = new Button();
            txtDiscount = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnUpdate = new Button();
            txtTaxNumber = new Krypton.Toolkit.KryptonMaskedTextBox();
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
            lblTitulo.Location = new Point(262, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 20);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "ACTUALIZACIÓN DE FACTURAS";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // gpbClientInfo
            // 
            gpbClientInfo.BackColor = Color.Transparent;
            gpbClientInfo.Controls.Add(txtStatusId);
            gpbClientInfo.Controls.Add(txtClientId);
            gpbClientInfo.Controls.Add(txtIdEmployee);
            gpbClientInfo.Controls.Add(txtTotalValue);
            gpbClientInfo.Controls.Add(btnExit);
            gpbClientInfo.Controls.Add(txtDiscount);
            gpbClientInfo.Controls.Add(btnUpdate);
            gpbClientInfo.Controls.Add(txtTaxNumber);
            gpbClientInfo.Location = new Point(127, 67);
            gpbClientInfo.Name = "gpbClientInfo";
            gpbClientInfo.Size = new Size(494, 403);
            gpbClientInfo.TabIndex = 16;
            gpbClientInfo.TabStop = false;
            gpbClientInfo.Enter += gpbClientInfo_Enter;
            // 
            // txtStatusId
            // 
            txtStatusId.BeepOnError = true;
            txtStatusId.Cursor = Cursors.IBeam;
            txtStatusId.Hint = "Id estado";
            txtStatusId.Location = new Point(70, 273);
            txtStatusId.Name = "txtStatusId";
            txtStatusId.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtStatusId.Size = new Size(183, 21);
            txtStatusId.StateActive.Content.Color1 = Color.DimGray;
            txtStatusId.StateCommon.Back.Color1 = SystemColors.Control;
            txtStatusId.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtStatusId.StateCommon.Content.Color1 = SystemColors.Control;
            txtStatusId.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatusId.TabIndex = 13;
            txtStatusId.MaskInputRejected += txtStatusId_MaskInputRejected;
            // 
            // txtClientId
            // 
            txtClientId.BeepOnError = true;
            txtClientId.Cursor = Cursors.IBeam;
            txtClientId.Hint = "Id Cliente";
            txtClientId.Location = new Point(70, 36);
            txtClientId.Name = "txtClientId";
            txtClientId.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtClientId.Size = new Size(183, 21);
            txtClientId.StateActive.Content.Color1 = Color.DimGray;
            txtClientId.StateCommon.Back.Color1 = SystemColors.Control;
            txtClientId.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtClientId.StateCommon.Content.Color1 = SystemColors.Control;
            txtClientId.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientId.TabIndex = 12;
            // 
            // txtIdEmployee
            // 
            txtIdEmployee.BeepOnError = true;
            txtIdEmployee.Cursor = Cursors.IBeam;
            txtIdEmployee.Hint = "Id Empleado";
            txtIdEmployee.Location = new Point(70, 81);
            txtIdEmployee.Name = "txtIdEmployee";
            txtIdEmployee.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtIdEmployee.Size = new Size(183, 21);
            txtIdEmployee.StateActive.Content.Color1 = Color.DimGray;
            txtIdEmployee.StateCommon.Back.Color1 = SystemColors.Control;
            txtIdEmployee.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtIdEmployee.StateCommon.Content.Color1 = SystemColors.Control;
            txtIdEmployee.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdEmployee.TabIndex = 11;
            // 
            // txtTotalValue
            // 
            txtTotalValue.BeepOnError = true;
            txtTotalValue.Cursor = Cursors.IBeam;
            txtTotalValue.Hint = "Valor total";
            txtTotalValue.Location = new Point(70, 222);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtTotalValue.Size = new Size(183, 21);
            txtTotalValue.StateActive.Content.Color1 = Color.DimGray;
            txtTotalValue.StateCommon.Back.Color1 = SystemColors.Control;
            txtTotalValue.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtTotalValue.StateCommon.Content.Color1 = SystemColors.Control;
            txtTotalValue.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalValue.TabIndex = 9;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(316, 347);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 10;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.BeepOnError = true;
            txtDiscount.Cursor = Cursors.IBeam;
            txtDiscount.Hint = "Número de descuento";
            txtDiscount.Location = new Point(70, 126);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtDiscount.Size = new Size(183, 21);
            txtDiscount.StateActive.Content.Color1 = Color.DimGray;
            txtDiscount.StateCommon.Back.Color1 = SystemColors.Control;
            txtDiscount.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtDiscount.StateCommon.Content.Color1 = SystemColors.Control;
            txtDiscount.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(69, 90, 100);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(61, 347);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.BeepOnError = true;
            txtTaxNumber.Cursor = Cursors.IBeam;
            txtTaxNumber.Hint = "Número de impuesto";
            txtTaxNumber.Location = new Point(70, 171);
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtTaxNumber.Size = new Size(183, 21);
            txtTaxNumber.StateActive.Content.Color1 = Color.DimGray;
            txtTaxNumber.StateCommon.Back.Color1 = SystemColors.Control;
            txtTaxNumber.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtTaxNumber.StateCommon.Content.Color1 = SystemColors.Control;
            txtTaxNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaxNumber.TabIndex = 4;
            // 
            // errorMessage
            // 
            errorMessage.ContainerControl = this;
            // 
            // FrmBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(lblTitulo);
            Controls.Add(gpbClientInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBilling";
            Text = "FrmBilling";
            Load += FrmBilling_Load;
            gpbClientInfo.ResumeLayout(false);
            gpbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gpbClientInfo;
        private Krypton.Toolkit.KryptonMaskedTextBox txtTotalValue;
        private Button btnExit;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDiscount;
        private Button btnUpdate;
        private Krypton.Toolkit.KryptonMaskedTextBox txtTaxNumber;
        private Krypton.Toolkit.KryptonMaskedTextBox txtStatusId;
        private Krypton.Toolkit.KryptonMaskedTextBox txtClientId;
        private Krypton.Toolkit.KryptonMaskedTextBox txtIdEmployee;
        private ErrorProvider errorMessage;
    }
}