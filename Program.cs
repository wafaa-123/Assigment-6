using System;

class Assignment6
{
    static void Main()
    {
        Console.WriteLine("Functions");
    }

    #region Q1 - Pass value types by value and by reference
    /*
     * - Pass by value: A copy of the original value is passed to the function. Changes made inside the function do not affect the original variable.
     * - Pass by reference: The actual memory address of the variable is passed. Changes made inside the function directly affect the original variable.
     */
    static void PassByValue(int x)
    {
        x = 100;
    }

    static void PassByReference(ref int x)
    {
        x = 100;
    }
    #endregion

    #region Q2 - Pass reference types by value and reference
    /*
     * - Reference type by value: The reference (pointer) is passed by value. The function can modify the contents of the object, but cannot reassign the reference itself.
     * - Reference type by reference: The reference itself is passed by reference. The function can both modify the object and reassign the reference to a new object.
     */

    class Person
    {
        public string Name = string.Empty;
    }

    static void RefTypeByValue(Person p)
    {
        p.Name = "Changed";
        p = new Person();
        p.Name = "New Person";
    }

    static void RefTypeByReference(ref Person p)
    {
        p = new Person();
        p.Name = "Changed with ref";
    }
    #endregion

    #region Q3 - Function to return sum and subtract
    static void SumAndSubtract(int a, int b, out int sum, out int diff)
    {
        sum = a + b;
        diff = a - b;
    }
    #endregion

    #region Q4 - Sum of digits of number
    static int SumDigits(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    #endregion

    #region Q5 - IsPrime function
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0)
                return false;
        return true;
    }
    #endregion

    #region Q6 - MinMaxArray function
    static void MinMaxArray(int[] arr, out int min, out int max)
    {
        min = max = arr[0];
        foreach (int num in arr)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
    }
    #endregion

    #region Q7 - Iterative Factorial function
    static long Factorial(int number)
    {
        long result = 1;
        for (int i = 2; i <= number; i++)
            result *= i;
        return result;
    }
    #endregion

    #region Q8 - ChangeChar function
    static string ChangeChar(string input, int index, char newChar)
    {
        if (index < 0 || index >= input.Length)
            return input;

        char[] chars = input.ToCharArray();
        chars[index] = newChar;
        return new string(chars);
    }
    #endregion
}
