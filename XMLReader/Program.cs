using System;
using System.Xml;

namespace ReadingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("path/to/xml/file.xml");

            // Select the nodes that you want to work with
            XmlNodeList nodeList = xmlDoc.SelectNodes("//element");

            // Loop through the nodes and extract data from them
            foreach (XmlNode node in nodeList)
            {
                // Perform calculations on the data in the node
                int value = int.Parse(node.Attributes["attribute"].InnerText) * 2;
                Console.WriteLine(value);
            }
        }
    }
}
