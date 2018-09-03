using System;
using System.IO;
using System.Xml.Serialization;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream xml = File.Open("Modules.xml", FileMode.Open);

            XmlSerializer serializer = new XmlSerializer(typeof(Services));

            Services s = (Services)serializer.Deserialize(xml);

            Module module = s[2].Instance;
            module.Display();

            Console.ReadKey();
        }
    }
}
