using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        Settings settings = Settings.getInstance();

        BindingList<CarReport> listCar = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = listCar;
        }


        private void btExit_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }

       
        public CarReport.MakerGroup GetRadioButtonMakerGroup() {

            //デフォルトの戻り値を設定
            CarReport.MakerGroup selectMakerGroup = CarReport.MakerGroup.その他;
            if (rbToyota.Checked) {
                selectMakerGroup = CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                selectMakerGroup = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                selectMakerGroup = CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                selectMakerGroup = CarReport.MakerGroup.スバル;
            }
            if (rbforeign.Checked) {
                selectMakerGroup = CarReport.MakerGroup.外国車;
            }
            return selectMakerGroup;
        }
        //コンボボックスに登録する(重複なし)
        private void setcbAuther(string Auther) {

            if (cbAuther.Items.IndexOf(cbAuther.Text)==-1) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(cbAuther.Text);
            }
        }
        private void setcbCarName(string CarName) {

            if (cbCarName.Items.IndexOf(cbCarName.Text) == -1) {
                cbCarName.Items.Add(cbCarName.Text);
            }
        }

      
        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvCarReports.CurrentRow == null) return;
            var index = dgvCarReports.CurrentRow.Index;
            //データグリッドビューのインデックス０番の名前をテキストボックスに格納
            cbAuther.Text = listCar[index].Auther;
            cbCarName.Text = listCar[index].CarName;
            tbReport.Text = listCar[index].Report;
            pbPicture.Image = listCar[index].Picture;

            dtpDate.Value =
               listCar[index].Date.Year > 1900 ? listCar[index].Date : DateTime.Today;
            setMakerGroup(index);   
        }
        private void setMakerGroup(int index) {
            //番号種別チェック処理
            switch (listCar[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    break;
                case CarReport.MakerGroup.日産:
                    break;
                case CarReport.MakerGroup.ホンダ:
                    break;
                case CarReport.MakerGroup.スバル:
                    break;
                case CarReport.MakerGroup.外国車:
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
            }
        }
        
        
        //更新・削除ボタンのマスク処理行う（マスク判定含む）
        private void EnabledCheck() {
            btUpdate.Enabled = btDelete.Enabled = listCar.Count() > 0 ? true : false;
        }
        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
        }
        
        

        private void btPictureOpen_Click_1(object sender, EventArgs e) {

            if (ofdopenFileDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdopenFileDialog.FileName);
            }
        }

        private void btClear_Click_1(object sender, EventArgs e) {

            pbPicture.Image = null;
        }

        private void btUpdate_Click_1(object sender, EventArgs e) {

            listCar[dgvCarReports.CurrentRow.Index].Auther = cbAuther.Text;
            listCar[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            listCar[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            listCar[dgvCarReports.CurrentRow.Index].Maker = GetRadioButtonMakerGroup();
            listCar[dgvCarReports.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReports.Refresh();//データグリッドビュー更新
        }

        private void btDelete_Click_1(object sender, EventArgs e) {

            listCar.RemoveAt(dgvCarReports.CurrentRow.Index);
            if (listCar.Count() == 0) {

                EnabledCheck(); //マスク処理呼び出し
            }
        }

        private void btOpen_Click_1(object sender, EventArgs e) {

            if (ofdopenFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdopenFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCar = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = listCar;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbAuther.Items.Clear();    //コンボボックスのアイテム消去
                //コンボボックスへ新規登録
                foreach (var item in listCar.Select(p => p.Auther)) {
                    setcbAuther(item);//存在する会社を登録
                }
                EnabledCheck(); //マスク処理呼び出し
            }
            cbCarName.Items.Clear();
            foreach (var item in listCar.Select(p => p.CarName)) {
                setcbCarName(item);//存在する会社を登録
            }
            EnabledCheck(); //マスク処理呼び出し
        }

        private void btSave_Click_1(object sender, EventArgs e) {

            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル式
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCar);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text)) {
                MessageBox.Show("error");
                return;
            }
            CarReport newCarReport = new CarReport {

                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = GetRadioButtonMakerGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };
            setcbAuther(cbAuther.Text);
            setcbCarName(cbCarName.Text);

            listCar.Add(newCarReport);

            EnabledCheck(); //マスク処理呼び出し

            
        }

        private void 設定toolStripMenuItem1_Click(object sender, EventArgs e) {

            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            using(var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer,settings);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e) {

            EnabledCheck(); //マスク処理呼び出し
            //逆シリアル化
            try {
                using (var reader = XmlReader.Create("settings.xml")) {

                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {


            }         
        }
      }
   }



