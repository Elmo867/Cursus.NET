using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenSupplies
{
    internal class InventoryItem
    {
        public InventoryItem() { }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string ListOfQuestions(string message)
        {
            Dictionary<string, string> messages = new Dictionary<string, string>()
            {
                { "welcome","How can we help you? \n1.View all items \n2.Search for items \n3.Add Item to inventory \n4.Buy Item"},
                { "helpagain", "Would you like to see anything else? \n1.View all items \n2.Search for items \n3.Add Item to inventory \n4.Buy Item" },
                { "view","These are all the items we have"},
                { "search", "Based on what would you like us to search? \n1.ID \n2.Type \n3.Name \n4.Description \n5.Price \n6.Quantity" },
                { "type", "What type would you like to see? \n1.Plant \n2.Tool \n3.Decor \n4.Fertilizer" },
                { "other", "is there any other type you would like to see?" }
            };

            string messageanswer = messages[message];
            Console.WriteLine(messageanswer);
            Console.WriteLine("\n");
            string cusomterAnswer = Console.ReadLine();
            Console.WriteLine("_______");
            return cusomterAnswer;

             
            // welcome message -- what would you like to do?
            // view all items
            // search for items based on ID / Type / Name / Description / Price / Quantity
            // add item to inventory
            // Buy item
            // What item would you like to buy;
            // recap of the item
            // generate and save an invoice
        }

        // dit moet nog als switch worden gebouwd //
        public void GardenStartMenu()
        {
            InventoryItem inventoryitem = new InventoryItem();
            string cusomterAnswer = inventoryitem.ListOfQuestions("welcome");
            string keepGoing = "true";
         
                if (cusomterAnswer == "view all items")
                {
                    List<string> list = InventoryList();
                    AddInventoryToList(list);
                    cusomterAnswer = inventoryitem.ListOfQuestions("helpagain");
                }
                else if (cusomterAnswer == "search for items")
                {
                    cusomterAnswer = inventoryitem.ListOfQuestions("search");
                    cusomterAnswer = inventoryitem.ListOfQuestions("type");

                    string keepSearching = "true";

                    while (keepSearching == "true")
                    {
                        List<string> list = InventoryList();
                        PlantItem plantItem = new PlantItem();
                        plantItem.AddInventoryToList(list, cusomterAnswer);
                        cusomterAnswer = inventoryitem.ListOfQuestions("other");

                        if (cusomterAnswer == "no")
                        {
                            keepSearching = "false";
                        }
                    }
                }
                else if (cusomterAnswer == "add item to inventory")
                {

                }
                else if (cusomterAnswer == "buy item")
                {

                }
                else
                {
                    throw new Exception();
                }            
        }

        public List<string> InventoryList()
        {
            List<string> Inventory = new List<string>();
            string filePath = @"C:\Users\Eelco\Desktop\programmeren\.NET\GardenInventory.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Inventory.AddRange(File.ReadAllLines(filePath));
                }
            }
            else
            {
                Console.WriteLine("The specified file does not exist.");
            }

            return Inventory;
        }

        // dit moet nog als LINQ gebouwd worden
        public void AddInventoryToList(List<string> Inventory)
        {

            for (int i = 1; i < Inventory.Count; i++)
            {
                string specificline = Inventory[i];
                string[] parts = specificline.Split(',');
                //dus als het tweede woord na de , gelijk is aan customerinput pakken we de string. Het tweede woord is in dit geval altijd type
                
                    Id = Convert.ToInt32(parts[0]);
                    Type = parts[1];
                    Name = parts[2];
                    Description = parts[3];
                    Price = decimal.Parse(parts[4], CultureInfo.InvariantCulture);
                    Quantity = Convert.ToInt32(parts[5]);

                    Console.WriteLine($"This {Type} is called {Name}, we would describe it as {Description}, the Price is: {Price}, and there are just {Quantity} left in the store \n");                
            }      

        }

    }


    // dit moet nog als LINQ gebouwd worden
    internal class PlantItem : InventoryItem
    {
        public PlantItem() { }
        public string PlantType { get; set; }
        public string SunRequirement { get; set; }

        public void AddInventoryToList(List<string> Inventory, string input)
        {
            string customerinput = input;

            for (int i = 0; i < Inventory.Count; i++)
            {
                string specificline = Inventory[i];
                string[] parts = specificline.Split(',');
                //dus als het tweede woord na de , gelijk is aan customerinput pakken we de string. Het tweede woord is in dit geval altijd type
                if (parts[1] == customerinput)
                {
                    Id = Convert.ToInt32(parts[0]);
                    Type = parts[1];
                    Name = parts[2];
                    Description = parts[3];
                    Price = decimal.Parse(parts[4], CultureInfo.InvariantCulture);
                    Quantity = Convert.ToInt32(parts[5]);
                    // deze moeten nog anders gesplits worden // gezocht worden
                    //PlantType = parts[PlantType];
                    //SunRequirement = parts[7];

                    Console.WriteLine($"This {customerinput} is called {Name}, The planttype is:{PlantType} we would describe it as {Description}, The fully grow this needs to be in {SunRequirement} the Price is: {Price}, and there are just {Quantity} left in the store \n");
                }
            }
        }
    }
    internal class ToolItem : InventoryItem 
    { 
        public ToolItem() { }
        public string ToolType { get; set; }
        public string Material {  get; set; }
    }

    internal class FertilizerItem : InventoryItem
    {
        public FertilizerItem() { }
        public string Composition { get; set; }
        public int PackageSize {get; set; }
    }

    internal class DecorItem : InventoryItem
    {
        public DecorItem() { }
        public string Material { get; set; }
        public string OutdoorIndoor { get; set; }
    }

}
