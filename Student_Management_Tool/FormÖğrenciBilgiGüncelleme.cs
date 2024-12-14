using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_Tool.Data; 

namespace Student_Management_Tool
{
    public partial class FormÖğrenciBilgiGüncelleme : Form
    {
        StudentManagementContext _context;
        public FormÖğrenciBilgiGüncelleme(StudentManagementContext context)
        {
            _context = context;
            InitializeComponent();
        }
        private void LoadImageFromBytes(byte[] imageBytes)
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    // Byte dizisinden bir Image nesnesi oluştur
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Fotoğraf verisi boş!");
            }
        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            //var student = _context.Ogrenciler.Where(x =>
            //x.OgrenciNumarasi == Convert.ToInt32(textBox1.Text)).ToList();
            //if (student.Count == 0)
            //{
            //    MessageBox.Show("Öğrenci bulunamadı.");
            //    return;
            //}
            //LoadImageFromBytes(student[0].Fotoğraf);
            //label12.Text = student[0].Isim + student[0].Soyisim;
            //textBox4.Text = student[0].Email;
            //textBox5.Text = student[0].TelefonNumarasi;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var student = _context.Ogrenciler.Where(x =>
            x.OgrenciNumarasi == Convert.ToInt32(textBox1.Text)).ToList();

            student[0].Email = textBox4.Text;
            student[0].TelefonNumarasi = textBox5.Text;

            _context.SaveChanges();

            MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            //var student = _context.Students.Where(x =>
            // x.StudentNbr == Convert.ToInt32(textBox1.Text)).ToList();

            //dataGridView1.DataSource = null;

            //_context.Students.Remove(student[0]);
            //_context.SaveChanges();
            //MessageBox.Show("Öğrenci başarıyla silindi.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonAra_Click_1(object sender, EventArgs e)
        {
            var student = _context.Ogrenciler.Where(x =>
            x.OgrenciNumarasi == Convert.ToInt32(textBox1.Text)).ToList();
            if (student.Count == 0)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }
            LoadImageFromBytes(student[0].Fotoğraf);
            label12.Text = student[0].Isim + " " + student[0].Soyisim;
            textBox4.Text = student[0].Email;
            textBox5.Text = student[0].TelefonNumarasi;
            label2.Text = student[0].Bölüm;
        }
    }
}
