using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ? achter een naam of iets dan betekent dat hij nullable kan zijn
 * 
 * interface
 * in een class kun je een interface interpreteren --- een contract voor behaviour
 * beginnen met hoofdletter I
 * gaat vaak over een eigenschap waar je iets mee kan doen of dingen die eigenschappen hebben
 * bij interface zet je geen abstract ervoor -- zie je aan het feit dat hij geen body heeft
 * 
 * public interface ISomeInterface
 * {
 * string Name {get;set};
 * bool Test(Object object);
 * }
 * 
 * Arrays
 * meerdere waardes van hetzelfde type in 1 variabele
 * Deze hebben altijd een fixed lengte van hoeveel dingen er in de array kunnen zitten.
 * 
 * string[] cars = {"Volvo", "BMW", "Ford"}
 * 
 *dingen eruit halen:
 *cars[0]
 *dingen overschrijven 
 *cars[0] = "Tesla"
 *
 *lengthe ophalen van de lijst
 *cars.Length;
 *
 *array.Sort(cars); -- alfabetische volgorde
 *
 *
 *gebruik van een for loop:
 *
 *string[] namen = {"Eelco", "Thomas"}
 *for int i = 0 i < namen.Length; 1++
 *
 *gebruik van for each loop
 *foreach(string naam in namen)
 *
 *lambda functie
 *input     wordt   output
 *(x,y)      =>     x.Length - y.Length
 * 
 * 
 * toString()
 * hiermee kun je aangeven hoe hijiets moet afdrukken als string
 * public to string()
 * {name}
 * 
 * Generics
 *                  T staat voor type
 * internal class Bag<T>
 * 
 * public T content {get;set;}
 * public void PrintContent()
 * {
 * console.WriteLine(content)
 * }
 * 
 * 
 * Lists:
 * var list = new List<int>();
 * list.add(1);
 * 
 * foreach (item in list)
 * 
 * list.count (hoeveel items er in de list zitten)
 * 
 *Dictionary
 *Deze pakken key-value pairs ipv 1 losse value
 *De keys moeten altijd uniek zijn
 *
 *LINQ
 *een set aan operaties die je op lijsten en data uit database kan uitvoeren  -- meerdere operatie op 1 lijst
 *list.where(getal => getal % 2 !=0).ForEach(getal => console.writeline(getal))
 *
 *
 *Als je using gebruikt wordt iets gebruikt en vervolgens automatisch gesloten
 *
 * 
 */
