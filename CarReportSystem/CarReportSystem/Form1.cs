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

       

        public Form1() {
            InitializeComponent();
            
        }


        private void btExit_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }


        public string GetRadioButtonMakerGroup() {

            //デフォルトの戻り値を設定
            
            if (rbToyota.Checked) {
                return"トヨタ";
            }
            if (rbNissan.Checked) {
                return"日産";
            }
            if (rbHonda.Checked) {
                return"ホンダ";
            }
            if (rbSubaru.Checked) {
                return"スバル";
            }
            if (rbforeign.Checked) {
                return"外国車";
            }
            return "その他";
        }
       

        
        private void setMakerGroup(string maker) {
            //番号種別チェック処理
            switch (maker) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbforeign.Checked = true;
                    break;
                case "その他":
                    rbother.Checked = true;
                    break;
                
            }
        }





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
            carReportDBBindingSource.RemoveAt(carReportDBDataGridView.CurrentRow.Index);
            
        }

        

       

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202217DataSet.CarReportDB.NewRow();
            newRow[1] = dateTimePicker1.Text;
            newRow[2] = cbAuther.Text;
            newRow[3] = GetRadioButtonMakerGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbImage.Image);
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
        

        private void btNameSerch_Click(object sender, EventArgs e) {
            carReportDBTableAdapter.FillByName(infosys202217DataSet.CarReportDB,tbSerchName.Text);
        }

        private void btNameDelete_Click(object sender, EventArgs e) {
            tbSerchName.Text = null;
            this.carReportDBTableAdapter.Fill(this.infosys202217DataSet.CarReportDB);
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null) {
                return;
            }
            else {
                dateTimePicker1.Value = (DateTime)carReportDBDataGridView.CurrentRow.Cells[1].Value;
                cbAuther.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerGroup(carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
                

                //画像表示処理
                if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))
                    pbImage.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
                else
                    pbImage.Image = null;
            }
        }
        //エラー回避
        private void carReportDBDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e) {

        }

        }
}




