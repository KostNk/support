// Chain of Responsibility / Цепочка обязанностей
namespace SupportChainnamespace;

/// <summary>
/// Паттерн - цепочка обязанностей
/// </summary>
abstract class SupportChain
{
    protected SupportChain nextSupport = default!;

    public void SetNext(SupportChain nextSupporter)
    {
        this.nextSupport = nextSupporter;
    }

    public void ResolveTask(string task)
    {
        if (CanResolveTask())
        {
            WriteMessage($"{task}");
        }
        else if (nextSupport != null)
        {
            nextSupport.ResolveTask(task);
        }
        else 
        { 
            Console.WriteLine("Извините, мы не можем решить эту задачу");
        }
    }

    protected abstract bool CanResolveTask();
    protected abstract void WriteMessage(string msg);
}

