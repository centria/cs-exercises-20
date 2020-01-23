## More loops

#### Exercise_45

Write a program that reads an integer from the user. Then the program prints numbers from 0 to the number given by the user. You can assume that the user always gives a positive number. Below is some examples of the wanted functionality. **You can use either a while-loop with a condition, or a for-loop.**

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

Write a program, which reads an integer from the user. Then the program prints numbers from that number to 100. You can assume that the user always gives a number less than 100. Below are some examples of the wanted functionality.

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
From now on, the exercises might be in multiple sections **in the instructions**, to make it easier to comprehend. In the end, you should still have **only one program per exercise**. Each section is counted separately, when calculating the total amount of exercises done. For example, an exercise with 2 sections, counts as 2 exercises in the total sum you have done.

Hint: The last section always shows what the program should do in total. When all the tests pass, you have done all the sections.

#### Exercise_47

##### Section 1
Write a program, which prints integers from 1 to a number given by the user.

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

Ask the user for the starting point as well.

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

Implement a program that asks the user for numbers(the program first prints "Write numbers: ") until the user gives the number -1, When the user writes -1, the program prints "Thx! Bye!" and ends.

##### Section 1
```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye!
```

##### Section 2

Extend the program so, that it prints the sum of the numbers (not including the -1) the user has written.

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
Extend the program so, that it also prints the number of numbers (not including the -1) the user has written.

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

Extend the program so, that it prints the mean of the numbers (not including the -1) the user has written.

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

Extend the program so that it prints the number of even and odd numbers (excluding the -1).

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