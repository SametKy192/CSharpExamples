using System;
using System.Collections.Generic;
using ConsoleApp1.Models;
using ConsoleApp1.Attendance.Strategies;
using ConsoleApp1.Notifiers;

namespace ConsoleApp1.Attendance
{
    public class AttendanceManager
    {
        // C# 7.3 uyumlu event
        public event Action<Student> StudentArrived;

        private readonly IAttendanceStrategy _strategy;
        private readonly IAttendanceNotifier _notifier;

        public AttendanceManager(IAttendanceStrategy strategy, IAttendanceNotifier notifier)
        {
            _strategy = strategy;
            _notifier = notifier;
        }

        public void Run(IEnumerable<Student> students)
        {
            foreach (var s in _strategy.Enumerate(students))
            {
                // Event tetikle
                if (StudentArrived != null)
                    StudentArrived(s);

                // Bildirim yap
                _notifier.OnArrived(s);
            }
        }
    }
}
