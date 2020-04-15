# Part 9

#### Exercise_148

CrEate the following three classes:

* Class A. Class should have no object variables nor should you specify a constructor for it. It only has the method **public void A()**, which prints a string "A".
* Class B. Class should have no object variables nor should you specify a constructor for it. It only has the method **public void B()**, which prints a string "B".
* Class C. Class should have no object variables nor should you specify a constructor for it. It only has the method **public void C()**, which prints a string "C".
* After you have crEated the classes, **modify them** so that class B inherits class A, and class C inherits class B. In other words, class A will be a base class for class B, and class B will be a base class for class C.

```cs
A a = new A();
B b = new B();
C c = new C();

a.APrint();
b.BPrint();
c.CPrint();

Console.WriteLine();

c.APrint();
c.BPrint();
c.CPrint();
```

```console
A
B
C

A
B
C
```

#### Exercise_149

CrEate a class **Person**. The class must work as follows:

```cs
Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
Console.WriteLine(ada);
Console.WriteLine(esko);
```

```console
Ada Lovelace, 24 Maddox St. London W1S 2QN
Esko Ukkonen, Mannerheimintie 15 00100 Helsinki
```

CrEate a class **Student**, which inherits the class Person.

At crEation, student has 0 study credits. Every time a student studies, amount of study credits goes up. Class must act as follows:

```cs
Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
Console.WriteLine(ollie);
ollie.Study();
Console.WriteLine(ollie);
```

```console
Ollie, 6381 Hollywood Blvd. Los Angeles 90028 credits: 0
Ollie, 6381 Hollywood Blvd. Los Angeles 90028 credits: 1
```

CrEate a class **Teacher**, which inherits the class Person.

The class must act as follows:

```cs
Teacher ada = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
Teacher esko = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
Console.WriteLine(ada);
Console.WriteLine(esko);
```

```console
Ada Lovelace, 24 Maddox St. London W1S 2QN salary 1200 per month
Esko Ukkonen, Mannerheimintie 15 00100 Helsinki salary 5400 per month
```

NOTICE! You have to override the ToString.

HINT! For Student and Teacher, use **base.ToString()** as a starting point.

#### Exercise_150

The exercise template contains a class **Warehouse**, which has the following properties, constructors and methods:

* **public int balance** - balance of the warehouse, i.e. the capacity which is taken up by the items in the warehouse.
* **public int capacity** - the total capacity of the warehouse (i.e. the one that was provided in the constructor).
* constructor **public Warehouse(int capacity)** - CrEates an empty warehouse, which has the capacity provided as a parameter; an invalid capacity (<=0) crEates a useless warehouse, with the the capacity 0.

* **public int HowMuchSpaceLeft()** - Returns a value telling how much space is left in the warehouse.
* **public void AddToWarehouse(int amount)** - Adds the desired amount to the warehouse; if the amount is negative, nothing changes, and if everything doesn't fit, then the warehouse is filled up and the rest is "thrown away" / "overflows".
* **public int TakeFromWarehouse(int amount)** - Take the desired amount from the warehouse. The method returns much we actually get. If the desired amount is negative, nothing changes and we return 0. If the desired amount is grEater than the amount the warehouse contains, we get all there is to take and the warehouse is emptied.
* **public override string ToString()** - Returns the state of the object represented as a string like this 

```console
balance: 64, space left 16
``` 


In this exercise we build variations of a warehouse based on the Warehouse class.

The class **Warehouse** handles the functions related to the amount of a product. Now we want product name for the product and a way to handle the name. Let's write **ProductWarehouse** as a *derived class of Warehouse!* First, we'll just crEate a private object variable for the product name, and a constructor:

* **public string productName**
* **public ProductWarehouse(string productName, int capacity)** - CrEates an empty product warehouse. The name of the product and the capacity of the warehouse are provided as parameters.
* **public override string ToString()** - Returns the state of the object represented as a string like in the example.

*Remind yourself of how a constructor can use the constructor of the base class so you understand the existing code!*

Example usage:

```cs
ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
juice.AddToWarehouse(1000);
juice.TakeFromWarehouse(11);
Console.WriteLine(juice.productName); // Juice
Console.WriteLine(juice);
```

```console
Juice
Juice: balance: 989, space left 11
```

Let's crEate a more informative warehouse. We want to know, if and how the balance of a product has changed. Let's first crEate a special tool for the change history, and crEate a class **ChangeHistory**:

* **private List<int> history**
* constructor **public ChangeHistory()** 
* **public void Add(int status)** - adds provided status as the latest amount to remember in the change history.
* **public void Clear()** - empties the history
* **public int MaxValue()** - returns the largest value of the change history. If the history is empty, returns 0.
* **public int MinValue()** - returns the smallest value of the change history. If the history is empty, returns 0.
* **public override string ToString()** returns the following kind of string:

```console
Current: 500 Min: 0 Max: 1000
```

Where the first number is the current balance (the last index of the list), second number is the smallest number on the list, and last is the largest number on the list.

HINT! Use the methods MaxValue and MinValue in your ToString!

Implement **ProductWarehouseWithHistory** as a derived class of **ProductWarehouse**. In addition to all the previous fEatures this new warehouse also provides services related to the change history of the warehouse inventory. The history is managed using the **ChangeHistory** object.

Public constructors and methods:

* **public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance)** crEates a product warehouse. The product name, capacity, and initial balance are provided as parameters. Set the initial balance as the initial balance of the warehouse, as well as the first value of the change history.
* **public string History()** returns the product history like this:

```console
Current: 500 Min: 0 Max: 1000
``` 

Use the string representation of the ChangeHistory object as is.

* **new public void AddToWarehouse(int amount)** works just like the method in the Warehouse class, but we also record the changed state to the history. NOTICE: the value recorded in the history should be the warehouse's balance after adding, not the amount added!
* **new public int TakeFromWarehouse(int amount)** works just like the method in the Warehouse class, but we also record the changed state to the history. NOTICE: the value recorded in the history should be the warehouse's balance after removing, not the amount removed!


Here's one massive example:

```cs
Warehouse wh = new Warehouse(100);
Console.WriteLine(wh);
wh.AddToWarehouse(10);
Console.WriteLine(wh);
wh.AddToWarehouse(100);
Console.WriteLine(wh);
wh.AddToWarehouse(-10);
Console.WriteLine(wh);
wh.TakeFromWarehouse(20);
Console.WriteLine(wh);
wh.TakeFromWarehouse(-20);
Console.WriteLine(wh);

Console.WriteLine();

ProductWarehouse juice = new ProductWarehouse("Juice", 1000);
juice.AddToWarehouse(1000);
juice.TakeFromWarehouse(11);
Console.WriteLine(juice.productName); // Juice
Console.WriteLine(juice);

Console.WriteLine();

ChangeHistory cs = new ChangeHistory();
cs.Add(100);
cs.Add(10);
cs.Add(200);
cs.Add(50);
Console.WriteLine(cs);

Console.WriteLine();

ProductWarehouseWithHistory milk = new ProductWarehouseWithHistory("Milk", 1000, 100);
Console.WriteLine(milk);
milk.TakeFromWarehouse(10);
Console.WriteLine(milk.History());
Console.WriteLine(milk);
milk.AddToWarehouse(100);
Console.WriteLine(milk.History());
Console.WriteLine(milk);
milk.TakeFromWarehouse(-10000);
Console.WriteLine(milk.History());
Console.WriteLine(milk);
```

```console
balance: 0, space left 100
balance: 10, space left 90
balance: 100, space left 0
balance: 100, space left 0
balance: 80, space left 20
balance: 80, space left 20

Juice
Juice: balance: 989, space left 11

Current: 50 Min: 10 Max: 200

Milk: balance: 100, space left 900
Current: 90 Min: 90 Max: 100
Milk: balance: 90, space left 910
Current: 190 Min: 90 Max: 190
Milk: balance: 190, space left 810
Current: 190 Min: 90 Max: 190
Milk: balance: 190, space left 810
```

#### Exercise_151

In the exercise template you'll find the classes **Item** and **Box**. Box is an abstract class, where adding multiple items is implemented by repeatedly calling the **Add-method**. The Add-method, meant for adding a single item, is abstract, so every class that inherits it, must implement it. Your assignment is to edit the Box-class and to implement different kinds of boxes based on the Box class.

* Implement the **Equals** and **GetHashCode** methods for the Item-class. They are needed, so that you can use the contains-methods of different lists and collections. *Implement the methods in such a way that value of the weight instance variable of the Item-class isn't considered.*

* Implement the class **BoxWithMaxWeight**, that inherits the Box class. BoxWithMaxWeight has a constructor public **BoxWithMaxWeight(int capacity)**, that defines the max weight allowed for that box. You can add an item to a BoxWithMaxWeight when and only when, adding the item won't cause the boxes max weight capacity to be exceeded.

* Next implement the class **OneItemBox**, that inherits the Box class. OneItemBox has constructor the **public OneItemBox()**, and it has the capacity of exactly one item. If there is already an item in the box, it must not be switched. The weight of the item added to the box is irrelevant.

* Next implement the class **MisplacingBox**, that inherits the Box-class. MisplacingBox has a constructor **public MisplacingBox()**. You can add any items to misplacing box, but items can never be found when looked for. In other words adding to the box must always succeed, but calling the method IsInbox must always return false.

Here's some code for testing them all:

```cs
BoxWithMaxWeight coffeeBox = new BoxWithMaxWeight(10);
coffeeBox.Add(new Item("Saludo", 5));
coffeeBox.Add(new Item("Pirkka", 5));
coffeeBox.Add(new Item("Kopi Luwak", 5));

Console.WriteLine(coffeeBox.IsInBox(new Item("Saludo")));
Console.WriteLine(coffeeBox.IsInBox(new Item("Pirkka")));
Console.WriteLine(coffeeBox.IsInBox(new Item("Kopi Luwak")));

OneItemBox box = new OneItemBox();
box.Add(new Item("Saludo", 5));
box.Add(new Item("Pirkka", 5));

Console.WriteLine(box.IsInBox(new Item("Saludo")));
Console.WriteLine(box.IsInBox(new Item("Pirkka")));

MisplacingBox mbox = new MisplacingBox();
Console.WriteLine(mbox.IsInBox(new Item("Saludo")));
Console.WriteLine(mbox.IsInBox(new Item("Pirkka")));
```

```console
True
True
False
True
False
False
False
```

#### Exercise_152

In the exercise template you'll find **Interface ITacoBox** ready for your use. It has the following methods:

the method **int TacosRemaining()** return the number of tacos remaining in the box.
the method **void Eat()** reduces the number of tacos remaining by one. The number of tacos remaining can't become negative.

* Implement the class **TripleTacoBox**, that implements the TacoBox interface. TripleTacobox has a constructor with no parameters. TripleTacobox has an object variable tacos which is initialized at 3 when the constructor is called.

* Implement the class **CustomTacoBox**, that implements the TacoBox interface. CustomTacoBox has a constructor with one parameter defining the initial number of tacos in the **CustomTacoBox(int tacos)**.

```cs
TripleTacoBox trip = new TripleTacoBox();
Console.WriteLine(trip.TacosRemaining());
trip.Eat();
Console.WriteLine(trip.TacosRemaining());
trip.Eat();
Console.WriteLine(trip.TacosRemaining());
trip.Eat();
Console.WriteLine(trip.TacosRemaining());
// Try to Eat one too much
trip.Eat();
Console.WriteLine(trip.TacosRemaining());

Console.WriteLine();

CustomTacoBox custom = new CustomTacoBox(2);
Console.WriteLine(custom.TacosRemaining());
custom.Eat();
Console.WriteLine(custom.TacosRemaining());
custom.Eat();
Console.WriteLine(custom.TacosRemaining());
// Try to Eat one too much
custom.Eat();
Console.WriteLine(custom.TacosRemaining());
```

```console
3
2
1
0
0

2
1
0
0
```

#### Exercise_153

Moving houses requires packing all your belongings into boxes. Let's imitate that with a program. The program will have boxes, and items to pack into those boxes. All items must implement the following Interface:

```cs
public interface IPackable {
    int Weight();
}
```

* CrEate classes **Book** and **Furniture**. Book has a constructor in which is given the author (string), name of the book (string) and the publication year (int). The weight of all books is 1 kg. Furniture has a constructor in which is given the type of furniture (string), color (string) and weight (int). Both of these should implement the interface **IPackable**. They also need a ToString each.

The classes should work as following:

```cs
Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
Book book2 = new Book("Robert Martin", "Clean Code", 2008);
Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);

Furniture sofa = new Furniture("Sofa", "Red", 20);
Furniture bed = new Furniture("Twin bed", "White", 15);
Furniture table = new Furniture("Dining room table", "Oak", 30);

List<IPackable> packages = new List<IPackable>();
packages.Add(book1);
packages.Add(book2);
packages.Add(book3);
packages.Add(sofa);
packages.Add(bed);
packages.Add(table);

packages.ForEach(Console.WriteLine);
```

```console
Fedor Dostojevski: Crime and Punishment (1866)
Robert Martin: Clean Code (2008)
Kent Beck: Test Driven Development (2000)
Red Sofa - weight 20 kg
White Twin bed - weight 15 kg
Oak Dining room table - weight 30 kg
```

Notice that the weight for books is not printed.

* CrEate a class called **Box**.  Items implementing the **IPackable** interface can be packed into a box. The Box constructor takes the maximum capacity of the box in kilograms as a parameter. The combined weight of all items in a box cannot be more than the maximum capacity of the box. **Box should also implement IPackable**, so you could have boxes inside boxes!

Below is an example of using a box:

```cs
Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
Book book2 = new Book("Robert Martin", "Clean Code", 2008);
Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);

Furniture sofa = new Furniture("Sofa", "Red", 20);
Furniture bed = new Furniture("Twin bed", "White", 15);
Furniture table = new Furniture("Dining room table", "Oak", 30);

Box box = new Box(40);
box.Add(book1);
box.Add(book2);
box.Add(book3);
box.Add(sofa);
box.Add(bed);
box.Add(table);

Console.WriteLine(box);
```

```console
5 items, total weight 38 kg
```

NOTICE! The table did not fit in the box, as the maximum capacity of the box is 40.

Let's try some boxes inside boxes, as well:

```cs
Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
Book book2 = new Book("Robert Martin", "Clean Code", 2008);
Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);

Furniture sofa = new Furniture("Sofa", "Red", 20);
Furniture bed = new Furniture("Twin bed", "White", 15);
Furniture table = new Furniture("Dining room table", "Oak", 30);

Box bookBox = new Box(5);
bookBox.Add(book1);
bookBox.Add(book2);
bookBox.Add(book3);

Console.WriteLine(bookBox);
Console.WriteLine();

Box movingVan = new Box(800);
movingVan.Add(bookBox);
movingVan.Add(sofa);
movingVan.Add(bed);
movingVan.Add(table);

Console.WriteLine(movingVan);
Console.WriteLine();

Box shippingContainer = new Box(3000);
shippingContainer.Add(movingVan);

Console.WriteLine(shippingContainer);
```

```console
3 items, total weight 3 kg

4 items, total weight 68 kg

1 items, total weight 68 kg
```

#### Exercise_154

In this exercise we are going to create organisms and herds of organisms that can move around. To represent the locations of the organisms we'll use a two-dimensional coordinate system. Each position involves two numbers: x and y coordinates. The x coordinate indicates how far from the (i.e. point zero, where x = 0, y = 0) that position is horizontally. The y coordinate indicates the distance from the origin vertically. If you are not familiar with using a coordinate system, you can study the basics from e.g. [**Wikipedia**](https://en.wikipedia.org/wiki/Cartesian_coordinate_system).


The exercise base includes the interface **IMovable**, which represents something that can be moved from one position to another. The interface includes the method void move(int dx, int dy). The parameter dx tells how much the object moves on the x axis, and dy tells the distance on the y axis.

This exercise consists of you implementing the classes **Organism** and **Herd**, both of which are movable.

* Create a class called **Organism** that implements the interface **IMovable**. An organism should know its own location (as x, y coordinates). The API for the class Organism is to be as follows:

* public Organism(int x, int y)

The class constructor that receives the x and y coordinates of the initial position as its parameters.

* public override string ToString()

Creates and returns a string representation of the organism. That representation should remind the following: "x: 3; y: 6". Notice that a semicolon is used to separate the coordinates.

* public void Move(int dx, int dy)

Moves the object by the values it receives as parameters. The dx variable contains the change to coordinate x, and the dy variable ontains the change to the coordinate y. For example, if the value of dx is 5, the value of the object variable x should be incremented by five.


Use the following code snippet to test the Organism class.


```cs
Organism organism = new Organism(20, 30);
Console.WriteLine(organism);
organism.Move(-10, 5);
Console.WriteLine(organism);
organism.Move(50, 20);
Console.WriteLine(organism);
```

```console
x: 20; y: 30 
x: 10; y: 35 
x: 60; y: 55
```

* Create a class called **Herd** that implements the interface **IMovable**. A herd consists of multiple objects that implement the Movable interface. They must be stored in e.g. a list data structure.

The Herd class must have the following API.

* public override string ToString()


Returns a string representation of the positions of the members of the herd, each on its own line.

* public void AddToHerd(IMovable movable)

Adds an object that implements the Movable interface to the herd.

* public void Move(int dx, int dy)

Moves the herd with by the amount specified by the parameters. Notice that here you have to move each member of the herd.

Test out your program with the sample code below:

```cs
Herd herd = new Herd();
herd.AddToHerd(new Organism(57, 66));
herd.AddToHerd(new Organism(73, 56));
herd.AddToHerd(new Organism(46, 52));
herd.AddToHerd(new Organism(19, 107));
Console.WriteLine(herd);
```

```console
x: 57; y: 66 
x: 73; y: 56 
x: 46; y: 52 
x: 19; y: 107
```

#### Exercise_155

In this exercise you'll demonstrate how to use both inheritance and interfaces.

* First implement an **abstract class** called **Animal**. The class should have a constructor that takes the animal's name as a parameter. The Animal class also has non-parameterized methods **Eat** and **Sleep** that return nothing (void).

The Sleep method should print "(name) sleeps", and the Eat method should print "(name) Eats". Here (name) is the name of the animal in question.

* Implement a class called **Dog** that inherits from Animal. Dog should have a **parameterized constructor** that can be used to name it. The class should also have a **non-parameterized constructor**, which gives the dog the name "Dog". Another method that Dog must have is the non-parameterized **Bark**, and it should not return any value (void). Like all animals, Dog needs to have the methods Eat and Sleep.

Below is an example of how the class Dog is expected to work.

```cs
Dog dog = new Dog();
dog.Bark();
dog.Eat();

Dog fido = new Dog("Fido");
fido.Bark();
```

```console
Dog barks
Dog eats
Fido barks
```

* Next to implement is the class **Cat**, that also inherits from the Animal class. Cat should have **two constructors**: one with a parameter, used to name the cat according to the parameter, and one without parameters, in which case the name is simply "Cat". Another methd for Cat is a non-parameterized method called Purr that returns no value (void). Cats should be able to Eat and Sleep like in the first part.

Here's an example of how the class Cat is expected to function:


```cs
Cat cat = new Cat();
cat.Purr();
cat.Eat();

Cat garfield = new Cat("Garfield");
garfield.Purr();
```

```console
Cat purrs
Cat eats 
Garfield purrs
```

* Finally, create an **interface** called **INoiseCapable**. It should define a non-parameterized method **MakeNoise** that returns no value (void). *Implement the interface in the classes Dog and Cat*. The interface should take use of the Bark and Purr methods you've defined earlier.

Below is an example of the expected functionality.

```cs
INoiseCapable dog = new Dog();
dog.MakeNoise();

INoiseCapable cat = new Cat("Garfield");
cat.MakeNoise();

Cat c = (Cat) cat;
c.Purr();
```

```console
Dog barks 
Garfield purrs 
Garfield purrs
```