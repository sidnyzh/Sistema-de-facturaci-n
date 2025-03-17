using MaterialSkin.Controls;
using System.Data;

namespace BillingSystem
{
    public partial class FrmEmployees : MaterialForm
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        public int IdEmployee { get; set; }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();

        private void Fill_Employees()
        {
            if (IdEmployee == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                string sentencia = $"SELECT * from TBLEMPLEADO where IdEmpleado = {IdEmployee}";

                dt = dataAccess.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtName.Text = row[1].ToString();
                    txtDocument.Text = row[2].ToString();
                    txtAddress.Text = row[3].ToString();
                    txtPhone.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                    txtRol.Text = row[6].ToString();
                    txtIngreso.Text = row[7].ToString();
                    txtRetiro.Text = row[8].ToString();
                    txtAditionalData.Text = row[9].ToString();

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            Fill_Employees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    DataAccess Acceso = new DataAccess();
                    string sentencia = $"Exec [actualizar_Empleado] {IdEmployee},'{txtName.Text}',{txtDocument.Text} ,'{txtAddress.Text}','{txtPhone.Text}', '{txtEmail}','Javier','{DateTime.Now.ToString("yyyy-MM-dd")}'";
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
            if (txtName.Text == string.Empty)
            {
                errorMessage.SetError(txtName, "debe ingresar el nombre del empleado");
                txtName.Focus();
                errorCampos = false;
            }
            else { errorMessage.SetError(txtName, ""); }
            if (txtDocument.Text == "")
            {
                errorMessage.SetError(txtDocument, "debe ingresar el documento");
                txtDocument.Focus();
                errorCampos = false;
            }
            else { errorMessage.SetError(txtDocument, ""); }
            if (!esNumerico(txtDocument.Text))
            {
                errorMessage.SetError(txtDocument, "El Documento debe ser numerico");
                txtDocument.Focus();
                return false;
            }

            errorMessage.SetError(txtDocument, "");
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
    }
}
