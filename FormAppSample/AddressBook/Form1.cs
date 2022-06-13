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

        private void GroupCheckBoxAllClear() {
            cbfamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }
    }
}

