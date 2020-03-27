using System;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1...
            Console.WriteLine("Task 1...");
            Console.Write("Введите сумму покупки: ");
            decimal _pay = Convert.ToDecimal(Console.ReadLine()); //Сумма покупки
            decimal _discount = 0m; //Скидка
            if(_pay > 500)
               _discount = 3m;
            else if (_pay > 1000)
                _discount = 5m;
            ////////////////////////////////////////////////
        }
    }
}
