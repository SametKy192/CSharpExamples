using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1.Data
{
    public interface IStudentReader
    {
        IEnumerable<Student> GetAll();
    }
}
