
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbWeatherinfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            this.pbImage3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherinfo
            // 
            this.tbWeatherinfo.Location = new System.Drawing.Point(29, 171);
            this.tbWeatherinfo.Multiline = true;
            this.tbWeatherinfo.Name = "tbWeatherinfo";
            this.tbWeatherinfo.Size = new System.Drawing.Size(739, 144);
            this.tbWeatherinfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(29, 12);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(112, 36);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "十勝地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "三重県",
            "佐賀県",
            "大阪府",
            "京都府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "山口県",
            "香川県",
            "徳島県",
            "愛媛県",
            "高知県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
            this.cbArea.Location = new System.Drawing.Point(138, 71);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(148, 21);
            this.cbArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "地域";
            // 
            // pbImage1
            // 
            this.pbImage1.BackColor = System.Drawing.Color.Transparent;
            this.pbImage1.Location = new System.Drawing.Point(190, 361);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(96, 57);
            this.pbImage1.TabIndex = 5;
            this.pbImage1.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(693, 589);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pbImage2
            // 
            this.pbImage2.BackColor = System.Drawing.Color.Transparent;
            this.pbImage2.Location = new System.Drawing.Point(190, 440);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(96, 61);
            this.pbImage2.TabIndex = 5;
            this.pbImage2.TabStop = false;
            // 
            // pbImage3
            // 
            this.pbImage3.BackColor = System.Drawing.Color.Transparent;
            this.pbImage3.Location = new System.Drawing.Point(190, 521);
            this.pbImage3.Name = "pbImage3";
            this.pbImage3.Size = new System.Drawing.Size(96, 61);
            this.pbImage3.TabIndex = 5;
            this.pbImage3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(107, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "今日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(107, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "明日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(86, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "明後日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(478, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(622, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(487, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "最高";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(633, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "最低";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pbImage3);
            this.Controls.Add(this.pbImage2);
            this.Controls.Add(this.pbImage1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherinfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImage1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pbImage2;
        private System.Windows.Forms.PictureBox pbImage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

