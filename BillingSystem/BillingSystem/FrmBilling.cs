using System.Data;

namespace BillingSystem
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        public int IdBill { get; set; }


        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();

        private void Fill_Billing()
        {
            if (IdBill == 0)
            {
                lblTitulo.Text = "INGRESO NUEVA FACTURA";
            }
            else
            {
                string sentencia = $"SELECT * from TBLFACTURA where IdFactura = {IdBill}";

                dt = dataAccess.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtClientId.Text = row[2].ToString();
                    txtIdEmployee.Text = row[3].ToString();
                    txtDiscount.Text = row[4].ToString();
                    txtTaxNumber.Text = row[5].ToString();
                    txtTotalValue.Text = row[6].ToString();
                    txtStatusId.Text = row[7].ToString();
                }
            }
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            //if (validar())
            //{
            try
            {
                DataAccess Acceso = new DataAccess();
                string sentencia = $"Exec [actualizar_Factura] {IdBill},'{DateTime.Now.ToString("yyyy-MM-dd")}',{txtClientId.Text} ,'{txtIdEmployee.Text}','{txtDiscount.Text}', '{txtTaxNumber.Text}', '{txtTotalValue.Text}', '{txtStatusId.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}','Javier'";
                MessageBox.Show(Acceso.EjecutarComando(sentencia));
                actualizado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("falló inserción: " + ex);
                actualizado = false;
            }
            //}
            return actualizado;
        }

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

        private void gpbClientInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStatusId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            Fill_Billing();
        }
    }
}
