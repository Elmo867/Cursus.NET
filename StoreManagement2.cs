using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
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
            Console.WriteLine("Hello and welcome to your boardgame menu, you have a few options you can choose from;\n 1.View all items \n 2.Look up item by ID \n 3.Add item to inventory \n");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("\nPerfect we will look up all the items for you:");
                InventoryItem3 InventoryList = new InventoryItem3();
                InventoryList.DisplayItems();
                Console.WriteLine("which kind of game would you like to see more details from? \nStrategyGame \nFamilyGame \nCardGame \n");
                string Answer2 = Console.ReadLine().ToLower();
                InventoryList.DisplayItems(Answer2);

            }
            else if (answer == 2)
            {
                Console.WriteLine("What ID do you have in mind for us?");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Perfect we will look it up for you now");
                InventoryItem3 InventoryList = new InventoryItem3();
                InventoryList.ItemByID(answer);

            }
            else if (answer == 3)
            {
                Console.WriteLine("What item would you like to add?");
                string answer2 = Console.ReadLine();
                InventoryItem3 InventoryList = new InventoryItem3();
                InventoryList.AddItem(answer2);

            }
            else { Console.WriteLine("Im sorry we didnt understand your question"); }
            // hier nog een exeption throwen

        }

    }
}
