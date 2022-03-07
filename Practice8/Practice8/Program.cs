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
        int digit;
       ArrayList  list = new ArrayList ();
        string reverse="";
        while (num > 0)
        {
            digit = num % 10;
            num = num / 10;
           list.Add(digit.ToString());
        }
        for (int i = 0; i < list.Count; i++)
        {
            reverse += list[i];
        }
        
        return int.Parse(reverse);
    }
     public string ToWords()
    {
        int num = GetReverse();
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
        int num = value;
        int sum = 0, digit;
        int count = GetCountOfDigits();
        while (num> 0)
        {
            digit  =num % 10;
            sum+= Power(digit, count, true);
            num = num /10;
            
        }
        return sum == value;
    }
     public string GetFibonacci()
    {
        int a = 0, b = 1;
        string fibonacci = a + ", " + b + ", ";
        int c = a + b;
        while (c <= value)
        {
            c = a + b;
            if (c > value) 
                break;

            
            fibonacci += c + ", ";

            a = b; 
            b = c; 
        }
        return fibonacci;
    }
     public bool isPalindrome()
    {
        int num = value;
        int reverse = GetReverse();
        return reverse == value;
    }

    static void Main()
    {
        Number number = new Number();
        number.SetValue(371); //To test we would input 371
        System.Console.WriteLine("Value: " + number.GetValue()); //Output: 371
        System.Console.WriteLine("IsZero: " + number.IsZero()); //Output: False
        System.Console.WriteLine("IsPositive: " + number.IsPositive()); //Output: True
        System.Console.WriteLine("IsNegative: " + number.IsNegative()); //Output: False
        System.Console.WriteLine("IsOdd: " + number.IsOdd()); //Output: True
        System.Console.WriteLine("IsEven: " + number.IsEven()); //Output: False
        System.Console.WriteLine("IsPrime: " + number.IsPrime()); //Output: False
        System.Console.WriteLine("GetCountOfDigits: " + number.GetCountOfDigits()); //Output: 3
        System.Console.WriteLine("GetSumOfDigits: " + number.GetSumOfDigits()); //Output: 11
        System.Console.WriteLine("GetReverse: " + number.GetReverse()); //Output: 173
        System.Console.WriteLine("ToWords: " + number.ToWords()); //Output: Three Seven One
        System.Console.WriteLine("IsArmstrong: " + number.IsArmstrong()); //Output: True
        System.Console.WriteLine("GetFibonacci: " + number.GetFibonacci()); //Output: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233
        System.Console.WriteLine("isPalindrome: " + number.isPalindrome()); //Output: False
        System.Console.ReadKey();
    }

}