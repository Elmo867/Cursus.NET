using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program1;

namespace Program1
{
    internal static class BoardGameMenu
    {
        public static void GameMenu()
        {
            BoarGameStart message = new BoarGameStart();
            message.GameStart();

        }
    }

    internal class BoarGameStart
    {
        public void GameStart()
        {
            Console.WriteLine("Hello and welcome to your boardgame menu, you have a few options you can choose from;\n 1.View all items \n 2.Look up item by ID \n 3.Add item to inventory");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Perfect we will look up all the items for you:");
                InventoryList InventoryList = new InventoryList();
                InventoryList.DisplayItems();

            }
            else if (answer == 2)
            {
                Console.WriteLine("What ID do you have in mind for us?");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Perfect we will look it up for you now");
                InventoryList InventoryList = new InventoryList();
                InventoryList.ItemByID(answer);

            }
            else if (answer == 3)
            {
                Console.WriteLine("What item would you like to add?");
                string answer2 = Console.ReadLine();
                InventoryItem2 NewItem = new InventoryItem2 { Name = answer2 };
                //InventoryItem NewItem = CreateInventory(answer2);                         Waarom kan hij deze niet vinden?
                InventoryList InventoryList = new InventoryList();
                InventoryList.AddItem(NewItem);
                //Console.WriteLine("In which category does this fall?;\n1.Strategygame \n2. FamilyGame \n3. CardGame");
                //int answer3 = Convert.ToInt32(Console.ReadLine());
            }
            else { Console.WriteLine("Im sorry we didnt understand your question"); }
            // hier nog een exeption throwen
            
        }
        
    }
}
