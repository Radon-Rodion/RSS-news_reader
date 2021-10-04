using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SPP_4
{
    public class RSSItem
    {
        public string Title { get; private set; } // заголовок записи
        public string Link { get; private set; } // ссылка на полный текст
        public string Description { get; private set; }// описание записи

        public RSSItem(XmlNode node)
        {
            foreach (XmlNode xmlTag in node.ChildNodes)
            {
                switch (xmlTag.Name)
                {
                    case "title":
                        Title = xmlTag.InnerText;
                        break;
                    case "description":
                        Description = xmlTag.InnerText;
                        break;
                    case "link":
                        Link = xmlTag.InnerText;
                        break;
                }
            }
        }
    }
}
