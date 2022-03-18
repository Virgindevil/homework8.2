using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в телефонную книгу!\n");
                Console.WriteLine("1 - Ввести данные нового владельца");
                Console.WriteLine("2 - Найти владельца по введенному номеру телефона ");
                switch (Console.ReadLine())
                {
                    case "1":
                        CreateNewPersona(pairs);
                        break;

                    case "2":
                        FindAndPrintPerson(pairs);
                        break;

                    default:
                        return;
                }
            }
        }

        #region Логические методы
        static void CreateNewPersona(Dictionary<string, string> persona)
        {
            Console.Clear();
            Console.Write("Введите ФИО Владельца телефона: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nЧтобы закончить ввод телефонов, введите пустую строку");

            while(true)
            {
                Console.Write("Введите телефон владельца: ");
                string number = Console.ReadLine();
                if (number == "")
                {
                    break;
                }
                else
                {
                    persona.Add(number, name);
                }                
            } 
            
            Console.WriteLine("Ввод данных завершён!");
            Console.ReadKey();
        }

        static void FindAndPrintPerson(Dictionary<string, string> persona)
        {
            Console.Clear();
            Console.Write("Введите номер телефона: ");
            string number = Console.ReadLine();
            if (persona.TryGetValue(number, out string name))
            {
                Console.WriteLine($"{persona[number]}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Владелец телефона не найден.");
                Console.ReadKey();
            }
        }

        #endregion
    }
}
