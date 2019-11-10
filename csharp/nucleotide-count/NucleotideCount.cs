using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var result = new Dictionary<char, int>()
        {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}
        };

        for (var i = 0; i < sequence.Length; i++)
        {
            if(!result.Keys.Contains(sequence[i]))
            {
                throw new ArgumentException();
            }
            result[sequence[i]]++;
        }

        return result;
    }
}