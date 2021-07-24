using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string str = "Hello";
            
            // Console.WriteLine("Hello");
            // Console.WriteLine("Hello");
            // Console.Write("He\n");
            // Console.Write("llo");

            
            // Console.Write("Ваше имя: ");
            // string name = Console.ReadLine();
            //
            // Console.WriteLine("\nПривет, " + name);
            //
            // ConsoleKeyInfo cki = Console.ReadKey();
            // Console.WriteLine(cki.Key.ToString());
            // Console.WriteLine(cki.KeyChar);


            //int a = 3;
            //int b = 2;
            //Console.WriteLine((double)a / b);
            
            //Домашка:
            // let number1 = prompt('Первое число');
            // let number2 = prompt('Второе число');
            // alert(
            // Числа: ${number1*1} и ${number2*1}
            // Сумма этих чисел =  ${number1*1 + number2*1}
            // Разность этих чисел = ${number1*1 - number2*1}
            // Произведение этих чисел = ${(number1*1) * (number2*1)}
            // Частное этих чисел = ${(number1*1) / (number2*1)}
            // Число по модулю (результат деления по модулю) этих чисел = ${(number1*1) % (number2*1)}
            // );
            
            Console.Write("Первое число: ");
            string text = Console.ReadLine();
            int number1 = Int32.Parse(text);
            Console.Write("Второе число: ");
            string text1 = Console.ReadLine();
            int number2 = Int32.Parse(text1);
            string sum = $"{number1 + number2}";
            Console.Write("Сумма чисел: ");
            Console.WriteLine(sum);
            string dif = $"{number1 - number2}";
            Console.Write("Разность чисел: ");
            Console.WriteLine(dif); 
            string prо = $"{number1 * number2}";
            Console.Write("Произведение чисел: ");
            Console.WriteLine(prо);
            string pri = $"{number1 / number2}";
            Console.Write("Частное чисел: ");
            Console.WriteLine(pri);
            string rem = $"{number1 % number2}";
            Console.Write("Остаток от деления чисел: ");
            Console.WriteLine(rem); 
            
            // let year = prompt('В каком году ты родился? (Напиши просто число)');
            // alert(Тебе ${2021 - year*1 - 1}-${2021 - year*1} лет!);
            
            Console.Write("В каком году ты родился? (Напиши просто число) ");
            string text2 = Console.ReadLine();
            int year = Int32.Parse(text2);
            string result = $" {2021 - year * 1 - 1}-{2021 - year * 1} ";
            Console.WriteLine("Тебе" + result + "лет");
            
            // let name = prompt('Твоё имя?');
            // let surname = prompt('Твоя фамилия?');
            // let patronymic = prompt('Твоё отчество?');
            // alert(Тебя зовут ${surname} ${name} ${patronymic}!); 
            
            Console.Write("Твоё имя? ");
            string name = Console.ReadLine();
            Console.Write("Твоя фамилия? ");
            string surname = Console.ReadLine();
            Console.Write("Твоё отчество? ");
            string patronymic = Console.ReadLine();
            Console.WriteLine($"Тебя зовут {surname} {name} {patronymic}!");

            /*
            * Спросить у пользователя интервал значений
            * После вывести
            *  - сумму всех значений в интервале
            *  - сумму всех чётных в интервале
            *  - сумму всех нечётных в интервале
            *  - произведение чётных в интервале
            *  - произведение нечётных в интервале
            * (в alert)
            * */
            
            Console.Write("Числа от... ");
            string text3 = Console.ReadLine();
            int one = Int32.Parse(text3);
            Console.Write("до... ");
            string text4 = Console.ReadLine();
            int two = Int32.Parse(text4);
            int summaAll = 0;
            int summaChet = 0;
            int summaNechet = 0;
            int proizvedenieChet = 1;
            int proizvedenieNechet = 1;
            
            if (one <= two) 
            {
                while (one <= two)
                {
                    summaAll += one * 1;

                    if (one % 2 == 0)
                    {
                        summaChet += one * 1;
                        proizvedenieChet *= one * 1;
                    }
                    else
                    {
                        summaNechet += one * 1;
                        proizvedenieNechet *= one * 1;
                    }

                    one++;
                }

                Console.WriteLine ($"Сумма всех значений в интервале - {summaAll}");
                Console.WriteLine ($"Сумма всех чётных значений в интервале - {summaChet}");
                Console.WriteLine ($"Сумма всех нечётных значений в интервале - {summaNechet}");
                Console.WriteLine ($"Произведение всех чётных значений в интервале - {proizvedenieChet}");
                Console.WriteLine ($"Произведение всех нечётных значений в интервале - {proizvedenieNechet}");

            } 
            else
            {
                Console.Write("Ошибка. Первое число должно быть меньше второго, попробуйте ещё раз.");
            }

        }
    }
}