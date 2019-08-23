using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 1; i <= rows; i ++)
        {
            List<int> temp = new List<int>();

            if (result.Count == 0)
            {
                temp.Add(i);
            }
            else
            {
                for (int j = 1; j <= i; j ++)
                {                  
                    foreach (var item in result.Take(i).First())
                    {
                        temp.Add(x);
                    }                   
                }
            }   

            result.Add(temp);
        }

        return result;
    }
}