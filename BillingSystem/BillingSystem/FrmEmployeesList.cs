using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Data;

namespace BillingSystem
{
    public partial class FrmEmployeesList : MaterialForm
    {
        public FrmEmployeesList()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataAccess DataAccess = new DataAccess();
        SqlConnection conexion;
        SqlCommand cmd;

        public void fill_grid()
        {
            dgEmployees.Rows.Clear();

            conexion = new SqlConnection("Server=AFDGRTR45\\MSSQLSERVER1;Database=DBFACTURAS;Trusted_Connection=True;");
            conexion.Open();

            string strConsulta = "select * from TBLEMPLEADO";

            SqlCommand command = new SqlCommand(strConsulta, conexion);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                dgEmployees.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);
            }

            conexion.Close();
        }

        private void FrmEmployeesList_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployees employee = new FrmEmployees();
            employee.IdEmployee = 0;

            employee.ShowDialog();
            fill_grid();
        }

        private void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si el botón presionado es el de borrar
            if (dgEmployees.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int posActual = dgEmployees.CurrentRow.Index; // Identificamos la fila a borrar

                // Mostramos un mensaje de confirmación de borrado
                if (MessageBox.Show($"¿Seguro de borrar al empleado {dgEmployees[1, posActual].Value.ToString()}?",
                    "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Tomamos el Id del cliente y lo convertimos a entero
                    int Idemployee = Convert.ToInt32(dgEmployees[0, posActual].Value.ToString());

                    // Creamos la sentencia SQL para eliminar el cliente
                    string sentencia = $"Exec Eliminar_Empleado '{Idemployee}';";

                    // Ejecutamos la sentencia en la base de datos
                    string mensaje = DataAccess.EjecutarComando(sentencia);

                    // Mostramos el mensaje de resultado
                    MessageBox.Show(mensaje);
                }
            }

            // Verificamos si el botón presionado es el de editar
            if (dgEmployees.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int posActual = dgEmployees.CurrentRow.Index;

                // Creamos una instancia del formulario de edición de clientes
                FrmEmployees employees = new FrmEmployees();

                // Pasamos el Id del cliente al formulario de edición
                employees.IdEmployee = int.Parse(dgEmployees[0, posActual].Value.ToString());

                // Mostramos el formulario de edición
                employees.ShowDialog();
            }

            // Método para actualizar la grilla después de una acción
            fill_grid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text != "")
            {
                dgEmployees.Rows.Clear();

                string sentencia = $"select StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail from TBLCLIENTES where strNombre like '%{txtSearchEmployee.Text}'";

                foreach (DataRow row in dt.Rows)
                {
                    dgEmployees.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
                txtSearchEmployee.Text = "";
            }
            else
            {
                fill_grid();
            }
        }
    }
}
