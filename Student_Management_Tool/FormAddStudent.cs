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
    public partial class FormAddStudent : Form
    {
        private readonly StudentManagementContext context;
        public FormAddStudent(StudentManagementContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student() //öğrenci noyu string olarak al
            {
                Name = textBoxİsim.Text,
                Surname = textBoxSoyisim.Text,
                Email = textBoxMail.Text,
                Phone = textBoxTelNo.Text,
                Bölüm = comboBox1.Text,
                RegistredDate = DateTime.Now.Date,
                StudentNbr = generateStudentNbr()
            };
            DepartmentData.AddStudentWithLessons(student);
            context.Students.Add(student);
            context.SaveChanges();

            MessageBox.Show("Öğrenci başarıyla eklendi.");
        }
        private int generateStudentNbr()
        {
            Random random = new Random();
            int sayi;
            do
            {
                sayi = random.Next(1000, 9999);
            }
            while (context.Students.Any(x => x.StudentNbr == sayi));

            return 240000 + sayi;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
