using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPExcercise
{
    internal class Person
    {
        // Create a `Person` class with properties like name, age, and address. Implement multiple constructors with different parameter lists to create `Person` objects in various ways.
        
        // de properties of deze class
        public string Name {  get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        // de overload constructors
        public Person() {}
        public Person(string name) 
        { }
        public Person(string name, int age) 
        { }
        public Person(string name, int age, string adress) { }
    }

    public class BankAccounts
    {
        //- Develop a `BankAccount` class with methods to deposit and withdraw funds, and a method to check the balance.
        //Use private variables to store the balance and public methods for these operations.
        public static int Balance = 10000;
        public BankAccounts() { }

        public static void CustomerQuestion()
        {
            Console.WriteLine("What would you like to do?; Withdraw, Deposit,Check?");
            string customerAnswer = Console.ReadLine();

            if (customerAnswer == "Withdraw")
            {
                BankAccounts.Withdraw();
            }
            else if (customerAnswer == "Deposit")
            {
                BankAccounts.Withdraw();
            }
            else if (customerAnswer == "Check")
            {
                BankAccounts.Withdraw();
            }
            else
            {
                Console.WriteLine("We couldn't get your answer");
            }

        }
              
        public static int Withdraw()
        {
            Console.WriteLine("What is the amount you would like to withdraw?");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the amount you would like to withdraw is; {amount}, is this correct?");
            string answer = Console.ReadLine();
            int totalBalance = Balance - amount;
            Console.WriteLine($"This is the balance left; {totalBalance}");
            return totalBalance;
            
        }

        public static int Deposit()
        {
            Console.WriteLine("What is the amount you would like to deposit?");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the amount you would like to deposit is; {amount}, is this correct?");
            int totalBalance = Balance + amount;
            Console.WriteLine($"This is the total balance; {totalBalance}");
            return totalBalance;

        }

        public static int Check()
        {
            return Balance;
        }


    }
}
