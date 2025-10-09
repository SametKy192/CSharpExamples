using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class InMemoryStudentReader : IStudentReader
    {
        public IEnumerable<Student> GetAll()
        {
            return StudentData.GetStudents();
        }
    }
}