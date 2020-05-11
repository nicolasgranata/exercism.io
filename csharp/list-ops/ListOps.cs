using System;
using System.Collections.Generic;

public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        return Foldl(input, 0, (count, _) => count + 1);
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        var result = new List<T>();

        var length = Length(input) - 1;

        for(var i = length; i >= 0; i--)
        {
            result.Add(input[i]);
        }

        return result;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        var result = new List<TOut>();

        foreach(var item in input)
        {
            result.Add(map.Invoke(item));
        }

        return result;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
        var result = new List<T>();

        foreach (var item in input)
        {
            if (predicate.Invoke(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        foreach (var item in input)
        {
           var output =  func.Invoke(start, item);

           start = output;
        }

        return start;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        var inputR = Reverse(input);

        foreach (var item in inputR)
        {
           var output =  func.Invoke(item, start);

           start = output;
        }

        return start;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        var result = new List<T>();

        foreach (var list in input)
        {
            Append(result, list);
        }

        return result;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        foreach(var item in right)
        {
            left.Add(item);
        }

        return left;
    }
}