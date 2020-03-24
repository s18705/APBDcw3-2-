using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDcw3_2_.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        
        public string FirstName { get; set; }

        public string LasName { get; set; }

        public string IndexNumber { get; set; }
        public string LastName { get; internal set; }
    }
}
