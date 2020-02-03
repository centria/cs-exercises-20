
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