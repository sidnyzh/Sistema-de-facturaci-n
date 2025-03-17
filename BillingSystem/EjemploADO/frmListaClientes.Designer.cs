namespace EjemploADO
{
    partial class frmListaClientes
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
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgClients).BeginInit();
            SuspendLayout();
            // 
            // dgClients
            // 
            dgClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClients.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Documento, Direccion, Telefono });
            dgClients.Location = new Point(12, 102);
            dgClients.Name = "dgClients";
            dgClients.Size = new Size(542, 314);
            dgClients.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "LISTA CLIENTES";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(629, 348);
            button1.Name = "button1";
            button1.Size = new Size(121, 39);
            button1.TabIndex = 2;
            button1.Text = "Información del combo";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(570, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgClients);
            Name = "frmListaClientes";
            Text = "Form1";
            Load += frmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClients;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
    }
}
