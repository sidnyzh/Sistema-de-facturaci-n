namespace BillingSystem
{
    partial class FrmCategories
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
            btnExit = new Button();
            btnUpdate = new Button();
            txtDescription = new Krypton.Toolkit.KryptonMaskedTextBox();
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
            lblTitulo.Location = new Point(286, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 20);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "ACTUALIZACIÓN DE CATEGORIAS";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // gpbClientInfo
            // 
            gpbClientInfo.BackColor = Color.Transparent;
            gpbClientInfo.Controls.Add(btnExit);
            gpbClientInfo.Controls.Add(btnUpdate);
            gpbClientInfo.Controls.Add(txtDescription);
            gpbClientInfo.Location = new Point(155, 115);
            gpbClientInfo.Name = "gpbClientInfo";
            gpbClientInfo.Size = new Size(494, 247);
            gpbClientInfo.TabIndex = 18;
            gpbClientInfo.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.FromArgb(69, 90, 100);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(322, 142);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 31);
            btnExit.TabIndex = 10;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(69, 90, 100);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(72, 142);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDescription
            // 
            txtDescription.BeepOnError = true;
            txtDescription.Cursor = Cursors.IBeam;
            txtDescription.Hint = "Descripción";
            txtDescription.Location = new Point(72, 61);
            txtDescription.Name = "txtDescription";
            txtDescription.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            txtDescription.Size = new Size(360, 21);
            txtDescription.StateActive.Content.Color1 = Color.DimGray;
            txtDescription.StateCommon.Back.Color1 = SystemColors.Control;
            txtDescription.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtDescription.StateCommon.Content.Color1 = SystemColors.Control;
            txtDescription.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.TabIndex = 4;
            txtDescription.MaskInputRejected += txtCode_MaskInputRejected;
            // 
            // errorMessage
            // 
            errorMessage.ContainerControl = this;
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(lblTitulo);
            Controls.Add(gpbClientInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategories";
            Text = "FrmCategories";
            Load += FrmCategories_Load;
            gpbClientInfo.ResumeLayout(false);
            gpbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gpbClientInfo;
        private Button btnExit;
        private Button btnUpdate;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDescription;
        private ErrorProvider errorMessage;
    }
}