using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BillingSystem
{
    public partial class FrmProductsList : MaterialForm
    {
        public FrmProductsList()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();
        SqlConnection connection;

        public void fill_grid()
        {
            dgProducts.Rows.Clear();

            connection = new SqlConnection("Server=AFDGRTR45\\MSSQLSERVER1;Database=DBFACTURAS;Trusted_Connection=True;");
            connection.Open();

            string strConsulta = @"
                SELECT
                    p.IdProducto,
                    p.StrNombre, 
                    p.StrCodigo,  
                    p.NumPrecioCompra, 
                    p.NumPrecioVenta, 
                    c.StrDescripcion AS CategoriaDescripcion, 
                    p.StrDetalle,  
                    p.NumStock 
                FROM 
                    TBLPRODUCTO AS p  
                INNER JOIN 
            TBLCATEGORIA_PROD AS c ON p.IdCategoria = c.IdCategoria;";

            SqlCommand command = new SqlCommand(strConsulta, connection);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                dgProducts.Rows.Add(data[0],data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
            }

            connection.Close();
        }

        private void txtSearchClient_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            FrmProducts product = new FrmProducts();
            product.IdProduct = 0;

            product.ShowDialog();
            fill_grid();
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si el botón presionado es el de borrar
            if (dgProducts.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int posActual = dgProducts.CurrentRow.Index; // Identificamos la fila a borrar

                // Mostramos un mensaje de confirmación de borrado
                if (MessageBox.Show($"¿Seguro de borrar el producto {dgProducts[1, posActual].Value.ToString()}?",
                    "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Tomamos el Id del cliente y lo convertimos a entero
                    int idProduct = Convert.ToInt32(dgProducts[0, posActual].Value.ToString());

                    // Creamos la sentencia SQL para eliminar el cliente
                    string sentencia = $"Exec Eliminar_Producto'{idProduct}';";

                    // Ejecutamos la sentencia en la base de datos
                    string mensaje = dataAccess.EjecutarComando(sentencia);

                    // Mostramos el mensaje de resultado
                    MessageBox.Show(mensaje);
                }
            }

            // Verificamos si el botón presionado es el de editar
            if (dgProducts.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int posActual = dgProducts.CurrentRow.Index;

                // Creamos una instancia del formulario de edición de clientes
                FrmProducts product = new FrmProducts();

                // Pasamos el Id del cliente al formulario de edición
                product.IdProduct = int.Parse(dgProducts[0, posActual].Value.ToString());

                // Mostramos el formulario de edición
                product.ShowDialog();
            }

            // Método para actualizar la grilla después de una acción
            fill_grid();
        }

        private void FrmProductsList_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text != "")
            {
                dgProducts.Rows.Clear();

                string sentencia = $"select StrNombre, NumDocumento, StrDireccion, StrTelefono from TBLCLIENTES where strNombre like '%{txtSearchProduct.Text}'";

                foreach (DataRow row in dt.Rows)
                {
                    dgProducts.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                }
                txtSearchProduct.Text = "";
            }
            else
            {
                fill_grid();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
