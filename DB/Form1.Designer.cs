namespace DB
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListBox();
            this.gridBtn = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(14, 16);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(102, 30);
            this.selectBtn.TabIndex = 0;
            this.selectBtn.Text = "목록조회";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // listView
            // 
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 12;
            this.listView.Location = new System.Drawing.Point(13, 59);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(769, 172);
            this.listView.TabIndex = 1;
            // 
            // gridBtn
            // 
            this.gridBtn.Location = new System.Drawing.Point(146, 16);
            this.gridBtn.Name = "gridBtn";
            this.gridBtn.Size = new System.Drawing.Size(102, 30);
            this.gridBtn.TabIndex = 2;
            this.gridBtn.Text = "목록조회-grid";
            this.gridBtn.UseVisualStyleBackColor = true;
            this.gridBtn.Click += new System.EventHandler(this.gridBtn_Click);
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 248);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 23;
            this.gridView.Size = new System.Drawing.Size(770, 176);
            this.gridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.gridBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.selectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ListBox listView;
        private System.Windows.Forms.Button gridBtn;
        private System.Windows.Forms.DataGridView gridView;
    }
}

