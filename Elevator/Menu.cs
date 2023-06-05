public class Menu{
    public void DisplayMenu(Elevator elevator){
        string response = "";
        string[] options ={"1","2","3","4","5","6","7"};
        while(response!="7"){
            while(options.Contains(response)==false)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Open Doors");
                Console.WriteLine("2. Close Doors");
                Console.WriteLine("3. Move to a Floor");
                Console.WriteLine("4. Call Elevator from floor");
                Console.WriteLine("5. Display Floor");
                Console.WriteLine("6. Display Floors Avaliable");
                Console.WriteLine("7. Quit");
                Console.WriteLine("What do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "1":
                elevator.OpenDoor();
                break;

                case "2":
                elevator.CloseDoor();
                break;
                
                case "3":
                elevator.MoveToAFloor();
                break;

                case "4":
                elevator.CallElevatorFromFloor();
                break;

                case "5":
                elevator.DisplayFloor();
                break;
                
                case "6":
                elevator.DisplayFloorsAvailable();
                break;

                case "7":
                Environment.Exit(0);
                break;
            }
        }

    }

    public Elevator CheckForVip()
    {
        Console.WriteLine("Are you using a VIP elevator (Y/N)? ");
        string usingVIP = Console.ReadLine() ?? string.Empty;
        if (usingVIP.ToUpper() == "Y")
        {
            VipElevator vipElevator = new VipElevator();
            Console.Write("What is the access code? ");
            string accessCode = Console.ReadLine() ?? string.Empty;
            if (VerifyAccessCode())
            {
                vipElevator.AddFloor();
            }
            return vipElevator;
        }
        else
        {
            Elevator elevator = new Elevator();
            return elevator;
        }
    }
}