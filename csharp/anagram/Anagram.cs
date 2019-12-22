using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private readonly string _baseWord;
    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {      
        return potentialMatches.Where(x => ValidateAnagram(x)).ToArray();
    }

    private bool ValidateAnagram(string wordToCompare)
    {
        var word = String.Concat(wordToCompare.Select(x => char.ToLower(x)).OrderBy(x => x));
        var baseWord = String.Concat(this._baseWord.Select(x => char.ToLower(x)).OrderBy(x => x));

        return word == baseWord && wordToCompare.ToLower() != this._baseWord.ToLower();
    }
}