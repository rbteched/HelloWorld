namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var textGenerator = new TextGenerator();
            var console = new SystemWrapper.ConsoleWrap();

            var mainProgram = new MainProgram(console, textGenerator);
            mainProgram.Run();
        }
    }
}
