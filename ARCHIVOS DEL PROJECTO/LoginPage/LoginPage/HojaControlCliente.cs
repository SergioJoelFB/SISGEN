using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using iTextSharp.text;

namespace LoginPage
{
    public partial class HojaControlCliente : MetroFramework.Forms.MetroForm
    {
     
        public HojaControlCliente()
        {
            InitializeComponent();
        }

        private void HojaControlCliente_Load(object sender, EventArgs e)
        {
          
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO SE Guardaran los Cambios", "Se perdieron los cambios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            PaginaPrincipal df = new PaginaPrincipal();
            df.ShowDialog();
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Invocar al PhotoViewer para ver imagnes....
            Process photoViewer = new Process();
            photoViewer.StartInfo.FileName = @"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\";
            photoViewer.StartInfo.Arguments = @"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\";
            photoViewer.Start();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            menuStrip1.Visible = false;

            //Funcion que sale de la Clase ScreenCapture..
            var image = ScreenCapture.CaptureActiveWindow();
            image.Save(@"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\HOJACONTROLCLIENTES\HojaControl.jpg", ImageFormat.Jpeg);
            
            //La Libreria PDfSharp.
            PdfDocument doc = new PdfDocument();
            PdfPage opage = new PdfPage();
            doc.Pages.Add(opage);
            opage.Width = 750;
            opage.Height = 644;
            opage.Rotate = 90;
            XGraphics xgr = XGraphics.FromPdfPage(opage);
            XImage img = XImage.FromFile(@"C:\Users\hp15\Documents\SISGEN PROJECT\FORMULARIOS\HOJACONTROLCLIENTES\HojaControl.jpg");
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

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Nuevo nv = new Nuevo();
            nv.ShowDialog();
            this.Close();
        }

        private void HojaControlCliente_MouseClick(object sender, MouseEventArgs e)
        {
            menuStrip1.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "X";
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "X";
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox8.Text = "X";
        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {
            textBox11.Text = "X";
           
        }

        private void textBox10_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBox10.Text = "X";
        }

        private void textBox14_MouseClick(object sender, MouseEventArgs e)
        {
            textBox14.Text = "X";
        }

        private void textBox16_MouseClick(object sender, MouseEventArgs e)
        {
            textBox16.Text = "X";
        }

        private void textBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox8.Text = "";
        }

        private void textBox11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox11.Text = "";
        }

        private void textBox10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = "";
        }

        private void textBox14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox14.Text = "";
        }

        private void textBox16_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox16.Text = "";
        }

        private void textBox5_CursorChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
 