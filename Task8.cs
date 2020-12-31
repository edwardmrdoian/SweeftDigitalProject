using Grpc.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SweeftDigitalProject
{
    class Task8
    {
        static double ExchangeRate(String from, String to)
        {
            String path = "D:\\edo\\Sweeft Digital\\SweeftDigitalProject\\RSS_feed\\CurrencyTable.xml";
            String file = Path.GetFullPath(path);
            XmlTextReader xmlReader = new XmlTextReader(file);

            List<String> names = new List<String>();
            List<double> ToCurrency = new List<double>();
            List<double> fromCurrency = new List<double>();
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Inital")
                {
                    string name = xmlReader.ReadElementString();
                    names.Add(name);
                }
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Buy")
                {
                    double toCurr = xmlReader.ReadElementContentAsDouble();
                    ToCurrency.Add(toCurr);
                }
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Sell")
                {
                    double fromCurr = xmlReader.ReadElementContentAsDouble();
                    fromCurrency.Add(fromCurr);
                }
            }
            if (from == "GEL" || from == "gel")
            {
                Console.WriteLine(ToCurrency[names.IndexOf(to.ToUpperInvariant())]);
            }
             else if (to == "GEL" || to == "gel")
            {
                Console.WriteLine(ToCurrency[names.IndexOf(from.ToUpperInvariant())]);
            }
            else
            {
                int indexOfname1 = names.IndexOf(from.ToUpperInvariant());
                //Console.WriteLine(indexOfname1);

                int indexOfname2 = names.IndexOf(to.ToUpperInvariant());
                //Console.WriteLine(indexOfname2);

                double ecxhangeValue = ToCurrency[indexOfname1];
                Console.WriteLine("Currency of {0} is {1}", names.ElementAt(indexOfname1), ecxhangeValue);

                double exchangeToValue = ToCurrency[indexOfname2];
                Console.WriteLine("Currency of {0} is {1}", names.ElementAt(indexOfname2), exchangeToValue);
                Console.WriteLine();
                double exchange = ecxhangeValue / exchangeToValue;
                Console.WriteLine("1 {0} = {1} {2}", names.ElementAt(indexOfname1), exchange, names.ElementAt(indexOfname2));
                Console.WriteLine();             
            }
            return  1;

        }
        public static void TaskEight()
        {
            Console.Write("Enter currency to sell: ");
            string From = Console.ReadLine();
            From.ToUpperInvariant();
            Console.Write("Enter currency to buy: ");
            string To = Console.ReadLine();
            To.ToUpperInvariant();
            Console.WriteLine();
            ExchangeRate(From, To);
        }
    }
}
