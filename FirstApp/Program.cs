using System;
using System.Security;

namespace FirstApp
{

    class Player
    {
        /*
         * Свойства
         * Методы
         */


        public string Name { get; set; }
        public int Level { get; set; }


        public void Walk()
        {
            Console.WriteLine($"Игрок ({Name})  - Идет.");
        }
        
        public int IntMethod()
        {
            return 1;
        }

    }

    class Enemy
    {
        public void Walk()
        {
            Console.WriteLine("Враг - Идет");
        }
    }


    // class Animal
    // {
    //     public string Title { get; set; }
    //     public string Name { get; set; }
    //     public int Age { get; set; }
    // }
    //
    //
    //
    // class Penguin : Animal
    // {
    //     public void Swim()
    //     {
    //         Console.WriteLine($"{Name} - плывет");
    //     }
    // }
    //
    // class Cat : Animal
    // {
    //     public void Run()
    //     {
    //         Console.WriteLine($"{Name} - бежит");
    //     }
    // }
    //
    // class Parrot : Animal
    // {
    //     public void Fly()
    //     {
    //         Console.WriteLine($"{Name} - летит");
    //     }
    // }

    class Sweets
    {
        public string Title { get; set; }
        public string Taste { get; set; }
    }

    
    
    class IceCream : Sweets
    {
        public void Melt()
        {
            Console.WriteLine($"{Title + Taste} - тает");
        }
    }
    
    class Cookie : Sweets
    {
        public void Crunch()
        {
            Console.WriteLine($"{Title + Taste} - хрустит");
        }
    }
    
    class Gum : Sweets
    {
        public void Stretch()
        {
            Console.WriteLine($"{Title + Taste} - тянется");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringLabs.Lab2();

            // Если ни один символ A не входит в B,
            // то упорядочить символы A в алфавитном порядке;
            // в остальных случаях упорядочить символы A в порядке,обратном к алфавитному


            // char

            // string str = "Hello";
            //
            // for (int i = 0; i < str.Length; i++)
            // {
            //     Console.WriteLine(str[i]);
            // }


            // Console.WriteLine("Первая строка: ");
            // string first = Console.ReadLine();
            //
            // Console.WriteLine("Вторая строка: ");
            // string second = Console.ReadLine();
            //
            // bool flag = false;

            // for (int i = 0; i < first.Length; i++)
            // {
            //     for (int j = i + 1; j < second.Length; j++)
            //     {
            //         if (first[i] == second[j])
            //         {
            //             flag = true;
            //         } 
            //     }
            // }
            //
            //
            // char[] charArray = first.ToCharArray();
            //
            // if (flag)
            // {
            //     // обратный алф
            //     for (int i = 0; i < charArray.Length - 1; i++)
            //     {
            //         for (int j = i + 1; j < charArray.Length; j++)
            //         {
            //             if (charArray[i] < charArray[j])
            //             {
            //                 char temp = charArray[i];
            //                 charArray[i] = charArray[j];
            //                 charArray[j] = temp;
            //             } 
            //         }
            //     }
            // }
            // else
            // {
            //     // алф
            //     for (int i = 0; i < charArray.Length - 1; i++)
            //     {
            //         for (int j = i + 1; j < charArray.Length; j++)
            //         {
            //             if (charArray[i] > charArray[j])
            //             {
            //                 char temp = charArray[i];
            //                 charArray[i] = charArray[j];
            //                 charArray[j] = temp;
            //             } 
            //         }
            //     }
            // }
            //
            // // string result = charArray.ToString();
            // // Console.WriteLine(result);
            //
            //
            // string result = "";
            // for (int i = 0; i < charArray.Length; i++)
            // {
            //     result += charArray[i];
            // }
            //
            // Console.WriteLine("Результат решения задания:");
            //
            // Console.WriteLine(result);





            // int[] arr = {1, 2, 3};
            // int[] arr1 = new int[] {1, 2, 3};
            // int[] arr2 = new int[3] {1, 2, 3};

            // Console.WriteLine(arr[0]); // 1


            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }

            // string list = "";
            //
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (i != arr.Length - 1)
            //     {
            //         list += arr[i] + ", ";
            //     }
            //     else
            //     {
            //         list += arr[i] + ".";
            //     }
            // }
            //
            // Console.WriteLine(list);


            // Penguin penguinFirst = new Penguin();
            // penguinFirst.Name = "Вася";
            // penguinFirst.Age = 1;
            // penguinFirst.Title = "пингвин";
            //
            // Penguin penguinSecond = new Penguin();
            // penguinSecond.Name = "Игорь";
            // penguinSecond.Age = 1;
            // penguinSecond.Title = "пингвин";
            //
            // Parrot parrotFirst = new Parrot();
            // parrotFirst.Name = "Петя";
            // parrotFirst.Age = 2;
            // parrotFirst.Title = "попугай";
            //
            // Parrot parrotSecond = new Parrot();
            // parrotSecond.Name = "Кеша";
            // parrotSecond.Age = 3;
            // parrotSecond.Title = "попугай";
            //
            // Cat catFirst = new Cat();
            // catFirst.Name = "Бусинка";
            // catFirst.Age = 7;
            // catFirst.Title = "кошка";
            //
            // Cat catSecond = new Cat();
            // catSecond.Name = "Белок";
            // catSecond.Age = 4;
            // catSecond.Title = "кот";
            //
            //
            //
            //
            // penguinFirst.Swim();
            // penguinSecond.Swim();
            //
            // parrotFirst.Fly();
            // parrotSecond.Fly();
            //
            // catFirst.Run();
            // catSecond.Run();

            // IceCream iceCreamFirst = new IceCream();
            // iceCreamFirst.Title = "Мороженое";
            // iceCreamFirst.Taste = " ванильное";
            //
            // IceCream iceCreamSecond = new IceCream();
            // iceCreamSecond.Title = "Мороженое";
            // iceCreamSecond.Taste = " фисташковое";
            //
            // Cookie cookieFirst = new Cookie();
            // cookieFirst.Title = "Печенье";
            // cookieFirst.Taste = " шоколадное";
            //
            // Cookie cookieSecond = new Cookie();
            // cookieSecond.Title = "Печенье";
            // cookieSecond.Taste = " с карамелью";
            //
            // Gum gumFirst = new Gum();
            // gumFirst.Title = "Жвачка";
            // gumFirst.Taste = " клубничная";
            //
            // Gum gumSecond = new Gum();
            // gumSecond.Title = "Жвачка";
            // gumSecond.Taste = " арбузная";
            //
            //
            //
            //
            // iceCreamFirst.Melt();
            // iceCreamSecond.Melt();
            //
            // cookieFirst.Crunch();
            // cookieSecond.Crunch();
            //
            // gumFirst.Stretch();
            // gumSecond.Stretch();



            // int a = 1;
            //
            // Player player1 = new Player();
            // player1.Name = "qwe";
            // player1.Level = 2;
            //
            // Player player2 = new Player();
            // player2.Name = "qwe123";
            // player2.Level = 2;
            //
            // Enemy enemy1 = new Enemy();
            //
            //
            //
            // player1.Walk();
            // player2.Walk();
            // enemy1.Walk();







            #region Comment

            // // // string str = "Hello";
            // //
            // // // Console.WriteLine("Hello");
            // // // Console.WriteLine("Hello");
            // // // Console.Write("He\n");
            // // // Console.Write("llo");
            // //
            // //
            // // // Console.Write("Ваше имя: ");
            // // // string name = Console.ReadLine();
            // // //
            // // // Console.WriteLine("\nПривет, " + name);
            // // //
            // // // ConsoleKeyInfo cki = Console.ReadKey();
            // // // Console.WriteLine(cki.Key.ToString());
            // // // Console.WriteLine(cki.KeyChar);
            // //
            // //
            // // //int a = 3;
            // // //int b = 2;
            // // //Console.WriteLine((double)a / b);
            // //
            // // //Домашка:
            // // // let number1 = prompt('Первое число');
            // // // let number2 = prompt('Второе число');
            // // // alert(
            // // // Числа: ${number1*1} и ${number2*1}
            // // // Сумма этих чисел =  ${number1*1 + number2*1}
            // // // Разность этих чисел = ${number1*1 - number2*1}
            // // // Произведение этих чисел = ${(number1*1) * (number2*1)}
            // // // Частное этих чисел = ${(number1*1) / (number2*1)}
            // // // Число по модулю (результат деления по модулю) этих чисел = ${(number1*1) % (number2*1)}
            // // // );
            // //
            // // Console.Write("Первое число: ");
            // // string text = Console.ReadLine();
            // // int number1 = Int32.Parse(text);
            // // Console.Write("Второе число: ");
            // // string text1 = Console.ReadLine();
            // // int number2 = Int32.Parse(text1);
            // // string sum = $"{number1 + number2}";
            // // Console.Write("Сумма чисел: ");
            // // Console.WriteLine(sum);
            // // string dif = $"{number1 - number2}";
            // // Console.Write("Разность чисел: ");
            // // Console.WriteLine(dif); 
            // // string prо = $"{number1 * number2}";
            // // Console.Write("Произведение чисел: ");
            // // Console.WriteLine(prо);
            // // string pri = $"{number1 / number2}";
            // // Console.Write("Частное чисел: ");
            // // Console.WriteLine(pri);
            // // string rem = $"{number1 % number2}";
            // // Console.Write("Остаток от деления чисел: ");
            // // Console.WriteLine(rem); 
            // //
            // // // let year = prompt('В каком году ты родился? (Напиши просто число)');
            // // // alert(Тебе ${2021 - year*1 - 1}-${2021 - year*1} лет!);
            // //
            // // Console.Write("В каком году ты родился? (Напиши просто число) ");
            // // string text2 = Console.ReadLine();
            // // int year = Int32.Parse(text2);
            // // string result = $" {2021 - year * 1 - 1}-{2021 - year * 1} ";
            // // Console.WriteLine("Тебе" + result + "лет");
            // //
            // // // let name = prompt('Твоё имя?');
            // // // let surname = prompt('Твоя фамилия?');
            // // // let patronymic = prompt('Твоё отчество?');
            // // // alert(Тебя зовут ${surname} ${name} ${patronymic}!); 
            // //
            // // Console.Write("Твоё имя? ");
            // // string name = Console.ReadLine();
            // // Console.Write("Твоя фамилия? ");
            // // string surname = Console.ReadLine();
            // // Console.Write("Твоё отчество? ");
            // // string patronymic = Console.ReadLine();
            // // Console.WriteLine($"Тебя зовут {surname} {name} {patronymic}!");
            //
            // /*
            // * Спросить у пользователя интервал значений
            // * После вывести
            // *  - сумму всех значений в интервале
            // *  - сумму всех чётных в интервале
            // *  - сумму всех нечётных в интервале
            // *  - произведение чётных в интервале
            // *  - произведение нечётных в интервале
            // * (в alert)
            // * */
            //
            // // Console.Write("Числа от... ");
            // // string text3 = Console.ReadLine();
            // // int one = Int32.Parse(text3);
            // // Console.Write("до... ");
            // // string text4 = Console.ReadLine();
            // // int two = Int32.Parse(text4);
            // // int summaAll = 0;
            // // int summaChet = 0;
            // // int summaNechet = 0;
            // // long proizvedenieChet = 1;
            // // long proizvedenieNechet = 1;
            // //
            // // if (one <= two) 
            // // {
            // //     while (one < two)
            // //     {
            // //         summaAll += one * 1;
            // //
            // //         if (one % 2 == 0)
            // //         {
            // //             summaChet += one;
            // //             proizvedenieChet *= one;
            // //         }
            // //         else
            // //         {
            // //             summaNechet += one;
            // //             proizvedenieNechet *= one;
            // //         }
            // //
            // //         one++;
            // //     }
            // //
            // //     Console.WriteLine ($"Сумма всех значений в интервале - {summaAll}");
            // //     Console.WriteLine ($"Сумма всех чётных значений в интервале - {summaChet}");
            // //     Console.WriteLine ($"Сумма всех нечётных значений в интервале - {summaNechet}");
            // //     Console.WriteLine ($"Произведение всех чётных значений в интервале - {proizvedenieChet}");
            // //     Console.WriteLine ($"Произведение всех нечётных значений в интервале - {proizvedenieNechet}");
            // //
            // // } 
            // // else
            // // {
            // //     Console.Write("Ошибка. Первое число должно быть меньше второго, попробуйте ещё раз.");
            // // }

            #endregion




            // bool a = true;
            //
            // if (a)
            // {
            //     int b = 1;
            // }
            //
            // Console.WriteLine(b);


            // int a;
            // Console.WriteLine(a);


            /*
             * Динамическая типизация
             * Статическая (строгая) типизация
             * 
             */


            // JS - функциональный подход
            // C# - объектно-ориентированный подход (ООП)


            /*
             * Класс - описание объекта
             * Объект - сущность
             *
             *
             * 
             */



            //Домашка:




        }
    }
}