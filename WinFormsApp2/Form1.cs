using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public string imagestorefolder = "F:\\vs2022\\imagewin\\WinFormsApp2\\Public\\images\\";
        public string existingimagename = "d23db23d-eeeb-41de-972d-2f2fc08a9a8e.jpg";


        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " jpg files(*.jpg)|*jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                dialog.Filter = "pdf files (*.pdf) |*.pdf|All Files|*.jpg;*.png;*.pdf;*.doc;*.docx;*.xlsx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pictureBox1.ImageLocation = imagelocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("an error occure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToPublic_Click(object sender, EventArgs e)
        {
            string imagefilename = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " jpg files(*.jpg)|*jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagefilename = System.IO.Path.GetFileName(dialog.FileName);
                    //imagelocation = dialog.FileName;
                    pictureBox1.ImageLocation = dialog.FileName;
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imagefilename);
                    //ImageFileNames = fileName;

                    File.Copy(dialog.FileName, Path.Combine(imagestorefolder, fileName), true);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("an error occure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string imagefilename = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG (*.png)|*.png|All files(*.*)|*.";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //string path = Path.Combine(imagestorefolder + imagefilename);
                    imagefilename = System.IO.Path.GetFileName(dialog.FileName);
                    pictureBox1.ImageLocation = (dialog.FileName);
                    //MessageBox.Show(dialog.FileName);
                    string a = System.IO.Path.GetDirectoryName(dialog.FileName);
                    MessageBox.Show(a);
                    byte[] newimagebyte = File.ReadAllBytes(dialog.FileName);
                    byte[] existingimagebyte = File.ReadAllBytes(Path.Combine(imagestorefolder + existingimagename));
                    if (!ArraysAreEqual(newimagebyte, existingimagebyte))
                    {

                        File.Delete(imagestorefolder + existingimagename);
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imagefilename);
                        //imagefilename = fileName;

                        File.Copy(dialog.FileName, Path.Combine(imagestorefolder, fileName), true);
                    }
                    else
                    {
                        MessageBox.Show("file not modified");

                    }



                }

            }
            catch (Exception)
            {
                MessageBox.Show("An error ocure ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ArraysAreEqual(byte[] array1, byte[] array2)
        {
            if (array1 == null || array2 == null || array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            //ofd.Filter = "pdf files (*.pdf) |*.pdf";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    // System.Diagnostics.Process.Start(ofd.FileName);

                    //string path= ofd.FileName;
                    axAcropdf2.src = ofd.FileName;
                    //axAcropdf1.Visible = true;
                    //axAcropdf1.gotoFirstPage();
                    //axAcroPDF1.LoadFile(ofd.FileName);
                    //axAcroPDF1.Show();


                }
                catch (Exception)
                {
                    MessageBox.Show("an error occcure");
                }

            }
        }



        //private void button3_Click(object sender, EventArgs e)
        //{

        //    {
        //        OpenFileDialog dlg = new OpenFileDialog();

        //        dlg.Filter = "PDF files (*.PDF)|*.PDF|All files (*.*)|*.*";
        //        dlg.ShowDialog();
        //        if (dlg.FileName != null)
        //        {

        //            axAcropdf1.LoadFile(dlg.FileName);
        //        }
        //    }
        //}
        private void axAcropdf1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }

        private void axAcropdf1_Enter_1(object sender, EventArgs e)
        {

        }

        private void axAcropdf1_Enter_2(object sender, EventArgs e)
        {

        }

        private void axAcropdf2_Enter(object sender, EventArgs e)
        {

        }
    }

}












