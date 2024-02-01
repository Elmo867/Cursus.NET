using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSecond;
using OefeningenCursus;
using OefeningenCursus2;
using System.Runtime.InteropServices;
using System.Drawing;
using OOPExcercise;
using Program1;
using Program2;
using NewArrays;
using GardenSupplies;

namespace ProgramFirst
{
    class Program
    {
        // this is where the progam starts
        static void Main(string[] args)
        {
            //OefeningenDag1.Extraoefeningen();
            //OefeningenDag1.Extraoefeningen3();
            //OefeningenDag1.Extraoefeningen4();
            //OefeningenDag1.Extraoefeningen5();
            //OefeningenDag1.Oefening1();
            //OefeningenDag1.Oefening2();
            //OefeningenDag1.Oefening3();
            //OefeningenDag1.Oefening4();
            //OefeningenDag1.Oefening5();
            //OefeningenDag1.Oefening7();
            //OefeningenDag1.Oefening8();
            //OefeningenDag1.Oefening9();
            //Program1Dag1.program1();
            //Program3Dag1.program3();
            //BankAccounts.CustomerQuestion();
            //Shapes shape = new Shapes(); 
            //shape.GetColor();
            //Shapes shape2 = new Retangle("blue");
            //shape2.GetColor();
            //DoExerciseCar();
            //BoardGameMenu.GameMenu();

            //Person6 person = new Person6();
            //person.Display();

            //CheckArray check = new CheckArray();
            //check.CheckTheArray();

            /*Customer customer = new Customer();
            var list = customer.getAdress();
            list = customer.AddAdress(list);
            list = customer.RemoveAdress(list);
            */

            //StartAnimals.PopulateAnimals(Zoo dieren);
            InventoryItem inventory = new InventoryItem();
            inventory.GardenStartMenu();
            
            

            
        }

        static void DoExerciseCar()
        {
            ExerciseCar car = new ExerciseCar("Red","Ford");
            car.Start(100);
            Console.WriteLine(car.IsRunning);
            car.IncreaseSpeed(25);
            Console.WriteLine(car.CurrentSpeed);
            Console.WriteLine(car.Color + car.Brand);
        }
    }

    

    class Program1
    {
         public static void program1()
        {
            //promp user to enter name
            Console.WriteLine("Enter your name, please:");

            // read the name entered
            String name = Console.ReadLine();

            //greet the user with the name that was entered
            Console.WriteLine($"Hello {name}");

            //Wait for the user to acknowledge the results
            Console.WriteLine("press enter to terminate...");
            Console.ReadLine();

            // A way to get a string on the next line
            Console.WriteLine("this is a line \n and this is a new line");

            // with this way C# takes the string literal
            Console.WriteLine(@"this is a line \ and this is a new line");

            // cast a long value to an int so the number fits and C# thinks its okay
            long longValue = 10;
            int intValue;
            intValue = (int)longValue;

        }
    }
 
} 