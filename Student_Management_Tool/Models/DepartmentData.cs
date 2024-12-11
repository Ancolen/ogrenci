using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student_Management_Tool.Models
{
    public static class DepartmentData
    {
        public static List<Student> Students = new List<Student>();
        public static Dictionary<string, List<Lesson>> Departments = new Dictionary<string, List<Lesson>>
        {
            {
            "Bilgisayar Programcılığı", new List<Lesson>
            {
                new Lesson { LessonName = "C#", LessonNote = 0 },
                new Lesson { LessonName = "Java", LessonNote = 0 },
                new Lesson { LessonName = "Python", LessonNote = 0 }
            }
            },
            {
                "Fizik", new List<Lesson>
                {
                    new Lesson { LessonName = "Klasik mekanik", LessonNote = 0 },
                    new Lesson { LessonName = "Optik", LessonNote = 0 },
                    new Lesson { LessonName = "Elektromanyetizma", LessonNote = 0 }
                }
            },
            {
                "Astronomi", new List<Lesson>
                {
                    new Lesson { LessonName = "Gözlemsel Astronomi", LessonNote = 0 },
                    new Lesson { LessonName = "Teorik Astronomi", LessonNote = 0 },
                    new Lesson { LessonName = "Astrofizik", LessonNote = 0 }
                }
            }
        };

        public static void AddStudentWithLessons(Student student)
        {
            // Bölüme göre dersleri al
            if (Departments.ContainsKey(student.Bölüm))
            {
                var lessons = Departments[student.Bölüm];

                // Öğrenciye dersleri atama
                student.Lessons = lessons;

                // Dersleri öğrenciye atayarak, her derse ilgili öğrenci bilgisini ekliyoruz
                foreach (var lesson in lessons)
                {
                    lesson.Student = student;
                }

                // Öğrenciyi listeye ekliyoruz
                Students.Add(student);
            }
        }
    }
}
