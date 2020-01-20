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
* Create a program, that asks the user for a name and a profession. Then make the program to write a little story with this information. Here is an example story with inputs **Ada** and **Data Scientist**:

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
