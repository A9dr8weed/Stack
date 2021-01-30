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

            Console.WriteLine(easyStack.Pop());
            Console.WriteLine(easyStack.Peek());

            LinkedStack<int> linkedStack = new LinkedStack<int>();

            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);

            foreach (int item in linkedStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());

            ArrayStack<int> arrayStack = new ArrayStack<int>(5);

            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
        }
    }
}