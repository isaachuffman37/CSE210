public abstract class Transaction 
{
    protected float _amount;
    protected string _date;
    protected string _description;
    

    public abstract void DisplayTransaction();

    public void GetAmount()
    {
        Console.Write("What is the amount? ");
        _amount = float.Parse(Console.ReadLine());
    }

    public void SetAmount(float amount)
    {
        _amount = amount;
    }

    public void GetDescription()
    {
        Console.Write("What is the description? ");
        _description = Console.ReadLine();
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void GetDate()
    {
        Console.Write("What date was it made?(MM/DD/YYYY) ");
        _date = Console.ReadLine();
    }

    public void SetDate(string date)
    {
        _date = date;
    }
    public virtual void AddTransaction()
    {
        GetAmount();
        GetDescription();
        GetDate();
    }
}