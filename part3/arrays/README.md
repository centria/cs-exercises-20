
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