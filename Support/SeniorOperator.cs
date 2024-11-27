using System;
using System.Security.Cryptography;
using SupportChainnamespace;

namespace Support;

/// <summary>
/// Класс старшего оператора саппорта
/// </summary>

class SeniorOperator : SupportChain
{
    IObservable _observable { get; set;}
    public SeniorOperator(IObservable observable)
    {
        _observable=observable;
    }

    protected override bool CanResolveTask()
    {
        var r=new Random();
        if (r.Next(0,2) == 1)
        {
            return true;
        }
        return false;
    }

    protected override void WriteMessage(string msg)
    {
        Console.WriteLine($"{msg} resolved by Senior Operator");
        _observable.Notify("Задача решена старшим оператором"); //послать нотификацию
    }
}