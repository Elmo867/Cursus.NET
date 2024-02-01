using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class DOTNETNotities
    {
    }
}


/*
C# is de taal waar we mee schrijven --> .NET is het framework die we gebruiken (een verzameling van liberaries + structuur)
binnen het framework hebben we ook nog meerdere opties
.framework is de voorloper van core
.core
.net




API --- application programming interface   --> deze kun je aanroepen en die voeren dan de programmering uit die daarop staat

ctrl k + ctrl c --> comments maken
ctrl k + ctrl u --> uncomment
ctrl + shift + /   ---> selecteer alles en comment het
@ voor de tekst wordt alles letterlijk genomen

github copilot  -- helpt je bij codeschrijven

Dry -- Dont Repeat Yourself

Namespace (begint met een hoofdletter) ---> een ruimte waar namen uniek moeten zijn -- je mag niet dezelfde class / program namen hebben

Valuetypes:  -- kunnen niet standaard null zijn
Variabele: (belangrijk om de juiste types te kiezen zodat de applicatie niet te vol raakt)
naamgevingsconventie; begin met kleine letter, vervolgens hoofdletter

Bestaat uit drie onderdelen
- type
- naam
- inhoud

type   naam    inhoud
string name = "Eelco"

declareren ---> je zegt dat iets bestaat
string name;
initialiseren --> je geeft het een waarde
name = "eelco"


Verschillende types;
bijvoorbeeld 
string  --> tekst
int --> heel nummer
double ---> decimaal
decimal --> wordt vaak voor geld gebruikt  --> 3.4m
float --> kleiner dan double   --> 3.4f
char character = 'a'  --> enkele quotes

functies:
naamgeving --> hoofdletter

Command readline geeft altijd een string terug
Als je dus een int wil uitlezen moet je eerst een convert. doen hiervoor dus bijvoorbeeld convert.ToInt32
32 --> int
64 --> long

kan eventueel ook met int.parse bijvoorbeeld (alleen is de convert manier veiliger i.v.m fout afhandeling)


Object verwijst naar een instantie van een klasse

Class is een verzameling van eigenschappen en functies
Class = auto
functie = rijden
eigenschap = kleur

The Heap
@100 = Car
int wielen = 5
string ruitenwisser = @101

@101 ruitenwisser
string kleur = blauw

The Stack
int x = 5
double y = 7.0
Car c = @100


string kan null zijn
int kan niet null zijn --- wil je een int wel een null maken moet je er een ? voor zetten
int? x = null;

Als je iets hebt dan null is dan kun je hier niks van opvragen
- bv heb je een kat
-- nee
-- hoe heet je kat 

dit kan dus niet want hij heeft helemaal geen kat


for loop gebruik je vaker als je al weet hoevaak je iets wil gaan doen
while loop gebruik je als je bijvoorbeeld connecties wil blijven proberen
do while gebruik je als je al weet dat je sowieso 1x een ding wil aftrappen

*/