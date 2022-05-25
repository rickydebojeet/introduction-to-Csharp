# Chapter 3: Introduction to C#

- **Introduction (Get some familirization with its syntax)**

  - **[A Simple C# Program](./Practice/Program1.cs)**: This is where we start. In this program we are just printing one string in a console. There are few things that should be noted:

    - **Class Declaration:** The line `class program1` declares a class, which is an object-oriented construct. Since C# is a true object-oriented language therefore, 'everything' must be placed inside a class. Moreover **class** in later topics.

    - **The Main Method:** The line `public static void Main()` defines a method named Main (M in capital). Every C# executable program must include the Main() method in one of the classes. This is the 'starting point' for executing the program. This line contains a number of keywords there are defined below:

      - `public`: The keyword is an access modifier that tells the C# compiler that the Main method is accesible by anyone.

      - `static`: The keyword static declares that the Main method is a global one and can be called without creating an instance of the class. The compiler stores the address of the method as the entry point and uses this information to begin execution before any objects are created.

      - `void`: The keyword void is a type modifier that states that the Main method does not return any value.

  - **[Using Aliasing](./Practice/Program2.cs)**: Before knowing about aliasing we first need to know what is namespaces. Let's consider the code `System.Console.WriteLine();` here System is a namespace (scope/library) where different classes are present (like Console), and the classses contains defination of different Methods (like WriteLine()). We can write `using System;` in the start of a program to use the elements of that namespce without using the namespace as prefix. Now let's go back to our program if we use certain class a lot we can use what is known as aliasing. `using syc = System.Console;` here we are using 'syc' as an alias for System.Console, so we can replace it with syc all together.

  - **[Printing String Variables](./Practice/Program3.cs)**: In this program isted of writng constant string output to the Console. We will use a string object to store a string value and we will pass the object as a parameter tot the WriteLine Method.

  - **[Command Line Inputs as Arguments](./Practice/Program4.cs)**: What if we want our program to behave in a particular way depending on the input provided at the time of execution? We can achieve that by using what is known as _Command Line Arguments_. Command Line arguments are parameters that are supplied to the Main method at the time of invoking it for execution. The CLI (Command Line Interface of the program will be something like this):

    ```console
    ricky@Rickys-Air % program4.exe
    C Sharp Welcome to C Sharp
    ricky@Rickys-Air %
    ```

    So what is really happening is C is stored in args[0] and Sharp is stored in args[1] and we have used it while printing it in the Console.

  - **[A Program with more than one Class](./Practice/Program5.cs)**: In this program we have more than class. In the class where the Main() method is present `class program5` we are instantiating one object `test` of that class `testClass` and we are calling one method `fun()` from that class.

  - **[Interactive Console Input](./Practice/Program6.cs)**: Till now we have only use two ways to give values to string objects:

    - Using an assignment statement.

    - Through command line arguments.

    But it is also possible to give values to string variables interactively through the keyboard at the time of execution (runtime). It is done using `System.Console.ReadLine()`. It should be noted that the method returns a string so to initialize a integer or float we need to use another method from Convert class i.e. `System.Convert`. So the final code for initializing one integer varible will be somthing like `System.Convert.ToInt32(System.Console.ReadLine());`

  - **[Multiple Main Methods](./Practice/Program7.cs)**: If there are multiple Main() methods in a program with multiple classes. We need to provide starting point by specifying from which class we should start the program. The CLI for that will be:

    ```console
    ricky@Rickys-Air % csc Program7.cs /main:ICI
    ```

- **Questions (Try it yourself before checking the solutions)**

  1. [Write a program to read two strings from the keyboard using the ReadLine statements and display them on one line using two Write statements.](./Exercise/3_1.cs)

  2. [Write a program that thakes the line of tex "John F Kennedy" as a command line input and displays the following output "Kennedy John F".](./Exercise/3_2.cs)

  3. [Define two classes, one with a method to display the string "C Sharp" and other to display the string "Programming". Write a program using these classes to display a single line output as follows: "C Sharp Programming"](./Exercise/3_3.cs)

  4. [Write a program that assigns two double type values to two variables, computes their sum, assigns the result to a third variable, and displays all the three values in one line of output.](./Exercise/3_4.cs)

  5. [Write a program to display the following pattern on the screen.](./Exercise/3_5.cs)
     ```console
             X
           X X X
         X X X X X
           X X X
             X
     ```

---
<p align="center"><a href="../">🏠 Go to Home </a>&emsp;&emsp;|&emsp;&emsp;<a  href="../Chapter_4/">Next Chapter ➡️</a></p>


