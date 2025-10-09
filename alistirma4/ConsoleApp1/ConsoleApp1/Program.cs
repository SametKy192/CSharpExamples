using System;
using System.Linq;
using ConsoleApp1.Models;
using ConsoleApp1.Data;
using ConsoleApp1.Attendance;
using ConsoleApp1.Attendance.Strategies;
using ConsoleApp1.Notifiers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veri katmanı (DIP)
            IStudentReader reader = new InMemoryStudentReader();
            var students = reader.GetAll().ToList();

            // Tüm öğrenciler
            Console.WriteLine("Tüm öğrenciler:");
            foreach (var s in students)
                Console.WriteLine($"{s.Id}: {s.Name} | Yaş: {s.Age} | Not: {s.Grade}");

            // LINQ 80+
            var goodStudents = students.Where(s => s.Grade >= 80);
            Console.WriteLine("\nNotu 80 ve üzeri olan öğrenciler:");
            foreach (var s in goodStudents)
                Console.WriteLine($"{s.Name} - {s.Grade}");

            // Yaşa göre sıralama
            var orderedByAge = students.OrderBy(s => s.Age);
            Console.WriteLine("\nYaşa göre sıralama (küçükten büyüğe):");
            foreach (var s in orderedByAge)
                Console.WriteLine($"{s.Name} - Yaş: {s.Age}");

            // Stack stratejisi
            var stackManager = new AttendanceManager(
                new StackStrategy(),
                new ConsoleAttendanceNotifier());

            Console.WriteLine("\nStack ile yoklama (LIFO):");
            stackManager.Run(students);

            // Queue stratejisi
            var queueManager = new AttendanceManager(
                new QueueStrategy(),
                new ConsoleAttendanceNotifier());

            Console.WriteLine("\nQueue ile yoklama (FIFO):");
            queueManager.Run(students);
        }
        
    }
}
