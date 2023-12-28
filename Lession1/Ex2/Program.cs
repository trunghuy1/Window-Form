using System;
using System.IO;
class GFG
{
    // Main Method
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a name for the new directory:");
        string DirName = Console.ReadLine();
        // Checking if string is empty or not
        if (DirName != String.Empty)
        {
            // Creating the Directory
            Directory.CreateDirectory(DirName);
            // Checking Directory is created
            // Successfully or not
            if (Directory.Exists(DirName))
            {
                Console.WriteLine("The directory was created!");
                Console.ReadKey();
            }
        }
        Console.WriteLine("Please enter a name of the directory to renamed:");
        DirName = Console.ReadLine();
        // checking directory exist or not
        if (Directory.Exists(DirName))
        {
            Console.WriteLine("Please enter a new name for this directory:");
            string newDirName = Console.ReadLine();
            if (newDirName != String.Empty)
            {
                // to rename directory
                Directory.Move(DirName, newDirName);
                // checking directory has
                // been renamed or not
                if (Directory.Exists(newDirName))
                {
                    Console.WriteLine("The directory was renamed to " + newDirName);
                    Console.ReadKey();
                }
            }
        }
    }
}