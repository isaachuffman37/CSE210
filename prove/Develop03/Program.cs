using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true)
        {
            Console.WriteLine("1. Write\n 2. Display\n 3. Load\n 4. Save\n 5. Quit\n What would you like to do?");
            string response = Console.ReadLine();
            if (response == "1")
            {
                menu.NewEntry();
            }

            else if (response == "2")
            {
                menu.DisplayJournal();
            }

            else if (response == "3")
            {
                menu.LoadFromFile();
            }

            else if (response == "4")
            {
                menu.SaveToFile();
            }

            else if (response == "5")
            {
                break;
            }
            

        }
        
        
    }
}