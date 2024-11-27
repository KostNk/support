using System;

namespace Support;

/// <summary>
/// Интерфейс наблюдателя
/// </summary>
public interface IObserver
{
    void Update(string msg);
}
