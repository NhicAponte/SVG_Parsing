using System;
using System.Xml;

namespace Create_SVG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Build_SVG();
            //width="3456"
            //height="2304"
            SVG_Template(3456,2304); 
        }

        public static void Build_SVG()
        {
            Console.WriteLine("svg build started");
            XmlDocument svg_doc = new XmlDocument();
            //XmlDocument clean_svg = new XmlDocument();
            Console.WriteLine("loading svg");
            svg_doc.LoadXml("SVG_Base_Template.xml");

            //string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            //if (svg_doc.StartsWith(_byteOrderMarkUtf8))
            //{
            //    svg_doc = svg_doc.Remove(0, _byteOrderMarkUtf8.Length);
           // }

            //svg_doc.LoadXml("Create_SVG/SVG_Template_engineering.xml");
            Console.WriteLine("svg load was successful");
            //XmlNodeList nodes = svg_doc.GetElementsByTagName("svg");
            //foreach(XmlNode node in nodes)
            //{
            //    clean_svg.AppendChild(node);
            //}
            
            //XmlElement rootNode = svg_doc.CreateElement("svg");
            //XmlElement bld_name = svg_doc.CreateElement("building");
            //bld_name.Add(new XmlAttribute("building"));
            //XmlAttribute attribute = svg_doc.CreateAttribute("Name");
            //attribute.Value = "engineering"; 

            //rootNode.AppendChild(bld_name);
            //svg_doc.AppendChild(rootNode);
            //string building_name = "engineering";
            //svg_doc.Save(@"SVG_Template_" + building_name + ".xml");
            Console.WriteLine("svg build was successful");
        }

        public static void SVG_Template(int Width, int Height)
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
            temp.Save("Temp_Files/New_Base_Template.svg");
        } 

    }
}
