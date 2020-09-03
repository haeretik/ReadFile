using System;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"C:\");
            string[] lines = System.IO.File.ReadAllLines(@"Animals.txt");
            foreach (string line in lines)
                Console.WriteLine("The quick " + line + " jumps over the lazy dog ");
        }
    }
}
