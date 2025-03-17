namespace BillingSystem
{
    partial class FrmEmployeesList
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
            btnNewEmployee = new Button();
            txtSearchEmployee = new Krypton.Toolkit.KryptonMaskedTextBox();
            btnSearch = new Button();
            dgEmployees = new DataGridView();
            clientId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            ingreso = new DataGridViewTextBoxColumn();
            salida = new DataGridViewTextBoxColumn();
            dataAdicional = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();
            label1 = new Label();
            gpbDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(792, 505);
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
            gpbDataGrid.Controls.Add(btnNewEmployee);
            gpbDataGrid.Controls.Add(txtSearchEmployee);
            gpbDataGrid.Controls.Add(btnSearch);
            gpbDataGrid.Controls.Add(dgEmployees);
            gpbDataGrid.Location = new Point(30, 109);
            gpbDataGrid.Name = "gpbDataGrid";
            gpbDataGrid.Size = new Size(872, 374);
            gpbDataGrid.TabIndex = 19;
            gpbDataGrid.TabStop = false;
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.AutoSize = true;
            btnNewEmployee.BackColor = Color.FromArgb(69, 90, 100);
            btnNewEmployee.FlatStyle = FlatStyle.Flat;
            btnNewEmployee.Font = new Font("Segoe UI", 9F);
            btnNewEmployee.ForeColor = SystemColors.ButtonFace;
            btnNewEmployee.Location = new Point(616, 29);
            btnNewEmployee.Margin = new Padding(0);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(122, 31);
            btnNewEmployee.TabIndex = 13;
            btnNewEmployee.Text = "NUEVO EMPLEADO";
            btnNewEmployee.UseVisualStyleBackColor = false;
            btnNewEmployee.Click += btnNewEmployee_Click;
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.BeepOnError = true;
            txtSearchEmployee.Cursor = Cursors.IBeam;
            txtSearchEmployee.Hint = "Buscar empleado";
            txtSearchEmployee.Location = new Point(59, 29);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txtSearchEmployee.Size = new Size(427, 21);
            txtSearchEmployee.StateActive.Back.Color1 = SystemColors.Control;
            txtSearchEmployee.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtSearchEmployee.StateCommon.Content.Color1 = Color.DimGray;
            txtSearchEmployee.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchEmployee.StateNormal.Back.Color1 = SystemColors.ButtonFace;
            txtSearchEmployee.StateNormal.Content.Color1 = SystemColors.ActiveCaption;
            txtSearchEmployee.TabIndex = 6;
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
            // dgEmployees
            // 
            dgEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployees.Columns.AddRange(new DataGridViewColumn[] { clientId, Nombre, Documento, Direccion, Telefono, Email, Rol, ingreso, salida, dataAdicional, btnDelete, btnEdit });
            dgEmployees.Location = new Point(26, 83);
            dgEmployees.Name = "dgEmployees";
            dgEmployees.Size = new Size(840, 274);
            dgEmployees.TabIndex = 0;
            dgEmployees.CellContentClick += dgEmployees_CellContentClick;
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
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // ingreso
            // 
            ingreso.HeaderText = "Fecha de ingreso";
            ingreso.Name = "ingreso";
            // 
            // salida
            // 
            salida.HeaderText = "fecha de salida";
            salida.Name = "salida";
            // 
            // dataAdicional
            // 
            dataAdicional.HeaderText = "Datos adicionales";
            dataAdicional.Name = "dataAdicional";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 81);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 18;
            label1.Text = "LISTA DE EMPLEADOS";
            // 
            // FrmEmployeesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 557);
            Controls.Add(btnExit);
            Controls.Add(gpbDataGrid);
            Controls.Add(label1);
            Name = "FrmEmployeesList";
            Load += FrmEmployeesList_Load;
            gpbDataGrid.ResumeLayout(false);
            gpbDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private GroupBox gpbDataGrid;
        private Button btnNewEmployee;
        private Krypton.Toolkit.KryptonMaskedTextBox txtSearchEmployee;
        private Button btnSearch;
        private DataGridView dgEmployees;
        private Label label1;
        private DataGridViewTextBoxColumn clientId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn ingreso;
        private DataGridViewTextBoxColumn salida;
        private DataGridViewTextBoxColumn dataAdicional;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
    }
}