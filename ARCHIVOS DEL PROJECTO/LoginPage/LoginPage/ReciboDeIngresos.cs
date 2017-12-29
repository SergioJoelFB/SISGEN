using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class ReciboDeIngresos : MetroFramework.Forms.MetroForm
    {
        public ReciboDeIngresos()
        {
            InitializeComponent();
        }

        private void ReciboDeIngresos_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Invocar al PhotoViewer para ver imagnes....
            Process photoViewer = new Process();
            photoViewer.StartInfo.FileName = @"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\";
            photoViewer.StartInfo.Arguments = @"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\";
            photoViewer.Start();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO SE Guardaran los Cambios", "Se perdieron los cambios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            PaginaPrincipal df = new PaginaPrincipal();
            df.ShowDialog();
            this.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

             this.menuStrip1.Hide();

            //Funcion que sale de la Clase ScreenCapture..
            var image = ScreenCapture.CaptureActiveWindow();
            image.Save(@"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\RECIBOPAGOS\HojaControl.jpg", ImageFormat.Jpeg);

            //La Libreria PDfSharp.
            PdfDocument doc = new PdfDocument();
            PdfPage opage = new PdfPage();
            doc.Pages.Add(opage);
            opage.Width = 700;
            opage.Height = 644;
            opage.Rotate = 90;
            XGraphics xgr = XGraphics.FromPdfPage(opage);
            XImage img = XImage.FromFile(@"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\RECIBOPAGOS\HojaControl.jpg");
            xgr.DrawImage(img, 0, 0);

            //Invoca al Explorador de Archivos..
            SaveFileDialog a = new SaveFileDialog();
            a.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = a.ShowDialog();
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(a.FileName);
                doc.Close();
            }

            MessageBox.Show("Guardado Correctamente", "SISGEN - Formulario Hoja Control Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ReciboDeIngresos_MouseClick(object sender, MouseEventArgs e)
        {
           menuStrip1.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nuevo nv = new Nuevo();
            nv.ShowDialog();
            this.Close();
        }

        private void ReciboDeIngresos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            menuStrip1.Show();
        }
    }
}
