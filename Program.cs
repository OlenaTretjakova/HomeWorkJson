using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(1, 2);
            Fraction fr2 = new Fraction(3, 2);
            Fraction fr3 = new Fraction(1, 10);

            Console.WriteLine(fr1.ToString());
            Console.WriteLine(fr2.ToString());
            Console.WriteLine(fr3.ToString());

            Console.WriteLine();

            string json = Fraction.SerializeJson("fraction.txt", fr1);
            Fraction.WrieteToFile("fraction.txt", json);

            string json1 = Fraction.SerializeJson("fraction.txt", fr2);
            Fraction.WrieteToFile("fraction.txt", json1);

            string json2 = Fraction.SerializeJson("fraction.txt", fr3);
            Fraction.WrieteToFile("fraction.txt", json2);

            string strFileJson = Fraction.ReadFile("fraction.txt");
            List<Fraction> list = JsonConvert.DeserializeObject<List<Fraction>>(strFileJson);

            foreach (var item in list)
            {
                Console.Write(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
