BankAccount account1 = new BankAccount("Іван Петренко", "UA001", 1000);
BankAccount account2 = new BankAccount("Марія Коваль", "UA002", 500);
BankAccount account3 = new BankAccount("Олег Сидоренко", "UA003", 2000);

account1.Deposit(500);
account1.Withdraw(200);
Console.WriteLine($"Рахунок {account1.Balance}");

account2.Deposit(1000);
account2.Withdraw(2000);
Console.WriteLine($"Рахунок {account2.Balance}");

account3.Withdraw(500);
Console.WriteLine($"Рахунок {account3.Balance}");

class BankAccount
{
    private string _owner;
    private string _accountNumber;
    public decimal Balance { get; set; }

    public BankAccount(string owner, string accountNumber, decimal startBalance)
    {
        _owner = owner;
        _accountNumber = accountNumber;
        Balance = startBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance = Balance + amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance = Balance - amount;
        }
        else
        {
            Console.WriteLine("Недостатньо коштів на рахунку");
        }
    }
}