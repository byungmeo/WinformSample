namespace WindowsFormsApp1
{
    partial class Form01_메인
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form01_메인));
            this.button_left = new System.Windows.Forms.Button();
            this.button_center = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.label_location = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_left.ForeColor = System.Drawing.Color.White;
            this.button_left.Location = new System.Drawing.Point(15, 284);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(140, 41);
            this.button_left.TabIndex = 10;
            this.button_left.Text = "로그인";
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_center
            // 
            this.button_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_center.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_center.ForeColor = System.Drawing.Color.White;
            this.button_center.Location = new System.Drawing.Point(175, 284);
            this.button_center.Name = "button_center";
            this.button_center.Size = new System.Drawing.Size(140, 41);
            this.button_center.TabIndex = 11;
            this.button_center.Text = "관리자";
            this.button_center.UseVisualStyleBackColor = false;
            this.button_center.Click += new System.EventHandler(this.button_center_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 8);
            this.label4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 8);
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 8);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 75);
            this.label1.TabIndex = 12;
            this.label1.Text = "Let\'s corail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(335, 284);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(140, 41);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "종료";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_location);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Location = new System.Drawing.Point(275, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 173);
            this.panel1.TabIndex = 18;
            // 
            // button_1
            // 
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_1.ForeColor = System.Drawing.Color.Red;
            this.button_1.Location = new System.Drawing.Point(16, 26);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(25, 25);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            // 
            // button_2
            // 
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_2.ForeColor = System.Drawing.Color.Black;
            this.button_2.Location = new System.Drawing.Point(52, 26);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(25, 25);
            this.button_2.TabIndex = 1;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            // 
            // button_3
            // 
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_3.ForeColor = System.Drawing.Color.Black;
            this.button_3.Location = new System.Drawing.Point(87, 26);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(25, 25);
            this.button_3.TabIndex = 2;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            // 
            // button_4
            // 
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_4.ForeColor = System.Drawing.Color.Black;
            this.button_4.Location = new System.Drawing.Point(122, 26);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(25, 25);
            this.button_4.TabIndex = 3;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            // 
            // button_5
            // 
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_5.ForeColor = System.Drawing.Color.Black;
            this.button_5.Location = new System.Drawing.Point(158, 26);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(25, 25);
            this.button_5.TabIndex = 4;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_location.Location = new System.Drawing.Point(71, 80);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(57, 30);
            this.label_location.TabIndex = 5;
            this.label_location.Text = "충북";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "82건/총1000건";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_center);
            this.Controls.Add(this.button_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_center;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_location;
    }
}

