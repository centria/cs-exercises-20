## Conditionals and comparison

#### Exercise_24

Create a program, which asks the user for an integer.

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

Create a program which asks for an integer. If the integer is 1984, output "Orwell".

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

Create a program which asks for an integer. If the integer is less than 1900, output "You're old".

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

Create a program which tells if the given number is positive (greater than zero), or not.

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

Create a program which tell if the given person is legally adult (in Finland, over 18), or not.

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

Create a program which asks for two integers. The program should tell which of them is greater. If they are equal, that should be noted, too.

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

#### Exercise_31

Create a program which asks for an integer and tells the user if it is even or not.

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

Create a program which asks for a string. If the string is "Mellon", print "Welcome, friend", otherwise print "They've got a cave troll!"

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

Create a program which asks for two string. If the strings are equal, print "Echo", otherwise print "Nope".

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