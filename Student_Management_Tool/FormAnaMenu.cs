

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
            FormÖðrenciEkle formAddStudent = new FormÖðrenciEkle(this._context);
            formAddStudent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormÖðrenciListele formListStudents = new FormÖðrenciListele(this._context);
            formListStudents.Show();
        }

        private void buttonBilgiGüncelle_Click(object sender, EventArgs e)
        {
            FormÖðrenciBilgiGüncelleme formUpdateÝnfo = new FormÖðrenciBilgiGüncelleme(this._context);
            formUpdateÝnfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormÖðrenciSil formÖðrenciSil = new FormÖðrenciSil(this._context);
            formÖðrenciSil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNotÝþlemleri formNotÝþlemleri = new FormNotÝþlemleri(this._context);
            formNotÝþlemleri.Show();
        }
    }
}
