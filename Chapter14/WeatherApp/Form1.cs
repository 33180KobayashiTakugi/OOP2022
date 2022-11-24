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

        }


        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();



        }






        private void btWeatherGet_Click(object sender, EventArgs e) {

            try {
                var wc = new WebClient() {
                    Encoding = Encoding.UTF8
                };

                var areacode = " ";
                var weather = " ";


                switch (cbArea.SelectedItem) {
                    case "宗谷地方":

                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");

                        break;
                    case "上川・留萌地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                        break;
                    case "網走・北見・紋別地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                        break;
                    case "十勝地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                        break;
                    case "釧路・根室地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                        break;
                    case "胆振・日高地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                        break;
                    case "石狩・空知・後志地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                        break;
                    case "渡島・檜山地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                        break;
                    case "青森県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                        break;
                    case "岩手県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                        break;
                    case "宮城県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                        break;
                    case "秋田県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                        break;
                    case "山形県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                        break;
                    case "福島県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                        break;
                    case "茨城県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                        break;
                    case "栃木県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                        break;
                    case "群馬県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                        break;
                    case "埼玉県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                        break;
                    case "千葉県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                        break;
                    case "東京都":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                        break;
                    case "神奈川県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                        break;
                    case "新潟県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                        break;
                    case "富山県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                        break;
                    case "石川県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                        break;
                    case "福井県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                        break;
                    case "山梨県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                        break;
                    case "長野県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                        break;
                    case "岐阜県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                        break;
                    case "静岡県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                        break;
                    case "愛知県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                        break;
                    case "三重県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                        break;
                    case "滋賀県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                        break;
                    case "京都府":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                        break;
                    case "大阪府":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                        break;
                    case "兵庫県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                        break;
                    case "奈良県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                        break;
                    case "和歌山県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                        break;
                    case "鳥取県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                        break;
                    case "島根県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                        break;
                    case "岡山県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                        break;
                    case "広島県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                        break;
                    case "山口県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                        break;
                    case "徳島県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
                        break;
                    case "香川県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                        break;
                    case "愛媛県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                        break;
                    case "高知県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                        break;
                    case "福岡県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                        break;
                    case "佐賀県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                        break;
                    case "長崎県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                        break;
                    case "熊本県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                        break;
                    case "大分県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                        break;
                    case "宮崎県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                        break;
                    case "鹿児島県":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
                        break;
                    default:
                        break;
                    case "沖縄本島地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                        break;
                    case "大東島地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                        break;
                    case "宮古島地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                        break;
                    case "八重山地方":
                        areacode = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                        weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                        break;
                }



                var djson1 = JsonConvert.DeserializeObject<Rootobject>(areacode);
                var djson2 = JsonConvert.DeserializeObject<Class1[]>(weather);


                if (djson1 == null) {
                    tbWeatherinfo.Text = "地域が選択されていません";
                }
                else {

                    label6.Text = djson2[1].tempAverage.areas[0].max;
                    label7.Text = djson2[1].tempAverage.areas[0].min;

                    //label8.Text = djson2[1].tempAverage.areas[0].max;
                    //label9.Text = djson2[1].tempAverage.areas[0].min;

                    //label10.Text = djson2[1].tempAverage.areas[0].max;
                    //label11.Text = djson2[1].tempAverage.areas[0].min;


                    tbWeatherinfo.Text = djson1.text;
                    pbImage1.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + djson2[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
                    pbImage2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + djson2[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
                    pbImage3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + djson2[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";


                }
            }
            catch (Exception) {

                MessageBox.Show("ネットワークに接続されていません。");
            }

            


        }

        //群馬を表示
        private void Form1_Load(object sender, EventArgs e) {
            //var wc = new WebClient() {
            //    Encoding = Encoding.UTF8
            //};

            //var gum1= " ";
            //var gum2 = " ";
            //gum1 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
            //gum2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
            //var djsongum1 = JsonConvert.DeserializeObject<Rootobject>(gum1);
            //var djsongum2 = JsonConvert.DeserializeObject<Class1[]>(gum2);
            //tbWeatherinfo.Text = djsongum1.text;
            //pbImage1.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + djsongum2[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
            //pbImage2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + djsongum2[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            //pbImage3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + djsongum2[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";
            //label6.Text = djsongum2[1].tempAverage.areas[0].max;
            //label7.Text = djsongum2[1].tempAverage.areas[0].min;


        }
    }
}