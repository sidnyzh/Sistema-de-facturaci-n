namespace BillingSystem
{
    partial class FrmProducts
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
            cmbCategories = new Krypton.Toolkit.KryptonComboBox();
            txtStock = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtBuyingPrice = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnExit = new Button();
            txtName = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtSellingPrice = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnUpdate = new Button();
            txtDetail = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtCode = new Krypton.Toolkit.KryptonMaskedTextBox();
            errorMessage = new ErrorProvider(components);
            gpbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorMessage).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(286, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 20);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "ACTUALIZACIÓN DE PRODUCTOS";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // gpbClientInfo
            // 
            gpbClientInfo.BackColor = Color.Transparent;
            gpbClientInfo.Controls.Add(cmbCategories);
            gpbClientInfo.Controls.Add(txtStock);
            gpbClientInfo.Controls.Add(txtBuyingPrice);
            gpbClientInfo.Controls.Add(btnExit);
            gpbClientInfo.Controls.Add(txtName);
            gpbClientInfo.Controls.Add(txtSellingPrice);
            gpbClientInfo.Controls.Add(btnUpdate);
            gpbClientInfo.Controls.Add(txtDetail);
            gpbClientInfo.Controls.Add(txtCode);
            gpbClientInfo.Location = new Point(153, 54);
            gpbClientInfo.Name = "gpbClientInfo";
            gpbClientInfo.Size = new Size(494, 447);
            gpbClientInfo.TabIndex = 16;
            gpbClientInfo.TabStop = false;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownWidth = 183;
            cmbCategories.Items.AddRange(new object[] { CategoriesEnum.Tecnología, CategoriesEnum.Alimentos, CategoriesEnum.Carnes });
            cmbCategories.Location = new Point(72, 215);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(183, 22);
            cmbCategories.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbCategories.TabIndex = 17;
            cmbCategories.Text = "Tecnología";
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // txtStock
            // 
            txtStock.BeepOnError = true;
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Hint = "En Stock";
            txtStock.Location = new Point(72, 323);
            txtStock.Name = "txtStock";
            txtStock.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtStock.Size = new Size(79, 21);
            txtStock.StateActive.Content.Color1 = Color.DimGray;
            txtStock.StateCommon.Back.Color1 = SystemColors.Control;
            txtStock.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtStock.StateCommon.Content.Color1 = Color.DimGray;
            txtStock.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.TabIndex = 11;
            txtStock.ToolTipValues.ImageTransparentColor = Color.Transparent;
            txtStock.ToolTipValues.ToolTipShadow = false;
            txtStock.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            txtStock.MaskInputRejected += kryptonMaskedTextBox1_MaskInputRejected;
            // 
            // txtBuyingPrice
            // 
            txtBuyingPrice.BeepOnError = true;
            txtBuyingPrice.Cursor = Cursors.IBeam;
            txtBuyingPrice.Hint = "Precio de compra";
            txtBuyingPrice.Location = new Point(72, 117);
            txtBuyingPrice.Name = "txtBuyingPrice";
            txtBuyingPrice.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtBuyingPrice.Size = new Size(151, 21);
            txtBuyingPrice.StateActive.Content.Color1 = Color.DimGray;
            txtBuyingPrice.StateCommon.Back.Color1 = SystemColors.Control;
            txtBuyingPrice.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtBuyingPrice.StateCommon.Content.Color1 = SystemColors.Control;
            txtBuyingPrice.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuyingPrice.TabIndex = 9;
            txtBuyingPrice.MaskInputRejected += txtAddress_MaskInputRejected;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(322, 380);
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
            txtName.Hint = "Nombre del producto";
            txtName.Location = new Point(72, 31);
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
            // txtSellingPrice
            // 
            txtSellingPrice.BeepOnError = true;
            txtSellingPrice.Cursor = Cursors.IBeam;
            txtSellingPrice.Hint = "Precio de venta";
            txtSellingPrice.Location = new Point(72, 165);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtSellingPrice.Size = new Size(151, 21);
            txtSellingPrice.StateActive.Content.Color1 = Color.DimGray;
            txtSellingPrice.StateCommon.Back.Color1 = SystemColors.Control;
            txtSellingPrice.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtSellingPrice.StateCommon.Content.Color1 = SystemColors.Control;
            txtSellingPrice.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellingPrice.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(69, 90, 100);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(72, 380);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDetail
            // 
            txtDetail.BeepOnError = true;
            txtDetail.Cursor = Cursors.IBeam;
            txtDetail.Hint = "Detalle";
            txtDetail.Location = new Point(72, 267);
            txtDetail.Name = "txtDetail";
            txtDetail.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtDetail.Size = new Size(360, 21);
            txtDetail.StateActive.Content.Color1 = Color.DimGray;
            txtDetail.StateCommon.Back.Color1 = SystemColors.Control;
            txtDetail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtDetail.StateCommon.Content.Color1 = Color.DimGray;
            txtDetail.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetail.TabIndex = 5;
            txtDetail.ToolTipValues.ImageTransparentColor = Color.Transparent;
            txtDetail.ToolTipValues.ToolTipShadow = false;
            txtDetail.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            txtDetail.MaskInputRejected += txtDetail_MaskInputRejected;
            // 
            // txtCode
            // 
            txtCode.BeepOnError = true;
            txtCode.Cursor = Cursors.IBeam;
            txtCode.Hint = "Código";
            txtCode.Location = new Point(72, 67);
            txtCode.Name = "txtCode";
            txtCode.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtCode.Size = new Size(151, 21);
            txtCode.StateActive.Content.Color1 = Color.DimGray;
            txtCode.StateCommon.Back.Color1 = SystemColors.Control;
            txtCode.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtCode.StateCommon.Content.Color1 = SystemColors.Control;
            txtCode.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.TabIndex = 4;
            txtCode.MaskInputRejected += txtDocument_MaskInputRejected;
            // 
            // errorMessage
            // 
            errorMessage.ContainerControl = this;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(lblTitulo);
            Controls.Add(gpbClientInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            gpbClientInfo.ResumeLayout(false);
            gpbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gpbClientInfo;
        private Krypton.Toolkit.KryptonMaskedTextBox txtBuyingPrice;
        private Button btnExit;
        private Krypton.Toolkit.KryptonMaskedTextBox txtName;
        private Krypton.Toolkit.KryptonMaskedTextBox txtSellingPrice;
        private Button btnUpdate;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDetail;
        private Krypton.Toolkit.KryptonMaskedTextBox txtCode;
        private Krypton.Toolkit.KryptonMaskedTextBox txtStock;
        private Krypton.Toolkit.KryptonComboBox cmbCategories;
        private ErrorProvider errorMessage;
    }
}