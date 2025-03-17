namespace BillingSystem
{
    partial class FrmProductsList
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
            gpbDataGrid = new GroupBox();
            btnNewProduct = new Button();
            txtSearchProduct = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnSearch = new Button();
            dgProducts = new DataGridView();
            btnExit = new Button();
            lbl = new Label();
            productId = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            productCode = new DataGridViewTextBoxColumn();
            buyingPrice = new DataGridViewTextBoxColumn();
            sellingPrice = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();
            gpbDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // gpbDataGrid
            // 
            gpbDataGrid.BackColor = Color.Transparent;
            gpbDataGrid.Controls.Add(btnNewProduct);
            gpbDataGrid.Controls.Add(txtSearchProduct);
            gpbDataGrid.Controls.Add(btnSearch);
            gpbDataGrid.Controls.Add(dgProducts);
            gpbDataGrid.Location = new Point(20, 109);
            gpbDataGrid.Name = "gpbDataGrid";
            gpbDataGrid.Size = new Size(879, 359);
            gpbDataGrid.TabIndex = 17;
            gpbDataGrid.TabStop = false;
            // 
            // btnNewProduct
            // 
            btnNewProduct.AutoSize = true;
            btnNewProduct.BackColor = Color.FromArgb(69, 90, 100);
            btnNewProduct.FlatStyle = FlatStyle.Flat;
            btnNewProduct.Font = new Font("Segoe UI", 9F);
            btnNewProduct.ForeColor = SystemColors.ButtonFace;
            btnNewProduct.Location = new Point(715, 29);
            btnNewProduct.Margin = new Padding(0);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(123, 31);
            btnNewProduct.TabIndex = 13;
            btnNewProduct.Text = "NUEVO PRODUCTO";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.BeepOnError = true;
            txtSearchProduct.Cursor = Cursors.IBeam;
            txtSearchProduct.Hint = "Buscar Producto";
            txtSearchProduct.Location = new Point(17, 29);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txtSearchProduct.Size = new Size(427, 21);
            txtSearchProduct.StateActive.Back.Color1 = SystemColors.Control;
            txtSearchProduct.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtSearchProduct.StateCommon.Content.Color1 = Color.DimGray;
            txtSearchProduct.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProduct.StateNormal.Back.Color1 = SystemColors.ButtonFace;
            txtSearchProduct.StateNormal.Content.Color1 = SystemColors.ActiveCaption;
            txtSearchProduct.TabIndex = 6;
            txtSearchProduct.MaskInputRejected += txtSearchClient_MaskInputRejected;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(69, 90, 100);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(473, 29);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { productId, productName, productCode, buyingPrice, sellingPrice, category, Detail, stock, btnDelete, btnEdit });
            dgProducts.Location = new Point(17, 70);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(839, 272);
            dgProducts.TabIndex = 0;
            dgProducts.CellContentClick += dgProducts_CellContentClick;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(800, 492);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 18;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(408, 82);
            lbl.Name = "lbl";
            lbl.Size = new Size(107, 15);
            lbl.TabIndex = 19;
            lbl.Text = "LISTA PRODUCTOS";
            // 
            // productId
            // 
            productId.HeaderText = "ID";
            productId.Name = "productId";
            // 
            // productName
            // 
            productName.HeaderText = "Nombre";
            productName.Name = "productName";
            // 
            // productCode
            // 
            productCode.HeaderText = "Código";
            productCode.Name = "productCode";
            // 
            // buyingPrice
            // 
            buyingPrice.HeaderText = "Precio de compra";
            buyingPrice.Name = "buyingPrice";
            // 
            // sellingPrice
            // 
            sellingPrice.HeaderText = "Precio de venta";
            sellingPrice.Name = "sellingPrice";
            // 
            // category
            // 
            category.HeaderText = "Categoría";
            category.Name = "category";
            // 
            // Detail
            // 
            Detail.HeaderText = "Detalle";
            Detail.Name = "Detail";
            // 
            // stock
            // 
            stock.HeaderText = "En stock";
            stock.Name = "stock";
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Borrar";
            btnDelete.Name = "btnDelete";
            btnDelete.ToolTipText = "Borrar";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.ToolTipText = "Editar";
            // 
            // FrmProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 532);
            Controls.Add(lbl);
            Controls.Add(btnExit);
            Controls.Add(gpbDataGrid);
            Name = "FrmProductsList";
            Load += FrmProductsList_Load;
            gpbDataGrid.ResumeLayout(false);
            gpbDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbDataGrid;
        private Button btnNewProduct;
        private Krypton.Toolkit.KryptonMaskedTextBox txtSearchProduct;
        private Button btnSearch;
        private DataGridView dgProducts;
        private Button btnExit;
        private Label lbl;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn buyingPrice;
        private DataGridViewTextBoxColumn sellingPrice;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn Detail;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
    }
}