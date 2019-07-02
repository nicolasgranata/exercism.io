using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string output = new string(phoneNumber.Where(char.IsDigit).ToArray());

        if (output.Length > 10 && output[0] <= '1'
            && output[4] > '1'  && output[1] > '1')
        {
            return new string (output.Remove(0, 1).ToArray());
        } 
        
        if (output.Length == 10 && output[0] > '1' && output[3] > '1')
        {
            return output;
        }

        throw new ArgumentException();
    }
}