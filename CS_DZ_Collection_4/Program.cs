using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Collection_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameAndPosition = new Dictionary<string, string>();

            string userInput;
            bool canExit = false;

            Console.WriteLine("Это программа для кадрого учета. ");
            Console.ReadKey();
            Console.Clear();
            
            while (canExit == false)
            {
                Console.WriteLine("Для добавления досье введите 1");
                Console.WriteLine("Для вывода всех досье введите 2");
                Console.WriteLine("Для удаления досье введите 3");
                Console.WriteLine("Для выхода досье введите 4 или exit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите ФИО и должность: ");
                        nameAndPosition.Add(Console.ReadLine(), Console.ReadLine());
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        foreach (var item in nameAndPosition)
                        {
                            Console.Write("\nФИО - " + item.Key + " должность - " + item.Value + "\n");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Введите ФИО для удаления досье: ");
                        nameAndPosition.Remove(Console.ReadLine());
                        Console.Clear();
                        break;

                    case "4":
                    case "exit":
                        Console.Clear();
                        canExit = true;
                        break;
                }
            }
        }
    }
}
