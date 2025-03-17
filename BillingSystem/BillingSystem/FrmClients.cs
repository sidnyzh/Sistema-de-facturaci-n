using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        public int IdClient { get; set; }

        DataTable dt = new DataTable();
        DataAccess dataAccess = new DataAccess();

        private void Fill_Client()
        {
            if (IdClient == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                string sentencia = $"SELECT * from TBLCLIENTES where IdCliente = {IdClient}";

                dt = dataAccess.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtName.Text = row[1].ToString();
                    txtDocument.Text = row[2].ToString();
                    txtAddress.Text = row[3].ToString();
                    txtPhone.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            Fill_Client();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    DataAccess Acceso = new DataAccess();
                    string sentencia = $"Exec [actualizar_Cliente] {IdClient},'{txtName.Text}',{txtDocument.Text} ,'{txtAddress.Text}','{txtPhone.Text}', '{txtEmail.Text}','Javier','{DateTime.Now.ToString("yyyy-MM-dd")}'";
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
                errorMessage.SetError(txtName, "debe ingresar el nombre del Cliente");
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
