using StructureMap;
using SystemInterface;
using SystemWrapper;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new Registry();
            registry.IncludeRegistry(new HelloRegistry());
            var container = new Container(registry);
            
            var mainProgram = container.GetInstance<MainProgram>();
            mainProgram.Run();
        }
    }
}
