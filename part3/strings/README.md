
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
Console.WriteLine("The length of the word" + word + " is " + length);
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