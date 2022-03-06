using System.Collections;
using System.Collections.Generic;

class Number
{
    private int value;
     public void SetValue(int value)
    {
        this.value = value;
    }
    public double GetValue()
        { return value; }
     public bool IsZero()
    {
        return value == 0;
    }
     public bool IsPositive()
    {
        return (value > 0);
    }
     public bool IsNegative()
    {
        return (value < 0);
    }
     public bool IsOdd()
    {
        return value % 2 == 1;
    }
     public bool IsEven()
    {
        return value % 2 == 0;
    }
     public bool IsPrime()
    {
        if (value <=1)
        {
            return false;
        }
        for (int i = 2; i < System.Math.Sqrt(value); i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static int Power(int baseNumber, int exponent, bool recursive = false)
    {
        if (!recursive)
        {
            int power = baseNumber;
            for (int i = 1; i < exponent; i++)
            {
                power *= baseNumber;
            }
            return power;
        }
        else
        {
            if (exponent == 0)
                return 1;
            else
                return baseNumber * (Number.Power(baseNumber: baseNumber, exponent: exponent - 1, recursive: true));

        }
    }
     public int GetCountOfDigits()
    {
        int number = value;
            int count = 0;
            while (number> 0) 
            {
                number = number / 10; 
                count++; 
            }
            return count;

      }
     public int GetSumOfDigits()
    {
        int num = value; 
        int digit, sum = 0;
        while (num > 0) 
        {
            digit = num % 10;
            num = num / 10;
            sum += digit; 
        }
        return sum;

    }
     public int GetReverse()
    {
        int num = value;
        int digit, reverse = 0;
        Stack<int> stack = new Stack<int>();

        while (num > 0)
        {
            digit = num % 10;
            num = num / 10;
           stack.Push(digit);
        }
        while(stack .Count >0)
        {
            reverse+= stack.Pop();
        }
        return reverse;
    }
     public string ToWords()
    {
        int num = value;
        int digit;
        string word , answer = "";
        while (num > 0)
        {
            digit = num % 10;
            num = num / 10;
            word = Number.GetWord(digit);
            answer += word;
            
        }
        return answer;
               
    }
    public static string GetWord(int digit)
    {
        switch (digit)
        {
            case 0: return "Zero ";
            case 1: return "One ";
            case 2: return "Two ";
            case 3: return "Three ";
            case 4: return "Four ";
            case 5: return "Five ";
            case 6: return "Six ";
            case 7: return "Seven ";
            case 8: return "Eight ";
            case 9: return "Nine ";
            default: return "";
        }
    }
    public bool IsArmstrong()
    {

    }
     public string GetFibonacci()
    {

    }
     public bool isPalindrome()
    {

    }

}