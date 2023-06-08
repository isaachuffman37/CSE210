using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity b = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 4, 6);
        
        ListingActivity l = new ListingActivity("Listing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        ReflectingActivity r  = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string response = "";

        while (response != "4")
        {
            Console.Write("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit\nWhich would you like to do? ");
            response = Console.ReadLine();
            switch(response) 
            {
            case "1":
                b.RunBreathingActivity();
                break;
            case "2":
                r.RunReflectionActivity();
                break;
            case "3":
                l.RunListingActivity();
                break;
            }
        }
        




        
    }
}