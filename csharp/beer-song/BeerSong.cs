using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        if (startBottles == 0)
        {
            return GetVerseWith0Bottles();
        }
      
        return GetMultipleVerses(startBottles, takeDown);
    }

    private static string GetGenericVerse(int startBottles, int takeDown)
    {
        StringBuilder builder = new StringBuilder();

        var bottleOrBottles = (startBottles - 1) == 1 ? "bottle" : "bottles";

        builder.Append($"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n");
        builder.Append($"Take one down and pass it around, {startBottles - 1} {bottleOrBottles} of beer on the wall.");

        return builder.ToString();
    }

    private static string GetVerseWith0Bottles()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("No more bottles of beer on the wall, no more bottles of beer.\n");
        builder.Append("Go to the store and buy some more, 99 bottles of beer on the wall.");

        return builder.ToString();
    }

    private static string GetMultipleVerses(int startBottles, int takeDown)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 1; i <= takeDown; i++)
        {
            switch(startBottles)
            {
                case 0:
                    if (i == takeDown)
                    {
                        builder.Append("\n\n");
                    }
                    builder.Append(GetVerseWith0Bottles());
                    break;
                case 1:
                    builder.Append("1 bottle of beer on the wall, 1 bottle of beer.\n");
                    builder.Append("Take it down and pass it around, no more bottles of beer on the wall.");
                    break;
                default:
                    builder.Append(GetGenericVerse(startBottles, takeDown));
                    if (i != takeDown)
                    {
                        builder.Append("\n\n");
                    }
                    break;
            }

            startBottles--;
        }

        return builder.ToString();
    }
}