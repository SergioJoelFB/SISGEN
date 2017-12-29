using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Registro : MetroFramework.Forms.MetroForm
    {
        
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void VolverMenu_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string apellido = Apellido.Text;
            string nomusuario = NomUsuario.Text;
            string pass = Pass.Text;
            string segpass = Segpass.Text;
           
            if (nombre == "")
            {
                lbl1.Visible = true;
            }

            if (apellido == "")
            {
                lbl2.Visible = true;
            }

            if (nomusuario == "")
            {
                lbl3.Visible = true;             
            }

            if (pass == "")
            {
                lbl4.Visible = true;             
            }

            if (segpass == "")
            {
                lbl5.Visible = true;             
            }

            if (nombre != "" && pass != "" && nomusuario != "" && pass != "" && segpass != "")
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=SISGEN_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

                bool registrar = false;

                con.Open();
                string sql = "INSERT INTO REGISTRO(NOMBRE, APELLIDO, NOMBRE_USUARIO, PASS, REP_PASS) VALUES ('" + Nombre.Text + "', '" + Apellido.Text + "', '" + NomUsuario.Text + "', '" + Pass.Text + "', '" + Segpass.Text + "') INSERT INTO LOGIN2 (USUARIO, PASS) VALUES ('"+NomUsuario.Text+"', '"+Pass.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, con);  
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    registrar = true;
                }

                rd.Close();
                con.Close();

                if (registrar == false)
                {
                    MessageBox.Show("Usuario Registrado con exito", "SISGEN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Registro rg = new Registro();
                    this.Hide();
                    rg.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("No puedes dejar ningún campo vacio", "SISGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Registro rg = new Registro();
                this.Hide();                
                rg.ShowDialog();           
                this.Close();
            }
        }
    }
}
