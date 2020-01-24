## How to return your exercises

You return your exercises by pushing your answers to your personal repository.

The deadlines are every Sunday.

|Part| Deadline           | Exercises and sections total|
|:--:|:------------------:|:----------|
| 1  | 26.01.2020 at 23:59| 40        |
| 2  | 02.02.2020 at 23:59| 31        |
| 3  | 09.02.2020 at 23:59| XX        |
| 4  | 16.02.2020 at 23:59| XX        |
| 5  | 23.02.2020 at 23:59| XX        |
| 6  | 01.03.2020 at 23:59| XX        |

The exercises might be in multiple sections **in the instructions**, to make it easier to comprehend. In the end, you should still have **only one program per exercise** to return in such case.  

Each section is counted separately, when calculating the total amount of exercises done. That is why they are calculated in the total of the table above.

## How to get more exercises

You can get more exercises to your local computer by **pulling this repository** with the command **git pull**.  

You can also update tests with this, if there are some problems.

# Exercises

The following instructions are also in the subfolders of each part.

# Part 1

## Printing and reading

The basic structure of the program is given in the exercises:

```cs
using System;

namespace exercise_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            
        }
    }
}
```

The line **// Add your code here:** is a comment. The composer does not compose it, so you do not have to worry about it. You can remove it, if you want.

#### Exercise_01:
* Create a program that writes the text **Hello World!** into the console. The program contains the basic structure pictured above.

#### Exercise_02:
* Let's write some more. Bonnie Tyler once sang about feelings, that also apply to coding:  
**Once upon a time**  
**I was falling in love**  
**Now I'm only falling apart**  
Create a program using 3 Console.WriteLines, that prints these lyrics.

#### Exercise_03:
* Let's refine our program. Print the same message:  
**Once upon a time**  
**I was falling in love**  
**Now I'm only falling apart**  
This time, use only one Console.WriteLine

#### Exercise_04:
* The exercise has following structure:

```cs
using System;

namespace exercise_04
{
    class Program
    {
        public static void Main(string[] args)
        {
            string message = "Passport and floss!";
            Console.WriteLine(message);
        }
    }
}
```

Change it, so that it prints **Passport and a toothbrush!**
Do not change the line containing Console.WriteLine, only change the content of the variable!



#### Exercise_05:
* You will find following structure in the exercise:
  
```cs
using System;

namespace exercise_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Ada Lovelace";
            // Write your code here:
            
        }
    }
}
```

Modify the code, so that it prints **Hello Ada LoveLace!**
Do not modify the variable content!

#### Exercise_06
* Create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line. Example output with **Hello** as input (input marked with **>** for clarification):

```console
Give input!
> Hello
Hello
```

#### Exercise_07
* Create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line 3 times. Example output with **Hello** as input:

```console
Give input!
> Hello
Hello
Hello
Hello
```

#### Exercise_08
* Create a program, that asks user for their name and greets them. Example output with **Ada** as input:

```console
What is your name?
> Ada
Hello Ada!
```
Notice the exclamation mark.

#### Exercise_09
* Create a program, that simulates a small conversation. The program will tell three lines, and expects two user inputs. Example output:

```console
Hello, how are you?
> Fine, thanks.
That's interesting, tell me more
> I learn coding
Thank you for sharing!
```

#### Exercise_10
* Create a program, that asks the user for a name and a profession. Then make the program to write a little story with this information. Here is an example story with inputs **Ada** and **Data Scientist**.

NOTICE! Every **Ada** and **Data Scientist** in the story are the inputs by the user. Remember to save the **Console.ReadLines** into variables and use them as parts of the story!

```console
I will tell a story, but I need some information.
Give a name for main character:
> Ada
Give the character a profession:
> Data Scientist
Here is the story:
Once upon a time there was a Data Scientist called Ada
On her way to work, Ada often pondered what being Data Scientist meant to them.
When you work as a Data Scientist you meet interesting people.
Ada enjoys their work as Data Scientist, The end.
```

## Variables

#### Exercise_11
* The exercise comes with a template that prints the following:

```console
Days to summer:
100
Hours to lunch:
1
Coding is fun:
Are you sure?
```

Change the values of the variables, so the program will print

```console
Days to summer:
200
Hours to lunch:
3.5
Coding is fun:
It sure is!
```

#### Exercise_12
* Create a program, that asks the user for an integer. After user input, the program will print the integer. Example prints:

```console
Give a number!
> 11
You gave 11
```

```console
Give a number!
> 42
You gave 42
```

#### Exercise_13
* Create a program, that asks the user for a double. After user input, the program will print the double. Example prints:

```console
Give a number!
> 11.11
You gave 11.11
```

```console
Give a number!
> 41.999999
You gave 41.999999
```

#### Exercise_14
* Create a program, that asks the user for a boolean. After user input, the program will print the boolean. Example prints:

```console
Give me the truth!
> tRuE
True
```

```console
Give me the truth!
> false
False
```

#### Exercise_15
* Let's combine everything you know so far. Create program that asks the user for a string, an integer, a double and a boolean, and prints them like follows:

```console
Give a string:
> This is a masterpiece!
Give an integer:
> 42
Give a double:
> 3.1415
Give a boolean:
> True
Your string: This is a masterpiece!
Your integer: 42
Your double: 3.1415
Your boolean: True
```

## Calculations

#### Exercise_16

Create a program, which asks user for amount of days, and prints the total amount of seconds for that amount of days, gives the answer and quits.

Example print:
```console
How many days?
> 2
172800
```
```console
How many days?
> 7
604800
```

#### Exercise_17

* Create a program, which asks the user for two integers, and calculates their sum.  

Remember, that the input is a string, so you have to convert it to integer!

Example output:

```console
Give the first number!
> 8
Give the second number!
> 3
The sum is 11
```

```console
Give the first number!
> 3
Give the second number!
> -1
The sum is 2
```

#### Exercise_18

* Expand a little on the previous exercise. Now create a program, which asks for three integers, and calculates their sum.

```console
Give the first number!
> 3
Give the second number!
> -1
Give the third number!
> 2
The sum is 4
```

#### Exercise_19

* Create a program, which asks the user for two integers and counts their sum. This time, also print the equation to the user, too.

```console
Give the first number!
> 3
Give the second number!
> 1
3 + 1 = 4
```

```console
Give the first number!
> 5
Give the second number!
> -1
3 + -1 = 2
```

#### Exercise_20

* Create a program, which asks the user for two integers and multiplies them with each other.

```console
Give the first number!
> 3
Give the second number!
> 2
3 * 2 = 6
```

```console
Give the first number!
> 50
Give the second number!
> -2
50  * -2 = -100
```

#### Exercise_21

* Create a program, which asks the user for two **integers** and calculates their **average** as a **double**.

```console
Give the first number!
> 3
Give the second number!
> 2
The average is 2.5
```

#### Exercise_22

* Create a program, which asks the user for three **integers** and calculates their **average** as a **double**.

```console
Give the first number!
> 3
Give the second number!
> 2
Give the third number!
> 1
The average is 2.0
```

#### Exercise_23

* Let's create a program, that does all the basic calculations from user input! Ask for two integers and do the calculations with them.

```console
Give the first number!
> 3
Give the second number!
> 2
3 + 2 = 5
3 - 2 = 1
3 * 2 = 6
3 / 2 = 1.5
```

## Conditionals and comparison

#### Exercise_24

* Create a program, which asks the user for an integer.

If the given integer is larger than 120, output "Speeding!".

```console
Your speed:
> 5
````

```console
Your speed:
125
Speeding!
```

#### Exercise_25

* Create a program which asks for an integer. If the integer is 1984, output "Orwell".

```console
Give a number:
>1985
```

```console
Give a number:
> 1984
Orwell
```

#### Exercise_26

* Create a program which asks for an integer. If the integer is less than 1900, output "You're old".

```console
Give your age:
>1985
```

```console
Give your age:
> 1899
You're old
```

#### Exercise_27

* Create a program which tells if the given number is positive (greater than zero), or not.

```console
Give a number:
> 5
It is positive
```

```console
Give a number:
-2
It is not positive
```

### Exercise_28

* Create a program which tell if the given person is legally adult (in Finland, over 18), or not.

```console
How old are you?
> 5
You're under age!
```

```console
How old are you?
> 18
You're an adult!
```

### Exercise_29

* Create a program which asks for two integers. The program should tell which of them is greater. If they are equal, that should be noted, too.

```console
Give the first number!
> 3
Give the second number!
> 2
The larger number is 3!
```

```console
Give the first number!
> 3
Give the second number!
> 4
The larger number is 4!
```

```console
Give the first number!
> 3
Give the second number!
> 2
They are equal!
```

#### Exercise_30

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

* Create a program, which asks the user for their percent, and gives them their score. For example:

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

#### Exercise_31

* Create a program which asks for an integer and tells the user if it is even or not.

```console
Give a number:
> 2
It is even.
```

````console
Give a number
> 5
It is odd.
````

Hint: You might want to use the **%** operator to get the remainder after a division with 2.

#### Exercise_32

* Create a program which asks for a string. If the string is "Mellon", print "Welcome, friend", otherwise print "They've got a cave troll!"

```console
Speak, friend, and enter!
> Let meeeee in!
They've got a cave troll!
```

```console
Speak, friend, and enter!
> Mellon
Welcome, friend
```

#### Exercise_33

* Create a program which asks for two string. If the strings are equal, print "Echo", otherwise print "Nope".

```console
Give the first string:
> Potato
Give the second string:
> Potato
Echo!
```

```console
Give the first string:
> Potato
Give the second string:
> Tomato
Nope!
```

## Repetition

#### Exercise_34

* Create a program which asks the user if they want to continue. If the user answers "no", then quit the program. Otherwise, ask again.

Hint: Use a while-loop!

```console
Do you want to continue?
> Yes
Do you want to continue?
> Hot potato
Do you want to continue?
> no
```

#### Exercise_35

* Create a program, which asks the user for integers, until the user give the number "42".

```console
Give a number:
> 41
Give a number:
> 68
Give a number:
-42
Give a number:
42
```

#### Exercise_36

* Create a program, which asks the user for integers. If the number is zero, exit the program. If the number is negative, give the user message "That is negative". If the number is positive, output the number, raised to its second power (the number multiplied with itself).

```console
Give a number:
> 5
25
Give a number:
> -2
That is negative
Give a number:
> 4
16
Give a number:
0
```

#### Exercise_37

* Create a program which asks the user for integers. If the integer is 0, quit. In the end, output "Total amount of numbers:" and the amount. Do not count the 0 into the amount.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total amount of numbers: 3
```

#### Exercise_38

* Create a program which asks the user for integers. If the integer is 0, quit. In the end, output the total amount of **negative numbers** with "Total amount of negative numbers:" and the amount. Do not count the 0 into the amount.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total amount of negative numbers: 1
```

#### Exercise_39

* Create a program which asks the user for integers. If the integer is 0, quit. In the end, output the total **sum** of the numbers with "Total sum of numbers:" and the sum. Do not count the 0 into the sum, even though it does not change the result.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total sum of numbers: 25
```

#### Exercise_40

* Create a program which asks the user for integers. Exit with 0. In the end, output both the amount and the sum. Do not count 0 to either.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total sum of numbers: 25
Total amount of numbers: 3
```

Hint: You will need two variables to store the data, one for the sum, one for the amount.


# Part 2

## Subproblems

#### Exercise_41

* Write a program that reads an integer from the user input, and then prints the second power of the given integer, i.e. the integer multiplied by itself.

```console
> 4
16
```

```console
> 5
25
```

```console
> -3
9
```

#### Exercise_42

* Write a program that reads **two integers** from the user, and prints the **square root of the sum of these integers**. The program **does not need to work with negative values**.

You can get the square root of an integer with the command Math.Sqrt like this:

```cs
int number = 42;
double squareRoot = Math.Sqrt(number);
Console.WriteLine(squareRoot);
```

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
> 35 
6
```

#### Exercise_43

* Write a program, that reads an integer from the user. If the number is less than 0, it prints the number multiplied by -1. Otherwise the program prints the number itself. A few examples of the expected function below:

```console
> -3
3
```

```console
> 1
1
```

```console
> 0
0
```

#### Exercise_44

* Write a program that reads two integers from the user input. If the first number is greater than the second, the program prints "(first) is greater than (second)." If the first number is less than the second, the program prints "(first) is less than (second)." Otherwise the program prints "(first) is equal to (second)." The (first) and (second) should always be replaced with the actual numbers given by the user.

A few examples of the expected behaviour:

```console
> 8 
> 4 
8 is greater than 4.
```

```console
> -3 
> 5 
-3 is less than 5.
```

```console
> 1 
> 1 
1 is equal to 1.
```

## More loops

#### Exercise_45

* Write a program that reads an integer from the user. Then the program prints numbers from 0 to the number given by the user. You can assume that the user always gives a positive number. Below is some examples of the wanted functionality. **You can use either a while-loop with a condition, or a for-loop.**

```console
> 4
0
1
2
3
4
```

```console
> 1
0
1
```

#### Exercise_46

* Write a program, which reads an integer from the user. Then the program prints numbers from that number to 100. You can assume that the user always gives a number less than 100. Below are some examples of the wanted functionality.

```console
> 99
99
100
```

```console
> -4
-4
-3
-2
-1
0
1
... (lots of numbers in between) ...
98
99
100
```

### NOTICE!
From now on, the exercises might be in multiple sections **in the instructions**, to make it easier to comprehend. In the end, you should still have **only one program per exercise** to return.  

Each section is counted separately, when calculating the total amount of exercises done. For example, the next exercise with 2 sections, counts as 2 exercises in the total sum you have done. 

Hint: The last section always shows what the program should do in total. When all the tests pass, you have done all the sections.

#### Exercise_47

##### Section 1
* Write a program, which prints integers from 1 to a number given by the user.

```console
Where to? 
>3 
1 
2 
3
```

```console
Where to? 
>5 
1 
2 
3 
4 
5
```

Hint: the number read from the user is now the upper limit of the condition. Remember that **a <= b** means a is smaller or equal to b.

##### Section 2

* Ask the user for the starting point as well.

```console
Where to? 
>8 
Where from? 
>5
5 
6 
7 
8
```

If the upper limit is larger than the starting point, nothing is printed:

```
Where to? 
> 12 
Where from? 
> 16
```

Hint: Remember that the lower and the upper limits can be negative!

#### Exercise_48

##### Section 1

* Implement a program that asks the user for numbers(the program first prints "Write numbers: ") until the user gives the number -1, When the user writes -1, the program prints "Thx! Bye!" and ends.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye!
```

##### Section 2

* Extend the program so, that it prints the sum of the numbers (not including the -1) the user has written.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
```

##### Section 3 
* Extend the program so, that it also prints the number of numbers (not including the -1) the user has written.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
Numbers: 3
```

##### Section 4

* Extend the program so, that it prints the mean of the numbers (not including the -1) the user has written.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
Numbers: 3
Average: 3.666666666666
```

##### Section 5

* Extend the program so that it prints the number of even and odd numbers (excluding the -1).

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
Numbers: 3
Average: 3.666666666666
Even: 2
Odd: 1
```

### NOTICE!
When you are writing a program, whether it's an exercise or a personal project, figure out the types of parts the program needs to function and proceed by implementing them one part at a time. Make sure to test the program right after implementing each part.

Never try solving the whole problem at once, because that makes running and testing the program in the middle of the problem-solving process difficult. Start with something easy that you know you can do. When one part works, you can move on to the next.

Some of the exercises are already split into parts. However, it's often the case in programming that these parts need to be split into even smaller parts. You should almost always run the program after every new line of code. This ensures that the solution is moving in the right direction.

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


