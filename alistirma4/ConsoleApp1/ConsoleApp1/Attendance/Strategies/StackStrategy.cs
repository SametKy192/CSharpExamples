using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1.Attendance.Strategies
{
    public class StackStrategy : IAttendanceStrategy
    {
        public IEnumerable<Student> Enumerate(IEnumerable<Student> source)
        {
            var stack = new Stack<Student>(source);
            while (stack.Count > 0)
                yield return stack.Pop(); // LIFO
        }
    }
}
