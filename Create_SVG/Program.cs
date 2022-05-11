using System;
using System.Xml;

namespace Create_SVG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            XmlDocument svg_doc = Build_SVG("Temp_Files/Base_Template.xml");
            //width="3456"
            //height="2304"
            //SVG_Template(3456,2304); 
        }

        public static XmlDocument Build_SVG(string file_name)
        {
            Console.WriteLine("svg build started");
            XmlDocument temp_doc = new XmlDocument();
            
            //Console.WriteLine("loading svg");
            
            temp_doc.Load(file_name);

            //Console.WriteLine("svg load was successful");

            
            //XmlElement rootNode = svg_doc.CreateElement("svg");
            //XmlElement bld_name = svg_doc.CreateElement("building");
            //bld_name.Add(new XmlAttribute("building"));
            //XmlAttribute attribute = svg_doc.CreateAttribute("Name");
            //attribute.Value = "engineering"; 

            //rootNode.AppendChild(bld_name);
            //svg_doc.AppendChild(rootNode);

            XmlDocument clean_svg = SVG_Template(3456,2304); 

            //Console.WriteLine("svg load was successful");
            XmlNodeList nodes = temp_doc.GetElementsByTagName("g");
            foreach(XmlNode node in nodes)
            {
                clean_svg.AppendChild(node);
            }
            
            string building_name = "test";
            clean_svg.Save("Temp_Files/clean_" + building_name + ".xml");
            Console.WriteLine("svg build was successful");

            return temp_doc;
        }

        public static XmlDocument SVG_Template(int Width, int Height)
        {
            Console.WriteLine("building wrapper");
            XmlDocument temp = new XmlDocument();  
            string BaseSvg = "<?xml version=\"1.0\" standalone=\"yes\"?>" 
                + "<!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 20010904//EN\" "
                + "\"https://www.w3.org/TR/2001/REC-SVG-20010904/DTD/svg10.dtd\">" 
                + "<svg width=\""+Width.ToString()
                +"\" height=\""
                +Height.ToString()
                +"\" xmlns=\"https://www.w3.org/2000/svg\"> "
                + "</svg>"; 
            temp.LoadXml(BaseSvg); 
            //temp.Save("Temp_Files/old_Template.svg");

            return temp;
        } 

    }
}
