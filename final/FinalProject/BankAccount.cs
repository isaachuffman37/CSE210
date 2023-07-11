public class BankAccount
{
    string _accountName;
    string _accountNumber;
    float _balance;

    public void GetName()
    {
        Console.Write("What is the name of your account?");
        _accountName = Console.ReadLine();
    }

    public void SetName(string accountName)
    {
        _accountName = accountName;
    }

    public void GetNumber()
    {
        Console.Write("What is your account number?");
        _accountNumber = Console.ReadLine();
    }

    public void SetNumber(string accountNumber)
    {
        _accountNumber = accountNumber;
    }

    public void GetBalance()
    {
        Console.Write("What is the balance of your account?");
        _balance = float.Parse(Console.ReadLine());
    }

    public void SetBalance(float balance)
    {
        _balance = balance;
    }



    public void DisplayTransactions(List<Transaction> transactions)
    {
        if (transactions.Count() > 0)
        {
            foreach( Transaction transaction in transactions)
            {
                Console.WriteLine($"{transaction.DisplayTransaction()}");
            } 
        }
        else 
        {
            Console.WriteLine("You do not have any transactions recorded yet.");
        }
    }

    public void AddBankAccount()
    {
        GetName();
        GetNumber();
        GetBalance();
    }

    public void DisplayBankAccount()
    {
        Console.WriteLine($"Account Name: {_accountName}\nAccount Number: {_accountNumber}\nCurrent Balance: {_balance}");
    }

    public void AddTransactionToBalance(Transaction transaction)
    {
        float transAmount = transaction.ReturnAmount();
        if (transaction.ReturnType() == "income")
        {
            _balance += transAmount;
        }
        else if (transaction.ReturnType() == "expense")
        {
            _balance -= transAmount;
        }
    }

    public float ReturnBalance()
    {
        return _balance;
    }
    


}