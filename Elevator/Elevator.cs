public class Elevator 
{
    protected List<int> _floorsAvailable = new List<int>();
    private bool _isDoorOpen = false;
    private int _floor;

    public Elevator()
    {
        for (int i = 1; i < 31; i++)
        {
            _floorsAvailable.Add(i);
        }
    }

    public void CloseDoor()
    {
        _isDoorOpen = false;
        Console.WriteLine("Door closed");
    }

    public void OpenDoor()
    {
        _isDoorOpen = true;
        Console.WriteLine("Door open");
    }

    public void MoveToAFloor()
    {
        Console.Write("What floor do you want to go to? ");
        int floor = Console.Read();
        CloseDoor();
        _floor = floor;
        OpenDoor();
    }

    public void CallElevatorFromFloor()
    {
        Console.Write("What floor are you on? ");
        int floor = Console.Read();
        MoveToAFloor();
        Console.WriteLine("Your elevator is here");
    }

    public void DisplayFloor()
    {
        Console.WriteLine($"The elevator is on: {_floor}");
    }
    
    public void DisplayFloorsAvailable()
    {
        Console.Write("Floors available: ");
        foreach (int floor in _floorsAvailable)
        {    
            Console.Write($"{floor} ");
        }
    }
}