using System;
using System.Collections;

namespace ConsoleApp1
{
    /// <summary>
    /// This class just contains an Id and Name, nothing really fancy about that
    /// </summary>
    class MyFancyObject
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
    class Program
    {
        /// <summary>
        /// Main method - entry point
        /// </summary>
        /// <param name="args">The command line arguements passed to the exec</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Queue and Stack");

            Queue q = new Queue();
            Console.WriteLine("Queue");

            var item1 = new MyFancyObject()
            {
                Name = "item1",
                Id = "id1"
            };

            var item2 = new MyFancyObject()
            {
                Name = "item2",
                Id = "id2"
            };

            MyFancyObject Fo = new MyFancyObject();

            q.Enqueue(item1);
            q.Enqueue(item2);

            var x = q.Dequeue() as MyFancyObject;
            Console.WriteLine(x.Name);
            var y = q.Dequeue() as MyFancyObject;
            Console.WriteLine(y.Name);
            Console.ReadLine();
            //stack
            Console.WriteLine("stack");

            Stack stack = new Stack();

            stack.Push(item1);
            stack.Push(item2);

            var a = stack.Pop() as MyFancyObject;
            var b = stack.Pop() as MyFancyObject;

            Console.WriteLine(a.Name);
            Console.WriteLine(b.Name);
            //note: see dofactory tutorials for conceptual design patterns
        }
    }
}
