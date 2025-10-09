using ConsoleApp1.Models;

namespace ConsoleApp1.Notifiers
{
    public interface IAttendanceNotifier
    {
        void OnArrived(Student s);
    }
}
