using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GFG
{
    // Driver code
    public static void Main()
    {
        SortedList<int, string> numberNames = new SortedList<int, string>()
    {
    {3, "Three"},
    {5, "Five"},
    {1, "One"}
    };
        Console.WriteLine("---Initial key-values--");
        foreach (KeyValuePair<int, string> kvp in numberNames)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        numberNames.Add(6, "Six");
        numberNames.Add(2, "Two");
        numberNames.Add(4, "Four");
        Console.WriteLine("---After adding new key-values--");
        foreach (var kvp in numberNames)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        numberNames.Remove(2);//removes key 2 pair
        Console.WriteLine("---After removing key 2 pair--");
        for (int i = 0; i < numberNames.Count; i++)
        {
            Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i],
            numberNames.Values[i]);
        }
        Console.ReadKey();
    }
}