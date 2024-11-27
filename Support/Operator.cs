using System;
using System.Security.Cryptography;
using SupportChainnamespace;

namespace Support;

/// <summary>
/// Класс рядового оператора саппорта
/// </summary>

class Operator : SupportChain
{
    IObservable _observable { get; set;}
    protected override bool CanResolveTask()
    {
        var r=new Random();
        if (r.Next(0,2) == 1)
        {
            return true;
        }
        return false;
    }
    public Operator(IObservable observable)
    {
        _observable=observable;
    }

    protected override void WriteMessage(string msg)
    {
        Console.WriteLine($"{msg} resolved by Operator");
        _observable.Notify("Задача решена оператором"); //послать уведомление наблюдателям
    }
}