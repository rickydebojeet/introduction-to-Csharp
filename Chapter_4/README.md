# Chapter 4: Literals, Variables and Data Types

This diagram should give a basic idea about what are the data types available for C# Language. What's interesting is that Value Types are fixed in length and it is stored in stack. Where as Variable Types are not fixed and is stored in heap.

<p align="center">
  <img src="./data_types.png" width="350">
</p>

- **Initialization of variables**

  ```C#
  int variable1 = 100; // Initialization of integer
  char variable2 = 'x'; // Initialization of character
  double variable3 = 45.20; // Initialization of double
  bool variable4 = true; // Initialization of boolean

  float x, y, z; // Declaration of x, y, z
  int m, n = 10; // Declaration of m, n and iinitialization of n
  int m = 10, n = 5; // Declaration and initialization of m, n

  // Variables with modifiers
  float a = 12.3F;
  uint b = 123U;
  long c = 123L;
  ulong d = 123UL;
  decimal e = 1.23M;
  ```

  All interger numbers by default represent int type values. If we want the value to represent any other integer type, we must append U to dentote and unsigned type, L to denote long and UL to denote unsigned long. Similarly, all floating-point numbers are double by default. Therefore we must append F or M to the numbers to denote float and decimal types respectively.

- **Constant Variables**

  ```C#
  const int ROWS = 10;
  const int COLS = 20;

  const int m = 5;
  const int n = m * 10; // Correct
  int m = 5;
  const int n = m * 10; // Error
  ```

  Somethings that should be noted:

  - After declaration of constants, they should not be assigned any other value.
  - Constants cannot be declared inside a method. They should be declared only at class level.

- **Boxing and Unboxing**:

  In object-oriented programming, methods are invoked using objects.

  Converting value-type or refernce type into object type is called as boxing.

  ```C#
  int m = 10;
  object om = m; // Creates a box to hold m
  // OR
  object om = (object) m; // C-style casting
  ```

  Note that the boxing operation creates a copy of the value of the m integer to the object om. Consider the following code:

  ```C#
  int m = 10;
  object om = m;
  m = 10;
  Console.WriteLine(m); // m = 20
  Console.WriteLine(om); // om = 10
  ```

  Conversly, the conversion from an object type back to a value type is known as unboxing.

  ```C#
  int m = 500;
  object  om = m;
  int n = int(om);
  ```

  I hope that everyone has a little bit of understanding of Operators and Expressions. It's almost same as C Programming Language. So I am going to skip it, if anyone want to learn more about it can find it in the book.

<p style="text-align:left;">
  <a href="../Chapter_3/README.md">⬅️ Previous Chapter </a>
    <span style="float:right;">
        <a text-align="right" href="../Chapter_6/README.md">Next Chapter ➡️</a>
    </span>
</p>
