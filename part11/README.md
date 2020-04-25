# Part 11

#### Exercise_161

The exercise template contains a class **Die**, which has the following body:

```cs
namespace Exercise
{
  using System;
  public class Die
  {
    private Random random;
    private int numberOfFaces;

    public Die(int numberOfFaces)
    {
      this.random = new Random();
      // Initialize the value of numberOfFaces here
    }
    public int ThrowDie()
    {
      // generate a random number which may be any number
      // between one and the number of faces, and then return it
      return 0;
    }
  }
}
```

Modify the class, such that the constructor **Die(int numberOfFaces)** creates a new die-object with the given number of faces (i.e. the number of "sides" with a number). Also, modify the method **ThrowDie** so it returns the result of a random throw of the die, which should be a value withing the range 1 ... number of faces.

The following is a Main program for testing the die:

```cs
Die die = new Die(6);

for (int i = 0; i < 10; i++)
{
  Console.WriteLine(die.ThrowDie());
}
```

The output could be as follows:

```console
5
3
2
6
4
2
4
1
2
5
```

#### Exercise_162

Your assignment is to complete the class **LotteryRow**, which is used to draw the week's winning numbers. The numbers are in range 1--40, and 7 numbers will be drawn in total. In other words, a lottery row consists of seven different numbers that are all in range 1--40.

We wish to implement the following functions in the class:

* the constructor **LotteryRow** creates a new LotteryRow object that contains new randomized numbers.
* the method **Numbers** returns the drawn lottery numbers of this lottery row
* the method **ContainsNumber** tells whether the given number is included in the drawn numbers
* the method **RandomizeNumbers** randomizes new numbers for the lottery row.  

The basic structure of the class is as follows:

```cs
namespace Exercise
{
  using System;
  using System.Collections.Generic;

  public class LotteryRow
  {
    private List<int> numbers;

    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      return false;
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
    }

  }
}
```

The following Main program is supplied in the exercise base:

```cs
LotteryRow row = new LotteryRow();
List<int> lotteryNumbers = row.Numbers();

Console.WriteLine("Lottery numbers:");
foreach (int number in lotteryNumbers)
{
  Console.Write(number + " ");
}

Console.WriteLine("");
```

Here are a few possible outputs of the program:

```console
Lottery numbers:
2 10 14 15 22 26 33
```


```console
Lottery numbers:
6 8 10 26 31 35 40
```

NOTICE! The same number can only appear once in a lottery row. Remember to also **Sort()** your list at the end of RandomizeNumbers.

#### Exercise_163

Let's practise a little parameter validation with the **ArgumentException** exception. There is a class called Person in the exercise:

* The constructor of the class **Person** should ensure that the name given as the parameter is not null, empty, or over 40 characters in length. The age should between 0 and 120. If some of these conditions are not met, the constructor should throw an **ArgumentException**.

#### Exercise_164

We have the following interface at our disposal:

```cs
namespace Exercise
{
  public interface Sensor
  {
    bool IsOn();    // returns true if the sensor is on
    void SetOn();      // sets the sensor on
    void SetOff();     // sets the sensor off
    int Read();        // returns the value of the sensor if it's on
                       // if the sensor is not on throw a IllegalStateException
  }
}
```

* Create a class called StandardSensor that implements the interface Sensor.

A standard sensor is always on. Calling the methods SetOn and SetOff has no effect. The StandardSensor must have a constructor that takes one integer parameter. The method call Read returns the number that was given to the constructor.

An example:

```cs
StandardSensor ten = new StandardSensor(10);
StandardSensor minusFive = new StandardSensor(-5);

Console.WriteLine(ten.Read());
Console.WriteLine(minusFive.Read());

Console.WriteLine(ten.IsOn());
ten.SetOff();
Console.WriteLine(ten.IsOn());
```

Sample output

```console
10
-5
true
true
```

* Create a class **TemperatureSensor** that implements the Sensor interface.

At first a temperature sensor is off. When the method Read is called and the sensor is on, the sensor randomly chooses an integer in the range -30...30 and returns it. If the sensor is off, the method Read throws an **InvalidOperationException**.

#### Exercise_165

In this exercise we will extend the dictionary so, that it can read words from a file and write words to a file. The dictionary must also be able to translate both from Finnish to another language and from another language to Finnish (in this exercise we ignore the fact that some words might be written the same in Finnish and in other languages). Your mission is to create a dictionary in the class **SaveableDictionary**.


##### Section 1

* For the dictionary, implement a constructor which takes no parameters, and the following methods:

* **public void Add(string words, string translation)** adds a word to the dictionary. Every word has just one translation, and if the same word is added for the second time, nothing happens.
* **public string Translate(string word)** returns the translation for the given word. If the word is not in the dictionary, returns null.  

In this phase, the dictionary should work as follows:

```cs
SaveableDictionary dictionary = new SaveableDictionary();
dictionary.Add("apina", "monkey");
dictionary.Add("banaani", "banana");
dictionary.Add("apina", "apfe");

Console.WriteLine(dictionary.Translate("apina"));
Console.WriteLine(dictionary.Translate("monkey"));
Console.WriteLine(dictionary.Translate("ohjelmointi"));
Console.WriteLine(dictionary.Translate("banana"));      
```

```console
monkey
apina

banaani
```

As can be seen from the output, after a translation has been added to the dictionary, it can translate the word to and from Finnish.

NOTICE! the methods Add and Translate do not read from a file or write to a file! The constructor does not touch the file either.

##### Section 2

* Add the dictionary method **public void Delete(string word)** which deletes the given word and its translation from the dictionary.

```cs
SaveableDictionary dictionary = new SaveableDictionary();
dictionary.Add("apina", "monkey");
dictionary.Add("banaani", "banana");
dictionary.Add("apina", "apfe");
dictionary.Add("ohjelmointi", "programming");

dictionary.Delete("apina");
dictionary.Delete("banana");

Console.WriteLine(dictionary.Translate("apina"));
Console.WriteLine(dictionary.Translate("monkey"));
Console.WriteLine(dictionary.Translate("banana"));
Console.WriteLine(dictionary.Translate("banaani"));
Console.WriteLine(dictionary.Translate("ohjelmointi"));
```

```console




programming
```

Deleting also works both ways: Both the word and its translation are removed if either the word or the translation are deleted.

##### Section 3

* Make a constructor **public SaveableDictionary(string file)** and method **public bool Load()**, which loads the dictionary from the file given to the constructor as a parameter. If the program is unable to open the file or read from it, the method returns false, otherwise it returns true.

NOTICE: the constructor only tells the dictionary the name of the file to load the dictionary from. The constructor does not read the file. Only the method Load reads the file.

In the dictionary file one line contains a word and its translation separated by ":". The exercise template contains a file words.txt which contains the following:

```console
apina:monkey
alla oleva:below
olut:beer
```

You can split a line using the string method **Split** like so:

```cs
string[] parts = line.split(":");   // split the line based on the ':' character

Console.WriteLine(parts[0]);     // part of line before :
Console.WriteLine(parts[1]);     // part of line after :
```

The dictionary can be used as follows:

```cs
SaveableDictionary dictionary = new SaveableDictionary("words.txt");
bool wasSuccessful = dictionary.Load();

if (wasSuccessful) 
{
  Console.WriteLine("Successfully loaded the dictionary from file");
}

Console.WriteLine(dictionary.Translate("apina"));
Console.WriteLine(dictionary.Translate("ohjelmointi"));
Console.WriteLine(dictionary.Translate("alla oleva"));
```

```console
Successfully loaded the dictionary from file
monkey

below
```

##### Sections 4 & 5

* Create the method **public bool Save()**, which saves the dictionary to the file given to the dictionary as a parameter to the constructor. If the program cannot save to the file, the method returns false. Otherwise it returns true. The dictionary files have to be saved in the form described above, so the program has to be able to read the files it has written.

NOTICE: Only the method save writes to the file.  

NOTICE: Even though the dictionary can translate both ways, the dictionary file should only contain one way. So if the dictionary for example knows, that computer = tietokone, the file should contain:

```console
tietokone:computer
```

or

```console
computer:tietokone
```

but not both!

It is best to handle the saving to, that the whole dictionary is written again on top of the previously saved version, rather than appending the new words.

The final version of the dictionary works as follows:

```cs
// assume the words.txt contains the original content.
SaveableDictionary dictionary = new SaveableDictionary("words.txt");
dictionary.Load();

// Translate all the words in the file both ways
Console.WriteLine(dictionary.Translate("apina"));
Console.WriteLine(dictionary.Translate("monkey"));
Console.WriteLine(dictionary.Translate("beer"));
Console.WriteLine(dictionary.Translate("olut"));
Console.WriteLine(dictionary.Translate("below"));
Console.WriteLine(dictionary.Translate("alla oleva"));

// Try adding, translating and removing a word, this should not affect the file
dictionary.Add("poista", "remove");
Console.WriteLine(dictionary.Translate("remove"));
dictionary.Delete("remove");

// Save the file
dictionary.Save();
```

```console
monkey
apina
olut
beer
alla oleva
below
poista
```

So in the beginning the dictionary is loaded from a file, and in the end it is saved back to the file, so that changes made to the dictionary are kept for the next time the dictionary is used.

NOTICE! The exercise also contains a file "testwords.txt" for tests. DO NOT TOUCH THAT FILE!
