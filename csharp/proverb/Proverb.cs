using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0)
        {
            return subjects;
        }

        List<string> result = new List<string>();

        for (int i = 0; i < subjects.Length - 1; i ++)
        {
           result.Add(AddSentence(subjects[i], subjects[i + 1]));
        }
                  
        result.Add(AddFinalSentence(subjects[0]));

        return result.ToArray();
    }
    
    private static string AddSentence(string subjectOne, string subjectTwo)
    {
        return $"For want of a {subjectOne} the {subjectTwo} was lost.";
    }

    private static string AddFinalSentence(string subjects)
    {
        return $"And all for the want of a {subjects}.";
    }
}