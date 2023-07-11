public abstract class Transaction 
{
    protected float _amount;
    protected string _description;
    protected DateTime _date;
    protected string _type;
    

    public abstract string DisplayTransaction();

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
        Console.WriteLine("Enter the date (MM/dd/yyyy): ");
        string userInput = Console.ReadLine();


        if (DateTime.TryParse(userInput, out _date))
        {
            // Successfully parsed the user input into a DateTime object
            Console.WriteLine("Parsed DateTime: " + _date);
        }
        else
        {
            // Failed to parse the user input
            Console.WriteLine("Invalid date and time format.");
        }
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }
    public virtual void AddTransaction(BankAccount b)
    {
        GetTransactionType();
        GetAmount();
        GetDescription();
        GetDate();
    }

    public DateTime ReturnDate()
    {
        return _date;
    }

    public float ReturnAmount()
    {
        return _amount;
    }

    public string ReturnType()
    {
        return _type;
    }

    public abstract void GetTransactionType();

    public abstract void AddTransactionToBalance(BankAccount b);
}