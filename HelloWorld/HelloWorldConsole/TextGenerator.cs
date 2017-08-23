namespace HelloWorldConsole
{
    public interface ITextGenerator
    {
        string GenerateHelloWorld();
    }

    public class TextGenerator : ITextGenerator
    {
        public string GenerateHelloWorld()
        {
            return "Hello World";
        }
    }
}
