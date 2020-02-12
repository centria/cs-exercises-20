## Object Oriented Programming

When creating own classes, make sure to include the correct **namespace** so you can reference it from your Program.cs file. We'll get to namespaces later. For now, whenever you create a new class, **use the folder name as the namespace**.

You can test your own classes in the Main if you want to, but it is not necessary. It does, of course, help you understand your code, and the exercises might include some examples, how the classes should work.

#### Exercise_93

The exercise template comes with a ready-made class named Account. The Account object represents a bank account that has balance (i.e. one that has some amount of money in it). The accounts are used as follows:

```cs
Account heikkisAccount = new Account("Heikki's account", 100.00);
Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

Console.WriteLine("Intial state");
Console.WriteLine(heikkisAccount);
Console.WriteLine(heikkisSwissAccount);

heikkisAccount.Withdrawal(20);
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
heikkisSwissAccount.Deposit(200);
Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

Console.WriteLine("End state");
Console.WriteLine(heikkisAccount);
Console.WriteLine(heikkisSwissAccount);
```

Write a program that 
- creates an account with a balance of 100.0, 
- deposits 20.0 in it, 
- and finally prints the balance. 

```console
120
```

NOTICE! Perform all the operations in this exact order.

#### Exercise_94

The Account from the previous exercise class is also available in this exercise.

Write a program that:

- Creates an account named "Heikki's account" with the balance 1000.0
- Creates an account named "Personal account" with the balance 0
- Withdraws 100.0 from Heikki's account
- Deposits 100.0 to its own personal account
- Prints account information (ToString) on both, first Heikki's, then Personal:

```console
Heikki's account balance: 900
Personal account balance: 100
```

#### Exercise_95

In this exercise, you'll practice creating a class.

[**CHECK THIS MATERIAL FOR HELP**](https://centria.github.io/basic-coding/part4/1/#creating-a-new-class)

Name the class **Dog** (and the file **Dog.cs**)

You have now created a class called **Dog**. 
Add the variables 
- private string name,
- private string breed and 
- private int age   
to the class. As a class diagram, the class looks like this:

![Dog class diagram](https://github.com/centria/coding-exercises/raw/master/assets/images/dogclass.jpg)

NOTICE! You have to give your dog **namespace exercise_95** for it to function!

#### Exercise_96

Create a class named **Room** (and file **Room.cs**). Add the variables **private string code** and **private int seats** to the class. Then create a constructor **public Room(string classCode, int numberOfSeats)** through which values are assigned to the instance variables.

![Room class diagram](https://github.com/centria/coding-exercises/raw/master/assets/images/roomclass.jpg)

NOTICE! You have to give your room **namespace exercise_96** for it to function!

#### Exercise_97

Create a class named **Whistle**. Add the variable **private string sound** to the class. After that, create the constructor **public Whistle(string whistleSound)**, which is used to create a new whistle that's given a sound. After that, create a method **public void Sound()** which prints out the sound (using Console.WriteLine).

```cs
Whistle duckWhistle = new Whistle("Kvaak");
Whistle roosterWhistle = new Whistle("Peef");

duckWhistle.Sound();
roosterWhistle.Sound();
duckWhistle.Sound();
```

```console
Kvaak 
Peef 
Kvaak
```

#### Exercise_98

Create a class **Product** that represents a store product. The product should have a **price (double)**, a **quantity (int)** and a **name (string)**.

The class should have:

- the constructor **public Product(string name, double price, int quantity)**
- a method **public void PrintProduct()** that prints product information in the following format:

```console
Banana: price 1.1: 13 pcs
```

The output above is based on the product being assigned the name banana, with a price of 1.1, and a quantity of 13 .

#### Exercise_99

This exercise consists of multiple sections. Each section corresponds to one exercise point.

The exercise template comes with a partially executed class DecreasingCounter:

```cs
using System;

namespace exercise_99
{
  public class DecreasingCounter
  {
    private int value;   // a variable that remembers the value of the counter

    public DecreasingCounter(int initialValue)
    {
      this.value = initialValue;
    }

    public void PrintValue()
    {
      Console.WriteLine("value: " + this.value);
    }

    public void decrement()
    {
      // write the method implementation here
      // the aim is to decrement the value of the counter by one
    }

    // and the other methods go here
  }
}
```

The following is an example of how the main program uses the decreasing counter:

```cs
public static void Main(string[] args)
{
  DecreasingCounter counter = new DecreasingCounter(10);
  counter.PrintValue();

  counter.Decrement();
  counter.PrintValue();

  counter.Decrement();
  counter.PrintValue();
}
```

```console
value: 10
value: 9
value: 8
```

##### Section 1 : Implementation of the **Decrement() method**

Implement the **Decrement()** method in the class body in such a way that it decrements the value variable of the object it's being called on by one. Once you're done with the **Decrement()** method, the main program of the previous example should work to produce the example output.

##### Section 2 : The counter's value cannot be negative

Improve the **Decrement()** in such a way that the counter's value never becomes negative. This means that if the value of the counter is 0, it cannot be decremented. A conditional statement is useful here.

```cs
public static void Main(string[] args)
{

  DecreasingCounter counter = new DecreasingCounter(2);
  counter.PrintValue();

  counter.Decrement();
  counter.Decrement();
  counter.PrintValue();

  counter.Decrement();
  counter.PrintValue();
}
```

```console
value: 2
value: 0
value: 0
```

##### Section 3: Resetting the counter value

Create the method **public void Reset()** for the counter that resets the value of the counter to 0. For example:

```cs
public static void Main(string[] args)
{

  DecreasingCounter counter = new DecreasingCounter(20);
  counter.PrintValue();

  counter.Reset();
  counter.PrintValue();
}
```

```console
value: 20
value: 0
```

#### Exercise_100

Create the class **Debt** that has double-typed instance variables of **balance** and **interestRate**. The balance and the interest rate are passed to the constructor as parameters **public Debt(double initialBalance, double initialInterestRate)**.

In addition, create the methods **public void PrintBalance()** and **public void WaitOneYear()** for the class. The method PrintBalance prints the current balance, and the WaitOneYear method grows the debt amount.

The debt is increased by multiplying the balance by the interest rate.

The class should do the following:

```cs
public static void Main(string[] args)
{

  Debt mortgage = new Debt(120000.0, 1.01);
  mortgage.PrintBalance();

  mortgage.WaitOneYear();
  mortgage.PrintBalance();

  // Wait 20 years
  int years = 0;
  while (years < 20)
  {
    mortgage.WaitOneYear();
    years = years + 1;
  }

  mortgage.PrintBalance();
}
```

The example above illustrates the development of a mortgage with an interest rate of one percent.

Prints:

```console
120000
121200
147887.0328416936
```

### Exercise_101

Create a class called **Dalmatian**. The dalmatian has instance variables **string name** and **int spots**. Both are set in the **public Dalmatian(string name, int spots)** constructor. Also, give the variables ability for get and set:
**Make the variables public rather than private, and add { get; set; } on the declaring lines!**

```cs
Dalmatian spotty = new Dalmatian("Spot", 306);
Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");
```

```console
Spot is a very good dog. He has 306 darker spots in his fur
```

#### Exercise_102

Create the class **Gauge**. The gauge has the instance **public int value**, a **constructor without parameters** (sets the initial value of the meter variable to 0), and also the following three methods:

- Method **public void Increase()** grows the value instance variable's value by one. It does not grow the value beyond five.
- Method **public void Decrease()** decreases the value instance variable's value by one. It does not decrease the value to negative values.
- Method **public bool Full()** returns **True** if the instance variable value has the value five. Otherwise, it returns **False**.

Also, give the value ability for get and set:
**Make the value public rather than private, and add { get; set; } on the declaring lines!**

An example of the class in use.

```cs
public static void Main(string[] args)
{
  Gauge g = new Gauge();

  while (!g.Full())
  {
    Console.WriteLine("Not full! Value: " + g.value);
    g.Increase();
  }

  Console.WriteLine("Full! Value: " + g.value);
  g.Decrease();
  Console.WriteLine("Not full! Value: " + g.value);
}
```

```console
Not full! Value: 0
Not full! Value: 1
Not full! Value: 2
Not full! Value: 3
Not full! Value: 4
Full! Value: 5
Not full! Value: 4
```

### Exercise_103

The exercise template defines an Agent class, having a first name and last name. The Main method tries to print the introduction for mister Bond, but with no luck. This is what is should do:

```cs
public static void Main(string[] args)
{
  Agent bond = new Agent("James", "Bond");
  Console.WriteLine(bond);

  Agent bourne = new Agent("Jason", "Bourne");
  Console.WriteLine(bond);
}
```

```console
My name is Bond. James Bond.
My name is Bourne. Jason Bourne.
```

Agent's ToString now returns an empty string. Fix it to introduce international agents in their proper form.

#### Exercise_104

Create a class **Multiplier** that has a:

Constructor **public Multiplier(int number)**.
Method **public int Multiply(int number)** which returns the value number passed to it multiplied by the number provided to the constructor.
You also need to create an instance variable in this exercise.

An example of the class in use:

```cs
public static void Main(string[] args)
{
  Multiplier multiplyByThree = new Multiplier(3);

  Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

  Multiplier multiplyByFour = new Multiplier(4);

  Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
  Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
  Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
}
```

```console
multiplyByThree.Multiply(2): 6
multiplyByFour.Multiply(2): 8
multiplyByThree.Multiply(1): 6
multiplyByFour.Multiply(1): 8
```

#### Exercise_105

The exercise template includes class **Statistics**

```cs
namespace exercise_105
{
  public class Statistics
  {
    public int count {get; set;}
    public int sum { get; set; }

    public NumberStatistics()
    {
      // initialize the variable count here
    }

    public void AddNumber(int number) {
        // write code here
    }
  }
}
```

The following program introduces the class' use:

```cs
Statistics statistics = new Statistics();
statistics.AddNumber(3);
statistics.AddNumber(5);
statistics.AddNumber(1);
statistics.AddNumber(2);
Console.WriteLine("Count: " + statistics.count);
Console.WriteLine("Sum: " + statistics.sum);
```

```console
Count: 4
Sum: 11
```

Expand the program as follows:
- When a number is added, **count** is increased by one
- When a number is added, **sum** is increased by the number's value

#### Exercise_106

In this exercise series, a class called PaymentCard is created which aims to mimic a cafeteria's payment process.

The template includes the **Program.cs** file. You have to create the **PaymentCard.cs** yourself.

- Add a new class to the project called **PaymentCard** (by creating the file mentioned above).
- Create the PaymentCard object's constructor, which is passed the opening balance of the card, and which then stores that balance in the object's internal variable. 
- Write the ToString method, which will return the card's balance in the form **"The card has a balance of X euros"**.

Here is the template for the PaymentCard:

```cs
namespace exercise_106
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
    }

    public override string ToString()
    {
      // write code here
    }
  }
}
```
The following main program tests the class:

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(50);
  Console.WriteLine(card);
}
```

```console
The card has a balance of 50 euros
```

#### Exercise_107

Expand your answer from the exercise 106 by adding two methods:
- Method **public void EatLunch()**
- Method **public void DrinkCoffee()**

The method **EatLunch** should decrease the card's balance by 10.60 euros. The method **DrinkCoffee** should decrease the card's balance by 2.0 euros.

The following main program tests the class:

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(50);
  Console.WriteLine(card);

  card.EatLunch();
  Console.WriteLine(card);
  
  card.DrinkCoffee();
  Console.WriteLine(card);
}
```

```console
The card has a balance of 50 euros
The card has a balance of 39.4 euros
The card has a balance of 37.4 euros
```

#### Exercise_108

Expand your previous answers, so that when an item is bought the balance is checked. If there is not enough money to buy, the balance does not change.

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(10);
  Console.WriteLine(card);

  card.EatLunch();
  Console.WriteLine(card);
  
  card.DrinkCoffee();
  Console.WriteLine(card);
}
```

```console
The card has a balance of 10 euros
The card has a balance of 10 euros
The card has a balance of 8 euros
```

Notice how EatLunch did not change the balance, as there was not enough money. DrinkCoffee still worked, as it should.

#### Exercise_109

Expand your previous answers, so that you can charge money on your card:

```cs
public void AddMoney(double amount) {
    // write code here
}
```

The purpose of the method is to increase the card's balance by the amount of money given as a parameter. However, the card's balance may not exceed 150 euros. As such, if the amount to be topped up exceeds this limit, the balance should, in any case, become exactly 150 euros.

The following main program tests the class:

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(100);
  Console.WriteLine(card);

  card.AddMoney(49.99);
  Console.WriteLine(card);

  card.AddMoney(10000.0);
  Console.WriteLine(card);

  card.AddMoney(-10);
  Console.WriteLine(card);
}
```

```console
The card has a balance of 100 euros
The card has a balance of 149.99 euros
The card has a balance of 150 euros
The card has a balance of 150 euros
```

Notice! You cannot add negative money!