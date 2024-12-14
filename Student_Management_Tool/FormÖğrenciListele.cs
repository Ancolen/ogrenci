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
    public partial class FormÖğrenciListele : Form
    {
        private readonly StudentManagementContext _context;
        public FormÖğrenciListele(StudentManagementContext context)
        {
            InitializeComponent();

            this._context = context;

            var filtered = _context.Ogrenciler
                .Where(x => x.Bölüm.Contains(textBoxBölümeGöre.Text))
                .Select(x => new
                {
                    x.Id,
                    x.Isim,
                    x.Soyisim,
                    x.OgrenciNumarasi,
                    x.Email,
                    x.TelefonNumarasi,
                    x.Bölüm,
                    x.KayitTarihi
                    // Fotoğraf sütunu burada dahil edilmez.
                })
                .ToList();
            dataGridView1.DataSource = filtered;
        }

        //private void buttonİsmeGöreAra_Click(object sender, EventArgs e)
        //{
        //    var filtered = _context.Ogrenciler.Where(x => x.Isim.Contains(textBoxİsmeGöre.Text)).ToList();
        //    dataGridView1.DataSource = filtered;
        //}

        private void buttonBölümeGöreAra_Click(object sender, EventArgs e)
        {
            if (textBoxİsmeGöre.Text == "")
            {
                var filtered = _context.Ogrenciler
                    .Where(x => x.Bölüm.Contains(textBoxBölümeGöre.Text))
                    .Select(x => new
                    {
                        x.Id,
                        x.Isim,
                        x.Soyisim,
                        x.OgrenciNumarasi,
                        x.Email,
                        x.TelefonNumarasi,
                        x.Bölüm,
                        x.KayitTarihi
                        // Fotoğraf sütunu burada dahil edilmez.
                    })
                    .ToList();
                if (filtered.Count == 0)
                    MessageBox.Show("ogrenci bulunamadi");
                dataGridView1.DataSource = filtered;
                textBoxBölümeGöre.Text = "";
            }
            else if (textBoxBölümeGöre.Text == "")
            {
                var filtered = _context.Ogrenciler
                .Where(x => x.Isim.Contains(textBoxİsmeGöre.Text))
                .Select(x => new
                {
                    x.Id,
                    x.Isim,
                    x.Soyisim,
                    x.OgrenciNumarasi,
                    x.Email,
                    x.TelefonNumarasi,
                    x.Bölüm,
                    x.KayitTarihi
                    // Fotoğraf sütunu burada dahil edilmez.
                })
                .ToList();
                if (filtered.Count == 0)
                    MessageBox.Show("ogrenci bulunamadi");
                dataGridView1.DataSource = filtered;
                textBoxİsmeGöre.Text = "";
            }
        }
    }
}
