using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSecond
{

    public class Program3
    {
        public static void program3()
        {
            // create a student object
            Student s1 = new Student();
            s1.Name = "Jenny";

            // now make a new object with the same name
            Student s2 = new Student();
            s2.Name = s1.Name.ToUpper();

            Console.WriteLine("s1 - " + s1.Name + ", s2 - " + s2.Name);
            Console.ReadLine();
        }
    }
    
    class Student
    {
        public String Name;
    }
}



