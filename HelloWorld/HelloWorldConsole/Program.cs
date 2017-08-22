using System;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new TextGenerator();
            Console.WriteLine(generator.GenerateHelloWorld());
        }
    }
}
