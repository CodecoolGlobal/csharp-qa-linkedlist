using System;

namespace QA0415
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(12);
            numbers.Add(15);
            numbers.Add(20);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("End.");
        }
    }
}
