using System;

namespace Support;

public interface IObservable
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string msg);

}
