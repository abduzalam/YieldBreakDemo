# YieldBreakDemo

# First, let’s create a method to generate random years between 1900 and 2023:

see below code

![image](https://user-images.githubusercontent.com/32676744/224356641-29aa0dc1-cefc-43a1-a1e8-6fb3dc4aadbb.png)

![image](https://user-images.githubusercontent.com/32676744/224356726-dab2021a-6c83-4fe5-837d-6c8a27947bc3.png)


This method will keep on generating random years between 1900 and 2023 and return those. However, do not run this program yet as this is an infinite loop and will probably cause the system to crash.

So let’s add a break condition to stop the iteration once we encounter a leap year: 

![image](https://user-images.githubusercontent.com/32676744/224357467-07f4edc8-e87c-4c1e-a42e-ce66ec69a806.png)

![image](https://user-images.githubusercontent.com/32676744/224357734-4d74fae3-8de5-4997-8454-47ab9a9af75f.png)


Output

![image](https://user-images.githubusercontent.com/32676744/224357538-8578a2c7-1e57-4b07-8e90-91b01d43bf9e.png)


# How Is a yield break Different From a break Statement?

Can we just use the `break` statement to end an iteration instead of the `yield break` statement? Well the answer is yes we can, but both these statements behave differently. We should be aware of the differences to use them in the correct context.

When the compiler encounters a **`break`** statement inside a loop, it terminates the loop and executes the next statement after the loop. It means that if we have other statements after the loop, the compiler will still execute those before exiting the method.

On the other hand, when the compiler encounters a yield break statement inside an iterator block, it terminates the iterator block altogether and exits the method. It means that even if there are some additional statements after the loop, the compiler will not execute those. The compiler will even raise a warning that it has detected some unreachable code in this case.  We can think of the yield break statement inside an iterator method as something similar to a return statement inside a regular method that does not return anything.

# Also we cannot just use `return` instead of `yield break` from an Iterator method, it generates compilation error to say use yield return 
