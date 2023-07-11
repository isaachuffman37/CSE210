public class Expense : Transaction
{
    string _category;
    public override string DisplayTransaction()
    {
            return $"{_amount} {_description} {_date}";
    }

    public void GetCategory()
    {
        Console.Write("What category would this expense fit into? ");
        _category = Console.ReadLine();
    }

    public void SetCategory(string category)
    {
        _category = category;
    }

    public string ReturnExpenseCategory()
    {
        return _category;
    }

    public override void AddTransaction(BankAccount b)
    {
        base.AddTransaction(b);
        GetCategory();
        AddTransactionToBalance(b);
    }


    public override void GetTransactionType()
    {
        _type = "expense";
    }

    public override void AddTransactionToBalance(BankAccount b)
    {
        float balance = b.ReturnBalance();
        balance -= _amount; 
    }
}