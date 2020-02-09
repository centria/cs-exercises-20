## Files and reading data

#### Exercise_114

As a recap, a simple program of reading the input.

Write a program that reads strings from the user until the user inputs the string "end". At that point, the program should print how many strings have been read. The string "end" should not be included in the number strings read. You can find some examples below of how the program works.

```console
> I 
> have
> a
> feeling
> that
> I
> have
> written
> this
> wrong
> before
> end 
11
```

```console
> end 
0
```

#### Exercise_115

Write a program that reads strings from the user until the user inputs the string "end". As long as the input is not "end", the program should handle the input as an integer and print the cube of the number provided (i.e., number _ number _ number). Below are some sample outputs

```console
> 3 
27 
> -1 
1 
> 11 
1331 
> end
```

```console
end
```

Remember to convert to integer before calculation!

#### Exercise_116

Write a program that prints the contents of a file called "data.txt", such that each line of the file is printed on its own line.

If the file content looks like so:

In a world
Where code is built

Then the program should print the following:

```console
In a world
Where code is built
```

#### Exercise_117

Write a program that asks the user for a string, and then prints the contents of a file with a name matching the string provided. You may assume that the user provides a file name that the program can find. You do not have to worry about getting errors when the file does not exist.

The exercise template contains the files "data.txt" and "song.txt", which you may use when testing the functionality of your program. The output of the program can be seen below for when a user has entered the string "song.txt". The content that is printed comes from the file "song.txt". Naturally, the program should also work with other filenames, assuming the file can be found.

```console
Which file should have its contents printed? 
> song.txt 

No option for duality 
The old is where we come 
Clockspeed is fast, but we'll survive 
The new will overcome 
We are challengers, not followers 
We take the ball to build 
Easy safe services 
Are here to stay

Value for society 
Value for life 
For you and me 
Tieto is here allright!
```

#### Exercise_118

The exercise template comes ready with functionality for the guest list application. It checks whether names entered by the user are on the guest list.

However, the program is missing the functionality needed for reading the guest list. Modify the program so that the names on the guest list are read from the file.

Name of the file: guestlist.txt

Enter names, an empty line quits. 
> Chuck Norris 
The name is not on the list. 
> Jack Baluer 
The name is not on the list. 
> Jack Bauer 
The name is on the list. 
> Jack Bower 
The name is on the list.
>
Thank you!

NOTICE! The exercise template comes with two files, names.txt and other-names.txt, which have the following contents. Do not change the contents of the files!

names.txt:

ada 
arto 
leena 
test
heikki

other-names.txt:

leo 
jarmo 
alicia
mike
potato

