namespace CheckCheck
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.范围选择 = new System.Windows.Forms.ComboBox();
            this.startid = new System.Windows.Forms.TextBox();
            this.endid = new System.Windows.Forms.TextBox();
            this.singleid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.listBox_all = new System.Windows.Forms.ListBox();
            this.label_all = new System.Windows.Forms.Label();
            this.label_not = new System.Windows.Forms.Label();
            this.listBox_not = new System.Windows.Forms.ListBox();
            this.label_not_count = new System.Windows.Forms.Label();
            this.label_all_count = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // 范围选择
            // 
            this.范围选择.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.范围选择.FormattingEnabled = true;
            this.范围选择.ItemHeight = 12;
            this.范围选择.Items.AddRange(new object[] {
            "范围查询",
            "指定学号"});
            this.范围选择.Location = new System.Drawing.Point(44, 34);
            this.范围选择.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.范围选择.Name = "范围选择";
            this.范围选择.Size = new System.Drawing.Size(83, 20);
            this.范围选择.TabIndex = 0;
            this.范围选择.SelectedIndexChanged += new System.EventHandler(this.范围选择_SelectedIndexChanged);
            // 
            // startid
            // 
            this.startid.Location = new System.Drawing.Point(197, 34);
            this.startid.Name = "startid";
            this.startid.Size = new System.Drawing.Size(75, 21);
            this.startid.TabIndex = 1;
            // 
            // endid
            // 
            this.endid.Location = new System.Drawing.Point(299, 34);
            this.endid.Name = "endid";
            this.endid.Size = new System.Drawing.Size(75, 21);
            this.endid.TabIndex = 2;
            // 
            // singleid
            // 
            this.singleid.Location = new System.Drawing.Point(197, 34);
            this.singleid.Name = "singleid";
            this.singleid.Size = new System.Drawing.Size(177, 21);
            this.singleid.TabIndex = 3;
            this.singleid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "学号范围:";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Location = new System.Drawing.Point(279, 37);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(14, 13);
            this.label_.TabIndex = 5;
            this.label_.Text = "-";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(381, 34);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(47, 23);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // listBox_all
            // 
            this.listBox_all.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_all.FormattingEnabled = true;
            this.listBox_all.ItemHeight = 17;
            this.listBox_all.Location = new System.Drawing.Point(44, 90);
            this.listBox_all.Name = "listBox_all";
            this.listBox_all.Size = new System.Drawing.Size(384, 208);
            this.listBox_all.TabIndex = 7;
            // 
            // label_all
            // 
            this.label_all.AutoSize = true;
            this.label_all.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_all.Location = new System.Drawing.Point(44, 66);
            this.label_all.Name = "label_all";
            this.label_all.Padding = new System.Windows.Forms.Padding(69, 4, 69, 4);
            this.label_all.Size = new System.Drawing.Size(199, 23);
            this.label_all.TabIndex = 8;
            this.label_all.Text = "全部结果";
            this.label_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_all.Click += new System.EventHandler(this.label_all_Click);
            // 
            // label_not
            // 
            this.label_not.AutoSize = true;
            this.label_not.Location = new System.Drawing.Point(237, 66);
            this.label_not.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label_not.Name = "label_not";
            this.label_not.Padding = new System.Windows.Forms.Padding(75, 4, 75, 4);
            this.label_not.Size = new System.Drawing.Size(196, 21);
            this.label_not.TabIndex = 9;
            this.label_not.Text = "未打卡";
            this.label_not.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_not.Click += new System.EventHandler(this.label_not_Click);
            // 
            // listBox_not
            // 
            this.listBox_not.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_not.FormattingEnabled = true;
            this.listBox_not.ItemHeight = 17;
            this.listBox_not.Location = new System.Drawing.Point(44, 90);
            this.listBox_not.Name = "listBox_not";
            this.listBox_not.Size = new System.Drawing.Size(384, 208);
            this.listBox_not.TabIndex = 10;
            // 
            // label_not_count
            // 
            this.label_not_count.AutoSize = true;
            this.label_not_count.Location = new System.Drawing.Point(352, 70);
            this.label_not_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_not_count.Name = "label_not_count";
            this.label_not_count.Size = new System.Drawing.Size(0, 13);
            this.label_not_count.TabIndex = 11;
            this.label_not_count.Click += new System.EventHandler(this.label_not_count_Click);
            // 
            // label_all_count
            // 
            this.label_all_count.AutoSize = true;
            this.label_all_count.Location = new System.Drawing.Point(163, 70);
            this.label_all_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_all_count.Name = "label_all_count";
            this.label_all_count.Size = new System.Drawing.Size(0, 13);
            this.label_all_count.TabIndex = 12;
            this.label_all_count.Click += new System.EventHandler(this.label_all_count_Click);
            // 
            // loading
            // 
            this.loading.ErrorImage = global::CheckCheck.Properties.Resources.loading;
            this.loading.Image = global::CheckCheck.Properties.Resources.loading;
            this.loading.InitialImage = global::CheckCheck.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(44, 302);
            this.loading.Margin = new System.Windows.Forms.Padding(0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(11, 12);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 13;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "能力有限，范围查询程序会暂停响应，50人3分钟左右。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(481, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label_all_count);
            this.Controls.Add(this.label_not_count);
            this.Controls.Add(this.label_not);
            this.Controls.Add(this.label_all);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endid);
            this.Controls.Add(this.startid);
            this.Controls.Add(this.范围选择);
            this.Controls.Add(this.singleid);
            this.Controls.Add(this.listBox_all);
            this.Controls.Add(this.listBox_not);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打卡查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox 范围选择;
        private System.Windows.Forms.TextBox startid;
        private System.Windows.Forms.TextBox endid;
        private System.Windows.Forms.TextBox singleid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListBox listBox_all;
        private System.Windows.Forms.Label label_all;
        private System.Windows.Forms.Label label_not;
        private System.Windows.Forms.ListBox listBox_not;
        private System.Windows.Forms.Label label_not_count;
        private System.Windows.Forms.Label label_all_count;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label label2;
    }
}

