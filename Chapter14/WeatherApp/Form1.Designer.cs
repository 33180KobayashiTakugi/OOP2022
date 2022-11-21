
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
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            this.pbImage3 = new System.Windows.Forms.PictureBox();
            this.pbImage4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherinfo
            // 
            this.tbWeatherinfo.Location = new System.Drawing.Point(29, 147);
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "天気概況";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(138, 71);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(148, 20);
            this.cbRegion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "地域";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbImage.Location = new System.Drawing.Point(452, 57);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(96, 57);
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
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
            this.pbImage2.BackColor = System.Drawing.SystemColors.Control;
            this.pbImage2.Location = new System.Drawing.Point(190, 336);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(96, 61);
            this.pbImage2.TabIndex = 5;
            this.pbImage2.TabStop = false;
            // 
            // pbImage3
            // 
            this.pbImage3.BackColor = System.Drawing.SystemColors.Control;
            this.pbImage3.Location = new System.Drawing.Point(190, 415);
            this.pbImage3.Name = "pbImage3";
            this.pbImage3.Size = new System.Drawing.Size(96, 61);
            this.pbImage3.TabIndex = 5;
            this.pbImage3.TabStop = false;
            // 
            // pbImage4
            // 
            this.pbImage4.BackColor = System.Drawing.SystemColors.Control;
            this.pbImage4.Location = new System.Drawing.Point(190, 497);
            this.pbImage4.Name = "pbImage4";
            this.pbImage4.Size = new System.Drawing.Size(96, 61);
            this.pbImage4.TabIndex = 5;
            this.pbImage4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pbImage4);
            this.Controls.Add(this.pbImage3);
            this.Controls.Add(this.pbImage2);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherinfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pbImage2;
        private System.Windows.Forms.PictureBox pbImage3;
        private System.Windows.Forms.PictureBox pbImage4;
    }
}

