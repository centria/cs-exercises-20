## Methods

In these exercises we practice making and calling our own methods.  
**If the exercise template says "// Call your method here:", call it once. Usually this is in the Main class**.

#### Exercise_49

* Create a method called **PrintPhrase** which prints the phrase "In a hole in the ground there lived a method" and a newline.

```cs
public static void Main(string[] args)
{
  // Call your method here:
  PrintPhrase();

}

// Write your method here:
public static void PrintPhrase() 
{

}
```

```console
In a hole in the ground there lived a method
```

#### Exercise_50

* Expand the previous program so that the main program asks the user for the number of times the phrase will be printed (i.e. how many times the method will be called).

```cs
public static void Main(string[] args)
{
  // ask the user for the number of times that the phrase will be printed
  // use the while command to call the method a suitable number of times

}

// Write your method here:
public static void PrintPhrase() 
{

}
```

```console
How many times?
> 3
In a hole in the ground there lived a method
In a hole in the ground there lived a method
In a hole in the ground there lived a method
```

## Notice!
From here on out, when introducing methods, we might not explicitly mention they must be located in the correct place. Methods cannot be defined e.g. inside other methods.

#### Exercise_51

* Create the following method in the exercise template: **public static void PrintUntilNumber(int number)**. It should print the numbers from one to the number passed as a parameter. Two examples of the method's usage are given below.

```cs
public static void Main(String[] args) 
{
  PrintUntilNumber(5);
}
```

```console
1
2
3
4
5
```

```cs
public static void Main(String[] args) 
{
  PrintUntilNumber(3);
}
```

```console
1
2
3
```

#### Exercise_52

* Create the following method in the exercise template: **public static void PrintFromNumberToOne(int number)**. It should print the numbers from the number passed as a parameter down to one. Two examples of the method's usage are given below.

```cs
public static void Main(String[] args) 
{
  PrintFromNumberToOne(5);
}
```

```console
5
4
3
2
1
```

```cs
public static void Main(String[] args) 
{
  PrintFromNumberToOne(2);
}
```

```console
2
1
```

#### Exercise_53

* Write a method **public static void Division(int numerator, int denominator)** that prints the result of the division of the numerator by the denominator. Keep in mind that the result of the division of the integers is an integer -- in this case we want the result to be a floating point number (double).

#### Exercise_54

* Write a method **public static void DivisibleByThreeInRange(int beginning, int end)** that prints all the numbers divisible by three in the given range. The numbers are to be printed in order from the smallest to the greatest.

```cs
public static void Main(String[] args) 
{
  DivisibleByThreeInRange(3, 6);
}
```

```console
3
6
```

```cs
public static void Main(String[] args) 
{
  DivisibleByThreeInRange(2, 10);
}
```

```console
3
6
9
```

#### Exercise_55

* Write a method **public static int NumberUno()** that returns the value 1.

#### Exercise_56

* Write a method **public static String Word()**. The method must return a string of your choice.

#### Exercise_57

* Expand the method **Sum**  in the exercise template so that it calculates and returns the sum of the numbers that are given as the parameters.
Create the method using the following structure:

```cs
public static int Sum(int number1, int number2, int number3, int number4) 
{
  // write your code here
  // remember to include return (at the end)!
}

public static void Main(String[] args) 
{
    int answer = Sum(4, 3, 6, 1);
    Console.WriteLine("Sum: " + answer);
}
```
Output of the example:

```console
Sum: 14
```

#### Exercise_58

* Define a two-parameter method **Smallest** that returns the smaller of the two numbers passed to it as parameters.

```cs
public static int Smallest(int number1, int number2) 
{
  // write your code here
  // do not print anything inside the method

  // there must be a return command at the end
}

public static void Main(String[] args) 
{
  int answer =  Smallest(2, 7);
  Console.WriteLine("Smallest: " + answer);
}
```

The output of the program:

```console
Smallest: 2
```

#### Exercise_59

* Define a three-parameter method **Greatest** that returns the smaller of the two numbers passed to it as parameters.

```cs
public static int Greatest(int number1, int number2) 
{
  // write your code here
  // do not print anything inside the method

  // there must be a return command at the end
}

public static void Main(String[] args) 
{
  int answer =  Greatest(2, 7, 3);
  Console.WriteLine("Greatest: " + answer);
}
```

The output of the program:

```console
Greatest: 7
```

#### Exercise_60

##### Section 1

* Define a method called **PrintStars** that prints the given number of stars and a line break.

Write the method in the following template:

```cs
public static void PrintStars(int number)
{
  // you can print one star with the command
  // Console.Write("*");
  // call the print command n times
  // in the end print a line break with the comand
  // Console.WriteLine("");
}

public static void Main(String[] args) 
{
  PrintStars(5);
  PrintStars(3);
  PrintStars(9);
}
```

The output of the program:
```console
***** 
*** 
*********
```

##### Section 2

* Define a method called **PrintSquare(int size)** that prints a suitable square with the help of the printStars method. So the method call **PrintSquare(4)** results in the following output:

```console
****
****
****
****
```

##### Section 3

* Write a method called PrintRectangle(int width, int height) that prints the correct rectangle by using the PrintStars method. So the method call PrintRectangle(17, 3) should produce the following output:

```console
***************** 
***************** 
*****************
```

##### Section 4

* Create a method called PrintTriangle(int size) that prints a triangle by using the PrintStars method. So the call PrintTriangle(4) should print the following:

```console
*
**
***
****
```


#### Exercise_61

##### Section 1
* Define a method called PrintSpaces(int number) that produces the number of spaces specified by number. The method **does not print the line break**.

You will also have to either copy the **PrintStars** method from your previous answer or reimplement it in this exercise template.

##### Section 2

* Create a method called **PrintRightTriangle(int size)** that uses PrintSpaces and PrintStars to print the correct triangle. So the method call **PrintRightTriangle(4)** should print the following:

```console
   *
  **
 ***
****
```

##### Section 3

* Define a method called **ChristmasTree(int height)** that prints the correct Christmas tree. The Christmas tree consists of a triangle with the specified height and the base. The base is two stars high and three stars wide, and is placed at the center of the triangle's bottom. The tree is to be constructed by using the methods PrintSpaces and PrintStars.

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
NOTICE! Heights shorter that 3 don't have work correctly!


