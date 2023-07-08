public class Room 
{
    int _roomNumber;
    List<Times> _timesAvailable = new List<Times>();
    
    public Room(int roomNumber) 
    {
        _roomNumber = roomNumber;
        SetTimeSlots();
    }

    public List<Times> GetTimeSlots()
    {
        return _timesAvailable;
    }

    public SetTimeSlots()
    {
        _timesAvailable.Add(new Times("8:00-9:00"));
        _timesAvailable.Add(new Times("9:00-10:00"));
        _timesAvailable.Add(new Times("10:00-11:00"));
        _timesAvailable.Add(new Times("11:00-12:00"));
    }
}