using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    public class XmlReader
    {
        private String path;
        private XElement xElement;

        public XmlReader()
        {
            this.path = "../../test.xml";
            this.xElement = XElement.Load(path);
        }



        public XElement findById(String id)
        {
            var item = from items in xElement.Elements("CD")
                         where (string)items.Attribute("id") == id
                         select items;
            return item.FirstOrDefault();
        }

        public IEnumerable<XElement> findByYear(String year)
        {
            var result = from items in xElement.Elements("CD")
                          where (string)items.Element("YEAR") == year
                          select items;
            return result;
        }

        public IEnumerable<XElement> findByCountry(String country)
        {
            var result = from items in xElement.Elements("CD")
                         where (string)items.Element("COUNTRY") == country
                         select items;
            return result;
        }

        public IEnumerable<XElement> findByCountryAndPrice(String country, double price)
        {
            var result = from items in xElement.Elements("CD")
                         where (string)items.Element("COUNTRY") == country 
                         && (double) items.Element("PRICE") > price
                         select items;
            return result;
        }
    }
}
