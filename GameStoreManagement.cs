using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class InventoryItem2
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }

        public InventoryItem2() 
        {
            
        }
        
        //List<string> Inventory = new List<string> {"scythe, monopoly, exploding kittens, dice"};

    
    }

    internal class InventoryList : InventoryItem2
    {
        public List<InventoryItem2> Inventory { get; set; }
        public InventoryList() 
        {
            //hiermee creeër je een lege lijst genaamd inventory
            Inventory = new List<InventoryItem2>
         {
             new FamilyGame("monopoly"),
             new StrategyGame("scythe"),
             new CardGame("exploding kittens"),
             new BoardGameAccessory("dice")
         };
        }
        public static InventoryItem2 CreateInventory(string name)
        {
            return new InventoryItem2 { Name = name };
        }

        public void DisplayItems()
        {
            foreach (InventoryItem2 item in Inventory)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void ItemByID(int ID)
        {
            InventoryItem2 item = Inventory[ID];
            Console.WriteLine(item.Name);
        }

        public void AddItem(InventoryItem2 item)
        {
            Inventory.Add(item);
            Console.WriteLine($"we have added the following game: {item.Name}");
        }
    }

    internal class StrategyGame : InventoryItem2
    {
        public int Age { get; set; }
        public int MaxPlayers { get; set; }

        public StrategyGame(string game) 
        {
            Name = game;
        }
    }

    internal class FamilyGame : InventoryItem2
    {
        public int RecommendedAge {  get; set; }
        public int Playtime {  get; set; }

        public FamilyGame(string game) 
        {
            Name = game;
        }

    }

    internal class CardGame : InventoryItem2
    {
        public int Decksize {  get; set; }
        public string Genre { get; set; }
        
        public CardGame(string game) 
        {
            Name = game;
        }
    }

    internal class BoardGameAccessory : InventoryItem2
    {
        public string Material { get; set; }
        public string Type { get; set; }

        public BoardGameAccessory(string game) 
        {
            Name = game;
        }
    }
}
