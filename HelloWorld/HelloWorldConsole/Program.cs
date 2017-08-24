using Autofac;

namespace HelloWorldConsole
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TextGenerator>().As<ITextGenerator>();
            builder.RegisterType<SystemWrapper.ConsoleWrap>().As<SystemInterface.IConsole>();
            Container = builder.Build();

            using(var scope = Container.BeginLifetimeScope())
            {
                var textGenerator = scope.Resolve<ITextGenerator>();
                var console = scope.Resolve<SystemInterface.IConsole>();
                var mainProgram = new MainProgram(console, textGenerator);
                mainProgram.Run();
            }
        }
    }
}
