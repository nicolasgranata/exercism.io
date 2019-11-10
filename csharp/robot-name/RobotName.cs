using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Store
{
    public static HashSet<string> RobotNames = new HashSet<string>();
}

public class Robot
{
    private string _name;
    private const string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public Robot() => _name = SetName();
    public string Name
    {
        get
        {
            return _name;
        }
    }

    public void Reset()
    {
        _name = SetName();
    }

    private string SetName()
    {
        var builder = new StringBuilder();
        
        do 
        {
            var rnd = new Random();

            builder.Append(_alphabet[rnd.Next(0, _alphabet.Length)]);
            builder.Append(_alphabet[rnd.Next(1,24)]);
            builder.Append(rnd.Next(0, 999).ToString("D3"));

        }while(Store.RobotNames.Contains((builder.ToString())));
      
        Store.RobotNames.Add(builder.ToString());
    
        return builder.ToString();
    }

}