using SystemInterface;

namespace HelloWorldConsole
{
    public class MainProgram {

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
