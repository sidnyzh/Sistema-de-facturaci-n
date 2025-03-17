namespace BillingSystem
{
    partial class FrmClientsList
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
            dgClients = new DataGridView();
            label1 = new Label();
            gpbDataGrid = new GroupBox();
            btnNewClient = new Button();
            txtSearchClient = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnSearch = new Button();
            btnExit = new Button();
            clientId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgClients).BeginInit();
            gpbDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // dgClients
            // 
            dgClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClients.Columns.AddRange(new DataGridViewColumn[] { clientId, Nombre, Documento, Direccion, Telefono, btnDelete, btnEdit });
            dgClients.Location = new Point(50, 83);
            dgClients.Name = "dgClients";
            dgClients.Size = new Size(644, 274);
            dgClients.TabIndex = 0;
            dgClients.CellContentClick += dgClients_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 81);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "LISTA CLIENTES";
            // 
            // gpbDataGrid
            // 
            gpbDataGrid.BackColor = Color.Transparent;
            gpbDataGrid.Controls.Add(btnNewClient);
            gpbDataGrid.Controls.Add(txtSearchClient);
            gpbDataGrid.Controls.Add(btnSearch);
            gpbDataGrid.Controls.Add(dgClients);
            gpbDataGrid.Location = new Point(10, 109);
            gpbDataGrid.Name = "gpbDataGrid";
            gpbDataGrid.Size = new Size(745, 374);
            gpbDataGrid.TabIndex = 16;
            gpbDataGrid.TabStop = false;
            // 
            // btnNewClient
            // 
            btnNewClient.AutoSize = true;
            btnNewClient.BackColor = Color.FromArgb(69, 90, 100);
            btnNewClient.FlatStyle = FlatStyle.Flat;
            btnNewClient.Font = new Font("Segoe UI", 9F);
            btnNewClient.ForeColor = SystemColors.ButtonFace;
            btnNewClient.Location = new Point(616, 29);
            btnNewClient.Margin = new Padding(0);
            btnNewClient.Name = "btnNewClient";
            btnNewClient.Size = new Size(110, 31);
            btnNewClient.TabIndex = 13;
            btnNewClient.Text = "NUEVO CLIENTE";
            btnNewClient.UseVisualStyleBackColor = false;
            btnNewClient.Click += btnNewClient_Click;
            // 
            // txtSearchClient
            // 
            txtSearchClient.BeepOnError = true;
            txtSearchClient.Cursor = Cursors.IBeam;
            txtSearchClient.Hint = "Buscar Cliente";
            txtSearchClient.Location = new Point(59, 29);
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txtSearchClient.Size = new Size(427, 21);
            txtSearchClient.StateActive.Back.Color1 = SystemColors.Control;
            txtSearchClient.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtSearchClient.StateCommon.Content.Color1 = Color.DimGray;
            txtSearchClient.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchClient.StateNormal.Back.Color1 = SystemColors.ButtonFace;
            txtSearchClient.StateNormal.Content.Color1 = SystemColors.ActiveCaption;
            txtSearchClient.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(69, 90, 100);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(509, 29);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(789, 490);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 17;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // clientId
            // 
            clientId.HeaderText = "ID";
            clientId.Name = "clientId";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
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
            // FrmClientsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 543);
            Controls.Add(btnExit);
            Controls.Add(gpbDataGrid);
            Controls.Add(label1);
            Name = "FrmClientsList";
            Load += frmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgClients).EndInit();
            gpbDataGrid.ResumeLayout(false);
            gpbDataGrid.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClients;
        private Label label1;
        private GroupBox gpbDataGrid;
        private Krypton.Toolkit.KryptonMaskedTextBox txtSearchClient;
        private Button btnSearch;
        private Button btnNewClient;
        private Button btnExit;
        private DataGridViewTextBoxColumn clientId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
    }
}
