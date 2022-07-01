
namespace RssReader {
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
            this.cbRssURL = new System.Windows.Forms.ComboBox();
            this.cbRssGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btForward = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRssURL
            // 
            this.cbRssURL.FormattingEnabled = true;
            this.cbRssURL.Location = new System.Drawing.Point(135, 22);
            this.cbRssURL.Name = "cbRssURL";
            this.cbRssURL.Size = new System.Drawing.Size(565, 20);
            this.cbRssURL.TabIndex = 0;
            // 
            // cbRssGet
            // 
            this.cbRssGet.Location = new System.Drawing.Point(713, 20);
            this.cbRssGet.Name = "cbRssGet";
            this.cbRssGet.Size = new System.Drawing.Size(75, 23);
            this.cbRssGet.TabIndex = 1;
            this.cbRssGet.Text = "取得";
            this.cbRssGet.UseVisualStyleBackColor = true;
            this.cbRssGet.Click += new System.EventHandler(this.cbRssGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 55);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(225, 556);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(182, 55);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(606, 556);
            this.wbBrowser.TabIndex = 3;
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(82, 19);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(47, 23);
            this.btForward.TabIndex = 4;
            this.btForward.Text = "→";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(23, 19);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(47, 23);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // wvBrowser
            // 
            this.wvBrowser.Location = new System.Drawing.Point(239, 55);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(549, 556);
            this.wvBrowser.TabIndex = 5;
            this.wvBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrowser_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.cbRssGet);
            this.Controls.Add(this.cbRssURL);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssURL;
        private System.Windows.Forms.Button cbRssGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btBack;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

