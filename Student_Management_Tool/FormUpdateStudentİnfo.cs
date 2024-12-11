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
    public partial class FormUpdateStudentİnfo : Form
    {
        StudentManagementContext _context;
        public FormUpdateStudentİnfo(StudentManagementContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            var student = _context.Students.Where(x =>
            x.StudentNbr == Convert.ToInt32(textBox1.Text)).ToList();
            if (student.Count == 0)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }
            textBoxİsim.Text = student[0].Name;
            textBoxSoyisim.Text = student[0].Surname;
            //textBoxÖğrenciNo.Text = student[0].StudentNbr.ToString();
            textBoxMail.Text = student[0].Email;
            textBoxTelNo.Text = student[0].Phone;
            comboBox1.Text = student[0].Bölüm;

            dataGridView1.DataSource = student;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var student = _context.Students.Where(x =>
            x.StudentNbr == Convert.ToInt32(textBox1.Text)).ToList();

            student[0].Name = textBoxİsim.Text;
            student[0].Surname = textBoxSoyisim.Text;
            //student[0].StudentNbr = Convert.ToInt32(textBoxÖğrenciNo.Text);
            student[0].Email = textBoxMail.Text;
            student[0].Phone = textBoxTelNo.Text;
            student[0].Bölüm = comboBox1.Text;

            dataGridView1.DataSource = student;
            _context.SaveChanges();

            MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            var student = _context.Students.Where(x =>
             x.StudentNbr == Convert.ToInt32(textBox1.Text)).ToList();

            dataGridView1.DataSource = null;

            _context.Students.Remove(student[0]);
            _context.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla silindi.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
