using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;

namespace BillingSystem
{
    public partial class FrmBillsList : MaterialForm
    {
        public FrmBillsList()
        {
            InitializeComponent();
        }

        public int IdBill { get; set; }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();
        SqlConnection connection;

        public void fill_grid()
        {
            dgBills.Rows.Clear();

            connection = new SqlConnection("Server=AFDGRTR45\\MSSQLSERVER1;Database=DBFACTURAS;Trusted_Connection=True;");
            connection.Open();

            string strConsulta = "select * from TBLFACTURA";

            SqlCommand command = new SqlCommand(strConsulta, connection);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                dgBills.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
            }

            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBillsList_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.IdBill = 0;

            billing.ShowDialog();
            fill_grid();
        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Verificamos si el botón presionado es el de editar
            if (dgBills.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int posActual = dgBills.CurrentRow.Index;

                // Creamos una instancia del formulario de edición de facturas
                FrmBilling billing = new FrmBilling();

                // Pasamos el Id del cliente al formulario de edición
                billing.IdBill = int.Parse(dgBills[0, posActual].Value.ToString());

                // Mostramos el formulario de edición
                billing.ShowDialog();
            }

            // Método para actualizar la grilla después de una acción
            fill_grid();
        }
    }
    
}
