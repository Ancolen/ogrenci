using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Tool.Models
{
    public class Lesson
    {
        public int Id { get; set; } //Primary Key
        public int StudentId { get; set; } //Foreign Key
        public string LessonName { get; set; }
        public int LessonNote { get; set; }

        //Navigation Property
        public Student Student { get; set; }
    }
}
