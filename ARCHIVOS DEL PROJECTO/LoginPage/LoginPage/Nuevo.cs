using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Nuevo : MetroFramework.Forms.MetroForm
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {

        }

        private void IniciarBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            HojaControlCliente hc = new HojaControlCliente();
            hc.ShowDialog();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReciboDeIngresos hc = new ReciboDeIngresos();
            hc.ShowDialog();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturaComprobanteFiscal fc = new FacturaComprobanteFiscal();
            fc.ShowDialog();
            this.Close();
        }
    }
}
