using System;
using System.Collections.Generic;
using System.Linq;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts) => 
        texts.AsParallel().SelectMany(x => x.ToLower())
             .Where(x => char.IsLetter(x)).GroupBy(x => x)
             .ToDictionary(j => j.Key, x => x.Count());

}