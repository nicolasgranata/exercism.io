using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var output = new Dictionary<string, int>();

        foreach(var value in old)
        {
            foreach(var newValue in value.Value)
            {
                output.Add(newValue.ToLower(), value.Key);
            }
        }

        return output;
    }
}