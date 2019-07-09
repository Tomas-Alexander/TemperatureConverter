using System;
using System.IO;

namespace TemperatureConverter
{
    public class TempConverter
    {
        public static string Convert(string path)
        {
            string text = File.ReadAllText(path);
            string[] data = text.Split(",");
            double result = Double.Parse(data[0]);
            if (data[1] == "C")
            {
                if (data[2] == "F")
                {
                    result = ConvertFromCToF(double.Parse(data[0]));
                }
                else if (data[2] == "K")
                {
                    result = ConvertFromCToK(double.Parse(data[0]));
                }

            }
            if (data[1] == "F")
            {
                if (data[2] == "C")
                {
                    result = ConvertFromFToC(double.Parse(data[0]));
                }
                else if (data[2] == "K")
                {
                    result = ConvertFromFToK(double.Parse(data[0]));
                }

            }

            if (data[1] == "K")
            {
                if (data[2] == "C")
                {
                    result = ConvertFromKToC(double.Parse(data[0]));
                }
                if (data[2] == "F")
                {
                    result = ConvertFromKToF(double.Parse(data[0]));
                }
            }

            result = Math.Round(result, 3);
            return text + "," + result.ToString();
        }

        private static double ConvertFromKToF(double v)
        {
            return ConvertFromCToF(ConvertFromKToC(v));
        }

        private static double ConvertFromKToC(double value)
        {
            return value - 273.15;
        }

        private static double ConvertFromFToK(double value)
        {
            return ConvertFromFToC(value) + 273.15;
        }

        private static double ConvertFromCToK(double value)
        {
            return value + 273.15;
        }

        public static double ConvertFromCToF(double value)
        {
            return (value * (9.0 / 5.0)) + 32;
        }

        private static double ConvertFromFToC(double value)
        {
            return (value - 32) * (5.0 / 9.0);
        }
    }
}