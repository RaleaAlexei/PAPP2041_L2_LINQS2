using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema.Models
{
    public class Failure
    {
        public string Nume {  get; set; }
        public int NumberOfFailure { get; set; }

        public Failure() { }
        public Failure(string nume, int numberOfFailure)
        {
            Nume = nume;
            NumberOfFailure = numberOfFailure;
        }
    }
}
