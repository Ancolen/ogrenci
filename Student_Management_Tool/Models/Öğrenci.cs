using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Tool.Models
{
    public class Öğrenci
    {
        //code first yaklaşımı ile veritabanı tablosu oluşturulur ve bu tablonun alanları belirlenir
        public int     Id              { get; set; } //Primary Key
        public string? Isim            { get; set; }
        public string? Soyisim         { get; set; }
        public int     OgrenciNumarasi { get; set; }
        public string? Email           { get; set; }
        public string? TelefonNumarasi { get; set; }
        public string? Bölüm           { get; set; }
        public DateTime KayitTarihi    { get; set; }
        public byte[] Fotoğraf         { get; set; }

        //Navigation Property
        public List<Ders> Dersler      { get; set; }
    }
}
