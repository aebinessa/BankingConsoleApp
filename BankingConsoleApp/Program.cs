

using BankingConsoleApp;
using System.Security.Principal;

Console.WriteLine("Welcome to the banco! please enter your name");
string name = Console.ReadLine();
Console.WriteLine("Enter your initial account number");
int accountNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your initial amount");
int initialAmount = int.Parse(Console.ReadLine());

BankAccount bankAccount = new BankAccount(initialAmount);


while (true)
{
    Console.WriteLine("Please choose one of the options below");
    Console.WriteLine("Main Menu:\r\n1. Deposit \r\n2. Withdraw \r\n3. View Balance \r\n4. Exit ");
    int chosenOption = int.Parse(Console.ReadLine());


    if (chosenOption == 1)
    {
        Console.WriteLine("Enter your desired deposit amount");
        int depositAmount = int.Parse(Console.ReadLine());
        bankAccount.Deposit(depositAmount);
    }
    else if (chosenOption == 2)
    {
        Console.WriteLine("Enter your desired withdrawal amount");
        int withdrawAmount = int.Parse(Console.ReadLine());
        if (withdrawAmount <= initialAmount)
        {
            bankAccount.Withdraw(withdrawAmount);
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
    else if (chosenOption == 3)
    {
        Console.WriteLine($"Your balance is {bankAccount.GetBalance()}");
    }
    else if (chosenOption == 4)
    {
        Console.WriteLine("bye");
        bankAccount.ShowTransactionHistory();




        break;
    }
    }
   








