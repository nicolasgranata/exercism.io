using System;
using System.Collections.Generic;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if (string.IsNullOrWhiteSpace(nucleotide))
        {
            return string.Empty;
        }

        Dictionary<char, char> mapping = new Dictionary<char, char>()
        {
            {'G', 'C'},
            {'C', 'G'},
            {'T', 'A'},
            {'A', 'U'}
        };

        var builder = new StringBuilder();

        for (var i = 0; i < nucleotide.Length; i++)
        {
            builder.Append(mapping[nucleotide[i]]);
        }

        return builder.ToString();
    }
}