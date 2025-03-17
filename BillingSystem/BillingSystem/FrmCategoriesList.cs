using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class FrmCategoriesList : MaterialForm
    {
        public FrmCategoriesList()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();
        SqlConnection connection;

        public void fill_grid()
        {
            dgCategories.Rows.Clear();

            connection = new SqlConnection("Server=AFDGRTR45\\MSSQLSERVER1;Database=DBFACTURAS;Trusted_Connection=True;");
            connection.Open();

            string strConsulta = "SELECT * From TBLCATEGORIA_PROD;";

            SqlCommand command = new SqlCommand(strConsulta, connection);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                dgCategories.Rows.Add(data[0], data[1], data[2]);
            }

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gpbDataGrid_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCategoriesList_Load(object sender, EventArgs e)
        {
            fill_grid();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si el botón presionado es el de editar
            if (dgCategories.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int posActual = dgCategories.CurrentRow.Index;

                // Creamos una instancia del formulario de edición de clientes
                FrmCategories categories = new FrmCategories();

                // Pasamos el Id del cliente al formulario de edición
                categories.IdCategory = int.Parse(dgCategories[0, posActual].Value.ToString());

                // Mostramos el formulario de edición
                categories.ShowDialog();
            }

            // Método para actualizar la grilla después de una acción
            fill_grid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchCategory.Text != "")
            {
                dgCategories.Rows.Clear();

                string sentencia = $"select StrDescripcion, DtmFechaModifica, from TBLCATEGORIA_PROD where strNombre like '%{txtSearchCategory.Text}'";

                foreach (DataRow row in dt.Rows)
                {
                    dgCategories.Rows.Add(row[0], row[1], row[2]);
                }
                txtSearchCategory.Text = "";
            }
            else
            {
                fill_grid();
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.IdCategory = 0;

            categories.ShowDialog();
            fill_grid();
        }
    }
}
