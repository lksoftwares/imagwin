using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAcroPDFLib;
using PdfiumViewer;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public Form2()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "pdf files (*.pdf) |*.pdf";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    openfilename(ofd.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("an error occcure");
                }

            }
        }

        public void openfilename(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pd = PdfDocument.Load(stream);
            pdf.Document = pd;
        }

    }
}
