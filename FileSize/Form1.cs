using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void PictureSizeButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(
                "C:\\Users\\Abra\\Desktop\\Фото с выпускного 2019");
            progressBar1.Maximum = dir.GetFiles().Length;
            progressBar1.Value = 0;

            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Name.ToUpper().Contains(".JPG"))
                {
                    Bitmap bmp = (Bitmap)Bitmap.FromFile(file.FullName);
                    Size s = bmp.Size;
                    s.Height = 1280 * s.Height / s.Width;
                    s.Width = 1280;
                    Bitmap b = new Bitmap(Image.FromFile(file.FullName), s);
                    b.Save("C:\\Users\\Abra\\Desktop\\Фото с выпускного 2019\\1\\" + file.Name,
                        System.Drawing.Imaging.ImageFormat.Jpeg);
                    
                    progressBar1.Value++;
                }
            }

            MessageBox.Show("Случилось");
        }

        private void OneLineButton_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("1.txt", Encoding.UTF8);
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                OneLineTextBox.Text += line + Environment.NewLine;
            }

            file.Close();
        }

        private void MultiLineButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("1.txt");
            MultiLineTextBox.Text = File.ReadAllText("1.txt");
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            
            foreach (DriveInfo disk in DriveInfo.GetDrives())
            {
                if (dir.Root.Name == disk.Name)
                {
                    FileInfo f = new FileInfo("1.txt");
                    if (disk.AvailableFreeSpace < f.Length)
                    {
                        MessageBox.Show("Места нет");
                    }
                    else
                    {
                        if (File.Exists("2.txt"))
                        {
                            File.Delete("2.txt");
                        }
                        File.Copy("1.txt", "2.txt");
                        MessageBox.Show("OK");
                    }
                }
            }
        }
    }
}