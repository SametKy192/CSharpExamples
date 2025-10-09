using System;

public class Publisher
{
    public event Action SomethingHappened;

    public void DoWork()
    {
        Console.WriteLine("İş yapılıyor...");
        SomethingHappened?.Invoke();
    }
}
