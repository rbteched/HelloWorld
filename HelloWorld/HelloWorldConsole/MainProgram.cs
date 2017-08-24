using System;
using SystemInterface;

namespace HelloWorldConsole
{
    public interface IMainProgram
    {
        void Run();
    }

    public class MainProgram :IMainProgram {

        private readonly IConsole _console;
        private readonly ITextGenerator _textGenerator;

        public MainProgram(IConsole console, ITextGenerator textGenerator)
        {
            _console = console;
            _textGenerator = textGenerator;
        }
        public void Run()
        {
            var generator = new TextGenerator();
            _console.WriteLine(_textGenerator.GenerateHelloWorld());
        }
    }

}
