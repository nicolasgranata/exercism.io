using System.Collections;
using System.Collections.Generic;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach(var item in input)
        {
            if(item is IEnumerable)
            {
                foreach(var nestedItem in Flatten(item as IEnumerable))
                {
                    yield return nestedItem;
                }
            }
            else if (item != null)
            {
                yield return item;
            }
        }
    }
}