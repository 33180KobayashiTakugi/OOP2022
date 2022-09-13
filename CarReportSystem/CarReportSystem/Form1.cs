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

            if (cbAuther.Items.IndexOf(cbAuther.Text) == -1) {
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
            pbImage.Image = listCar[index].Picture;

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
        //private void EnabledCheck() {
        //    btUpdate.Enabled = btDelete.Enabled = listCar.Count() > 0 ? true : false;
        //}
        //private void Form1_Load(object sender, EventArgs e) {
        //    dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
        //}



        private void btPictureOpen_Click_1(object sender, EventArgs e) {
            ofdopenFileDialog.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdopenFileDialog.ShowDialog() == DialogResult.OK) {
                pbImage.Image = Image.FromFile(ofdopenFileDialog.FileName);
            }
        }

        private void btClear_Click_1(object sender, EventArgs e) {

            pbImage.Image = null;
        }

        private void btUpdate_Click_1(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dateTimePicker1.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMakerGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pbImage.Image;
            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202217DataSet);
        }

        private void btDelete_Click_1(object sender, EventArgs e) {

            cbAuther.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
        }

        private void btOpen_Click_1(object sender, EventArgs e) {

            //if (ofdopenFileDialog.ShowDialog() == DialogResult.OK) {
            //    try {
            //        //バイナリ形式で逆シリアル化
            //        var bf = new BinaryFormatter();
            //        using (FileStream fs = File.Open(ofdopenFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
            //            //逆シリアル化して読み込む
            //            listCar = (BindingList<CarReport>)bf.Deserialize(fs);
            //            dgvCarReports.DataSource = null;
            //            dgvCarReports.DataSource = listCar;
            //        }
            //    }
            //    catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //    cbAuther.Items.Clear();    //コンボボックスのアイテム消去
            //    //コンボボックスへ新規登録
            //    foreach (var item in listCar.Select(p => p.Auther)) {
            //        setcbAuther(item);//存在する会社を登録
            //    }
            //    EnabledCheck(); //マスク処理呼び出し
            //}
            //cbCarName.Items.Clear();
            //foreach (var item in listCar.Select(p => p.CarName)) {
            //    setcbCarName(item);//存在する会社を登録
            //}
            //EnabledCheck(); //マスク処理呼び出し
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
            DataRow newRow = infosys202217DataSet.CarReportDB.NewRow();
            newRow[3] = cbAuther.Text;
            newRow[4] = cbCarName.Text;
            //データセットへ新しいレコードを追加
            infosys202217DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202217DataSet.CarReportDB);


        }

        private void 設定toolStripMenuItem1_Click(object sender, EventArgs e) {

            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e) {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //EnabledCheck(); //マスク処理呼び出し
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

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202217DataSet);

        }

        private void carReportDBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null) {
                return;
            }else {
                cbAuther.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
                cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
                tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString();
               
                //画像表示処理
                if (!(carReportDBDataGridView.CurrentRow.Cells[5].Value is DBNull))
                    pbImage.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
                else
                    pbImage.Image = null;
            }
        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202217DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202217DataSet.CarReportDB);
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}



