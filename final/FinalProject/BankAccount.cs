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



    public void DisplayTransactions()
    {

    }

    public void AddBankAccount()
    {
        GetName();
        GetNumber();
        GetBalance();
    }


    


}