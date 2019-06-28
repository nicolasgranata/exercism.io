using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] cArray = input.ToCharArray();

        Array.Reverse(cArray);
        
        return new string(cArray);
    } 
}