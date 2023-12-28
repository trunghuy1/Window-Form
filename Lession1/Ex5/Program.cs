// C# program to read from a file
// using StreamReader Class
using System;
using System.IO;
class GFG
{
    // Main Method
    static void Main(string[] args)
    {
        // Takinga a new input stream i.e.
        // geeksforgeeks.txt and opens it
        StreamReader sr = new StreamReader("D://Windows Programming/tmp.txt");
        Console.WriteLine("Content of the File");
        // This is use to specify from where
        // to start reading input stream
        sr.BaseStream.Seek(0, SeekOrigin.Begin);
        // To read line from input stream
        string str = sr.ReadLine();
        // To read the whole file line by line
        while (str != null)
        {
            Console.WriteLine(str);
            str = sr.ReadLine();
        }
        Console.ReadLine();
        // to close the stream
        sr.Close();
    }
}