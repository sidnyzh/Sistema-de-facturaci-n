namespace BillingSystem
{
    partial class FrmCategoriesList
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
            dgCategories = new DataGridView();
            categoryId = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            modifiedDate = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnNewCategory = new Button();
            txtSearchCategory = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnSearch = new Button();
            label1 = new Label();
            gpbDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(647, 477);
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
            gpbDataGrid.Controls.Add(dgCategories);
            gpbDataGrid.Controls.Add(btnNewCategory);
            gpbDataGrid.Controls.Add(txtSearchCategory);
            gpbDataGrid.Controls.Add(btnSearch);
            gpbDataGrid.Location = new Point(12, 102);
            gpbDataGrid.Name = "gpbDataGrid";
            gpbDataGrid.Size = new Size(745, 349);
            gpbDataGrid.TabIndex = 19;
            gpbDataGrid.TabStop = false;
            gpbDataGrid.Enter += gpbDataGrid_Enter;
            // 
            // dgCategories
            // 
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Columns.AddRange(new DataGridViewColumn[] { categoryId, Description, modifiedDate, btnEdit });
            dgCategories.Location = new Point(156, 112);
            dgCategories.Name = "dgCategories";
            dgCategories.Size = new Size(441, 231);
            dgCategories.TabIndex = 14;
            dgCategories.CellContentClick += dgCategories_CellContentClick;
            // 
            // categoryId
            // 
            categoryId.HeaderText = "ID";
            categoryId.Name = "categoryId";
            // 
            // Description
            // 
            Description.HeaderText = "Descripción";
            Description.Name = "Description";
            // 
            // modifiedDate
            // 
            modifiedDate.HeaderText = "Fecha de modificación";
            modifiedDate.Name = "modifiedDate";
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.ToolTipText = "Editar";
            // 
            // btnNewCategory
            // 
            btnNewCategory.AutoSize = true;
            btnNewCategory.BackColor = Color.FromArgb(69, 90, 100);
            btnNewCategory.FlatStyle = FlatStyle.Flat;
            btnNewCategory.Font = new Font("Segoe UI", 9F);
            btnNewCategory.ForeColor = SystemColors.ButtonFace;
            btnNewCategory.Location = new Point(605, 29);
            btnNewCategory.Margin = new Padding(0);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(122, 31);
            btnNewCategory.TabIndex = 13;
            btnNewCategory.Text = "NUEVA CATEGORIA";
            btnNewCategory.UseVisualStyleBackColor = false;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.BeepOnError = true;
            txtSearchCategory.Cursor = Cursors.IBeam;
            txtSearchCategory.Hint = "Buscar Clategoria";
            txtSearchCategory.Location = new Point(50, 29);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txtSearchCategory.Size = new Size(427, 21);
            txtSearchCategory.StateActive.Back.Color1 = SystemColors.Control;
            txtSearchCategory.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtSearchCategory.StateCommon.Content.Color1 = Color.DimGray;
            txtSearchCategory.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchCategory.StateNormal.Back.Color1 = SystemColors.ButtonFace;
            txtSearchCategory.StateNormal.Content.Color1 = SystemColors.ActiveCaption;
            txtSearchCategory.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(69, 90, 100);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(495, 29);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 84);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 18;
            label1.Text = "LISTA DE CATEGORIAS";
            label1.Click += label1_Click;
            // 
            // FrmCategoriesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 531);
            Controls.Add(btnExit);
            Controls.Add(gpbDataGrid);
            Controls.Add(label1);
            Name = "FrmCategoriesList";
            Load += FrmCategoriesList_Load;
            gpbDataGrid.ResumeLayout(false);
            gpbDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private GroupBox gpbDataGrid;
        private Button btnNewCategory;
        private Krypton.Toolkit.KryptonMaskedTextBox txtSearchCategory;
        private Button btnSearch;
        private Label label1;
        private DataGridView dgCategories;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn modifiedDate;
        private DataGridViewButtonColumn btnEdit;
    }
}