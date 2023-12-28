using System;
using System.IO;
class WriteToFile
{
    // Main Method
    static void Main(string[] args)
    {
        // This will create a file named tmp.txt
        // at the specified location
        StreamWriter sw = new StreamWriter("D://Windows Programming/tmp.txt");
        // To write on the console screen
        Console.WriteLine("Enter the Text that you want to write on File");
        // To read the input from the user
        string str = Console.ReadLine();
        // To write a line in buffer
        sw.WriteLine(str);
        // To write in output stream
        sw.Flush();
        // To close the stream
        sw.Close();
        Console.ReadKey();
    }
}