using System;
using System.Xml;

namespace Geck
{
    internal static class XmlTools 
    {
 
        public static void ReadString(this XmlNode node, String field, ref String read)
        {
            XmlElement element = node[field];
            if (element != null)
            {
                read = element.InnerText;
            }
        }

        public static void ReadInt(this XmlNode node, String field, ref int read)
        {
            XmlElement element = node[field];
            if (element != null)
            {
                int temp;
                if (int.TryParse(element.InnerText, out temp))
                {
                    read = temp;       
                }
            }
        }

        public static void ReadBool(this XmlNode node, String field, ref bool read)
        {
            XmlElement element = node[field];
            if (element != null)
            {
                bool temp;
                if (bool.TryParse(element.InnerText, out temp))
                {
                    read = temp;
                }
            }
        }

        public static void ReadDecimal(this XmlNode node, String field, ref decimal read)
        {
            XmlElement element = node[field];
            if (element != null)
            {
                decimal temp;
                if (decimal.TryParse(element.InnerText, out temp))
                {
                    read = temp;
                }
            }
        }

        public static void ReadDouble(this XmlNode node, String field, ref double read)
        {
            XmlElement element = node[field];
            if (element != null)
            {
                double temp;
                if (double.TryParse(element.InnerText, out temp))
                {
                    read = temp;
                }
            }
        }
    }
}