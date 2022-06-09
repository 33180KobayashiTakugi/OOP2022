
namespace AddressBook {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMailaddress = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.cbfamily = new System.Windows.Forms.CheckBox();
            this.cbFriend = new System.Windows.Forms.CheckBox();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.cbothers = new System.Windows.Forms.CheckBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(145, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "メールアドレス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(145, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(145, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(114, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "グループ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(776, 225);
            this.dataGridView1.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(249, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbMailaddress
            // 
            this.tbMailaddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMailaddress.Location = new System.Drawing.Point(249, 91);
            this.tbMailaddress.Name = "tbMailaddress";
            this.tbMailaddress.Size = new System.Drawing.Size(310, 31);
            this.tbMailaddress.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(249, 139);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 61);
            this.textBox3.TabIndex = 2;
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCompany.Location = new System.Drawing.Point(249, 222);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(310, 31);
            this.tbCompany.TabIndex = 2;
            // 
            // cbfamily
            // 
            this.cbfamily.AutoSize = true;
            this.cbfamily.Location = new System.Drawing.Point(249, 289);
            this.cbfamily.Name = "cbfamily";
            this.cbfamily.Size = new System.Drawing.Size(48, 16);
            this.cbfamily.TabIndex = 4;
            this.cbfamily.Text = "家族";
            this.cbfamily.UseVisualStyleBackColor = true;
            // 
            // cbFriend
            // 
            this.cbFriend.AutoSize = true;
            this.cbFriend.Location = new System.Drawing.Point(324, 289);
            this.cbFriend.Name = "cbFriend";
            this.cbFriend.Size = new System.Drawing.Size(48, 16);
            this.cbFriend.TabIndex = 4;
            this.cbFriend.Text = "友人";
            this.cbFriend.UseVisualStyleBackColor = true;
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(390, 289);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(48, 16);
            this.cbWork.TabIndex = 4;
            this.cbWork.Text = "仕事";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // cbothers
            // 
            this.cbothers.AutoSize = true;
            this.cbothers.Location = new System.Drawing.Point(461, 289);
            this.cbothers.Name = "cbothers";
            this.cbothers.Size = new System.Drawing.Size(55, 16);
            this.cbothers.TabIndex = 4;
            this.cbothers.Text = "その他";
            this.cbothers.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddPerson.Location = new System.Drawing.Point(628, 259);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(114, 35);
            this.btAddPerson.TabIndex = 5;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(628, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 151);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(621, 203);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 7;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(698, 203);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.cbothers);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.cbFriend);
            this.Controls.Add(this.cbfamily);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbMailaddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMailaddress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.CheckBox cbfamily;
        private System.Windows.Forms.CheckBox cbFriend;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.CheckBox cbothers;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btClear;
    }
}

