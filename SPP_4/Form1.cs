using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP_4
{
    public partial class ReaderForm : Form
    {
        RSSChannel channel;
        public ReaderForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddressBox.Text)) return;
            RecordsList.Clear();
            channel = new RSSChannel(AddressBox.Text);
            foreach (RSSItem feedItem in channel.ItemsList)
            {
                ListViewItem listViewItem = new ListViewItem(feedItem.Title);
                listViewItem.Name = feedItem.Title;
                RecordsList.Items.Add(listViewItem);
            }
        }

        private void RecordsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecordsList.SelectedItems.Count > 0 && channel != null && channel.ItemsList.Count > 0)
            {
                WebBrowser.DocumentText =
                    channel.ItemsList.GetItem(RecordsList.SelectedItems[0].Text).Description;
            }
        }
    }
}
