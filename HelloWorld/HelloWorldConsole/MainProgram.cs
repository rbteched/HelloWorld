using System;

namespace HelloWorldConsole
{
    public class MainProgram {
        public void Run()
        {
            var generator = new TextGenerator();
            Console.WriteLine(generator.GenerateHelloWorld());
        }
    }

}
