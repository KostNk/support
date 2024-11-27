using System;
using System.Security.Cryptography;
using SupportChainnamespace;

namespace Support;

/// <summary>
/// Класс начальника отдела поддержки
/// </summary>

class BossOperator : SupportChain, IObserver
{

    public string Name { get; }

    public BossOperator(string name)
    {
        Name = name;
    }

    public void Update(string msg)
    {
        Console.WriteLine($"{Name} получил уведомление: {msg}");
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
        Console.WriteLine($"{msg} resolved by Boss Operator");
    }
}


