

using Student_Management_Tool.Data;

namespace Student_Management_Tool
{
    public partial class FormAnaMenu : Form
    {
        private readonly StudentManagementContext _context; //singleton pattern
        public FormAnaMenu(StudentManagementContext context)
        {
            this._context = context;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddStudent formAddStudent = new FormAddStudent(this._context);
            formAddStudent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListStudents formListStudents = new FormListStudents(this._context);
            formListStudents.Show();
        }

        private void buttonBilgiG�ncelle_Click(object sender, EventArgs e)
        {
            FormUpdateStudent�nfo formUpdate�nfo = new FormUpdateStudent�nfo(this._context);
            formUpdate�nfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNot��lemleri formNot��lemleri = new FormNot��lemleri(this._context);
            formNot��lemleri.Show();
        }
    }
}
