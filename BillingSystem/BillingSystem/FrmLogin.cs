using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics.Eventing.Reader;

namespace BillingSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string answer = "";


            if (txtUsername.Text != "" && txtPassword.Text != string.Empty)
            {
                DataAccess access = new DataAccess();

                answer = access.ValidarUsuario(txtUsername.Text, txtPassword.Text);
                if (answer != "")
                {
                    MessageBox.Show("Bienvenido : " + answer);
                    FrmPrincipal frmppal = new FrmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y clave no encontrados");
                    txtUsername.Text = "";
                    txtUsername.Focus();
                    txtPassword.Text = "Password";
                }
            }

            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }

        private void materialLabelControl1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabelControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonWrapLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Text.ToString();
        }
    }
}
