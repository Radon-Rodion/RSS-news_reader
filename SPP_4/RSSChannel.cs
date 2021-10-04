using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace SPP_4
{
    public class RSSChannel
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Link { get; private set; }
        public RSSItemsList ItemsList { get; private set; }

        public RSSChannel(XmlDocument xmlDoc)
        {
            ChannelFromXmlDoc(xmlDoc);
        }

        private void ChannelFromXmlDoc(XmlDocument xmlDoc)
        {
            ItemsList = new RSSItemsList();

            XmlNode channelXmlNode = xmlDoc.GetElementsByTagName("channel")[0];
            if (channelXmlNode != null)
            {
                foreach (XmlNode channelNode in channelXmlNode.ChildNodes)
                {
                    switch (channelNode.Name)
                    {
                        case "title":
                            Title = channelNode.InnerText;
                            break;
                        case "description":
                            Description = channelNode.InnerText;
                            break;
                        case "link":
                            Link = channelNode.InnerText;
                            break;
                        case "item":
                            ItemsList.Add(new RSSItem(channelNode));
                            break;
                    }
                }
            }
            else
            {
                throw new Exception("Invalid XML: Channel description not found!");
            }
        }
        public RSSChannel(string url)
        {
            XmlTextReader xmlTextReader = new XmlTextReader(url);
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(xmlTextReader);
                xmlTextReader.Close();
                ChannelFromXmlDoc(xmlDoc);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception");
            }
        }
    }
}
