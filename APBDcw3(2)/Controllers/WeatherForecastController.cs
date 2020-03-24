using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBDcw3_2_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APBDcw3_2_.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        //[HttpGet("{id}")]
        public string GetStudent(string orderBy)
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }

        [HttpPost]
        public IActionResult CreateStudent(Studen student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
                return Ok(student);
        }
    }
}