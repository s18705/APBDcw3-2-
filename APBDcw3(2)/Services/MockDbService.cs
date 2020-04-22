using APBDcw3_2_.Models;
using APBDcw3_2_.Services;
using System.Collections.Generic;

namespace APBDcw3_2_
{
    internal class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students = new List<Student>
        {
            new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski", IndexNumber="s1234"},
            new Student{IdStudent=2, FirstName="Anna", LastName="Malewski", IndexNumber="s2342"},
            new Student{IdStudent=3, FirstName="Krzysztof", LastName="Andrzejewicz", IndexNumber="s5432"}
        };

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

    }
}