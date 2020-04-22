using APBDcw3_2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDcw3_2_.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
