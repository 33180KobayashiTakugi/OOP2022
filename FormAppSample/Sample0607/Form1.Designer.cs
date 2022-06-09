
namespace Sample0607 {
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
            this.btRandom = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.NumericUpDown();
            this.Min = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(311, 163);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(125, 43);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "乱数";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(67, 165);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(167, 31);
            this.Number.TabIndex = 1;
            this.Number.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "最小値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(110, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大値";
            // 
            // Max
            // 
            this.Max.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Max.Location = new System.Drawing.Point(294, 83);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(167, 31);
            this.Max.TabIndex = 1;
            this.Max.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Min.Location = new System.Drawing.Point(294, 46);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(167, 31);
            this.Min.TabIndex = 1;
            this.Min.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btRandom);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Max;
        private System.Windows.Forms.NumericUpDown Min;
    }
}

