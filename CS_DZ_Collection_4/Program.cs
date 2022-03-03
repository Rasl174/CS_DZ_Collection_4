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
                Console.WriteLine("Для выхода введите 4 или exit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateDossier(ref nameAndPosition);
                        break;

                    case "2":
                        ShowDossier(ref nameAndPosition);
                        break;

                    case "3":
                        DeleteDossier(ref nameAndPosition);
                        break;

                    case "4":
                    case "exit":
                        Console.Clear();
                        canExit = true;
                        break;
                }
            }
        }

        static void CreateDossier(ref Dictionary<string, string> dossier)
        {
            Console.WriteLine("Введите ФИО и должность: ");
            dossier.Add(Console.ReadLine(), Console.ReadLine());
            Console.Clear();
        }

        static void ShowDossier(ref Dictionary<string,string> dossier)
        {
            Console.Clear();
            foreach (var item in dossier)
            {
                Console.Write("\nФИО - " + item.Key + " должность - " + item.Value + "\n");
            }
        }

        static void DeleteDossier(ref Dictionary<string, string> dossier)
        {
            Console.WriteLine("Введите ФИО для удаления досье: ");
            dossier.Remove(Console.ReadLine());
            Console.Clear();
        }
    }
}
