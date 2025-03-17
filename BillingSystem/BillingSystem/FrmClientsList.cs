using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;

namespace BillingSystem
{
    public partial class FrmClientsList : MaterialForm
    {
        public FrmClientsList()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataAccess DataAccess = new DataAccess();
        SqlConnection conexion;
        SqlCommand cmd;

        public void fill_grid()
        {
            dgClients.Rows.Clear();

            conexion = new SqlConnection("Server=AFDGRTR45\\MSSQLSERVER1;Database=DBFACTURAS;Trusted_Connection=True;");
            conexion.Open();

            string strConsulta = "select * from TBLCLIENTES";

            SqlCommand command = new SqlCommand(strConsulta, conexion);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                dgClients.Rows.Add(data[0], data[1], data[2], data[3], data[4]);
            }

            conexion.Close();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchClient.Text != "")
            {
                dgClients.Rows.Clear();

                string sentencia = $"select StrNombre, NumDocumento, StrDireccion, StrTelefono from TBLCLIENTES where strNombre like '%{txtSearchClient.Text}'";

                foreach (DataRow row in dt.Rows)
                {
                    dgClients.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
                txtSearchClient.Text = "";
            }
            else
            {
                fill_grid();
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            FrmClients client = new FrmClients();
            client.IdClient = 0;

            client.ShowDialog();
            fill_grid();
        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si el botón presionado es el de borrar
            if (dgClients.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int posActual = dgClients.CurrentRow.Index; // Identificamos la fila a borrar

                // Mostramos un mensaje de confirmación de borrado
                if (MessageBox.Show($"¿Seguro de borrar al cliente {dgClients[1, posActual].Value.ToString()}?",
                    "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Tomamos el Id del cliente y lo convertimos a entero
                    int IdCliente = Convert.ToInt32(dgClients[0, posActual].Value.ToString());

                    // Creamos la sentencia SQL para eliminar el cliente
                    string sentencia = $"Exec EliminarCliente '{IdCliente}';";

                    // Ejecutamos la sentencia en la base de datos
                    string mensaje = DataAccess.EjecutarComando(sentencia);

                    // Mostramos el mensaje de resultado
                    MessageBox.Show(mensaje);
                }
            }

            // Verificamos si el botón presionado es el de editar
            if (dgClients.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int posActual = dgClients.CurrentRow.Index;

                // Creamos una instancia del formulario de edición de clientes
                FrmClients cliente = new FrmClients();

                // Pasamos el Id del cliente al formulario de edición
                cliente.IdClient = int.Parse(dgClients[0, posActual].Value.ToString());

                // Mostramos el formulario de edición
                cliente.ShowDialog();
            }

            // Método para actualizar la grilla después de una acción
            fill_grid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
