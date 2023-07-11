public class Report
{
    DateTime _startDate;
    DateTime _endDate;
    float _totalExpenses;
    float _totalIncome;
    float _percentOfExpenses;
    float _addAmount;
    float _expenseAmount;
    float _incomeAmount;

    public void CalcCurrentBudgets(List<Budget>budgets, List<Expense>expenses)
    {
        foreach (Budget budget in budgets)
        {
            foreach(Expense expense in expenses)
            {
                if (budget.ReturnCategory() == expense.ReturnExpenseCategory() && expense.ReturnDate() >= _startDate && expense.ReturnDate() <= _endDate)
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
            DateTime expenseDate = expense.ReturnDate();
            if(_startDate <= expenseDate && expenseDate <= _endDate)
            {
                _expenseAmount = expense.ReturnAmount();
                _totalExpenses += _expenseAmount;
            }
        }
    }

    public void DisplayTotalExpenses()
    {
        Console.WriteLine($"Your total expenses are: -{_totalExpenses} ");
    }

    public void CalcTotalIncome(List<Income> incomes)
    {
        foreach(Income income in incomes)
        {
            DateTime incomeDate = income.ReturnDate();
            if(_startDate <= incomeDate && incomeDate <= _endDate)
            {
                _incomeAmount = income.ReturnIncomeAmount();
                _totalIncome += _incomeAmount;
            }
        }
    }

    public void DisplayTotalIncome()
    {
        Console.WriteLine($"Your total income is: {_totalIncome} ");
    }

     public void GetStartDate()
    {
        Console.Write("What is the date you want the data to start?(MM/DD/YYYY) ");
        string _userInput = Console.ReadLine();
        if (DateTime.TryParse(_userInput, out _startDate))
        {
            // Successfully parsed the user input into a DateTime object
            Console.WriteLine("Parsed DateTime: " + _startDate);
        }
        else
        {
            // Failed to parse the user input
            Console.WriteLine("Invalid date and time format.");
        }
    }

    public void SetStartDate(DateTime startDate)
    {
        _startDate = startDate;
    }

    public void GetEndDate()
    {
        Console.Write("What is the date you want the data to end?(MM/DD/YYYY) ");
        string endDate = Console.ReadLine();
        if (DateTime.TryParse(endDate, out _endDate))
        {
            // Successfully parsed the user input into a DateTime object
            Console.WriteLine("Parsed DateTime: " + _endDate);
        }
        else
        {
            // Failed to parse the user input
            Console.WriteLine("Invalid date and time format.");
        }
    }

    public void DisplayBudgets(List<Budget> budgets)
    {
        foreach (Budget budget in budgets)
        {
            budget.DisplayBudget();
        }
    }

    public void SetEndDate(DateTime endDate)
    {
        _endDate = endDate;
    }

    public void DisplayReport(List<Budget>budgets, List<Expense>expenses, List<Income> incomes)
    {
        GetStartDate();
        GetEndDate();
        CalcCurrentBudgets(budgets, expenses);
        DisplayBudgets(budgets);
        CalcTotalExpenses(expenses);
        DisplayTotalExpenses();
        CalcTotalIncome(incomes);
        DisplayTotalIncome();

    }



}