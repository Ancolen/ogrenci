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
    public partial class FormNotİşlemleri : Form
    {
        private Öğrenci Ogrenci { get; set; }

        private readonly StudentManagementContext _context;
        public FormNotİşlemleri(StudentManagementContext _context)
        {
            this._context = _context;
            InitializeComponent();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci.Dersler[0].NotVize = Convert.ToInt32(textBox2.Text);
            Ogrenci.Dersler[1].NotVize = Convert.ToInt32(textBox3.Text);
            Ogrenci.Dersler[2].NotVize = Convert.ToInt32(textBox4.Text);
            _context.SaveChanges();
            MessageBox.Show("Notlar başarıyla güncellendi.");
            getData();
        }
        private void getData()
        {
            int studentnbr;
            if (int.TryParse(textBox1.Text, out studentnbr))
            {
                Ogrenci = _context.Ogrenciler.Include(s => s.Dersler)
                    .FirstOrDefault(x => x.OgrenciNumarasi == studentnbr);
                if (Ogrenci != null)
                {
                    var lessonList = Ogrenci.Dersler.Select(lesson => new
                    {
                        StudentName = Ogrenci.Isim,
                        StudentNbr = Ogrenci.OgrenciNumarasi,
                        LessonName = lesson.DersAdi,
                        LessonGrade = lesson.NotVize,
                    }).ToList();
                    dataGridView2.DataSource = lessonList;
                    label2.Text = lessonList[0].LessonName.ToString();
                    label3.Text = lessonList[1].LessonName.ToString();
                    label4.Text = lessonList[2].LessonName.ToString();

                    textBox2.Text = lessonList[0].LessonGrade.ToString();
                    textBox3.Text = lessonList[1].LessonGrade.ToString();
                    textBox4.Text = lessonList[2].LessonGrade.ToString();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci numarası hatalı.");
            }
        }
    }
}
