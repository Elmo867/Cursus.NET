using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Customer
    {
        
        public virtual List<string> getAdress()
        {
            Console.WriteLine("How can i help you?\n get adress \n add adress \n remove adress");
            string answer = Console.ReadLine();

            if(answer == "get adress")
            {
                Adress adress = new Adress();
                var list = adress.ListOfAdresses();
                return list;
            }
            else
            {
                throw new Exception();
            }
        }

        public List<string> AddAdress(List<string> list)
        {
            Adress adress = new Adress();
            adress.AddAdresses(list);
            return list;
        }
        public List<string> RemoveAdress(List<string> list)
        {
            Adress adress = new Adress();
            adress.Removeadress(list);
            return list;
        }       
    }

    internal class Adress
    { 
        public List<string> ListOfAdresses()
        {
            var list = new List<string> { "adres1", "adres2", "adres3", "adres4" };
            foreach (string adress in list)
            {
                Console.WriteLine(adress);
            }

            Console.WriteLine("------------");
            return list;

        }
       public List<string> AddAdresses(List<string> list)
        {
            list.Add("adres5");
            list.Add("adres6");
            foreach (string adress in list)
            {
                Console.WriteLine(adress);
            }
            Console.WriteLine("------------");


            list.Insert(5, "adress7");
            foreach (string adress in list)
            {
                Console.WriteLine(adress);
            }

            Console.WriteLine("------------");

            return list;
        }

        public void Removeadress(List<string> list)
        {
            list.RemoveAt(5);
            foreach (string adress in list)
            {
                Console.WriteLine(adress);
            }
        }




    }
}
