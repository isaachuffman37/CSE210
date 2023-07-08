public class Expense : Transaction
{
    string _category;
    public override void DisplayTransaction()
    {
            
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

    public float ReturnAmount()
    {
        return _amount;
    }

    public override void AddTransaction()
    {
        base.AddTransaction();
        GetCategory();
    }

    public string ReturnExpenseDate()
    {
        return _date;
    }
    
}