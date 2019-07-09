using NUnit.Framework;
using System;
using TemperatureConverter;

namespace TemperatureConverterTests
{
    [TestFixture]
    public class TemperatureConverterTest
    {
        [Test]
        public void ConvertingTemperature_With0DegreesFromCToF_ShouldReturn32F()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test1.txt";
            string expected = "0,C,F,32";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertingTemperature_With100DegreesFromCToF_ShouldReturn212F()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test2.txt";
            string expected = "100,C,F,212";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertingTemperature_With32DegreesFromFToC_ShouldReturn0C()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test3.txt";
            string expected = "32,F,C,0";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertingTemperature_With0DegreesFromCToK_ShouldReturn273K()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test4.txt";
            string expected = "0,C,K,273.15";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertingTemperature_With0DegreesFromFToK_ShouldReturn255K()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test5.txt";
            string expected = "0,F,K,255.372";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertingTemperature_With273DegreesFromKToC_ShouldReturn0C()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test6.txt";
            string expected = "273.15,K,C,0";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConvertingTemperature_With273DegreesFromKToF_ShouldReturn0C()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\TemperatureConverter Pruebas\Test7.txt";
            string expected = "273.15,K,F,32";
            string result = TempConverter.Convert(path);
            Assert.AreEqual(expected, result);
        }
    }
}
