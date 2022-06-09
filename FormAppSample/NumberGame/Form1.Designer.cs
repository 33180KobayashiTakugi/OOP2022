
namespace NumberGame {
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
            this.Judge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudnum1 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Judge
            // 
            this.Judge.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Judge.Location = new System.Drawing.Point(415, 174);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(147, 66);
            this.Judge.TabIndex = 0;
            this.Judge.Text = "判定";
            this.Judge.UseVisualStyleBackColor = true;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(305, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "の中から数字を入力";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudnum1
            // 
            this.nudnum1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudnum1.Location = new System.Drawing.Point(203, 190);
            this.nudnum1.Name = "nudnum1";
            this.nudnum1.Size = new System.Drawing.Size(120, 36);
            this.nudnum1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(164, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 36);
            this.textBox1.TabIndex = 4;
            // 
            // maxNum
            // 
            this.maxNum.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNum.Location = new System.Drawing.Point(236, 62);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(76, 36);
            this.maxNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(159, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "１から";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.nudnum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Judge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Judge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudnum1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.Label label2;
    }
}

