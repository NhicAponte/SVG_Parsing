using System;
using System.Xml;

namespace Create_SVG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Build_SVG()
        {
            XmlDocument svg_doc = new XmlDocument();
            XmlElement rootNode = svg_doc.CreateElement("SVG");
            svg_doc.AppendChild(rootNode);
            svg_doc.Save(@".\SVG_Template.xml");
            Console.WriteLine("svg build was successful");
        }

    }
}
