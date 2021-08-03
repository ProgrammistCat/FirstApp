using System.Data;

namespace FirstApp
{
    public class StringAlgorithms
    {
        
        // 1.Если в A есть символы из B
        public static bool Lab1(string first, string second)
        {
            bool flag = false;
                        
            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (first[j] == second[i])
                    {
                        flag = true;
                    } 
                }
            }

            return flag;
        }
        
        // 2.Если все символы A входят в B
        
        public static bool Lab2(string first, string second)
        {
            bool flag = false;
            
            bool condition = false;
            
            for (int i = 0; i < first.Length; i++)
            {
                condition = false; 
                
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        condition = true;
                    }
                }
                
                if (condition)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        
        // 3.Если в A есть русские буквы

        public static bool Lab3(string first, string second)
        {
            bool flag = false;

            for (int i = 0; i < first.Length; i++)
            {
                if (((first[i] >= 'а') && (first[i] <= 'я')) || ((first[i] >= 'А') && (first[i] <= 'Я')))
                {
                    flag = true;
                }
            }

            return flag;
        }
        
        // 4.Если в A есть знаки препинания

        public static bool Lab4(string first, string second)
        {
            bool flag = false;

            string symbols = ".,,;:!?-";

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (first[i] == symbols[j])
                    {
                        flag = true;
                    }
                }
            }

            return flag;
        }

        // 5. Если строки состоят из одних и тех же символов
        
        public static bool Lab5(string first, string second)
        {
            bool flag = false;
            
            bool condition = false;
            
            for (int i = 0; i < first.Length; i++)
            {
                condition = false; 
                
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        condition = true;
                    }
                }
                
                if (condition)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
            
        // 6. Если в B нет повторяющихся символов
        
        public static bool Lab6(string first, string second)
        {
            bool flag = true;
                        
            for (int i = 0; i < second.Length; i++)
            {
                for (int j = i + 1; j < second.Length; j++)
                {
                    if (second[i] == second[j])
                    {
                        flag = false;
                    }
                }
            }

            return flag;
        }
    }
}