// See https://aka.ms/new-console-template for more information
using BankingApp;

Console.WriteLine("Hello, World!");


BankAccount account = new BankAccount();
Console.WriteLine("How much would you like to deposit?");
var amountToDep = double.Parse(Console.ReadLine()); 
account.Deposit ( amountToDep);
Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");