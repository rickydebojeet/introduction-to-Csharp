# Chapter 7: Decision Making and Looping

A computer is well suited for repetitive operations. Using looping, a sequence of statements are executed untill some conditions for the termination of the loop are satisfied. A program loop therefore consists of two segments, one known as the body of the loop and the other known as the control statement.

<!--TODO Flowchart -->

- **[The four constructs for perfoming loop operations](./Practice/Program1.cs):** In this program all the loop constructs that are available in C# Language is demonstrated. They are:
    - The `while` statement: In this construct the control segment is evaluated and if it true, then the body of the loop is executed.
    - The `do` statement: Here instead of evaluating the control segment first the body is executed the the control segment is checked. So the body of the loop is executed atleast once.
    - The `foreach` statement: It is similar to the for statement but implemented differently. It enables us to iterate the elements in arrays and collection classes such as List and HashTable.
    - The `for` statement: It is a special and most used case where the loop starts with an initialization followed by condition checking, loop body execution and then incrementation of the control variable.
- **Jumps in Loops:** Sometimes, when executing a loop it becomes desirable to skip a part of the loop or to leave the loop as soon as a certain condition occurs. This is where the following statements are usefull:
    - `break` statements: It takes the control out of a loop, in other words we can say that we jump out of a loop.
    - `continue` statements: It takes the control to the begining of a loop, in other words we can say that we skip some part of a loop.
    - `goto` statements: These are the labelled jumps and can take the control wherever we want. But one thing that should be remembered is that the label should always start with a capital alphabet. The following two programs demonstrates the use of the statement:
        - **[Demonstration of jump statements](./Practice/Program2.cs)**
        - **[Star Generator using jump statements](./Practice/Program3.cs)**

#### **Practice**
- [Sum of array elements using for each](./Practice/Program4.cs): In this program all the elements of an array are added using foreach statement.
- [Check for prime number](./Practice/Program5.cs): In this program a number is checked whether it is prime or not using continue & break statements.
- [Max of three numbers](./Practice/Program6.cs): In this program max of three integers is found using jump statements.
- [Even & Odd sum](./Practice/Program7.cs): In this program even sum and odd sum of all integers between 1 to 100 is found out using switch and if statements.


#### **Questions (Try it yourself before checking the solutions)**
1. [Given a number, write a program using while loop to reverse the digits of the number.](./Exercise/7_1.cs)
2. [Write a program that computes and prints factorial of a given m](./Exercise/7_2.cs)
3. [Write a program to compute the sum of the digits of a given integer number.](./Exercise/7_3.cs)
4. [Write a program using a do..while loop to calculate and print the first m Fibonacci numbers.](./Exercise/7_4.cs)
5. [Write a program to evaluate the following investment equation $P * (1+r)^n$.](./Exercise/7_5.cs)
6. [Write a program to print the following outputs using for loops.](./Exercise/7_6_a.cs)
    ```console
        (a) 1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5

        (b) $ $ $ $ $
            $ $ $ $
            $ $ $
            $ $
            $

        (c)      1
                2 2
               3 3 3
              4 4 4 4
             5 5 5 5 5
     ```

7. [Write a program using a for that accepts five values in US dollars, one at a time, and convers each value entered to its Indian rupees equivalent befoere the next value is requested.](./Exercise/7_7.cs)
---
<!-- Pagination -->
<p align="center"><a href="../Chapter_6/">⬅️ Previous Chapter </a>&emsp;&emsp;|&emsp;&emsp;<a  href="../Chapter_8/">Next Chapter ➡️</a></p>

