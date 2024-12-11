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
    public partial class FormListStudents : Form
    {
        private readonly StudentManagementContext _context;
        public FormListStudents(StudentManagementContext context)
        {
            InitializeComponent();

            this._context = context;

            var students = _context.Students.ToList();
            dataGridView1.DataSource = students;
        }

        private void buttonİsmeGöreAra_Click(object sender, EventArgs e)
        {
            var filtered = _context.Students.Where(x => x.Name.Contains(textBoxİsmeGöre.Text)).ToList();
            dataGridView1.DataSource = filtered;
        }

        private void buttonBölümeGöreAra_Click(object sender, EventArgs e)
        {
            var filtered = _context.Students.Where(x => x.Bölüm.Contains(textBoxBölümeGöre.Text)).ToList();
            dataGridView1.DataSource = filtered;
        }
    }
}
