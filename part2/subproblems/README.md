## Subproblems

#### Exercise_41

Write a program that reads an integer from the user input, and then prints the second power of the given integer, i.e. the integer multiplied by itself.

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

Write a program that reads **two integers** from the user, and prints the **square root of the sum of these integers**. The program **does not need to work with negative values**.

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

Write a program, that reads an integer from the user. If the number is less than 0, it prints the number multiplied by -1. Otherwise the program prints the number itself. A few examples of the expected function below:

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

Write a program that reads two integers from the user input. If the first number is greater than the second, the program prints "(first) is greater than (second)." If the first number is less than the second, the program prints "(first) is less than (second)." Otherwise the program prints "(first) is equal to (second)." The (first) and (second) should always be replaced with the actual numbers given by the user.

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