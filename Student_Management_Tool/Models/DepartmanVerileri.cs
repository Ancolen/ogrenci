using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student_Management_Tool.Models
{
    public static class DepartmanVerileri
    {
        public static List<Öğrenci> Students = new List<Öğrenci>();
        public static Dictionary<string, List<Ders>> Departments = new Dictionary<string, List<Ders>>
        {
            {
            "Bilgisayar Programcılığı", new List<Ders>
            {
                new Ders { DersAdi = "C#", NotVize = 0, NotFinal = 0 },
                new Ders { DersAdi = "Java", NotVize = 0, NotFinal = 0 },
                new Ders { DersAdi = "Python", NotVize = 0, NotFinal = 0 }
            }
            },
            {
                "Fizik", new List<Ders>
                {
                    new Ders { DersAdi = "Klasik mekanik", NotVize = 0, NotFinal = 0 },
                    new Ders { DersAdi = "Optik", NotVize = 0, NotFinal = 0 },
                    new Ders { DersAdi = "Elektromanyetizma", NotVize = 0, NotFinal = 0 }
                }
            },
            {
                "Astronomi", new List<Ders>
                {
                    new Ders { DersAdi = "Gözlemsel Astronomi", NotVize = 0, NotFinal = 0 },
                    new Ders { DersAdi = "Teorik Astronomi", NotVize = 0, NotFinal = 0 },
                    new Ders { DersAdi = "Astrofizik", NotVize = 0, NotFinal = 0 }
                }
            }
        };

        public static void AddStudentWithLessons(Öğrenci student)
        {
            // Bölüme göre dersleri al
            if (Departments.ContainsKey(student.Bölüm))
            {
                var lessons = Departments[student.Bölüm];

                // Öğrenciye dersleri atama
                student.Dersler= lessons;

                // Dersleri öğrenciye atayarak, her derse ilgili öğrenci bilgisini ekliyoruz
                foreach (var lesson in lessons)
                {
                    lesson.Öğrenci = student;
                }

                // Öğrenciyi listeye ekliyoruz
                Students.Add(student);
            }
        }
    }
}
