using ProgramFirst;
using ProgramSecond;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace OefeningenCursus
{
    public class OefeningenDag1
    {
        public static void Notities()
        {
            string conventieNamespace = "hoofdletter";
            string conventieClass = "hoofdletter";
            string conventieFunctie = "hoofdletter";
            string conventieVariabel = "kleineletter, rest hoofdletter";
        }

        public static void Extraoefeningen()
        {
            string name1 = "Eelco";
            int age1 = 29;
            int phoneNumber = 0612324569;
            string weather = "sunny day";
            int weight = 70;
            double table = 50.7;
            char firstLetter = 'E';
            string multianswser = "not present";
            byte randomNumber = 4;

            //write a program that takes the length of the two sides of a right triangle and calculates the length of the hyptenuse
            Console.WriteLine("Please enter the number of side A");
            int lenghtA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of side B");
            int lenghtB = Convert.ToInt32(Console.ReadLine());
            double lenghtASquare = Math.Pow(lenghtA, 2);
            double lenghtBSquare = Math.Pow(lenghtB, 2);
            double lenghtHypo = Math.Sqrt(lenghtASquare + lenghtBSquare);
            Console.WriteLine($"This is the length of the hypotenuse {lenghtHypo}");


            Console.WriteLine("Lets go to the next exercise, we are going to calculate the length of this string; dit is een test");
            string exercise1 = "dit is een text";
            int exercise2 = extraoefeningen1(exercise1);
            Console.WriteLine(exercise2);
        }

        public static int extraoefeningen1(string exercise1)
        {
            int lenghtOfString = exercise1.Length;
            return lenghtOfString;
        }
        public static void Extraoefeningen3()
        {
            Console.WriteLine("What is the degrees you have for us?");
            int Answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Option A: switch Celsius to Fahrenheit, Option B; switch Fahrenheit to Celsius");
            string Answer2 = Console.ReadLine();
            double Answer3 = SwitchDegrees(Answer, Answer2);
            Console.WriteLine($"This is the result; {Answer3}");

            static int SwitchDegrees(int Answer, string Answer2)
            {
                if (Answer2 == "A")
                {
                    double step1 = 1.8;
                    int step2 = 32;
                    int Result2 = Answer * Convert.ToInt32(step1) + step2;
                    return Result2;
                }
                else
                {
                    double step1 = 1.8;
                    int step2 = 32;
                    int Result2 = Answer - step2 * Convert.ToInt32(step1);
                    return Result2;
                }
            }
        }
        public static void Extraoefeningen4()
        {

            Console.WriteLine("What is the First number?");
            int AnswerA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            int AnswerB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want to do?");
            char operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                int resultX = AnswerA + AnswerB;
                Console.WriteLine(resultX);
            }
            else if (operation == '-')
            {
                int resultX = AnswerA - AnswerB;
                Console.WriteLine(resultX);
            }
            else if (operation == '/')
            {
                int resultX = AnswerA / AnswerB;
                Console.WriteLine(resultX);
            }
            else
            {
                Console.WriteLine("wrong text");
            }
        }

        enum Weekday
        {
            MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY
        }
        public static void Extraoefeningen5()
        {
            // 1. * *Weekday Finder * *: Ask the user to input a number from 1 to 7 and use a switch statement to convert it to the corresponding weekday(1 for Monday, 2 for Tuesday, etc.).

            Console.WriteLine("please typ a number between 1 - 7");
            string inputNumber = Console.ReadLine();

            Weekday gekozenNumber;

            switch (inputNumber)
            {
                case "1":
                    gekozenNumber = Weekday.MONDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
                case "2":
                    gekozenNumber = Weekday.TUESDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
                case "3":
                    gekozenNumber = Weekday.WEDNESDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
                case "4":
                    gekozenNumber = Weekday.THURSDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
                case "5":
                    gekozenNumber = Weekday.FRIDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
                case "6":
                    gekozenNumber = Weekday.SATURDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
                case "7":
                    gekozenNumber = Weekday.SUNDAY;
                    Console.WriteLine($"today is {gekozenNumber}");
                    break;
            }
        }


        public static void Oefening1()
        {
            Console.WriteLine("Wat is je naam?");
            string name = Console.ReadLine();
            Console.WriteLine("Perfect, what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite number?");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your least favorite number?");
            int leastFavoriteNumber = Convert.ToInt32(Console.ReadLine());
            double resultFavoriteNumber = favoriteNumber / leastFavoriteNumber;
            Console.WriteLine("Perfect, these are the results");
            Console.WriteLine($"{name}\n{age}\n{resultFavoriteNumber}");
            Console.WriteLine("de naam is zoveel chars: " + name.Length);

        }

        public static void Oefening2()
        {
            // haal de lengte op van de variabele number
            int number = 4567895;
            // ze int om naar string, want anders kun je de lengte niet ophalen
            int length = Convert.ToString(number).Length;
            Console.WriteLine(length);


        }

        public static void Oefening3()
        {
            // bepaal de toegangsprijs op basis van de leeftijd

            Console.WriteLine("Hello and welcome, we would lilke to know your age");
            int ageCustomer = Convert.ToInt32(Console.ReadLine());
            int price = 0;

            if (ageCustomer >= 3 && ageCustomer <= 18)
            {
                price = 10;
            }
            else if (ageCustomer > 18)
            {
                price = 15;
            }
            else
            {
                Console.WriteLine($"Toegang is {price}");
            }



        }
        // dit zijn vaste waardes die je eenmalig kan instellen en later niet meer kan veranderen in je code
        enum VerkeerslichtStatus
        {
            GROEN, ORANJE, ROOD
        }
        public static void Oefening4()
        {
            VerkeerslichtStatus kleur = VerkeerslichtStatus.GROEN;
            bool dichtbij = false;

            if (VerkeerslichtStatus.GROEN == kleur)
            {
                Console.WriteLine("Gewoon normaal doorrijden.");
            }
            else if (VerkeerslichtStatus.ORANJE == kleur && dichtbij)
            {
                Console.WriteLine("Gewoon normaal doorrijden.");
            }
            else if (VerkeerslichtStatus.ORANJE == kleur && !dichtbij)
            {
                Console.WriteLine("Remmen.");
            }
            else if (VerkeerslichtStatus.ROOD == kleur && dichtbij)
            {
                Console.WriteLine("Stoppen.");
            }
            else if (VerkeerslichtStatus.ROOD == kleur && !dichtbij)
            {
                Console.WriteLine("Voorbereiden op stoppen.");
            }
            else
            {
                Console.WriteLine("Doe voorzichtig. Succes.");
            }
        }

        enum VerkeersLicht
        {
            GROEN, ORANJE, ROOD, DEFECT
        }

        public static void Oefening5()
        {
            //input van readline omzetten naar enum met een switch 

            string inputKleur = Console.ReadLine();

            VerkeersLicht gekozenKleur;

            switch (inputKleur.ToLower())
            {
                case "groen":
                    gekozenKleur = VerkeersLicht.GROEN;
                    break;
                case "oranje":
                    gekozenKleur = VerkeersLicht.ORANJE;
                    break;
                case "rood":
                    gekozenKleur = VerkeersLicht.ROOD;
                    break;
                default:
                    gekozenKleur = VerkeersLicht.DEFECT;
                    break;
            }

            //vervolgens de enum gebruiken om berichten te versturen

            switch (gekozenKleur)
            {
                case VerkeersLicht.GROEN:
                    string message = "rijden nu!";
                    Console.WriteLine(message);
                    break;
                case VerkeersLicht.ORANJE:
                    message = "snel gas bij geven, of toch maar netjes stoppen!";
                    Console.WriteLine(message);
                    break;
                case VerkeersLicht.ROOD:
                    message = "Doorrijden betekent geld betalen";
                    Console.WriteLine(message);
                    break;
                default:
                    Console.WriteLine("Goed uitkijken anders gaat het fout");
                    break;
            }

        }
        /* public static void Oefening6()
         {

             switch (kleur)
             {
                 case VerkeerslichtStatus.GROEN:
                     string message = dichtbij ? "rijden" : "rijden"; // ternary statement
                     Console.WriteLine(message);
                     break;
                 case VerkeerslichtStatus.ORANJE:
                     Console.WriteLine("Voorzichtig");
                     break;
                 case VerkeerslichtStatus.ROOD:
                     Console.WriteLine("Stoppen");
                     break;
                 default:
                     Console.WriteLine("Voorzichtig doen.");
                     break;
             }
         }
         */
        public static void Oefening7()
        {
            for (int i = 10; i >= 1; i--)
            {
                string song = $"{i} Little monkeys jumping on a bed, one jumped up and bumped his head, Mom called the Doctor and the doctor said........no more monkeys jumping on a bed.";
                Console.WriteLine(song);

                if (i == 1)
                {
                    song = $"{i} Little monkey jumping on a bed, he jumped up and bumped his head, Mom called the Doctor and the doctor said........no more monkeys jumping on a bed.";
                    Console.WriteLine(song);
                }
            }
        }


        public static void Oefening8()
        {
            Random r = new Random();
            int secret = r.Next(1, 20);
            string foundAnswer = "false";
            int counter = 0;
            int myAnswer;

            while (foundAnswer != "true")
            {
                Console.WriteLine("You can guess the number i have in my CPU");
                myAnswer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(secret);

                if (myAnswer == secret && counter < 5)
                {
                    Console.WriteLine("MINDER DAN 5X SNEL GEDAAN");
                    foundAnswer = "true";
                }
                else if (myAnswer == secret && counter >= 5 && counter < 10)
                {
                    Console.WriteLine("TUSSEN DE 5 EN 10x NETJES");
                    foundAnswer = "true";
                }
                else if (myAnswer == secret && counter >= 10 && counter < 15)
                {
                    Console.WriteLine("TUSSEN DE 10 EN 15X ZO ZO");
                    foundAnswer = "true";
                }
                else if (myAnswer == secret && counter > 15)
                {
                    Console.WriteLine("MEER DAN 15X HET DUURDE WEL LANG");
                    foundAnswer = "true";
                }
                else
                {
                    counter++;
                }
            }
        }

        enum Feedback
        {
            MINDER_DAN_5X,
            TUSSEN_DE_5_EN_10x,
            TUSSEN_DE_10_EN_15X,
            MEER_DAN_15X
        }

        public static void Oefening9()
        {
            Random r = new Random();
            int secret = r.Next(1, 20);
            string foundAnswer = "false";
            int counter = 0;
            int myAnswer;

            static string resultString(Feedback value) => value switch
            {
                Feedback.MINDER_DAN_5X => "Snel Gedaan!",
                Feedback.TUSSEN_DE_5_EN_10x => "Netjes",
                Feedback.TUSSEN_DE_10_EN_15X => "Zo,Zo",
                Feedback.MEER_DAN_15X => "Het duurde wel lang",

                _ => "We didn't specify"
            };

            while (foundAnswer != "true")
            {
                Console.WriteLine("You can guess the number i have in my CPU");
                myAnswer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(secret);

                switch (counter)
                {
                    case int n when n < 5 && myAnswer == secret:
                        Console.WriteLine(resultString(Feedback.MINDER_DAN_5X));
                        foundAnswer = "true";
                        break;
                    case int n when n >= 5 && n < 10 && myAnswer == secret:
                        Console.WriteLine(resultString(Feedback.TUSSEN_DE_5_EN_10x));
                        foundAnswer = "true";
                        break;
                    case int n when n >= 10 && n <15 && myAnswer == secret:
                        Console.WriteLine(resultString(Feedback.TUSSEN_DE_10_EN_15X));
                        foundAnswer = "true";
                        break;
                    case int n when n > 15 && myAnswer == secret:
                        Console.WriteLine(resultString(Feedback.MEER_DAN_15X));
                        foundAnswer = "true";
                        break;
                    default:
                        counter++;
                        break;
                }
            }
            
        } 
    }
}
/*
switch (myAnswer)
{
    case secret:
        gekozenNummer =
                        break;
}

string inputKleur = Console.ReadLine();

VerkeersLicht gekozenKleur;

switch (inputKleur.ToLower())
{
    case "groen":
        gekozenKleur = VerkeersLicht.GROEN;
        break;
    case "oranje":
        gekozenKleur = VerkeersLicht.ORANJE;
        break;
    case "rood":
        gekozenKleur = VerkeersLicht.ROOD;
        break;
    default:
        gekozenKleur = VerkeersLicht.DEFECT;
        break;
}*/