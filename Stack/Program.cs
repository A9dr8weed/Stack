using Stack.Model;

using System;

namespace Stack
{
    internal static class Program
    {
        private static void Main()
        {
            EasyStack<int> easyStack = new EasyStack<int>();

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);
            Console.WriteLine(easyStack.Contains(3));

            Console.WriteLine($"Pop element {easyStack.Pop()}");
            Console.WriteLine($"Peek element {easyStack.Peek()}");

            LinkedStack<int> linkedStack = new LinkedStack<int>();

            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);
            Console.WriteLine(linkedStack.Contains(60));

            foreach (int item in linkedStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Peek element {linkedStack.Peek()}");
            Console.WriteLine($"Pop element {linkedStack.Pop()}");
            Console.WriteLine($"Pop element {linkedStack.Pop()}");
            Console.WriteLine($"Peek element {linkedStack.Peek()}");

            ArrayStack<int> arrayStack = new ArrayStack<int>(2);

            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);
            Console.WriteLine(arrayStack.Contains(400));

            Console.WriteLine($"Peek element {arrayStack.Peek()}");
            Console.WriteLine($"Delete element {arrayStack.Pop()}");
        }
    }
}