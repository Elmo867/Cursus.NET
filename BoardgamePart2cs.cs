using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program2.CardGame;

namespace Program2
{
    internal class InventoryItem3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }

        public InventoryItem3()
        {

        }

        string game1 = "scythe";
        string game2 = "Exploding Kittens";
        string game3 = "duizendbommenengranaten";


        public void DisplayItems()
        {
            
             Console.WriteLine($"These are the games we have; {game1},{game2},{game3} \n");

        }
        public virtual void DisplayItems(string name)
        {

            if (name == "strategygame")
            {
                StrategyGame game = new StrategyGame();
                game.DisplayItems(name);
            }
            else if (name == "familygame")
            {
                FamilyGame game = new FamilyGame();
                game.DisplayItems(name);
            }
            else if (name == "cardgame")
            {
                CardGame game = new CardGame();
                game.DisplayItems(name);
            }
            else 
            {
                Console.WriteLine("im sorry we don't have that game");
            }


        }

        public void ItemByID(int ID)
        {
            if (ID == 1)
            { Console.WriteLine($"This is the game; {game1}"); }
            else if (ID == 2)
            { Console.WriteLine($"This is the game; {game2}"); }
            else if (ID == 3) {  Console.WriteLine($"This is the game; {game3}"); }
            else
            {
                Console.WriteLine("sorry couldn't find your game");
            }

        }
     
        public void AddItem(string item)
        {
            Console.WriteLine($"we have added the following game: {item}");
        }

    }

    internal class StrategyGame : InventoryItem3
    {
        public int Age { get; set; }
        public int MaxPlayers { get; set; }

        public StrategyGame()
        {
        }

        public override void DisplayItems(string name)
        {

                Id = 1;
                Name = "Scythe";
                Description = "A epic game where you have to strategically move against your opponent";
                Price = 60;
                Quantity = 2;
            Console.WriteLine($"The ID: {Id},\nThe Game: {Name},\nThe Desciption: {Description},\nThe Price: {Price},\nand there are just {Quantity} games left ");
            Console.WriteLine("\nWould you like more specifics?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("\nwhat game would you like more specifics on?");
                answer = Console.ReadLine().ToLower();
                BoardGameAccessory game = new BoardGameAccessory();
                game.DisplayItems(answer);
            }
            else
            {
                Console.WriteLine("okay thankyou, see you next time");
            }

            

        }
    }

    internal class FamilyGame : InventoryItem3
    {
        public int RecommendedAge { get; set; }
        public int Playtime { get; set; }

        public FamilyGame()
        {
        }

        public override void DisplayItems(string name)
        {

            Id = 2;
            Name = "Exploding Kittens";
            Description = "A game full of chaos where you have to outsmart your opponent";
            Price = 20;
            Quantity = 10;
            Console.WriteLine($"The ID: {Id},\nThe Game: {Name},\nThe Desciption: {Description},\nThe Price: {Price},\nand there are just {Quantity} games left ");
            Console.WriteLine("\nWould you like more specifics?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("\nwhat game would you like more specifics on?");
                answer = Console.ReadLine().ToLower();
                BoardGameAccessory game = new BoardGameAccessory();
                game.DisplayItems(answer);
            }
            else
            {
                Console.WriteLine("okay thankyou, see you next time");
            }
        }
    }

    internal class CardGame : InventoryItem3
    {
        public int Decksize { get; set; }
        public string Genre { get; set; }

        public CardGame()
        {
        }
        public override void DisplayItems(string name)
        {

            Id = 2;
            Name = "duizendbommenengranaten";
            Description = "A game of luck, can you outthrow you opponent?";
            Price = 15;
            Quantity = 5;
            Console.WriteLine($"The ID: {Id},\nThe Game: {Name},\nThe Desciption: {Description},\nThe Price: {Price},\nand there are just {Quantity} games left ");
            Console.WriteLine("\nWould you like more specifics?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("\nwhat game would you like more specifics on?");
                answer = Console.ReadLine().ToLower();
                BoardGameAccessory game = new BoardGameAccessory();
                game.DisplayItems(answer);
            }
            else
            {
                Console.WriteLine("okay thankyou, see you next time");
            }
        }
    }
    internal class BoardGameAccessory : InventoryItem3
    {
        public string Material { get; set; }
        public string Type { get; set; }

        public BoardGameAccessory()
        {
        }

        public override void DisplayItems(string name)
        {

            if (name == "scythe")
            {
                Material = "wood";
                Type = "strategic";
                Console.WriteLine($"\nThe material is {Material} and the gametype is:{Type}");
            }
            else if (name == "exploding kittens")
            {
                Material = "paper";
                Type = "chaos";
                Console.WriteLine($"\nThe material is {Material} and the gametype is:{Type}");
            }
            else if (name == "duizendbommenengranaten")
            {
                Material = "paper";
                Type = "dice";
                Console.WriteLine($"\nThe material is {Material} and the gametype is:{Type}");
            }
            else 
            {
                Console.WriteLine("Sorry we don't have that game");
            }
        }
    }
}
