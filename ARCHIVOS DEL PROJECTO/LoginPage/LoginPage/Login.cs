using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LoginPage
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private bool res;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void OlvidarContra_Click(object sender, EventArgs e)
        {

        }

        private void IniciarBt_MouseClick(object sender, MouseEventArgs e)
        {
            string usuario = UsuarioTx.Text;
            string pass = ContraTx.Text;
            bool login = false;

            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog = SISGEN_DB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            string sql = "SELECT USUARIO FROM LOGIN2 WHERE USUARIO = @usuario AND PASS = @pass";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@pass", pass);
            SqlDataReader dr = cmd.ExecuteReader();
        
            while (dr.Read())
            {
                login = true;
            }

            dr.Close();
            con.Close();

            if(login == true)
            {
                this.Hide();
                PaginaPrincipal pg = new PaginaPrincipal();
                pg.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El Usuario No Existe o Contraseña Incorrecta", "SISGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Login lg = new Login();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void NuevoUsBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro rg = new Registro();
            rg.ShowDialog();
            this.Close();
        }

        private void IniciarBt_Click(object sender, EventArgs e)
        {


        }
    }
}

