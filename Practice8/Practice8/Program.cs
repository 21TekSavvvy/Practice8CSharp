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


    }
     public int GetReverse()
    {

    }
     public string ToWords()
    {

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