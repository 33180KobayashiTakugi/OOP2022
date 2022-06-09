using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {

           var r = new Random();
            Number.Value = r.Next(minValue: (int)Min.Value, (int)Max.Value+1);
        }

        private void Number_ValueChanged(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
