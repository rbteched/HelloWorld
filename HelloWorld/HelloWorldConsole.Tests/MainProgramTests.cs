using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SystemInterface;

namespace HelloWorldConsole.Tests
{
    [TestClass]
    public class MainProgramTests
    {
        [TestMethod]
        public void Should_Call_ConsoleWriteline_When_Run_Is_Called()
        {
            // Arrange
            var expectedText = "Hello World";
            var mockConsole = Mock.Of<IConsole>();
            var mockTextGenerator = Mock.Of<ITextGenerator>(x=>x.GenerateHelloWorld() == expectedText);
            var mainProgram = new MainProgram(mockConsole, mockTextGenerator);

            // Act
            mainProgram.Run();

            // Assert
            Mock.Get(mockConsole).Verify(x => x.WriteLine(expectedText), Times.Once);
        }

        [TestMethod]
        public void Should_Call_TextGeneratorGenerateHelloWorld_When_Run_Is_Called()
        {
            // Arrange
            var mockConsole = Mock.Of<IConsole>();
            var mockTextGenerator = Mock.Of<ITextGenerator>();
            var mainProgram = new MainProgram(mockConsole, mockTextGenerator);

            // Act
            mainProgram.Run();

            // Assert
            Mock.Get(mockTextGenerator).Verify(x => x.GenerateHelloWorld(), Times.Once);
        }

    }
}
