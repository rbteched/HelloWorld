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
            builder.RegisterType<MainProgram>().As<IMainProgram>();
            Container = builder.Build();

            using(var scope = Container.BeginLifetimeScope())
            {
                var mainProgram = scope.Resolve<IMainProgram>();
                mainProgram.Run();
            }
        }
    }
}
