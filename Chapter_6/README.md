# Chapter 6: Decision Making and Branching

Normally a set of statements in a program is executed sequentially but normally that's not what we want. We might want to to change the order of execution of statements based on certain conditions.

When the branching is based on a particular condition, it is known as conditional branching. If branching takes place without any decision, it is known as unconditional branching.

C# language has the following control or decision-making statements:
  1. `if` statement
  2. `switch` statement
  3. Conditional operator statement

#### **Familirization with Decision Making**
The if statement can be implemented in different forms depending on the complexity of the conditions to be tested.
1. **[Simple if Statement](./Practice/Program1.cs):** In this program we have used simple if statement to count students that is meeting the criteria `weight < 50 && height > 170`. You may ignore the for loop as we are going to learn about it in the next lesson. 

    One thing that should be noted is that in case of C programming language `a == b` resulted to a integer value i.e 1 or 0 so error such as `a = b` was undected by the compiler. But in case of C# the code `a == b` results to a boolean value. So error detection is definite.

2. **[The if..else Statement](./Practice/Program2.cs):** If the if expression results to true, then the the first block statement(s) are executed; otherwise, the second block statement(s) are executed. In either case, either first or second block will be executed, not both. In this program either even or odd are found out easily using if..else statement.

3. **[Nested if..else Statement](./Practice/Program3.cs):** When a series of decision are involved, we may have to use more than if..else statement in nested forms. In the program largest value out of 3 values is found out using the nested if..else statement.

4. **[The else..if Ladder](./Practice/Program4.cs):** There is another way of putting ifs together when multipath decisions are involved. A multipath decision is a chain of ifs in which the statement associated with each else is an if. In this program we are grading students based on some rules. Please follow the comments in the code for better understandng of the grading scheme.

  We can use if statements to make a selection scheme. But, the complexity of such a program increases dramatically when the alternative icrease. The program becomes difficult to read and follow. That's where switch statements are usefull. The switch statement tests the value of a given variable (or expression) against a list of case values and when a match is found, the statements that are associated with it are executed.

  The expression must be an integer type or char or string type.
  - **[Using switch..case](./Practice/Program5.cs):** The same program that was solved using the else..if ladder is solved using the switch..case statements. It can be seen that the scheme simplifies the program a lot.

#### **Questions (Try it yourself before checking the solutions)**

---
<p align="center"><a href="../Chapter_4/">⬅️ Previous Chapter </a>&emsp;&emsp;|&emsp;&emsp;<a  href="../Chapter_7/">Next Chapter ➡️</a></p>