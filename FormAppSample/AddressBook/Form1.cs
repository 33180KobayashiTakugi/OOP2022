using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {

           if( ofdopenFileDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdopenFileDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailaddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };
            listPerson.Add(newPerson);
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {

            var listGroup = new List<Person.GroupType>();

            if(cbfamily.Checked ) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }
        private void btClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvPersons.CurrentRow == null) return;
            var selectrow = dgvPersons.CurrentRow.Index;
            //データグリッドビューのインデックス０番の名前をテキストボックスに格納
            tbName.Text = listPerson[selectrow].Name;
            tbMailaddress.Text = listPerson[selectrow].MailAddress;
            tbAddress.Text = listPerson[selectrow].Address;
            tbCompany.Text = listPerson[selectrow].Company;
            pbPicture.Image = listPerson[selectrow].Picture;

            GroupCheckBoxAllClear();

            foreach (var group in listPerson[selectrow].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbfamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }
        //グループのチェックボックスをクリア
        private void GroupCheckBoxAllClear() {

            cbfamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }
        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailaddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = tbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            dgvPersons.Refresh();//データグリッドビュー更新
        }
        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {

            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
            if (listPerson.Count() == 0) {

                btDelete.Enabled = false;
                btUpdate.Enabled = false;
            }



        }

        private void Form1_Load(object sender, EventArgs e) {
            btDelete.Enabled = false;  //削除ボタンをマスク
            btUpdate.Enabled = false;  //更新ボタン
        }

        
    }
}

