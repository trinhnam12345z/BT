using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Đoc_ghi_file_XML
{
    class ReadWriteFileXML
    {
        static void Main(string[] args)
        {
            bool isWriten = WriteToFile();
            if (isWriten)
            {
                ReadFromFile();
            }
            else
            {
                System.Console.WriteLine("Write data to file occur an error. Please try again !");
            }

        }
        public static bool WriteToFile()
        {
            Book book = new Book();
            book.Title = "Đắc Nhân Tâm";
            book.Price = 123.5f;
            try
            {
                XDocument xDoc = XDocument.Load("Books.xml");
                XElement newBook = new XElement("book", new XElement("title", book.Title) , new XElement("price", book.Price.ToString()));

                xDoc.Element("bookstore").Add(newBook);
                xDoc.Save("Books.xml");
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return false;
            }
        }
        static void ReadFromFile()
        {
            XmlTextReader reader = new XmlTextReader("Books.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
        }
        
    }
}
