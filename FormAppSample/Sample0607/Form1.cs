﻿using System;
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

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void tbNum1_TextChanged(object sender, EventArgs e) {

       }

        private void button1_Click(object sender, EventArgs e) {

            if (int.Parse(nudNum2.Text) != 0) {
                nudAns.Value = nudNum1.Value / nudNum2.Value;
                nudMod.Value = nudNum1.Value % nudNum2.Value;
            }
            else {
                MessageBox.Show("0で割り算できません",
                "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    }
            

        }
    }
}