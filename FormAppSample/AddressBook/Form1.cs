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
            };
            listPerson.Add(newPerson);
        }

        private void btClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
    }
}

