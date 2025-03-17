using System.Data.SqlClient;

namespace EjemploADO
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

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


        SqlConnection conexion;
        SqlCommand cmd;
        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
