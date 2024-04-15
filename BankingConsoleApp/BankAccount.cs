
namespace BankingConsoleApp
{
    public class BankAccount
    {
        private double balance;
        private double[] transactionAmounts = new double[100];
        private string[] transactionTypes = new string[100];
        private int transactionCount = 0;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                RecordTransaction(amount, "Deposit");
                Console.WriteLine($"Deposit of {amount} successful. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    RecordTransaction(amount, "Withdrawal");
                    Console.WriteLine($"Withdrawal of {amount} successful. New balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public void RecordTransaction(double amount, string type)
        {
            transactionAmounts[transactionCount] = amount;
            transactionTypes[transactionCount] = type;
            transactionCount++;
        }
        public void ShowTransactionHistory()
        {
            Console.WriteLine("Transaction History:");
            for (int i = 0; i < transactionCount; i++)
            {
                Console.WriteLine($"{transactionTypes[i]}: {transactionAmounts[i]}");
            }
        }
    }
}
