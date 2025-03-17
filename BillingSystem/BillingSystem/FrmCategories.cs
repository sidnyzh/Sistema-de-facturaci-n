using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BillingSystem
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        public int IdCategory { get; set; }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();

        private void Fill_Category()
        {
            if (IdCategory == 0)
            {
                lblTitulo.Text = "INGRESO NUEVA CATEGORIA";
            }
            else
            {
                string sentencia = $"SELECT * from TBLCATEGORIA_PROD where IdCategoria = {IdCategory}";

                dt = dataAccess.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtDescription.Text = row[1].ToString();
                }
            }
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    DataAccess Acceso = new DataAccess();
                    string sentencia = $"Exec [actualizar_CategoriaProducto] {IdCategory},'{txtDescription.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}','Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtDescription.Text == string.Empty)
            {
                errorMessage.SetError(txtDescription, "debe ingresar la descripción de la categoria");
                txtDescription.Focus();
                errorCampos = false;
            }
            errorMessage.SetError(txtDescription, "");
            return errorCampos;
        }
       
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            Fill_Category();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
