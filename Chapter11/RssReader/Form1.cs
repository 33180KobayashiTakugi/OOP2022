﻿using System;
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

        IEnumerable<string> xLink;

        public Form1() {
            InitializeComponent();
        }

        private void cbRssGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssURL.Text);
                var xdoc = XDocument.Load(stream);
                var xNews = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));
                
                foreach (var data in xNews) {

                    lbRssTitle.Items.Add(data);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {

           int index = lbRssTitle.SelectedIndex; //選択した箇所のインデックスを取得
            if (index == -1) return;
            var url = xLink.ElementAt(index);
            wvBrowser.Navigate(url);
           
        }

        private void btBack_Click(object sender, EventArgs e) {

            //wbBrowser.GoBack();
            wvBrowser.GoBack();
        }

        private void btForward_Click(object sender, EventArgs e) {
            //wbBrowser.GoForward();
            wvBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e) {

            BackForwardButtonMaskCheck();

        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            BackForwardButtonMaskCheck();
        }

        private void BackForwardButtonMaskCheck() {
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }
    }
}
