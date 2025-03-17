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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        public int IdProduct { get; set; }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();

        private void Fill_Product()
        {
            if (IdProduct == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                string sentencia = $"SELECT * from TBLPRODUCTO where IdProducto = {IdProduct}";

                dt = dataAccess.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {

                    txtName.Text = row[1].ToString();
                    txtCode.Text = row[2].ToString();
                    txtBuyingPrice.Text = row[3].ToString();
                    txtSellingPrice.Text = row[4].ToString();
                    int categoriaId = Convert.ToInt32(row[5]);
                    txtDetail.Text = row[6].ToString();
                    txtStock.Text = row[8].ToString();

                    cmbCategories.SelectedItem = (CategoriesEnum)categoriaId;
                }
            }
        }



        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtDocument_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAddress_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kryptonMaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDetail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
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

        private enum CategoriesEnum
        {
            Tecnología = 1,
            Alimentos = 2,
            Carnes = 3,
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    DataAccess Acceso = new DataAccess();
                    int selectedCategory = (int)(CategoriesEnum)cmbCategories.SelectedItem;
                    string sentencia = $"Exec [actualizar_Producto] {IdProduct},'{txtName.Text}',{txtCode.Text} ,'{txtBuyingPrice.Text}','{txtSellingPrice.Text}', '{selectedCategory}', '{txtDetail.Text}', 'ninguna', '{txtStock.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}','Javier'";
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

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtName.Text == string.Empty)
            {
                errorMessage.SetError(txtName, "debe ingresar el nombre del Producto");
                txtName.Focus();
                errorCampos = false;
            }
            else { errorMessage.SetError(txtCode, ""); }
            if (txtCode.Text == "")
            {
                errorMessage.SetError(txtCode, "debe ingresar el Código");
                txtCode.Focus();
                errorCampos = false;
            }
            else { errorMessage.SetError(txtCode, ""); }
            if (!esNumerico(txtCode.Text))
            {
                errorMessage.SetError(txtCode, "El código debe ser numerico");
                txtCode.Focus();
                return false;
            }

            errorMessage.SetError(txtCode, "");
            return errorCampos;
        }
        //función para validar si un valor dado es numerico
        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            Fill_Product();
        }
    }
}
