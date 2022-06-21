# Chapter 9: Handling Arrays

An Array is a group of contiguous or related data items that share a common name.<br>Like other variables, arrays must be declared and created in the computer memory before they are used. Creation of an array involves three steps:
- **Declaring the array:** type[ ] arrayname;<br>example:
    ```cs
    int[] counter;
    float[] marks;
    int[] x, y;
    ```
- **Creating memory location:** arrayname = new type[size];<br>example:
    ```cs
    number = new int[5];
    average = new float[10];
    ```
- **Initialization of arrays:** arrayname[subscript] = value;<br>example:
    ```cs
    number[0] = 35;
    number[1] = 40;
    number[2] = 31;
    number[3] = 20;
    number[4] = 19;
    ```
We can also initialize arrays automatically in the same way as the ordinary variables when they are declared as shown: type[ ] arrayname = {list of values};<br>example:
```cs
int[] number = {35, 40, 20, 57, 19};
// or
int[] number = new int[5] {35, 40, 20, 57, 19};
```
This combines all the three steps, namely declaration, creation, and initialization.

### Array Length
In C# all arrays are class-based and store the allocated size in a variable named Length. We can access the length of the array using `a.length`.<br>
```cs
int aSize = a.Length;
```

## Two Dimensional Array
For creating two-dimensional arrays, we must follow the same steps as that of simple arrays:
```cs
int [,] myArray;
myArray = new int[3, 4];
// or
int [,] myArray = new int[3, 4];

// Direct Initialization
int[,] table = {
    {0, 0, 0},
    {1, 1, 1}
};
```

## Use of System.Array class
In C# every array we create is automatically dervied from the System.Array class. The class defines a number of methods and properties that can be used to maniputalte arrays more efficiently.<br>exmaple:
```cs
int [] A = new int[5];
A[0] = 42;
A[1] = 54;
A[2] = 12;
A[3] = 32;
A[4] = 24;
Array.Sort(A);      // Sorts the array in ascending order
Array.Reverse(A);   // The array is sorted in descending order
```

- **[Using Array.Sort:](./Practice/Program1.cs)** In this program Array.Sort() method is used to find the smallest, largest and the middle element of an array.

## ArrayLists using System.Collections class
An ArrayList is a dynamic array whose size can be increased or decreased according to requirements. It can hold objects of similliar types. By default, the capacity (or size is 16). To use the ArrayList class we need to use the System.Collections class where it is defined

- **[Creating an object of ArrayList:](./Practice/Program2.cs)** In this program creation and use of ArrayList is demonstrated. For understanding the creation is shown in the code intercept.
    ```cs
    using System.Collections;
    ArrayList a = new ArrayList(); // a is an object of type ArrayList
    a.Add("Mumbai");
    a.Add("Delhi");
    a.Add("Pune");
    ```
- **Changing the capacity of an ArrayList object:** 
    ```cs
    cities.Capacity = 50;
    cities.Capacity = 5;
    ```
- **[Use of Sort(), Contains(), Remove(), RemoveAt(), etc:](./Practice/Program3.cs)** The program uses the methods defined in System.Collections. We can see use of some methods below:
    ```cs
    cities.Sort(); // Sorts the elements
    bool b = cities.Contains("Kolkata"); // Checks if the element is present
    cities.Remove("Kolkata") // Removes first occurent of an element
    cities.RemoveAt(2) // Removes the index 2 
    ```


### Excercise Programs
1. **[Write a method that would take an array as input and check whether a given element is present in the list of not. The method must return true if it is present, otherwise return false.](./Excercise/9_12.cs)**

2. **[Write a program that stores a list of numbers in an array and computes the maximum and minimum values in the list.](./Excercise/9_13.cs)**

3. **[Write a method that would take two arrays as input and produces a third array by appending one to the other.](./Excercise/9_16.cs)**


---
<p align="center"><a href="../Chapter_8/">⬅️ Previous Chapter </a>&emsp;&emsp;|&emsp;&emsp;<a  href="../">Next Chapter ➡️</a></p>
