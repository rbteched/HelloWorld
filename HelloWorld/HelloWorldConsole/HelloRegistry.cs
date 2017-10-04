using StructureMap;
using SystemInterface;
using SystemWrapper;

namespace HelloWorldConsole
{
    public class HelloRegistry:Registry
    {
        public HelloRegistry()
        {
            For<ITextGenerator>().Use<TextGenerator>();
            For<IConsole>().Use<ConsoleWrap>();
        }
    }
}
