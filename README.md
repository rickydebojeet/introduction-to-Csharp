# Introduction to C#

C# pronounced as _C Sharp_ is a Object Oriented Programming Language by Microsoft. It is derived from C, C++, Java, Visual Basic. It is a modern language with type safe and garbage collection unlike C++ and its predecessor C. But we can use unsafe operation like pointers, and arrow operations but it will make the program type unsafe.

This repository is meant to be used with the book [_"Programming in C# : A Primer"_](introduction_to_c%23_Balagurusamy.pdf) by **E Balagurusamy**.

The repository is divided into 2 parts:

- **Basics:** The basics goes through the simple programs that are meant for explaination how the syntax works in C# language.

- **Excercises:** The excercise problems of the book that is solved using the C# language.

I am currently planning to include more modules in this repository including DSA _(Data Structures and Algorithms)_ which has some flavours of OOP _(Objected Oriented Programming)_

## Pre-Requisites

.NET Framework is required to compile the code into MSIL _(Intermediate Language)_ using the CLR _(Common Language Runtime)_

## Usage

For compiling the C# files:

```sh
csc <filename.cs>
```

For running the executable file in Windows:

```sh
<filename.exe>
```

For running the executable file in mac OS (using mono):

```sh
mono <filename.exe>
```

## Roadmap

Follow this route if you are a beginner it will start with total basics, including some problems.

### Chapter 1: Introduction to C#

- **Intruduction (Get some familirization with its syntax)**

  - **[A Simple C# Program](./Tests/Chapter_3/Program1.cs)**: This is where we start. In this program we are just printing one string in a console. There are few things that should be noted:

	- **Class Declaration:** The line `class program1` declares a class, which is an object-oriented construct. Since C# is a true object-oriented language therefore, 'everything' must be placed inside a class. Moreover class in later topics.

	- **The Main Method:** The line `public static void Main()` defines a method named Main (M in capital). Every C# executable program must include the Main() method in one of the classes. This is the 'starting point' for executing the program. This line contains a number of keywords there are defined below:

		- `public`: The keyword is an access modifier that tells the C# compiler that the Main method is accesible by anyone.

		- `static`: The keyword static declares that the Main method is a global one and can be called without creating an instance of the class. The compiler stores the address of the method as the entry point and uses this information to begin execution before any objects are created.

		- `void`: The keyword void is a type modifier that states that the Main method does not return any value.

  - **[Using Aliasing](./Tests/Chapter_3/Program2.cs)**: Before knowing about aliasing we first need to know what is namespaces. Let's consider the code `System.Console.WriteLine();` here System is a namespace (scope/library) where different classes are present (like Console), and the classses contains defination of different Methods (like WriteLine()). We can write `using System;` in the start of a program to use the elements of that namespce without using the namespace as prefix. Now let's go back to our program if we use certain class a lot we can use what is known as aliasing. `using syc = System.Console;` here we are using 'syc' as an alias for System.Console, so we can replace it with syc all together.

  - **[Printing String Variables](./Tests/Chapter_3/Program3.cs)**: In this program isted of writng constant string output to the Console. We will use a string object to store a string value and we will pass the object as a parameter tot the WriteLine Method.
  
  - **[Command Line Inputs as Arguments](./Tests/Chapter_3/Program4.cs)**: What if we want our program to behave in a particular way depending on the input provided at the time of execution? We can achieve that by using what is known as *Command Line Arguments*. Command Line arguments are parameters that are supplied to the Main method at the time of invoking  it for execution. The CLI (Command Line Interface of the program will be something like this): 
  	```sh
  	  ricky@Rickys-Air % program4.exe C Sharp
	  Welcome to C Sharp
	  ricky@Rickys-Air %
  	```
	So what is really happening is C is stored in args[0] and Sharp is stored in args[1] and we have used it while printing it in the Console.

  - **[A Program with more than one Class](./Tests/Chapter_3/Program5.cs)**: In this program we have more than class. In the class where the Main() method is present `class program5` we are instantiating one object `test` of that class `testClass` and we are calling one method `fun()` from that class.

  - **[Interactive Console Input](./Tests/Chapter_3/Program6.cs)**: Till now we have only use two ways to give values to string objects:

	- Using an assignment statement.

	- Through command line arguments.

	But it is also possible to give values to string variables interactively through the keyboard at the time of execution (runtime). It is done using `System.Console.ReadLine()`. It should be noted that the method returns a string so to initialize a integer or float we need to use another method from Convert class i.e. `System.Convert`. So the final code for initializing one integer varible will be somthing like `System.Convert.ToInt32(System.Console.ReadLine());`

  - **[Multiple Main Methods](./Tests/Chapter_3/Program7.cs)**: If there are multiple Main() methods in a program with multiple classes. We need to provide starting point by specifying from which class we should start the program. The CLI for that will be:
	```sh
	ricky@Rickys-Air % csc Program7.cs /main:ICI
	```
- Questions (Try it yourself before checking the solutions)
	1. [Write a program to read two strings from the keyboard using the ReadLine statements and display them on one line using two Write statements.](./Chapter_3/3_1.cs)

	2. [Write a program that thakes the line of tex "John F Kennedy" as a command line input and displays the following output "Kennedy John F".](./Chapter_3/3_2.cs)

	3. [Define two classes, one with a method to display the string "C Sharp" and other to display the string "Programming". Write a program using these classes to display a single line output as follows: "C Sharp Programming"](./Chapter_3/3_3.cs)

	4. [Write a program that assigns two double type values to two variables, computes their sum, assigns the result to a third variable, and displays all the three values in one line of output.](./Chapter_3/3_4.cs)

	5. [Write a program to display the following pattern on the screen.](./Chapter_3/3_5.cs)
		```sh
				    X
				  X X X
				X X X X X
				  X X X
				    X
		```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## :+1: Credits

- [Debojeet Das](https://rickydebojeet.github.io)
- [Swaubhik Chakraborty](https://swaubhik.github.io)

## License

[MIT](https://choosealicense.com/licenses/mit/)
