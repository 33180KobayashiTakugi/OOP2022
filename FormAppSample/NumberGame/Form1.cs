using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        //乱数
        private int randomNumber;

        Random r = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            getRandom();
        }

        private void Judge_Click(object sender, EventArgs e) {
         
             //入力した値とあらかじめ取得した乱数を比較し結果を表示
             if(nudnum1.Value == randomNumber) {
                textBox1.Text = ("正解");
            }else if(nudnum1.Value < randomNumber){
                textBox1.Text = ("大きい");
            }else {
                textBox1.Text = ("小さい");
            }
            
            }
        
        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            getRandom();
        }

        private void getRandom() {
            randomNumber = r.Next(1, (int)maxNum.Value);
            this.Text = randomNumber.ToString();
        }

    }
}
