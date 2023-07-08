public class Menu
{
    List<Budget> _budgets = new List<Budget>();
    List<Expense> _expenses = new List<Expense>();
    List<Transaction> _transactions = new List<Transaction>();

    string _budgetResponse = "";
    string _accountResponse;
    string _optionResponse;

    public void DisplayMenu()
    {
        Console.Write("1. Sign In\n2. Create Account\nWhich would you like to do? ");
        _accountResponse = Console.ReadLine();
        if (_accountResponse == "2")
        {
            User u = new User();
            u.AddUser();
            Console.WriteLine();
            Console.WriteLine("Congratulations! You are now signed in.\nNow let's add an account:");
            Console.WriteLine();

            BankAccount b = new BankAccount();
            b.AddBankAccount();
            Console.WriteLine();
            Console.WriteLine("Perfect! Now, think of the elements of your budget.\nLet's add one of them now:");
            
            while (_budgetResponse != "n")
            {
                Budget bgt = new Budget();
                bgt.AddBudget();
                _budgets.Add(bgt);
                Console.Write("Your budget element has been successfully added.\nWould you like to add another one?(y/n) ");
                _budgetResponse = Console.ReadLine();
            } 

            Console.WriteLine("Now you are all set up! Take a look at the options below to track your finances");
    

        while (_optionResponse != "8")
        {
            Console.Write("1. View Account And History\n2. Add Budget Element\n3. Add Expense\n4. Add Income\n5. View Report\n6. Save\n7. Load\n8. Quit\nWhich would you like to do?");
            _optionResponse = Console.ReadLine();

            switch(_optionResponse)
            {
                case "1":
                    
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "7":

                    break;
                default:
                    Console.Write($"{_optionResponse} was an invalid option, please choose again");
                    break;
            }





        }





            
            
            



        }
    }
}