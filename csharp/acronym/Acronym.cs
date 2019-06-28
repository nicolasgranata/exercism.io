using System;
using System.Linq;
using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var temp = phrase.Split(new Char [] {' ' , '-', '_' });

        var builder = new StringBuilder();

        for (var i = 0; i < temp.Length; i++)
        {
           if (!string.IsNullOrWhiteSpace(temp[i]))
           {
               builder.Append(char.ToUpper(temp[i][0]));
           }                  
        }

        return builder.ToString();
    }
}