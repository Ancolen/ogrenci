using Student_Management_Tool.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Tool
{
    
    public partial class FormÖğrenciSil : Form
    {
        private readonly StudentManagementContext _context;
        public FormÖğrenciSil(StudentManagementContext context)
        {
            this._context = context;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = _context.Ogrenciler.Where(x => x.OgrenciNumarasi == Convert.ToInt32(textBox1.Text)).ToList();
            if (student.Count == 0)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }
            _context.Ogrenciler.Remove(student[0]);
            _context.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla silindi.");
        }
    }
}
