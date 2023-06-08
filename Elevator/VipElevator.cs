public class VipElevator : Elevator{
    private string _accessCode = "1234";
    public void AddFloor()
    {
        _floorsAvailable.Add(31);
    }

    public bool Verify(string accessCode)
    {
        if (_accessCode == accessCode){
            return true;
        }
        else {
            return false;
        }
    }
}