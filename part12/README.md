# Part 12

#### Exercise_166

* In the exercise, you have a program with a ready Main, but the **NamespaceExample.cs** is missing namespaces.

* Create two namespaces, one nested in another. You can find the namespaces by looking at the **fully qualified names** of the method calls in Main.

NOTICE! The code does not work at all without namespaces. When the **dotnet test** passes, you know it is correct.

#### Exercise_167

* In this exercise, our very simple program is missing its **using directives**. Add them to make the code work. You will need 4 different usings.

HINT! If you don't know where everything is located, look from for example [**the Microsoft API Browser**](https://docs.microsoft.com/en-us/dotnet/api/system?view=dotnet-plat-ext-3.1) for help. *You might have to find something we have not used yet...*

#### Exercise_168

* In this exercise, we are missing an alias from both **MasterProject.cs** and from **Program.cs**. Create them to make the code work. You can find the alias name by looking at the **fully qualified names** and **method calls**.

#### Exercise_169

* In this exercise, we are missing **using statements** from our tests. Add them to make the tests pass.

NOTICE! The only code you have to touch, is in the **ExerciseTests.cs** file! There are some tests you should not touch, and they are marked as such!

#### Exercise_170

* In this exercise, we have a working Main, which has a **StreamWriter**. Change the code, so that the Main has a **using statement** for the StreamWriter.

* You will also have to take away the **Close()** command, as the using statement takes care of it!

NOTICE! The functionality should not change!

