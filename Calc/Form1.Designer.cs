namespace Calc
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
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_m = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_mt = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_p = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(324, 67);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_m, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_mt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_d, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_cal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_p, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_ac, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_m
            // 
            this.btn_m.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_m.Location = new System.Drawing.Point(228, 153);
            this.btn_m.Name = "btn_m";
            this.btn_m.Size = new System.Drawing.Size(69, 69);
            this.btn_m.TabIndex = 15;
            this.btn_m.Text = "-";
            this.btn_m.UseVisualStyleBackColor = true;
            this.btn_m.Click += new System.EventHandler(this.btn_m_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.Location = new System.Drawing.Point(153, 153);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(69, 69);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.Location = new System.Drawing.Point(78, 153);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(69, 69);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.Location = new System.Drawing.Point(3, 153);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(69, 69);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_mt
            // 
            this.btn_mt.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mt.Location = new System.Drawing.Point(228, 78);
            this.btn_mt.Name = "btn_mt";
            this.btn_mt.Size = new System.Drawing.Size(69, 69);
            this.btn_mt.TabIndex = 11;
            this.btn_mt.Text = "X";
            this.btn_mt.UseVisualStyleBackColor = true;
            this.btn_mt.Click += new System.EventHandler(this.btn_mt_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_6.Location = new System.Drawing.Point(153, 78);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(69, 69);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_5.Location = new System.Drawing.Point(78, 78);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(69, 69);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.Location = new System.Drawing.Point(3, 78);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(69, 69);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_d
            // 
            this.btn_d.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_d.Location = new System.Drawing.Point(228, 3);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(69, 69);
            this.btn_d.TabIndex = 7;
            this.btn_d.Text = "/";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_9.Location = new System.Drawing.Point(153, 3);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(69, 69);
            this.btn_9.TabIndex = 6;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_0.Location = new System.Drawing.Point(3, 228);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(69, 69);
            this.btn_0.TabIndex = 4;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cal.Location = new System.Drawing.Point(153, 228);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(69, 69);
            this.btn_cal.TabIndex = 3;
            this.btn_cal.Text = "=";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_p
            // 
            this.btn_p.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_p.Location = new System.Drawing.Point(228, 228);
            this.btn_p.Name = "btn_p";
            this.btn_p.Size = new System.Drawing.Size(69, 69);
            this.btn_p.TabIndex = 2;
            this.btn_p.Text = "+";
            this.btn_p.UseVisualStyleBackColor = true;
            this.btn_p.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ac.Location = new System.Drawing.Point(78, 228);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(69, 69);
            this.btn_ac.TabIndex = 1;
            this.btn_ac.Text = "AC";
            this.btn_ac.UseVisualStyleBackColor = true;
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_7.Location = new System.Drawing.Point(3, 3);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(69, 69);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_8.Location = new System.Drawing.Point(78, 3);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(69, 69);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_m;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_mt;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_p;
        private System.Windows.Forms.Button btn_8;
    }
}

