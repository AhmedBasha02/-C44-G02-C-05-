namespace Session_5_Assignment
{
    class MyClass
    {
        public int Number;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
            Passing by value : --> When a value type parameter is passed by value, 
            --> a copy of the variable's value is passed to the function. 
            --> Any modifications made to the parameter inside the function 
            --> do not affect the original variable outside the function.

            Passing by reference : --> When a value type parameter is passed by reference 
            --> using the ref keyword a reference to the original variable's memory location 
            --> is passed to the function. Any modifications made to the parameter inside the function 
            --> directly affect the original variable outside the function.  
            --> The variable must be initialized before it can be passed as a ref parameter. 
             */
            // Example :-

            //// passing by value 

            //static void ByValue(int num)
            //{
            //    num += 10;
            //}


            //// passing by ref
            //static void ByReference(ref int num)
            //{
            //    num += 10;
            //}

            //int a = 5;
            //ByValue(a);
            //Console.WriteLine("After ByValue: " + a); //--> o/p will be 5 
            //Console.WriteLine();
            //ByReference(ref a);
            //Console.WriteLine("After ByReference: " + a); //--> o/p will be 15
            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             Passing by value : --> When a reference type parameter is passed by value, a copy of the 
             --> reference (the memory address) to the object is passed to the function. 
             --> Both the original variable and the parameter inside the function point to the same object 
             --> in memory. Therefore, modifications to the object's properties or fields inside 
             --> the function will affect the original object. However, if you assign a new object to 
             --> the parameter inside the function, the original variable will still point to the old object.

             Passing by reference : --> When a reference type parameter is passed by reference 
             -->(using the ref keyword), the original reference itself is passed. 
             -->This means that if you assign a new object to the parameter inside the function, 
             -->the original variable outside the function will also be updated to point to the new object. 
             */

            // Examples :-

            //// passing by value 

            //static void RefTypeByValue(MyClass obj)
            //{
            //    obj.Number = 10; 
            //    obj = new MyClass(); // Doesn’t affect original reference
            //    obj.Number = 20;
            //}


            ////passing by reference 

            //static void RefTypeByReference(ref MyClass obj)
            //{
            //    obj = new MyClass();
            //    obj.Number = 30;
            //}

            //MyClass a = new MyClass();
            //a.Number = 5;

            //RefTypeByValue(a);
            //Console.WriteLine("After ByValue: " + a.Number); // --> o/p --> 10

            //RefTypeByReference(ref a);
            //Console.WriteLine("After ByReference: " + a.Number); // --> o/p --> 30
            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static void Sum_And_Sub(int Num1, int Num2, out int Sum, out int Sub)
            //{
            //    Sum = Num1 + Num2;
            //    if (Num1 > Num2)
            //    {
            //        Sub = Num1 - Num2;
            //    }
            //    else
            //    {
            //        Sub = Num2 - Num1;
            //    }
            //}

            //int num1, num2;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter first Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out num1);
            //}while (!flag);
            //do
            //{
            //    Console.WriteLine("Enter second Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out num2);
            //} while (!flag);


            //int Sum, Sub;
            //Sum_And_Sub(num1, num2, out Sum, out Sub);
            //Console.WriteLine($"Sum of 2 numbers is = {Sum}");
            //Console.WriteLine($"Sub of 2 numbers is  = {Sub}");

            #endregion


            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.Output should be likeEnter a number: 25The sum of the digits of the number 25 is: 7

            //static int SumDigits(int num)
            //{
            //    int sum = 0;
            //    while (num > 0)
            //    {
            //        sum += num % 10;
            //        num = num / 10;
            //    }
            //    return sum;
            //}


            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Number conatin 2 parts like 25 : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);

            //int Sum = SumDigits(num);
            //Console.WriteLine($"SUMDigits of ({num}) that coantain 2 parts is = {Sum}");
            #endregion


            #region 5-Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not:
            //static bool IsPrime(int number)
            //{
            //    if (number < 2) return false;
            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }
            //    return true;
            //}


            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine($"Please Enter number  :\n");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //} while (!flag);
            //bool res = IsPrime(number);
            //if (res)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(ref int min, ref int max, params int[] arr)
            //{
            //    min = arr[0];
            //    max = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min)
            //            min = arr[i];
            //        if (arr[i] > max)
            //            max = arr[i];
            //    }
            //}


            ////int[] numbers = { 10, 20, 30, 40, 50, -60 };
            //int min = 0;
            //int max = 0;
            //MinMaxArray(ref min, ref max, 10, 20, 30, 100, 5, 6);
            //Console.WriteLine($"Minimum value in array: {min} ");
            //Console.WriteLine($"Maximum value in array: {max}");
            #endregion


            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //static int Factorial(int num)
            //{
            //    int result = 1;
            //    for (int i = 2; i <= num; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}


            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine($"Please Enter number  :\n");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //} while (!flag || number <= 0);

            //Console.WriteLine($"Factorial of {number} = {Factorial(number)}");

            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //static string ChangeChar(string text, int pos, char newChar)
            //{
            //    char[] chars = new char[text.Length];
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (i == pos)
            //            chars[i] = newChar;
            //        else
            //            chars[i] = text[i];
            //    }
            //    string result = "";
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        result += chars[i];
            //    }
            //    return result;
            //}

            //string original = "A7med Basha";
            //string modified = ChangeChar(original, 1, 'h');
            //Console.WriteLine(modified);
            #endregion
        }
    }
}
