using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApp10
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

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaYolu = string.Empty;
            Bitmap bmp = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = openFileDialog1.FileName;
                bmp = new Bitmap(dosyaYolu);
                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int y = 0; y < bmp.Height; y++) //Pixelleri boyuna olarak tarar.
            {
                for (int x = 0; x < bmp.Width; x++)//Pixelleri yatay olarak tarar.
                {
                    Color eski = bmp.GetPixel(x, y); //Sıradaki pixeli alır.
                    int ortalama = (eski.R + eski.G + eski.B) / 3; //ele alınan pixelin RGB kodlarının ortalamasını alır.
                    Color yeni = Color.FromArgb(eski.A, ortalama, ortalama, ortalama);//Bulunan ortalamanın RGB olarak renk değerini alır.
                    bmp.SetPixel(x, y, yeni);//Pixele yeni RGB kodlarını atar ve pixeli eski yerine koyar.
                }
            }
            pictureBox1.Image = bmp;
        }

    }
}
