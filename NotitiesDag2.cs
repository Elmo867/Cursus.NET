using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/* classes bevat de volgende dingen
 * - fields                 -- begint met een kleine letter
 * - properties             -- begint met een hoofdletter   --- 
 * variable {get; set;}     -- set waardes kun je ook aanpassen met bijvoorbeeld if statements
 * - methods                -- stuk code die je las aan kan roepen en die iets uitvoert 
 * modifier - returntype - nameofmethod - (paramater list)
 * {method body}
 * - constructors           -- een methode zonder naam en die return een x
 * - finalizers
 * 
 * acces modifiers;
 * private              -- kan je alleen bij vanuit de class
 * public               -- kan overal bij
 * internal             -- alleen beschikbaar vanuit jou eigen project
 * protected internal
 * proteced
 * 
 * 
 *  
 * scope
 * class        --- gehele class, dus alles in die classes zijn beschikbaar
 * methode      --- alleen beschikbaar in de methode
 * block        --- alleen beschikbaar in bijvoorbeeld een specifieke if statement
 * 
 * 
 * inheritance
 * 
 * maak een class aan genaamd Person met x gegevens
 * 
 * vervolgens maak een nieuwe class aan zoals dit; User : Person
 * deze erft nu dus alle gegevens* die je gedefinieerd hebt bij Person en die kun je dus ook direct weer gebruiken
 * ** bijna alles behalve private members, constructors, finalizers
 * 
 * als 1 class iets erft van bovenstaande "base" class -- die heet derived classed
 * 
 * -- om een constructur van één class boven je eigen class aan te roepen kun je neerzetten : Base()
 * -- om een constructur van je eigen class aan te roepen kun je nog neerzetten : this.
 * 
 * 
 * Method overriding
 * vindt plaats tussen een base en derived class --- een derived class kan dan de methode van base overschrijven maar wel met dezelfde naam etc.
 * 
 * in de base class geef je de naam "virtual" mee en in de derived class zet je dan "override" neer
 * 
 * Polymorphism
 * 
 * 
 * 
 * abstract --- hiermee kun je een class aanmaken waarbij je nog niet weet met welke waardes deze gevuld gaan worden
 * static   --- a member belongs to the class itself and not an instance -- you can acces them without having to make an object of the class -- is een gedeelde variabele
 * -- variabele wil je static maken als je geen nieuwe instances hiervan aan hoeft te maken. Voor bijvoorbeeld een gamecharacter wil je niet static hebben want hier heb je verschillende
 * instances van
 * sealed   --- als het op een class staat mag je die niet erven, als het op een methode staat mag je die niet overschrijven
 * 
 * 
 * 
 * class -- is a blueprint and defines actual objects
 * instance --- is the embodiment of a class --- dus het aanmaken van een nieuwe object --- new Person()
 */