// C# code to get an enumerator
// that iterates through the List<T>.
using System;
using System.Collections.Generic;
class GFG
{
    // Driver code
    public static void Main()
    {
        // Creating a List of string
        List<string> mylist = new List<string>();
        // Inserting elements into List
        mylist.Add("C#");
        mylist.Add("Java");
        mylist.Add("C");
        mylist.Add("C++");
        // To get an Enumerator
        // for the List.
        List<string>.Enumerator em = mylist.GetEnumerator();
        //display(em);
        while (em.MoveNext())
        {
            string val = em.Current;
            Console.WriteLine(val);
        }
        Console.ReadKey();
    }
}