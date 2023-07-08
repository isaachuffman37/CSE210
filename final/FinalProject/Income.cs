public class Income : Transaction
{
    string _source;
    public override void DisplayTransaction()
    {
        
    }

    public void GetSource()
    {
        Console.Write("What source did this come from? ");
        _source = Console.ReadLine();
    }

    public void SetSource(string source)
    {
        _source = source;
    }

    public override void AddTransaction()
    {
        base.AddTransaction();
        GetSource();
    }

    public string ReturnIncomeDate()
    {
        return _date;
    }

    

    
}