using NUnit.Framework;
using System.IO;
using TemperatureConverter;

namespace TemperatureConverterTests
{
    [TestFixture]
    public class TemperatureConverterTest
    {
        [Test]
        public void InstancingConverter_WithNonExistingFile_ShouldThrowException()
        {
            string path = @"C\Hello.txt";
            Assert.Throws(typeof(FileNotFoundException), Converter.Convert(path));
        }
    }
}