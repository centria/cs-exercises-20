# Exercises for exam rehearsal

These exercises are purely voluntary and **do not** count towards the grade. You can do them if you want to train for the exam.  

There is about one exercise per part and subpart so far.

**THESE EXERCISES DO NOT HAVE ANY TESTS!**

The solutions will be published in this folder before the exam.

#### extra_01

Write a program which asks the user for a string input and an integer. It should print the string the amount of times of the integer. Examples:

```console
What do you want to print?
> This is my input for this program
How many times do you want to print?
> 5
This is my input for this program
This is my input for this program
This is my input for this program
This is my input for this program
This is my input for this program
```


```console
What do you want to print?
> I am pretty fly for a white guy
How many times do you want to print?
> 1
I am pretty fly for a white guy
```

#### extra_02

Ask the user for three integers. Print the largest. Examples:

```console
Give three numbers:
> 42
> 12
> 68
Largest: 68
```


```console
Give three numbers:
> 42
> 12
> -68
Largest: 42
```

#### extra_03

Ask the user for amount of integers, and then that many integers. Calculate and print their sum, multiplication and average. For example:

```console
How many numbers?
> 3
Give 3 numbers:
> 1
> 2
> 3
Their sum: 6
Their total: 6
Their average: 2
```


```console
How many numbers?
> 4
Give 4 numbers:
> 1
> 2
> 0
> 3
Their sum: 6
Their total: 0
Their average: 1.5
```

#### extra_04

Here is the grading for this course:

| Percent | Grade|
|---|---|
| < 0 | Impossible |
| 0 - 49  | Fail |
| 50 - 59 | 1 |
| 60 - 69 | 2 |
| 70 - 79 | 3 |
| 80 - 89 | 4 |
| 90 - 100 | 5 |
| > 100 | Outstanding! |

Create a program, which asks the user for their percent, and gives them their score. For example:

```console
Give your percent [0 - 100]:
> -2
Impossible
```

```console
Give your percent [0 - 100]:
> 49
Fail
```

```console
Give your percent [0 - 100]:
> 75
Grade: 3
```

```console
Give your percent [0 - 100]:
> 99
Grade: 5
```

```console
Give your percent [0 - 100]:
> 9001
Outstanding!
```

#### extra_05

Write a program, which... 
* prints the numbers from 1 to 5, using a **for-loop**,
* then ask user for words, until they give "end". Do this with **while-loop**. Store the words in a list.
* Print the content of the list using **foreach-loop**.

```console
1
2
3
4
5
Give words, 'end' quits:
> Potato
> Is
> Hot
> end
Potato
Is
Hot
```

#### extra_06

Write a program that reads **two integers** from the user, and prints the **square root of the sum of these integers**. If the sum is negative, print 0.


```console
> 1 
> 0 
1
```

```console
> 5 
> 4 
3
```

```console
> 1 
> -35 
0
```

```console
> 1 
> 35 
6
```

#### extra_07

Using any looping method you want, ask the user for integers. When user gives "end", print the sum of the given integers.

```console
Give integers, 'end' quits:
> 2
> 2
> 2
> end
Sum: 6
```


```console
Give integers, 'end' quits:
> -1
> 2
> 0
> end
Sum: 1
```

#### extra_08

Define a method called **ChristmasTree(int height)** that prints the correct Christmas tree. The Christmas tree consists of a triangle with the specified height and the base. The base is two stars high and three stars wide, and is placed at the center of the triangle's bottom.

For example, the call **ChristmasTree(4)** should print the following:

```console
   * 
  *** 
 *****
******* 
  *** 
  ***
```
The call **christmasTree(10)** should print:

```console
         * 
        *** 
       ***** 
      ******* 
     ********* 
    *********** 
   ************* 
  *************** 
 ***************** 
******************* 
        *** 
        ***
```

#### extra_09

Here's a list: List<string> list = new List<string>() { "This is a string", "This is magic", "THIS IS PATRICK!" };

Iterate through this list (or any other list to your liking) with a for-loop, while-loop and a foreach-loop, and print the content.

```console
This is a string
This is magic
THIS IS PATRICK
This is a string
This is magic
THIS IS PATRICK
This is a string
This is magic
THIS IS PATRICK
```

#### extra_10

Create a method **public static void PrintArrayInStars(int[] array)** in the template to make it print a row of stars for each number in the array. The amount of stars on each row is defined by the corresponding number in the array.

You can try out the printing with this example:

```cs
int[] array = {5, 1, 3, 4, 2};
PrintArrayInStars(array);
```

```
***** 
* 
*** 
**** 
**
```

#### extra_11

Ask the user for a sentence. Split the sentence on whitespace, and print each word on its own line.

```console
Give a sentence:
> I live in a hole under the ground
I
live
in
a
hole
under
the
ground
```

#### extra_12

Create a class **Person**, which has a constructor which gives the new person a name, and sets the age to 0. The **ToString** should return in format "name, age 0". The class should also have a method **public int GrowOlder(int howMuch)**, which increase the person's age by the parameter's amount.

```cs
Person mike = new Person("Mike");
Console.WriteLine(mike);
mike.GrowOlder(5);
Console.WriteLine(mike);
```

```console
Mike, age 0
Mike, age 5
```

#### extra_13

Use your previous answer as the Person-class for this task.

Create a list to store our young Persons into, and then print the content with for example:

```cs
foreach (Person child in kindergarten) 
{
  Console.WriteLine(child);
}
```

```console
Mike, age 0
Lily, age 1
```

#### extra_14

We have a file text.txt

```console
This is a line
This is second line
This is 3rd
This includes a double, 3.25
This has "quotes"
```

Read the content of the file and print it in the console.

#### extra_15

Create a **Cube** class that represents a cube (i.e., a standard hexahedron). Create a **public Cube (int edgeLength)** constructor for the class, that takes the length of the cube's edge as its parameter.

Make a **public int Volume()** method for the cube, which calculates and returns the cube's volume. The volume of the cube is calculated with the formula **edgeLength x edgeLength x edgeLength**. Moreover, make a **public override string ToString()** method for the cube, which returns a string representation of it. The string representation should take the form (for example with **Cube cube = new Cube(3)** ) **"The length of the edge is 3 and the volume 27"**, where l is the length and v the volume - both the length and volume must be represented as integers.

#### extra_16

Use the Person class from earlier for this task.

Give the person two new variables, height and weight. Create following constructors:
* public Person(string name, int age, int height, int weight)
* public Person(string name, int age)
* public Person(string name)

If a variable is not given, set it to 0. Also modify the ToString to give all the information as follows.

```cs
Person informative = new Person("Master Blaster", 300, 200, 200);
Person lightweight = new Person("Youngling", 25);
Person baby = new Person("Waa");

Console.WriteLine(informative);
Console.WriteLine(lightweight);
Console.WriteLine(baby);
```

```console
Master Blaster, age 300, height 200cm, weight 200kg
Youngling, age 25, height 0cm, weight 0kg
Waa, age 0, height 0cm, weight 0cm
```

#### extra_17

The program should read person details from the user. When all the details from the user have been read, the program prints the information of each person.

For each person, its identifying number and name should be read. If the identifier or name is empty, the program stops asking for input, and prints all the information.

Example print:

```console
Identifying number?
> 01011970-1234 
Name? (empty will stop):
> Unix Man
Identifying number?
> 01011970-1234 
Name? (empty will stop):
> Nixon Man
Identifying number?
> 20202020-2020 
Name? (empty will stop):
> Impossible Woman
Identifying number?
> 20022020-2020 
Name? (empty will stop):
> Impossible Man
Identifying number?
>

==Persons== 
01011970-1234: Unix Man
20022020-2020: Impossible Woman
```


The printing format of the persons should be **identifying number: name**.

After entering the information, each person is printed at most once. Two persons should be considered the same if their identifying numbers are the same (some one could be using an alias for name, for example).

If the user enters the same person multiple times, the print uses the information that was added first.

Hint! It is probably smart to add each person to the list at most once -- compare the equality of the objects based on their identifying numbers.


#### extra_18

In this exercise you will design and implement a database for bird-watchers. The database contains birds, each of which has a name (string) and a name in Latin (string). The database also counts the observations of each bird.

The program must implement the following commands:

Add - adds a bird
Observation - adds an observation
All - prints all birds
One - prints one bird
Quit - ends the program
Incorrect input must also be handled. The following is an example of the program functionality:

```
? 
> Add 
Name:
> Crow 
Name in Latin:
> Corvus Corvus 
? 
>Add 
Name:
> Hawk 
Name in Latin:
> Dorkus Dorkus 
? 
>Observation 
Bird?
> Hawk 
? 
> Observation
Bird? 
> Lion 
Not a bird! 
? 
> Observation 
Bird? 
> Hawk 
? 
>All 
Hawk (Dorkus Dorkus): 2 observations 
Crow (Corvus Corvus): 0 observations 
? 
> One 
Bird? 
> Hawk 
Hawk (Dorkus Dorkus): 2 observations 
? 
> Quit
```

The Main Program should look something like this:

```cs
BirdDatabase db = new BirdDatabase();
UserInterface ui = new UserInterface(db);
ui.Start();
```