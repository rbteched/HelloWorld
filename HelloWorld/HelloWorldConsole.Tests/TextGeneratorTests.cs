using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldConsole.Tests
{
    [TestClass]
    public class TextGeneratorTests
    {
        [TestMethod]
        public void GenerateHelloWorldGeneratesExpectedText()
        {
            var textGenerator = new TextGenerator();
            Assert.AreEqual("Hello World", textGenerator.GenerateHelloWorld());
        }
    }
}
