using System;

namespace Support;

/// <summary>
/// Паттерн - наблюдатель
/// </summary>
public class NotificationService : IObservable
{

    private readonly List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer) // добавить получателя уведомлений
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer) // исключить получателя уведомлений
    {
        _observers.Remove(observer);
    }

    public void Notify(string msg) // послать уведомление всем наблюдателям
    {
        foreach (var observer in _observers)
        {
            observer.Update(msg);
        }
    }
}
