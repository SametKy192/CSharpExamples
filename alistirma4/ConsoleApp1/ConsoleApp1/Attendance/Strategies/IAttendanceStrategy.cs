using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1.Attendance.Strategies
{
    public interface IAttendanceStrategy
    {
        IEnumerable<Student> Enumerate(IEnumerable<Student> source);
    }
}
