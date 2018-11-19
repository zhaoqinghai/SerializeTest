using System;
using BenchmarkDotNet.Running;

namespace SerializeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Test>();
            Console.Read();
        }
    }
}
