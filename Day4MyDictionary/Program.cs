using System;

namespace Day4MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> selam = new MyDictionary<int, string> { };
            selam.Add(14, "meraba");
            selam.Add(15, "heyo");

            for (int i = 0; i < selam.Length; i++)
            {
                Console.WriteLine(selam.Items[0]);
            }
            
        }
    }
}
