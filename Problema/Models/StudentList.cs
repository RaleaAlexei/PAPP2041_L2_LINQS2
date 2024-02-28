using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema.Models
{
    public class StudentList
    {
        public static ObservableCollection<Student> LoadSampleData()
        {
            return new ObservableCollection<Student>
            {
            new Student("Ana Maria", new DateTime(2000, 5, 15), new List<double> { 8.5, 9.2, 7.8 }),
            new Student("Ion Andrei", new DateTime(1999, 9, 10), new List<double> { 7.0, 6.5, 8.0 }),
            new Student("Maria Elena", new DateTime(2001, 3, 25), new List<double> { 9.0, 8.7, 9.5 }),
            new Student("Ioana Mihaela", new DateTime(2002, 6, 18), new List<double> { 8.0, 7.5, 8.2 }),
            new Student("Andrei Mihai", new DateTime(2000, 11, 8), new List<double> { 7.5, 8.0, 8.5 }),
            new Student("Elena Nicoleta", new DateTime(2001, 2, 20), new List<double> { 9.2, 8.8, 9.7 }),
            new Student("Mihai Alexandru", new DateTime(1999, 7, 30), new List<double> { 6.8, 7.2, 6.5 }),
            new Student("Cristina Ioana", new DateTime(2000, 9, 5), new List<double> { 8.3, 8.5, 7.9 }),
            new Student("Radu Andrei", new DateTime(2001, 4, 12), new List<double> { 7.9, 8.1, 7.5 })
            };
        }
    }
}
