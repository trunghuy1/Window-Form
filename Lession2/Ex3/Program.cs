using System;
using System.Collections.Generic;
class GFG
{
    // Driver code
    public static void Main()
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        Console.Write("Number of elements in Stack: {0} \n", myStack.Count);
        while (myStack.Count > 0)
            Console.Write(myStack.Pop() + ",");
        Console.Write("\nNumber of elements in Stack: {0}", myStack.Count);
        Console.ReadKey();
    }
}