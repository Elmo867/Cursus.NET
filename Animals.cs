using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    internal class Zoo
    {
        public List<Animals> AlltheAnimals { get; set; } = new List<Animals>();
    }
}
    
  /*  internal class StartAnimals()
    {
        static void PopulateAnimals()
        {
            var animals = new list<Animals>()
            {
                Name = "Geit",
                Age = 20
            }
            dieren.AlltheAnimals.Add(new Animals()
            {
                Name = "Aap",
                Age = 15
            });
            dieren.AlltheAnimals.Add(new Animals()
            {
                Name = "Koe",
                Age = 5
            });

            dieren.Where(a => a.Age >5)
                .ForEach(a => { Console.WriteLine(a)
                 .order; })

        }
    }
}*/
