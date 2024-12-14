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
    public partial class FormGiriş : Form
    {
        private readonly StudentManagementContext _context;
        public FormGiriş(StudentManagementContext context)
        {
            this._context = context;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            { 
                FormAnaMenu formAnaMenu = new FormAnaMenu(_context);
                formAnaMenu.Show();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
        }
    }
}
