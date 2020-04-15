# Part 10

NOTICE! All the exercises in part 10 are worth 2.

#### Exercise_156

You are provided with the class **Human**. A human has a name and wage information. Implement the interface **IComparable** in a way, that the **CompareTo**-method sorts the humans according to wage from biggest to smallest salary. The Program.cs already contains the following code for trying out your method.

```cs
List<Human> humans = new List<Human>();
humans.Add(new Human("Merja", 500));
humans.Add(new Human("Pertti", 80));
humans.Add(new Human("Matti", 150000));

// Sorts the list when your ComparedTo works
// Sort uses CompareTo internally
humans.Sort();
humans.ForEach(Console.WriteLine);
```

```console
Matti 150000
Merja 500
Pertti 80
```

#### Exercise_157

The exercise template includes the class **Student**, which has a name. Implement the **IComprable**-interface in the Student-class in a way, that the CompareTo-method sorts the students in alphabetical order based on their names.

HINT: The name of the Student is a string, which implements Comparable itself. You may use it's CompareTo-method for your advantage when implementing the method for the Student-class. Note that string.CompareTo is case sensitive, but at this exercise, we don't have to worry about it.

```cs
Student first = new Student("jamo");
Student second = new Student("jamo1");

// Should print -1
Console.WriteLine(first.CompareTo(second));
``` 

#### Exercise_158

Write a program that reads user input for books and their age recommendations.

The program asks for new books until the user gives an empty string (only presses enter). After this, the program will print the amount and names of the books.

* Implement the reading and printing the books first in the **TextInterface**, the ordering of them doesn't matter yet.

```console
Input the name of the book, empty stops: 
> The Ringing Lullaby Book 
Input the age recommendation:
> 0
Input the name of the book, empty stops:
> The Exiting Transpotation Vehicles 
Input the age recommendation:
> 0
Input the name of the book, empty stops:
> The Snowy Forest Calls 
Input the age recommendation:
> 12
Input the name of the book, empty stops: 
> Litmanen 10 
Input the age recommendation:
> 10
Input the name of the book, empty stops:

4 books in total.

Books: 
The Ringing Lullaby Book (recommended for 0 year-olds or older) 
The Exiting Transpotation Vehicles (recommended for 0 year-olds or older) 
The Snowy Forest Calls (recommended for 12 year-olds or older) 
Litmanen 10 (recommended for 10 year-olds or older)
```

* Expand your program so, that the books are sorted based on their age recommendations when they are printed. If two (or more) books share the same age recommendations the order between them does not matter. (i.e. create ComparedTo in Book class)


```console
Input the name of the book, empty stops: 
> The Ringing Lullaby Book 
Input the age recommendation:
> 0
Input the name of the book, empty stops:
> The Exiting Transpotation Vehicles 
Input the age recommendation:
> 0
Input the name of the book, empty stops:
> The Snowy Forest Calls 
Input the age recommendation:
> 12
Input the name of the book, empty stops: 
> Litmanen 10 
Input the age recommendation:
> 10
Input the name of the book, empty stops:

4 books in total.

Books: 
The Ringing Lullaby Book (recommended for 0 year-olds or older) 
The Exiting Transpotation Vehicles (recommended for 0 year-olds or older) 
Litmanen 10 (recommended for 10 year-olds or older) 
The Snowy Forest Calls (recommended for 12 year-olds or older)
```

* Expand your program, so that it sorts the books with the same age recommendation based on their name alphabetically. HINT! Use an if for the age recommendations!

```console
Input the name of the book, empty stops: 
> The Ringing Lullaby Book 
Input the age recommendation:
> 0
Input the name of the book, empty stops:
> The Exiting Transpotation Vehicles 
Input the age recommendation:
> 0
Input the name of the book, empty stops:
> The Snowy Forest Calls 
Input the age recommendation:
> 12
Input the name of the book, empty stops: 
> Litmanen 10 
Input the age recommendation:
> 10
Input the name of the book, empty stops:

4 books in total.

Books: 
The Exiting Transpotation Vehicles (recommended for 0 year-olds or older) 
The Ringing Lullaby Book (recommended for 0 year-olds or older) 
Litmanen 10 (recommended for 10 year-olds or older) 
The Snowy Forest Calls (recommended for 12 year-olds or older)
```

#### Exercise_159

In the template is a class **Checker**, which has three methods. Your task is to fill in the methods as follows:

* Use regular expressions in **DayOfWeek(string str)**, which returns true if the parameter string is an abbreviation of a day of the week (mon, tue, wed, thu, fri, sat, sun)

* Use regular expressions in **AllVowels(string str)**, which returns true if all the letters in given string are wovels.

NOTICE! For simplicity's sake, in this exercises the letters that are considered vowels are: a, e, i, o, and u. You don't have to take into account capital letters, but you can if you want to.

* Use regular expressions in **TimeOfDay(string str)**  to check whether the parameter string expresses a time of day in the form hh:mm:ss (hours, minutes, and seconds each always take up two spaces).

NOTICE! The last one is tricky, and you might want to search the internet for answers.

```cs
Checker check = new Checker();

Console.WriteLine(check.DayOfWeek("tue"));
  Console.WriteLine(check.DayOfWeek("tues"));

Console.WriteLine(check.AllVowels("aeiouaaeeioiouoiaoueaiaeiou"));
Console.WriteLine(check.AllVowels("aeiouaaeeioiouoKiaoueaiaeiou"));

Console.WriteLine(check.TimeOfDay("23:23:59"));
Console.WriteLine(check.TimeOfDay("00:00:60"));
```

```console
True
False
True
False
True
False
```

#### Exercise_160

The exercise template has a class that represents a playing card. Each card has a value and a suit. Card's value is represented as a number *2, 3, ..., 14* and its suit as *Club, Diamond, Heart or Spade*. Ace's value is 14. The value is represented with an integer, and the suit as an enum. Cards also have a method **ToString**, which can be used to print the value and the suit in a readable form.

New cards can be created like this:

```cs
Card first = new Card(2, Suit.Diamond);
Card second = new Card(14, Suit.Spade);
Card third = new Card(12, Suit.Heart);

Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);
```

```console
Diamond 2
Spade A
Heart Q
```

NOTICE! in the ToString, make sure you have special returns for values 11 to 14 (J, Q, K and A).

* Change the Card class to implement the **IComparable**. Implement the **CompareTo** method so that using it sorts the cards ascending by their value. If the cards being compared have the same value, they are sorted by *club first, diamond next, heart third, and spade last*.

So, for this sorting, the least valuable card is two of clubs, and highest the ace of spades.

```cs
Card first = new Card(2, Suit.Club);
Card second = new Card(14, Suit.Spade);
Card third = new Card(12, Suit.Heart);
Card fourth = new Card(14, Suit.Heart);
Card fifth = new Card(12, Suit.Diamond);

List<Card> list = new List<Card> { first, second, third, fourth, fifth };
list.Sort();
list.ForEach(Console.WriteLine);
```

```console
Club 2
Diamond Q
Heart Q
Heart A
Spade A
```

* Create a class **Hand** to represent the cards in player's hand. Add the following methods to the class:

* **public void Add(Card card)** adds a card to the hand. If the card is already in the hand, someone is cheating, and the card should not be added. **Use a List to store the cards.**
* **public void Print()** prints the cards in hand as shown in the example below

```cs
Hand hand = new Hand();

hand.Add(new Card(2, Suit.Diamond));
hand.Add(new Card(14, Suit.Spade));
hand.Add(new Card(12, Suit.Heart));
hand.Add(new Card(2, Suit.Spade));

hand.Print();
```

```console
Diamond 2
Spade A
Heart Q
Spade 2
```

* Add a method **public void Sort()** to Hand class, which sorts the cards in the hand. After sorting, the cards are printed out in order:

```cs
Hand hand = new Hand();

hand.Add(new Card(2, Suit.Diamond));
hand.Add(new Card(14, Suit.Spade));
hand.Add(new Card(12, Suit.Heart));
hand.Add(new Card(2, Suit.Spade));

hand.Sort();
hand.Print();
```

```console
Diamond 2
Spade 2
Heart Q
Spade A
```

In a card game, hands are ranked based on the sum of values of its cards. Modify the Hand class to be comparable based on this criteria, i.e. change the class so that interface **IComparable\<Hand\>** applies to it.

Here's an example of a program that compares the hands:

```cs
Hand hand1 = new Hand();

hand1.Add(new Card(2, Suit.Diamond));
hand1.Add(new Card(14, Suit.Spade));
hand1.Add(new Card(12, Suit.Heart));
hand1.Add(new Card(2, Suit.Spade));

Hand hand2 = new Hand();

hand2.Add(new Card(11, Suit.Diamond));
hand2.Add(new Card(11, Suit.Spade));
hand2.Add(new Card(11, Suit.Heart));

int comparison = hand1.CompareTo(hand2);

if (comparison < 0)
{
  Console.WriteLine("better hand is");
  hand2.Print();
}
else if (comparison > 0)
{
  Console.WriteLine("better hand is");
  hand1.Print();
}
else
{
  Console.WriteLine("hands are equal");
}
```

```console
better hand is
Diamond J
Spade J
Heart J
```