## How to run exercises

In the exercise folder, run the command **dotnet run** to run your program. To see if your program does what it's supposed to, run **dotnet test**. When all the tests pass, you have done the exercise as intended.

## How to return your exercises

You return your exercises by pushing your answers to your personal repository.

The deadlines are every Sunday.

|Part| Deadline           | Exercises and sections total|
|:--:|:------------------:|:----------|
| 1  | 26.01.2020 at 23:59| 40        |
| 2  | 02.02.2020 at 23:59| 31        |
| 3  | 09.02.2020 at 23:59| 31        |
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
> 3
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

* Create a method called **PrintPhrase** which prints the phrase "In a hole in the ground there lived a method" and a newline (use WriteLine and not just Write).

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

* Write a method **public static string Word()**. The method must return a string of your choice.

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

* Define a three-parameter method **Greatest** that returns the greatest of the three numbers passed to it as parameters.

```cs
public static int Greatest(int number1, int number2, int number3) 
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

**NOTICE!** There has been an update to the template for exercises 60 and 61.  
The template should include empty methods for the exercise.  
IF YOU DO NOT GET THEM BY **GIT PULL**, JUST COPY THEM BY HAND!

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


# Part 3

## Lists

#### Exercise_62

The exercise contains a base that asks the user for strings and adds them to a list. The program stops reading when the user enters an empty string. The program then prints the first element of the list.

Your assignment is to modify the program so that instead of the first value, the third value on the list is printed. Remember that programmers start counting from zero! The program is allowed to malfunction if there are fewer than three entries on the list, so you don't need to prepare for such an event at all.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
Alex
```

```console
> Emma 
> Alex 
> Mary
>

Mary
```

#### Exercise_63

In the exercise template there is a program that reads integers from the user and adds them to a list. This ends when the user enters 0. The program then prints the first value on the list.

Modify the program so that instead of the first value, the program prints the sum of the second and third numbers. The program is allowed to malfunction if there are fewer than three entries on the list, so you don't need to prepare for such an event at all.

```console
> 1 
> 3 
> 5 
> 7 
> 0 
8
```

```console
> 2 
> 3 
> 4 
> 0 
7
```

#### Exercise_64

There is a program that uses a list in the exercise template. Modify it so that its execution always produces the error ArgumentOutRangeException. The user should not have to give any inputs to the program (e.g. write something on the keyboard)

#### Exercise_65

In the exercise template is a program that reads input from the user. Modify its working so that when the program quits reading (with an empty line), the program prints the number of values on the list.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
In total: 4
```

```console
> Juno 
> Elizabeth 
> Mason 
> Irene
> Olivia
> Liam
> Ida
> Christopher
> Mark
> Sylvester
> Oscar
>
In total: 11
```

Notice! Be sure to use the **Count property** of the list.

The next exercises are meant for learning to use lists and indices. Even if you could complete the execises without a list, concentrate on training to use lists. The functionality in the exercises is to be implemented after reading the inputs.

#### Exercise_66

In the exercise template there is a program that reads inputs from the user and adds them to a list. Reading is stopped once the user enters an empty string.

Your task is to modify the method to print the last read value after it stops reading. Print the value that was read last from the list. Use the Count to help you. You do not have to take into consideration empty lists, you can assume that the user always gives at least one input.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
Mary
```

```console
> Juno 
> Elizabeth 
> Mason 
> Irene
> Olivia
> Liam
> Ida
> Christopher
> Mark
> Sylvester
> Oscar
>
Oscar
```

#### Exercise_67

In the exercise template there is a program that reads inputs from the user and adds them to a list. Reading is stopped once the user enters an empty string.

Modify the program to print both the first and the last values after the reading ends. You may suppose that at least two values are read into the list.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
Tom
Mary
```

```console
> Juno 
> Elizabeth 
> Mason 
> Irene
> Olivia
> Liam
> Ida
> Christopher
> Mark
> Sylvester
> Oscar
>
Juno
Oscar
```

```console
> Tom 
> Mary
>
Tom
Mary
```

#### Exercise_68

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Expand the functionality of the program so that after reading the numbers, it prints all the numbers received from the user. The number used to indicate stopping should not be printed.

```console
> 72
> 2
> 8
> 11
> -1 
72
2
8
11
```

#### Exercise_69

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Expand the program to ask for a start and end indices once it has finished asking for numbers. After this the program shall prints all the numbers in the list that fall in the specified range (between the indices given by the user, inclusive). You may assume that the user gives indices that match some numbers in the list.

```console
> 72
> 2
> 8
> 11
> -1 
From where?
> 1
Where to?
> 9 
2 
8
```

```console
> 72
> 2
> 8
> 11
> -1 
From where?
> 0 
Where to?
> 20  
2
8
11 
```

#### Exercise_70

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Continue developing the program so that it ends the greatest number in the list and prints its value after reading all the numbers. The programming should work in the following manner.

```console
> 72
> 2
> 8
> 93
> 11
> -1
The greatest number: 93
```
You can assume that user always gives atleast one viable number.

You can use the source code below as an inspitation. It is used to find the smallest number.

```cs
// assume we have a list that contains integers

int smallest = list[0];

for(int i = 0; i < list.Count; i++) {
    int number = list[i];
    if (smallest > number) {
        smallest = number;
    }
}

Console.WriteLine("The smallest number: " + smallest);
```

#### Exercise_71

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Expand the program that then asks the user for a number, and reports that number's index in the list. If the number is not found, the program should not print anything.

```console
> 72 
> 2 
> 8 
> 8 
> 11 
> -1
Search for? 
> 2 
2 is at index 1
```

```console
> 72 
> 2 
> 8 
> 8 
> 11 
> -1
Search for? 
> 8 
8 is at index 2
8 is at index 3
```

#### Exercise_72

Write a program that reads numbers from the user. When number 9999 is entered, the reading process stops. After this the program will print the smallest number in the list, and also the indices where that number is found. Notice: the smallest number can appear multiple times in the list.

```console
> 72
> 2
> 8
> 8
> 11
> 9999
Smallest number: 2 
Found at index: 1
```

```console
> 72
> 44
> 8
> 8
> 11
> 9999
Smallest number: 8 
Found at index: 2 
Found at index: 3
```

HINT: combine the programs you wrote for the exercises "Greatest number in the list" and "Index of the requested number". First find the smalleest number, and then find the index of that number.

#### Exercise_73

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Modify the program so that after reading the numbers it calculates and prints the sum of the numbers in the list.

```console
> 72
> 2
> 8
> 11
> -1
Sum: 93
```

#### Exercise_74

In the exercise template there is a program that reads inputs from the user until an empty string is entered. Add the following functionality to it: after reading the inputs one more string is requested from the user. The program then tell whether that string was found in the list or not.

```
> Tom
> Emma
> Alex
> Mary
Search for?
> Mary
Mary was found!
```

```
> Tom
> Emma
> Alex
> Mary
Search for?
> Logan
Logan was not found!
```

#### Exercise_75

Create the method **public static void PrintNumbersInRange(List\<int\> numbers, int lowerLimit, int upperLimit)** in the exercise template. The method prints the numbers in the given list whose values are in the range [lowerLimit, upperLimit]. A few examples of using the method are supplied below.

```cs
List<int> numbers = new List<int>();
numbers.Add(3);
numbers.Add(2);
numbers.Add(6);
numbers.Add(-1);
numbers.Add(5);
numnbers.Add(1);

Console.WriteLine("The numbers in the range [0, 5]");
PrintNumbersInRange(numbers, 0, 5);

Console.WriteLine("The numbers in the range [3, 10]");
PrintNumbersInRange(numbers, 3, 10);
```

```console
The numbers in the range [0, 5] 
3 
2 
5 
1 
The numbers in the range [3, 10] 
3 
6 
5
```

#### Exercise_76


Create the method **public static int Sum(List\<int\> numbers)** in the exercise template. The method is to **return** the sum of the numbers in the parameter list.

```cs
List<int> numbers = new List<int>();
numbers.Add(3);
numbers.Add(2);
numbers.Add(6);
numbers.Add(-1);
Console.WriteLine(Sum(numbers));

numbers.Add(5);
numbers.Add(1);
Console.WriteLine(Sum(numbers));
```

```console
10
16
```

### Exercise_77

Create the method **public static void RemoveLast(List\<string\> strings)** in the exercise template. The method should remove the last value in the list it receives as a parameter. If the list is empty, the method does nothing.

```cs
List<string> strings = new List<string>();

strings.Add("First");
strings.Add("Second");
strings.Add("Third");

// Remember, this is how you print all the items in a list
strings.ForEach(Console.WriteLine);

RemoveLast(strings);
RemoveLast(strings);

strings.ForEach(Console.WriteLine);
```

## Arrays

#### Exercise_78

The exercise template already contains a program, that creates an array and prints the values of the array twice. Modify the program to do following: After the first printing, the program should ask for two indices from the user. The values in these two indices should be swapped, and in the end the values of the array should be printed once again.

```console
1 
3 
5 
7 
9

Give two indices to swap: 
> 2 
> 4

1 
3 
9 
7 
5
```

```console
1 
3 
5 
7 
9

Give two indices to swap: 
> 0 
> 1

3 
1 
5 
7 
9
```

You can assume the array to contain the given indices.   

Tip! You'll need an additional variable to store one of the values for little while.

#### Exercise_79

The exercise template has already an array containing numbers. Complete the program to ask the user for a number to search in the array. If the array contains the given number, the program tells the index containing the number. If the array doesn't contain the given number, the program will tell the number wasn't found.

```console
Search for? 
> 3 
3 is at index 4.
```

```console
Search for? 
> 7 
7 is at index 7.
```

```console
Search for? 
> 22 
22 was not found.
```

#### Exercise_80

The template has a method **public static int SumOfNumbersInArray(int[] array)**. Complete the method so, that it computes and returns the sum of the numbers in the array it receives as parameter.

You can try out the computation of the sum with this example:

```cs
int[] numbers = {5, 1, 3, 4, 2};
int sum = SumOfNumbersInArray(numbers);
Console.WriteLine(sum);
```

```console
15
```

#### Exercise_81

Complete the method **public static void PrintNeatly(int[] array)** in the template to make it print the numbers of the array it receives more neatly. There should be a whitespace and a comma between each number. don't put a comma after the last number.

Print the numbers on one line using **Console.Write**.

You can try out your printing with this example:

```cs
int[] array = {5, 1, 3, 4, 2};
PrintNeatly(array);
```

```console
5, 1, 3, 4, 2
```

#### Exercise_82

Complete the method **public static void PrintArrayInStars(int[] array)** in the template to make it print a row of stars for each number in the array. The amount of stars on each row is defined by the corresponding number in the array.

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

The 0th element of the array is 5, so the first line has 5 stars. The next one has 1 etc.

## Strings

#### Exercise_83

Write a program, that reads a string from the user and then prints it three times.

```console
Give a word: cake

cakecakecake
```

NOTICE! The program should ask for only one string. Don't use a loop here.

#### Exercise_84

Write a program that asks the user for a string. If the user writes the string "true", the program prints "You got it right!", otherwise it prints "Try again!".

```console
Give a string: true 
You got it right!
```


```console
Give a string: trueish 
Try again!
```

#### Exercise_85

write a program that recognizes the following users:


|username	|password|
|--|--|
|alex|	sunshine|
|emma|	haskell|

The program either shows a login message or informs of incorrect username or password.

```console
Enter username: 
>alex 
Enter password: 
> sunshine 
You have successfully logged in!
```
```console
Enter username: 
> emma 
Enter password: 
> haskell 
You have successfully logged in!
```

```console
Enter username: 
> alex 
Enter password: 
> haskell 
Incorrect username or password!
```

NOTICE! In read life login should not be implemented like this! This is just an exercise.

#### Exercise_86

Write a program that reads strings from the user. If the input is empty, the program stops reading input and halts. For each non-empty input it splits the string input by whitespaces and prints each part of the string on a new line.

```console
> once upon a time 
once 
upon 
a 
time 
> a little program 
a 
little 
program 
> halted 
halted
>
```

#### Exercise_87

Write a program, that reads user input until an empty line. For each non-empty string, the program splits the string by spaces and then prints the pieces that contain **av**, each on a new line.

```console
> navy blue shirt
navy
> Do you have a favourite flavour
have
favourite
flavour
> was that a cat
>
```

Tip! Strings have a Contains method, which tells if a string contains another string. It works like this:

```cs
string text = "volcanologist";

if (text.Contains("can")) 
{
  Console.WriteLine("can was found");
}

if (!text.Contains("tin")) 
{
  Console.WriteLine("tin wasn't found");
}
```

```console
can was found 
tin wasn't found
```

#### Exercise_88

Write a program, that reads user input until an empty line. For each non-empty line the program splits the string by spaces and prints the first part of the string.

```console
> one two three four 
one 
> this is a very important message 
this
>
```

#### Exercise_89

Write a program, that reads user input until an empty line. For each non-empty line the program splits the string by spaces and prints the last part of the string.

```console
> one two three four 
four 
> this is a very important message 
message
>
```

Tip! You can find out the length of the array like this:

```cs
string[] parts = {"one", "two", "three"};
Console.WriteLine("Number of parts: " + parts.Length);
```

```console
Number of parts: 3
```

#### Exercise_90

Write a program that reads names and ages from the user until an empty line is entered. The name and age are separed by a comma.

After reading the program prints the age of the oldest person. You can assume, that the user enters at least one person, and that one of the users is older than the others.

```console
> sebastian,2 
> lucas,2
> lily,1
> hanna,5
> gabriel,10
>
Age of the oldest: 10
```

#### Exercise_91

Write a program that reads names and ages from the user until an empty line is entered. The name and age are separed by a comma.

After reading the program prints the name of the oldest person. You can assume, that the user enters at least one person, and that one of the users is older than the others.

```console
> sebastian,2 
> lucas,2
> lily,1
> hanna,5
> gabriel,10
>
Name of the oldest: gabriel
```

#### Exercise_92

In this exercise you'll be asked for the length of the names. You can find out the length of a string with Length property:

```cs
string word = "equisterian";
int length = word.Length;
Console.WriteLine("The length of the word " + word + " is " + length);
```

```console
The length of the word equisterian is 11
```
Write a program that reads names and birth years from the user until an empty line is entered. The name and birth year are separed by a comma.

After that the program prints the longest name and the highest age. If multiple names are equally longest, you can print any of them. You can assume the user to enter at least one person, and the current year to be 2020.

```console
> sebastian,2017 
> lucas,2017 
> lily,2017 
> hanna,2014 
> gabriel,2009
>
Longest name: sebastian 
Highest age: 11
```

# Part 4

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

- the constructor **public Product (string name, double price, int quantity)**
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

## Objects in list

#### Exercise_110