using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listCar = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvarticles.DataSource = listCar;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {

            //if (ofdopenFileDialog.ShowDialog() == DialogResult.OK) {
            //    pbPicture.Image = Image.FromFile(ofdopenFileDialog.FileName);
            }

        private void btExit_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }
    } 
}