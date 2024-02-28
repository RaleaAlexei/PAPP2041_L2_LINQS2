using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema.Models
{
    public class Student
    {
        public string? Name { get; set; }
        public DateTime DateBirth { get; set; }
        public List<double> Marks { get; set; }
        public Student()
        {
            Name = "";
            DateBirth = new DateTime(1900,1,1);
            Marks = new List<double>();
        }
        public Student(string name, DateTime dateBirth, List<double> marks)
        {
            Name = name;
            DateBirth = dateBirth;
            Marks = marks;
        }
    }
}
