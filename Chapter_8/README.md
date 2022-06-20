# Chapter 8: Methods in C#

Methods are declared inside the body of a class, normally after the declaration of data fields. A method consists of:
- **Method Name:** It is a valid C# identifier.
- **Number of Parameters:** It is also known as formal parameter. This list contains varable names and types of all the values we want to give to the method as input.
- **Return type of a Method:** It specifies the type of value the method will return.
- **Body of the Method**

### Practice Programs
- **[Defining and Invoking a Method:](./Practice/Program1_0.cs)** Once a method have been defined, they must be activated for operations. The process of activating the method is known as *invoking or calling.* <br>In this program we have defined a method inside a class it has modifier public so that we can call it from other classes. To invoke the method from another class we need to create an object and invoke the method.

- **[Defining and Invoking a Method within a class:](./Practice/Program1_1.cs.cs)** In this program a method have been defined, and invoked within one class only. To do so we had to make an object i.e an instance of a class.

- **[Calling a static Method:](./Practice/Program2.cs)** In this program the keyword static is used to qualify the method Square. Here the method does not operate on a specific instance of the class. More about static in next chapters.

- **[Nesting of Methods:](./Practice/Program3.cs)** A method can be invoked only by an object of that class if it is invoked outside the class. A method can be called using only its name by another method of the same class. This is known as nesting of methods.

- **Types of parameters pased in method calls:**
    - **[Pass by Value:](./Practice/Program4.cs)** By default, method parameters are passed by value. In case of call by value, a memory location of an actual parameter is different than that of formal parameter.<br>So, in call by value, any modification mode in formal parameter will not have any effect on the corresponding actual parameter.

    - **[Pass by Reference:](./Practice/Program5.cs)** Here, the memory location of an actual parameter and the corresponding formal parameter is same. i.e. formal parameter is an alias of the actual.<br>Therefore, any modification made in the formal parameter will be reflected in the corresponding actual address. 

    - **[The Output Parameter:](./Practice/Program6.cs)** Output parameters are used to pass result back to the calling method. This is achieved by declaring the parameter with an `out` keyword.<br>Similar to the reference parameter, in an output calling method when a formal parameter is declared as out, the corresponding actual parameter in the calling method, the parameters must also be declared as out.

- **[Method Overloading:](./Practice/Program7.cs)** Same method name can be used for different types of functioning. But the prototype of the methods must not be exactly be the same. Method Overloading is used when methods are required to perform similar tasks but using different input parameters. 

### Excercise Programs
1. **[Write a method Space(int n) that can be used to provide a space of n positions between output of two numbers.](./Excercise/8_8.cs)**

2. **[Write a method Prime that returns true if its argument is a prime numer and returns false otherwise](./Excercise/8_10.cs)**

3. **[Write a void type method that takes two int type value parameters and one int type out parameter and returns the product of two value parameters through the output parameter. Write a program to test its working.](./Excercise/8_11.cs)**

4. **[Write a method that takes an array as an input paramter and uses two methods, one to find the largest array element and other to compute the average of array elements.](./Excercise/8_15.cs)**


---
<p align="center"><a href="../Chapter_7/">⬅️ Previous Chapter </a>&emsp;&emsp;|&emsp;&emsp;<a  href="../">Next Chapter ➡️</a></p>
