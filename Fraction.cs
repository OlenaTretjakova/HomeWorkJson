using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HomeWorkJson
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}, ";
        }

        public static string SerializeJson(string file, Fraction fraction)
        {
            List<Fraction> list = new List<Fraction>();

            if (File.Exists(file))
            {
                string existJsonFile = File.ReadAllText(file);

                list = JsonConvert.DeserializeObject<List<Fraction>>(existJsonFile);

                list.Add(fraction);

                string serializeContent = JsonConvert.SerializeObject(list);

                return serializeContent;
            }
            else
            {
                list.Add(fraction);
                return JsonConvert.SerializeObject(list);
            }
        }

        public static void WrieteToFile(string file,string json)
        { 
            File.WriteAllText(file, json);
        }

        public static string ReadFile(string file)
        {
            return File.ReadAllText(file);
        }

    }
}
