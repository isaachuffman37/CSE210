public class Budget
{
    string _category;
    float _amount;
    float _currentlySpent;
    float _percent;

    public void DisplayBudget()
    {
        _percent = (float)Math.Round(_currentlySpent/_amount * 100,1,MidpointRounding.AwayFromZero);

        Console.WriteLine($"{_category}: {_currentlySpent}/{_amount}");
        Console.WriteLine($"Percentage spent: {_percent}");
        Console.WriteLine("");

    }

    public void GetCurrentlySpent()
    {
        Console.Write("How much of the budget have you spent already? ");
        _currentlySpent = float.Parse(Console.ReadLine());
    }

    public void SetCurrentlySpent(float currentlySpent)
    {
        _currentlySpent = currentlySpent;
    }

    public void resetBudget()
    {
        _currentlySpent = 0;
    }

    public void AddExpenseToBudget(float expenseAmount)
    {
        _currentlySpent += expenseAmount;
    }

     public void GetCategory()
    {
        Console.Write("Which category is this budget for? ");
        _category = Console.ReadLine();
    }

    public void SetCategory(string category)
    {
        _category= category;
    }


     public void GetBudgetAmount()
    {
        Console.Write("How much would you like this budget to be? ");
        _amount = float.Parse(Console.ReadLine());
    }

    public void SetBudgetAmount(float amount)
    {
        _amount = amount;
    }

    public string ReturnCategory()
    {
        return _category;
    }

    public void AddBudget()
    {
        GetCategory();
        GetBudgetAmount();
        GetCurrentlySpent();

    }








}