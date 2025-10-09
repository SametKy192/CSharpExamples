using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public static class StudentData
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Ali",    Age = 20, Grade = 75 },
                new Student { Id = 2, Name = "Ayşe",   Age = 22, Grade = 90 },
                new Student { Id = 3, Name = "Mehmet", Age = 19, Grade = 60 },
                new Student { Id = 4, Name = "Fatma",  Age = 21, Grade = 85 },
                new Student { Id = 5, Name = "Samet",  Age = 23, Grade = 50 }
            };
        }
    }
}