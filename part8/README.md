# Part 8

#### Exercise_138

In the Main-method create a new Dictionary\< string , string \> object. Store the names and nicknames of the following example in this dictionary so, that the name is the key and the nickname is the value.

Then get the names from the dictionary, and print the following:

```console
matthew's nickname is matt
michael's nickname is mix
arthur's nickname is artie
```

Use a foreach-loop to print over KeyValuePair for the printing.

#### Exercise_139

Fill in the class **Abbreviations** for managing common abbreviations. The class must have a constructor, which does not take any parameters. The class must also provide the following methods:

* **public void AddAbbreviation(string abbreviation, string explanation)** adds a new abbreviation and its explanation. You can use the **.Add** method for the dictionary and assume we never add the same abbrevation twice.
* **public bool HasAbbreviation(string abbreviation)** checks if an abbreviation has already been added; returns true if it has and false if it has not.
* **public string FindExplanationFor(string abbreviation)** finds the explanation for an abbreviation; returns "not found" if the abbreviation has not been added yet.

HINT! Use HasAbbreviation in your FindExplanationFor to avoid errors!

Example:

```cs
Abbreviations abbreviations = new Abbreviations();
abbreviations.AddAbbreviation("e.g", "for example");
abbreviations.AddAbbreviation("etc.", "and so on");
abbreviations.AddAbbreviation("i.e", "more precisely");

string text = "e.g i.e etc. lol";

foreach (string part in text.Split(" "))
{
  Console.WriteLine(abbreviations.FindExplanationFor(part));
}
```

```console
for example
and so on
more precisely
not found
```

#### Exercise_140

Exercise template contains a class Program. Implement the following class methods in the class:

* **public static void PrintKeys(Dictionary<string,string> dict)**, prints all the keys in the dictionary given as a parameter.
* **public static void PrintKeysWhere(Dictionary<string,string> dict, string text)** prints the keys in the dictionary given as a parameter, which contain the string given as a parameter.
* **public static void PrintValuesOfKeysWhere(Dictionary<string,string> dict, string text)**, prints the values in the given dictionary whichs keys contain the given string.

Example of using the class methods:

```cs
Dictionary<string,string> dict = new Dictionary<string, string>();
dict.Add("f.e", "for example");
dict.Add("etc.", "and so on");
dict.Add("i.e", "more precisely");

PrintKeys(dict);
Console.WriteLine("---");
PrintKeysWhere(dict, "i");
Console.WriteLine("---");
PrintValuesOfKeysWhere(dict, ".e");
```

```console
f.e 
etc. 
i.e 
--- 
i.e 
--- 
for example 
more precisely
```

NOTICE! The order of the output can vary, as the dictionary does not guarantee the order of the objects in it.

#### Exercise_141

The exercise template contains the already familiar classes Book and Program. In the class Program implement the following class methods:

* **public static void PrintValues(Dictionary\< string, Book \> dictionary)**, which prints all the values in the dictionary given as a parameter using the **ToString** method of the Book objects.
* **public static void PrintValueIfNameContains(Dictionary\< string, Book \> dictionary, string text)**, which prints only the Books in the given dictionary whose name contains the given string. You can find out the name of a Book with the property **name**.

```cs
Dictionary<string, Book> books = new Dictionary<string, Book>();
Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
books.Add(senseAndSensibility.name, senseAndSensibility);
books.Add(prideAndPrejudice.name, prideAndPrejudice);

PrintValues(books);
Console.WriteLine("-- -- -- --");
PrintValueIfNameContains(books, "prejud");
```

```console
Name: Sense and Sensibility (1811)
Content: ...
Name: Pride and Prejudice (1813)
Content: ....
-- -- -- --
Name: Pride and Prejudice (1813)
Content: ....
```

NOTICE! The order of the output can vary, as the dictionary does not guarantee the order of the objects in it.

#### Exercise_142

Create a class called **IOU** which has the following methods:

* constructor **public IOU()** creates a new IOU
* **public void ChangeDebt(string toWhom, int amount)** saves the amount owed and the person owed to to the IOU. You can use this to also lower the debt, but the total amount cannot be negative!
* **public int HowMuchDoIOweTo(string toWhom)** returns the amount owed to the person whose name is given as a parameter. If the person cannot be found, it returns 0.

The class can be used like this:

```cs
IOU mattsIOU = new IOU();
mattsIOU.ChangeDebt("Arthur", 51);
mattsIOU.ChangeDebt("Michael", 30);

Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Michael"));
Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Heikki"));
```

```console
51
30
0
```

Notice! If a new debt is added, the debt increases or decreases. Take that into account in your code. Also, the the total amount should not be negative!

```cs
IOU mattsIOU = new IOU();
mattsIOU.ChangeDebt("Arthur", -10);

Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));

mattsIOU.ChangeDebt("Arthur", 51);
mattsIOU.ChangeDebt("Arthur", 30);

Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));

mattsIOU.ChangeDebt("Arthur", -30);

Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));

mattsIOU.ChangeDebt("Arthur", -80);

Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
```

```console
0
81
51
0
```

#### Exercise_143

The exercise template contains a class **SimpleDate**, which defines a date object based on a given day, month, and year. In this exercise you will expand the SimpleDate class with an equals method, which can tell if the dates are exactly the same.

* Create a method **public override bool Equals(object compared)** for the SimpleDate class, which returns true if the date of the object passed to the method as a parameter is the same as the date of the object used to call the method.

Create a method **public override int GetGetHashCode()** for the SimpleDate class, which calculates a hash for the the SimpleDate object. Implement the calculation of the hash in way that there are as few similar hashes as possible between the years 1900 and 2100.

The Equals should work as follows:

```cs      
SimpleDate d = new SimpleDate(1, 2, 2000);
Console.WriteLine(d.Equals("heh"));
Console.WriteLine(d.Equals(new SimpleDate(5, 2, 2012)));
Console.WriteLine(d.Equals(new SimpleDate(1, 2, 2000)));
```

```console
false
false
true
```

#### Exercise_144

European license plates have to parts, a two letter country code and a nationally unique license number. The license number is made up of numbers and characters. License plates are represented by the following class:

```cs
public class LicensePlate
{
  private string liNumber;
  private string country;

  public LicensePlate(String country, String liNumber)
  {
    this.liNumber = liNumber;
    this.country = country;
  }


  public override string ToString()
  {
    return country + " " + liNumber;
  }
}
```

We want to be able to save the license plates in e.g Lists and to use them as keys in a Dictionary. Which, as explained above, means that the **Equals** and **GetHashCode** methods need to be overwritten, or they won't work as intended. Implement the methods Equals and GetHashCode for the LicensePlate class.

Example program:

```cs
LicensePlate li1 = new LicensePlate("FI", "ABC-123");
LicensePlate li2 = new LicensePlate("FI", "UXE-465");
LicensePlate li3 = new LicensePlate("D", "B WQ-431");

List<LicensePlate> finnishPlates = new List<LicensePlate>();
finnishPlates.Add(li1);
finnishPlates.Add(li2);

LicensePlate newLi = new LicensePlate("FI", "ABC-123");
if (!finnishPlates.Contains(newLi))
{
  finnishPlates.Add(newLi);
}
Console.WriteLine("Finnish: ");
foreach (LicensePlate plate in finnishPlates)
{
  Console.WriteLine(plate);
}

Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
owners.Add(li1, "Arto");
owners.Add(li3, "Jürgen");

Console.WriteLine("Owners:");
Console.WriteLine(owners[new LicensePlate("FI", "ABC-123")]);
Console.WriteLine(owners[new LicensePlate("D", "B WQ-431")]);
```

```console
Finnish: 
FI ABC-123
FI UXE-465
Owners:
Arto
Jürgen
```

#### Exercise_145

Expand on the previous exercise. 

* Copy your answer for the LicensePlate-class to this exercise's template.

Implement the class **VehicleRegistry**, which has the following methods:

* **public bool Add(LicensePlate licensePlate, string owner)** assigns the owner it received as a parameter to car corresponding with the license plate received as a parameter. If the license plate didn't have an owner returns **true**. If the license already had an owner attached, the method returns **false and does nothing**.

* **public string Get(LicensePlate licensePlate)** returns the owner of the car corresponding to the license plate received as a parameter. If the car isn't in the registry, returns an error message (of your choice).

* **public bool Remove(LicensePlate licensePlate)** removes the license plate and attached data from the registry. Returns **true** if removed successfully and **false** if the license plate wasn't in the registry.

* **public void PrintLicensePlates()** prints the license plates in the registry.

* **public void PrintOwners()** prints the owners of the cars in the registry. Each name should only be printed once, even if a particular person owns more than one car.

Now the program should work something like this:

```cs
LicensePlate li1 = new LicensePlate("FI", "ABC-123");
LicensePlate li2 = new LicensePlate("FI", "UXE-465");
LicensePlate li3 = new LicensePlate("D", "B WQ-431");
LicensePlate li4 = new LicensePlate("D", "B WQ-432");
LicensePlate li5 = new LicensePlate("D", "B WQ-433");

VehicleRegistry register = new VehicleRegistry();

register.Add(li1, "Arto");
register.Add(li2, "Arto");
register.Add(li3, "Jürgen");
register.Add(li4, "Jürgen");
register.Add(li5, "Jürgen");

Console.WriteLine("Plates:");
register.PrintLicensePlates();

Console.WriteLine("Owners:");
register.PrintOwners();
```

```console
Plates:
FI ABC-123
FI UXE-465
D B WQ-431
D B WQ-432
D B WQ-433
Owners:
Arto
Jürgen
```

HINT! In the printOwners method, you can create a list used for remembering the owners that were already printed. If an owner is not on the their name is printed and they are added to the list -- if an owner is on the list their name isn't printed.

#### Exercise_146

Your assignment is to create the class **DictionaryOfManyTranslations**. In it can be stored one or more translations for each word. The class is to implement the following methods:

* **public void Add(string word, string translation)** adds the translation for the word and preserves the old translations.
* **public List<string> Translate(string word)** returns a list of the translations added for the word. If the word has no translations, the method should return an empty list.
* **public void Remove(string word)** removes the word and all its translations from the dictionary.
It's probably best to add the translations to an object variable that is of the type **Dictionary\<string, List\<String\> \>**

An example:

```cs
DictionaryOfManyTranslations dictionary = new DictionaryOfManyTranslations();
dictionary.Add("lie", "maata");
dictionary.Add("lie", "valehdella");

dictionary.Add("bow", "jousi");
dictionary.Add("bow", "kumartaa");

foreach (string translation in dictionary.Translate("bow"))
{
  Console.WriteLine(translation);
}
Console.WriteLine();

foreach (string translation in dictionary.Translate("lie"))
{
  Console.WriteLine(translation);
}

dictionary.Remove("bow");
foreach (string translation in dictionary.Translate("bow"))
{
  Console.WriteLine(translation);
}
```

```console
jousi
kumartaa

maata
valehdella
```

#### Exercise_147

Your task is creating a class called **StorageFacility** that can be used to keep track of storage units and their contents. The class is to implement the following methods:

* **public void Add(string unit, string item)** adds the parameter item to the storage unit that is also given as a parameter.

* **public List\<string\> Contents(string storageUnit)** returns a list that contains all the items in the storage unit indicated by the parameter. If there is no such storage unit or it contains no items, the method should return an empty list.

* **public void Remove(string storageUnit, string item)**  removes the given item from the given storage unit. 

NOTICE! Only removes one item -- if there are several items with the same name, the rest still remain. If the storage unit would be empty after the removal, the method also removes the unit.

* **public List\<string\> StorageUnits()**  returns the names of the storage units as a list. 

NOTICE! Only the units that contain items are listed.

Here's an example:

```cs
StorageFacility facility = new StorageFacility();
facility.Add("a14", "ice skates");
facility.Add("a14", "ice hockey stick");
facility.Add("a14", "ice skates");

facility.Add("f156", "rollerblades");
facility.Add("f156", "rollerblades");

facility.Add("g63", "six");
facility.Add("g63", "pi");

foreach (string unit in facility.StorageUnits())
{
  Console.WriteLine(unit);
}

foreach (string item in facility.Contents("a14"))
{
  Console.WriteLine(item);
}

foreach (string item in facility.Contents("f156"))
{
  Console.WriteLine(item);
}
facility.Remove("f156", "rollerblades");

foreach (string item in facility.Contents("f156"))
{
  Console.WriteLine(item);
}

facility.Remove("f156", "rollerblades");

foreach (string unit in facility.StorageUnits())
{
  Console.WriteLine(unit);
}
```

```console
a14
f156
g63
ice skates
ice hockey stick
ice skates
rollerblades
rollerblades
rollerblades
a14
g63
```