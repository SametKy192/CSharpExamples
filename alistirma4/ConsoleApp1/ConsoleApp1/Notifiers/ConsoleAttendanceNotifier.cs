using System;
using ConsoleApp1.Models;

namespace ConsoleApp1.Notifiers
{
    public class ConsoleAttendanceNotifier : IAttendanceNotifier
    {
        public void OnArrived(Student s)
        {
            Console.WriteLine($"EVENT -> {s.Name} geldi");
        }
    }
}
