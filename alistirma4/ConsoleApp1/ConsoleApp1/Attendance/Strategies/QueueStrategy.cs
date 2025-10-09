using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1.Attendance.Strategies
{
    public class QueueStrategy : IAttendanceStrategy
    {
        public IEnumerable<Student> Enumerate(IEnumerable<Student> source)
        {
            var queue = new Queue<Student>(source);
            while (queue.Count > 0)
                yield return queue.Dequeue(); // FIFO
        }
    }
}
