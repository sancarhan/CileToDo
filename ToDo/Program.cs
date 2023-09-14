using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> toDoList = new List<string>();

        while (true)
        {   Console.WriteLine("************************");
            Console.WriteLine("Yapılacak işlemi girin (Ekle/Liste/Çık): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "çık")
                break;
            else if (input.ToLower() == "liste")
            {
                Console.WriteLine("************************");
                Console.WriteLine("Yapılacaklar Listesi:");
                foreach (string item in toDoList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                toDoList.Add(input);
                Console.WriteLine(input + " eklendi.");
            }
        }
    }
}
