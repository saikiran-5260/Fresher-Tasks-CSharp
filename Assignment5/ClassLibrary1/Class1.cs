using System;

public class Number
{
    private int Value;

    public void SetValue(int value)
    {
        Value = value;
    }
    public double GetValue()
    {
        return Value;
    }
    public bool IsZero()
    {
        if (Value == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsPositive()
    {
        if (Value < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool IsNegative()
    {
        if (Value < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsOdd()
    {
        if (Value % 3 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsEven()
    {
        if (Value % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsPrime()
    {
        int count = 0;
        for (int i = 1; i <= Value; i++)
        {
            if (Value % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int Power(int baseNumber, int exponent, bool recursive = false)
    {
        if (!recursive) //if not recursive, perform a normal 'for' loop
        {
            int power = baseNumber;
            for (int i = 1; i < exponent; i++) //loop for 'exponent - 1' times
            {
                power *= baseNumber; //multiply the baseNumber itself
            }
            return power;
        }
        else //if recursive
        {
            if (exponent == 0) //if the exponent is reached down to zero (0), then the result is 1.
                return 1;
            else //if the exponent is greater than zero (0), then the result is 'baseNumber * power(basenumber, exponent - 1)'.
                return baseNumber * (Number.Power(baseNumber: baseNumber, exponent: exponent - 1, recursive: true));
        }
    }
    public int GetCountOfDigits()
    {
        
    }
}