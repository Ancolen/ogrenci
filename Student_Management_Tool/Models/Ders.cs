using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Tool.Models
{
    public class Ders
    {
        public int Id { get; set; } //Primary Key
        public int OgrenciId { get; set; } //Foreign Key
        public string DersAdi { get; set; }
        public int NotVize { get; set; }
        public int NotFinal { get; set; }

        //Navigation Property
        public Öğrenci Öğrenci { get; set; }
    }
}
