using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            RegionCode();
        }

        public void RegionCode() {
            List<string> codes = new List<string> { "北海道地方" ,"東北地方","関東甲信地方","東海地方","北陸地方","近畿地方",
                                                    "中国地方","四国地方","九州北部地方","九州南部・奄美地方","沖縄地方"};
            cbRegion.Items.AddRange(codes.ToArray());
            
            
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherinfo.Text = json.text;

            pbImage.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";




        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
