using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Tool.Models
{
    public class Student
    {
        //code first yaklaşımı ile veritabanı tablosu oluşturulur ve bu tablonun alanları belirlenir
        public int     Id         { get; set; } //Primary Key
        public string? Name       { get; set; }
        public string? Surname    { get; set; }
        public int     StudentNbr { get; set; }
        public string? Email      { get; set; }
        public string? Phone      { get; set; }
        public string? Bölüm      { get; set; }
        public DateTime RegistredDate { get; set; }

        //Navigation Property
        public List<Lesson> Lessons { get; set; }
    }
}
