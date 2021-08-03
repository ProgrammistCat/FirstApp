using System;





namespace FirstApp
{
    public class StringLabs
    {
        private static string First { get; set; }
        private static string Second { get; set; }


        public static void ReadValues()
        {
            Console.WriteLine("Первая строка: ");
            string first = Console.ReadLine();
            
            Console.WriteLine("Вторая строка: ");
            string second = Console.ReadLine();
        }


        private static void DisplayAnswer(string answer)
        {
            Console.WriteLine(answer);
        }

        private static void DisplayAnswer(bool result)
        {
            string answer = "";
            
            if (result)
            {
                answer = "Условие выполнено";
            }
            else
            {
                answer = "Условие не выполнено";
            }
            
            DisplayAnswer(answer);
        }
        
        
        // Сигнатура метода (void, DisplayAnswer, string)
        
        // Перегрузка метода
        
        
        public static void Lab1()
        {
            // 1.Если в A есть символы из B
            
            ReadValues();
            
            bool result = StringAlgorithms.Lab1(First, Second);

            DisplayAnswer(result);
        }

        public static void Lab2()
        {
            // 2.Если все символы A входят в B
            
            ReadValues();
            
            bool result = StringAlgorithms.Lab2(First, Second);
            
            DisplayAnswer(result);
        }

        public static void Lab3()
        {
            // 3.Если в A есть русские буквы

            ReadValues();
            
            bool result = StringAlgorithms.Lab3(First, Second);
            
            DisplayAnswer(result);
        }
        
        public static void Lab4()
        {
            // 4.Если в A есть знаки препинания
            
            ReadValues();
            
            bool result = StringAlgorithms.Lab4(First, Second);
            
            DisplayAnswer(result);
        }
        
        public static void Lab5()
        {
            // 5. Если строки состоят из одних и тех же символов
            
            // Перебор первой строки
            // каждый ее символы сравнивается с символом второй строки
            // если находится те, которые есть в A, но нет в B - false
        }
        
        public static void Lab6()
        {
            // 6. Если в B нет повторяющихся символов
            
            ReadValues();
            
            bool result = StringAlgorithms.Lab6(First, Second);
            
            DisplayAnswer(result);
        }
    }
}