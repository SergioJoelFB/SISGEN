using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class PaginaPrincipal : MetroFramework.Forms.MetroForm
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HojaControlCliente hcc = new HojaControlCliente();
            hcc.ShowDialog();
            this.Close();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReciboDeIngresos ri = new ReciboDeIngresos();
            ri.ShowDialog();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturaComprobanteFiscal fc = new FacturaComprobanteFiscal();
            fc.ShowDialog();
            this.Close();
        }
    }
}
