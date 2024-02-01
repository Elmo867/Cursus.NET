using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Program1
{
    public interface IDisplayable
    {
        void Display();
        
    }
    internal class Person6 : IDisplayable
    {
        // Create a `Person` class with properties like name, age, and address. Implement multiple constructors with different parameter lists to create `Person` objects in various ways.

        // de properties of deze class
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        // de overload constructors
        public Person6() { }
        public Person6(string name)
        {
            Name = name;
        }
        public Person6(string name, int age)
        { }
        public Person6(string name, int age, string adress) { }

        public void Display()
        {
            Console.WriteLine("test");
        }
    }

}
