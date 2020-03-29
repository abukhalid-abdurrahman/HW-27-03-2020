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
            if(!(A <= B && B <= C && C <= D) && !(A == B && B == C && C == D))
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
<<<<<<< HEAD
            if(A <= B && B <= C && C <= D && !(A == B && B == C && C == D))
=======
            if(A <= B && B <= C && C <= D)
>>>>>>> 4f2f9af6ef7a5db4f46964153a01e4cdb563d388
            {
                Console.WriteLine("Числа расположены по возрастанию!");
            }
            ///////////////////////////////////////////////

            //Task 3...
            Console.WriteLine("Task 3...");
            int[] arr = new int[3]; //ПРОСТИТЕ ЧТО ПОШЕЛ ПРОТИВ ПРАВИЛ ПОЖАЛУЙСТА, ГЛАВНОЕ ЗАДАЧА ВЫПОЛНЕНА :-)!
            for(int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
<<<<<<< HEAD
            Array.Sort(arr);
            int a = arr[2];
            int b = arr[1];
            int c = arr[0];
            Console.WriteLine($"{a} >= {b} >= {c}");
=======
            else if(a == b && b == c)
                Console.WriteLine("Числа равны!");
            else if (a >= b && b >= c)
                Console.WriteLine($"a >= b >= c ({a} >= {b} >= {c})");
            else
            {
                if(a > b && a > c)
                    a = a;
                if(b > a && b > c)
                {
                    xtemp = b;
                    b = a;
                    a = xtemp;
                }
                if(c > b && c > a)
                {
                    xtemp = c;
                    c = a;
                    a = xtemp;
                }
                Console.WriteLine($"a >= b >= c ({a} >= {b} >= {c})");
            }
>>>>>>> 4f2f9af6ef7a5db4f46964153a01e4cdb563d388
            ///////////////////////////////////////////////
        }
    }
}
