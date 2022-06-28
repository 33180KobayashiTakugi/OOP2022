using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void cbRssGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssURL.Text);

                var xdoc = XDocument.Load(stream);
                var xNews = xdoc.Root.Descendants("title");

                foreach (var data in xNews) {

                    lbRssTitle.Items.Add(data);
                }
            }
        }
    }
}
