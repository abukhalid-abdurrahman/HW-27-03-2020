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
            string _discountStr = "";
            if(_pay >= 500 && _pay <= 1000)
            {
                _discount = 3m;
                _discountStr = "3-х";
            }
            else if (_pay > 1000)
            {
                _discount = 5m;
                _discountStr = "5-ти";
            }
            
            if(_pay > 500)
                Console.WriteLine($"Итог с {_discountStr} процентной скидкой: " + (_pay - ((_pay * _discount) / 100)));
            else
                Console.WriteLine($"Покупка на сумму {_pay} не предоставляет скидки!");
            ////////////////////////////////////////////////

            //Task 2...
            Console.WriteLine("Task 2...");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            if(!(A < B && B < C && C < D) && !(A == B && B == C && C == D))
            {
                Console.WriteLine("Числа не расположены по возрастанию!");
                if(A < B && A < C && A < D)
                {
                    Console.WriteLine("Наименьшее Число: " + A);
                }
                
                if(B < A && B < C && B < D)
                {
                    Console.WriteLine("Наименьшее Число: " + B);
                }

                if(C < A && C < B && C < D)
                {
                    Console.WriteLine("Наименьшее Число: " + C);
                }

                if(D < A && D < C && D < B)
                {
                    Console.WriteLine("Наименьшее Число: " + D);
                }
            }
            if(A == B && B == C && C == D)
            {
                Console.WriteLine("Числа равны, их произведение " + (A * B * C * D));
            }
            if(A < B && B < C && C < D)
            {
                Console.WriteLine("Числа расположены по возрастанию!");
            }
            ///////////////////////////////////////////////
        }
    }
}
