using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Student_Management_Tool.Data;
using Student_Management_Tool.Models;

namespace Student_Management_Tool
{
    public partial class FormÖğrenciEkle : Form
    {
        private readonly StudentManagementContext context;
        public FormÖğrenciEkle(StudentManagementContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] fotoğrafverisi = ImageToByteArray(pictureBox1.Image);
            Öğrenci student = new Öğrenci() //öğrenci noyu string olarak al
            {
                Isim = textBoxİsim.Text,
                Soyisim = textBoxSoyisim.Text,
                Email = textBoxMail.Text,
                TelefonNumarasi = textBoxTelNo.Text,
                Bölüm = comboBox1.Text,
                KayitTarihi = DateTime.Now.Date,
                OgrenciNumarasi = generateStudentNbr(),
                Fotoğraf = fotoğrafverisi
            };
            DepartmanVerileri.AddStudentWithLessons(student);
            context.Ogrenciler.Add(student);
            context.SaveChanges();

            MessageBox.Show("Öğrenci başarıyla eklendi.");
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Görüntüyü bir stream'e kaydediyoruz
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray(); // Byte dizisine dönüştür
            }
        }
        private int generateStudentNbr()
        {
            Random random = new Random();       //1den sırayla gidecek
            int sayi;
            do
            {
                sayi = random.Next(1000, 9999);
            }
            while (context.Ogrenciler.Any(x => x.OgrenciNumarasi == sayi));

            return 240000 + sayi;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFotoğrafSeç_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Title = "Bir Fotoğraf Seçin",
                Filter = "JPG Dosyaları (*.jpg)|*.jpg|PNG Dosyaları (*.png)|*.png"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                string yol = file.FileName;

                try
                {
                    pictureBox1.Image = Image.FromFile(yol);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen sadece resim dosyası seçin." + ex.Message);
                }

            }
        }
    }
}
