using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names=new List<string>();
            //names.Add("Samet");
            //names.Add("Ahmet");
            //Console.WriteLine("Liste Elemanları:");
            //foreach (var name in names)
            //{ 
            // Console.WriteLine(name);
            //}

            //List<object> mixlist=new List<object>();
            //mixlist.Add("Samet");
            //mixlist.Add(1907);
            //mixlist.Add('a');

            //Console.WriteLine("Karışık Liste Elemanları:");
            //foreach (var item in mixlist)
            //{
            //    Console.WriteLine($"{item} (Tür: {item.GetType()})");
            //}


            //ObservableCollection<string> names = new ObservableCollection<string>();

            //names.CollectionChanged += Names_CollectionChanged;

            //names.Add("Samet");
            //names.Add("Ahmet");

            //names.Remove("Ahmet");

            //Console.WriteLine("\nSon liste durumu:");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //Stack<string> stack = new Stack<string>();

            //stack.Push("Birinci");
            //stack.Push("İkinci");
            //stack.Push("Üçüncü");

            //Console.WriteLine("Stack içeriği:");
            //foreach (var item in stack)
            //    Console.WriteLine(item);

            //Console.WriteLine("\nPop ile çıkan: " + stack.Pop()); // Üçüncü
            //Console.WriteLine("Peek ile görülen (kalan): " + stack.Peek()); // İkinci

            //Console.WriteLine("\nStack içeriği (son hali):");
            //foreach (var item in stack)
            //    Console.WriteLine(item);

            //Queue<string> queue = new Queue<string>();
            //// Eleman ekle (Enqueue)
            //queue.Enqueue("İlk İşlem");
            //queue.Enqueue("İkinci İşlem");
            //queue.Enqueue("Üçüncü İşlem");

            //Console.WriteLine("Queue içeriği:");
            //foreach (var item in queue)
            //    Console.WriteLine(item);

            //// Sıradaki elemanı gör (Peek)
            //Console.WriteLine("\nPeek ile görülen sıradaki eleman: " + queue.Peek());

            //// Sıradaki elemanı çıkar (Dequeue)
            //Console.WriteLine("Dequeue ile çıkan eleman: " + queue.Dequeue());

            //Console.WriteLine("\nQueue içeriği (son hali):");
            //foreach (var item in queue)
            //    Console.WriteLine(item);

            //Publisher publisher = new Publisher();
            //publisher.SomethingHappened += () =>
            //{
            //    Console.WriteLine("Olay oldu! Abone tepki verdi.");
            //};
            //publisher.DoWork(); //iş yap

            //LinqExamples ornek = new LinqExamples();
            //ornek.CiftSayilariBul();
            //ornek.KareleriAl();

        }

        private static void Names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"Liste değişti! Action: {e.Action}");
        }
    }
}
