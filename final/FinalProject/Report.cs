public class Report
{
    string _startDate;
    string _endDate;
    float _totalExpenses;
    float _totalIncome;
    float _percentOfExpenses;
    float _addAmount;
    float _expenseAmount;

    public void CalcCurrentBudgets(List<Budget>budgets, List<Expense>expenses)
    {
        foreach (Budget budget in budgets)
        {
            foreach(Expense expense in expenses)
            {
                if (budget.ReturnCategory() == expense.ReturnExpenseCategory())
                {
                    _addAmount = expense.ReturnAmount();
                    budget.AddExpenseToBudget(_addAmount);
                }
            }
        }
    }

    public void CalcTotalExpenses(List<Expense> expenses)
    {
        foreach(Expense expense in expenses)
        {
            
            _expenseAmount = expense.ReturnAmount();
            _totalExpenses += _expenseAmount;
        }
    }

    public void DisplayTotalExpense()
    {
        Console.WriteLine($"Your total expenses are: ");
    }

     public void GetStartDate()
    {
        Console.Write("What is the date you want the data to start?(MM/DD/YYYY) ");
        _startDate = Console.ReadLine();
    }

    public void SetStartDate(string startDate)
    {
        _startDate = startDate;
    }

    public void GetEndDate()
    {
        Console.Write("What is the date you want the data to start?(MM/DD/YYYY) ");
        _startDate = Console.ReadLine();
    }

    public void SetEndDate(string endDate)
    {
        _endDate = endDate;
    }



}