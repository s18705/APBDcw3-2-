using APBDcw3_2_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDcw3_2_.DAL
{
    public class MockDbServic : IDbService
    {
        private static IEnumerable<Student> _students;


        static MockDbServic()
       {
            _students = new List<Student>
            {
                new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski"},
                new Student{IdStudent=2, FirstName="Anna", LastName="Malewski"},
                new Student{IdStudent=3, FirstName="Andrzej", LastName="Andrzejewicz"}
            };
        }

        public IEnumerable<Student> GetStudent()
        {
            return _students;
        }
    }
}
