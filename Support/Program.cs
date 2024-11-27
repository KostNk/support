using SupportChainnamespace;

namespace Support;

class Program
{
    static void Main()
    {
        var ns = new NotificationService(); //создаём сервис наблюдателя
        var seniorOperator = new SeniorOperator(ns); // создаём старшего оператора
        var bossOperator  = new BossOperator("Петров Иван"); //создаём начальника службы поддержки
        var operator1 = new Operator(ns); //создаём оператора

        ns.Attach(bossOperator); //Начальник поддержки подписывается на уведомления

        operator1.SetNext(seniorOperator);//выстраиваем цепочку обработки задач. После оператора - старший оператор
        seniorOperator.SetNext(bossOperator);//выстраиваем цепочку обработки задач. После старшего оператора - начальник отдела

        //генерируем задачи
        for (var i=0;i<10;i++)
        {
            operator1.ResolveTask($"Проблема {i}");
        }
        return;
    }
}
