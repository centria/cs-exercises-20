## Objects in list

#### Exercise_110

Implement the class **Main** described here. **Do not modify the class Item.**

Write a program that reads names of items from the user. If the name is empty, the program stops reading. Otherwise, the given name is used to create a new item, which you will then add to the items list.

Having read all the names, print all the items by using the ToString method of the Item class. The implementation of the Item class keeps track of the time of creation, in addition to the name of the item.

Example print:
```console
Name: Hammer
Name: Radio
Name: Hot Potato
Name: 

Hammer (created at: 9.2.2020 13.48.16)
Radio (created at: 9.2.2020 13.48.18)
Hot Potato (created at: 9.2.2020 13.48.21)
```

#### Exercise_111

The program described here should be implemented in the class Main. Do not modify the class PersonalInformation.

After the user has entered the last set of details (they enter an empty first name), exit the repeat statement. 

Print one empty line here for reading clarity.

Then print the collected personal information so that each entered object is printed in the following format: first and last names separated by a space (you don't print the identification number). An example of the working program is given below:

```console
First name: 
> Jean 
Last name: 
> Bartik 
Identification number: 
> 271224 
First name: 
> Betty 
Last name: 
> Holberton 
Identification number: 
> 070317 
First name:
>

Jean Bartik 
Betty Holberton
```

You can (and should) ask the identification number as a string.

#### Exercise_112

In the exercise template there is a ready-made class TelevisionProgram, representing a television program. The class has object variables name and duration, a constructor, and a few methods.

Implement a program that begins by reading television programs from the user. When the user inputs an empty string as the name of the program, the program stops reading programs.

After this the user is queried for a maximum duration. Once the maximum is given, the program proceeds to list all the programs whose duration is smaller or equal to the specified maximum duration.

```console
Name: Rick and Morty 
Duration: 25 
Name: Two and a Half Men 
Duration: 30 
Name: Love it or list it 
Duration: 60 
Name: House 
Duration: 60
Name:

Program's maximum duration? 30 
Rick and Morty, 25 minutes 
Two and a Half Men, 30 minutes
```

#### Exercise_113

This exercise is worth 2.

Write a program that first reads book information from the user. The details to be asked for each book include the title, the number of pages, and the publication year. Entering an empty string as the name of the book ends the reading process.

After this the user is asked for what is to be printed. If the user inputs "everything", all the details are printed: the book titles, the numbers of pages, and the publication years. However, if the user enters the string "title", only the book titles are printed. If something else than "everything" or "title" is given, the program should not print anything.

- Implement the class Book.
- Implement the functionality in the Main method.

Example of how the program in Main should work:

```console

Name: To Kill a Mockingbird 
Pages: 281 
Publication year: 1960 
Name: A Brief History of Time 
Pages: 256 
Publication year: 1988 
Name: Beautiful Code 
Pages: 593 
Publication year: 2007 
Name: The Name of the Wind 
Pages: 662 
Publication year: 2007 
Name:

What information will be printed? everything 
To Kill a Mockingbird, 281 pages, 1960 
A Brief History of Time, 256 pages, 1988 
Beautiful Code, 593 pages, 2007 
The Name of the Wind, 662 pages, 2007
```

```console
Name: To Kill a Mockingbird 
Pages: 281 
Publication year: 1960 
Name: A Brief History of Time 
Pages: 256 
Publication year: 1988 
Name: Beautiful Code 
Pages: 593 
Publication year: 2007 
Name: The Name of the Wind 
Pages: 662 
Publication year: 2007 
Name:

What information will be printed? title 
To Kill a Mockingbird 
A Brief History of Time 
Beautiful Code 
The Name of the Wind
```
