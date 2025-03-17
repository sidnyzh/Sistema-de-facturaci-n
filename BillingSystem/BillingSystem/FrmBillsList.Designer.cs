namespace BillingSystem
{
    partial class FrmBillsList
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
            btnExit = new Button();
            gpbDataGrid = new GroupBox();
            btnNewBill = new Button();
            txtSearchBill = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnSearch = new Button();
            dgBills = new DataGridView();
            lblTitulo = new Label();
            BillingId = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ClientId = new DataGridViewTextBoxColumn();
            EmployeeId = new DataGridViewTextBoxColumn();
            DiscountNumber = new DataGridViewTextBoxColumn();
            TaxNumber = new DataGridViewTextBoxColumn();
            totalValue = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            gpbDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBills).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(767, 478);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 20;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // gpbDataGrid
            // 
            gpbDataGrid.BackColor = Color.Transparent;
            gpbDataGrid.Controls.Add(btnNewBill);
            gpbDataGrid.Controls.Add(txtSearchBill);
            gpbDataGrid.Controls.Add(btnSearch);
            gpbDataGrid.Controls.Add(dgBills);
            gpbDataGrid.Location = new Point(28, 74);
            gpbDataGrid.Name = "gpbDataGrid";
            gpbDataGrid.Size = new Size(864, 374);
            gpbDataGrid.TabIndex = 19;
            gpbDataGrid.TabStop = false;
            // 
            // btnNewBill
            // 
            btnNewBill.AutoSize = true;
            btnNewBill.BackColor = Color.FromArgb(69, 90, 100);
            btnNewBill.FlatStyle = FlatStyle.Flat;
            btnNewBill.Font = new Font("Segoe UI", 9F);
            btnNewBill.ForeColor = SystemColors.ButtonFace;
            btnNewBill.Location = new Point(720, 29);
            btnNewBill.Margin = new Padding(0);
            btnNewBill.Name = "btnNewBill";
            btnNewBill.Size = new Size(110, 31);
            btnNewBill.TabIndex = 13;
            btnNewBill.Text = "NUEVA FACTURA";
            btnNewBill.UseVisualStyleBackColor = false;
            btnNewBill.Click += btnNewBill_Click;
            // 
            // txtSearchBill
            // 
            txtSearchBill.BeepOnError = true;
            txtSearchBill.Cursor = Cursors.IBeam;
            txtSearchBill.Hint = "Buscar Factura";
            txtSearchBill.Location = new Point(43, 29);
            txtSearchBill.Name = "txtSearchBill";
            txtSearchBill.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txtSearchBill.Size = new Size(427, 21);
            txtSearchBill.StateActive.Back.Color1 = SystemColors.Control;
            txtSearchBill.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtSearchBill.StateCommon.Content.Color1 = Color.DimGray;
            txtSearchBill.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBill.StateNormal.Back.Color1 = SystemColors.ButtonFace;
            txtSearchBill.StateNormal.Content.Color1 = SystemColors.ActiveCaption;
            txtSearchBill.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(69, 90, 100);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(507, 29);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgBills
            // 
            dgBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBills.Columns.AddRange(new DataGridViewColumn[] { BillingId, Date, ClientId, EmployeeId, DiscountNumber, TaxNumber, totalValue, Status, btnEdit });
            dgBills.Location = new Point(11, 83);
            dgBills.Name = "dgBills";
            dgBills.Size = new Size(838, 274);
            dgBills.TabIndex = 0;
            dgBills.CellContentClick += dgClients_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(386, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 15);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "LISTA FACTURAS";
            // 
            // BillingId
            // 
            BillingId.HeaderText = "ID";
            BillingId.Name = "BillingId";
            // 
            // Date
            // 
            Date.HeaderText = "Fecha";
            Date.Name = "Date";
            // 
            // ClientId
            // 
            ClientId.HeaderText = "Cliente";
            ClientId.Name = "ClientId";
            // 
            // EmployeeId
            // 
            EmployeeId.HeaderText = "Empleado";
            EmployeeId.Name = "EmployeeId";
            // 
            // DiscountNumber
            // 
            DiscountNumber.HeaderText = "Número de descuento";
            DiscountNumber.Name = "DiscountNumber";
            // 
            // TaxNumber
            // 
            TaxNumber.HeaderText = "Número de impuesto";
            TaxNumber.Name = "TaxNumber";
            // 
            // totalValue
            // 
            totalValue.HeaderText = "Valor Total";
            totalValue.Name = "totalValue";
            // 
            // Status
            // 
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.ToolTipText = "Editar";
            // 
            // FrmBillsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(btnExit);
            Controls.Add(gpbDataGrid);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBillsList";
            Text = "FrmBillingsList";
            Load += FrmBillsList_Load;
            gpbDataGrid.ResumeLayout(false);
            gpbDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private GroupBox gpbDataGrid;
        private Button btnNewBill;
        private Krypton.Toolkit.KryptonMaskedTextBox txtSearchBill;
        private Button btnSearch;
        private DataGridView dgBills;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn BillingId;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn DiscountNumber;
        private DataGridViewTextBoxColumn TaxNumber;
        private DataGridViewTextBoxColumn totalValue;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnEdit;
    }
}