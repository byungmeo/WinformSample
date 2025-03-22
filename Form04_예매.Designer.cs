namespace WindowsFormsApp1
{
    partial class Form04_예매
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form04_예매));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_도착지 = new System.Windows.Forms.Button();
            this.button_출발지 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_날짜 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_도착시간 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_출발시간 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_달력 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_좌석 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_호차 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox_좌석배치도 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_할인 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_금액 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button_예매 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_달력)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_좌석배치도)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_도착지);
            this.panel1.Controls.Add(this.button_출발지);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(15, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 49);
            this.panel1.TabIndex = 0;
            // 
            // button_도착지
            // 
            this.button_도착지.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_도착지.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_도착지.ForeColor = System.Drawing.Color.Gray;
            this.button_도착지.Location = new System.Drawing.Point(346, 12);
            this.button_도착지.Name = "button_도착지";
            this.button_도착지.Size = new System.Drawing.Size(112, 23);
            this.button_도착지.TabIndex = 3;
            this.button_도착지.Text = "도착지 선택>";
            this.button_도착지.UseVisualStyleBackColor = true;
            this.button_도착지.Click += new System.EventHandler(this.button_도착지_Click);
            // 
            // button_출발지
            // 
            this.button_출발지.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_출발지.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_출발지.ForeColor = System.Drawing.Color.Gray;
            this.button_출발지.Location = new System.Drawing.Point(117, 12);
            this.button_출발지.Name = "button_출발지";
            this.button_출발지.Size = new System.Drawing.Size(112, 23);
            this.button_출발지.TabIndex = 2;
            this.button_출발지.Text = "출발지 선택>";
            this.button_출발지.UseVisualStyleBackColor = true;
            this.button_출발지.Click += new System.EventHandler(this.button_출발지_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(248, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "도착지";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "출발지";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 8);
            this.label4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 8);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 8);
            this.label2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 75);
            this.label1.TabIndex = 16;
            this.label1.Text = "Let\'s corail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_날짜);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox_도착시간);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_출발시간);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox_달력);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(15, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 91);
            this.panel2.TabIndex = 4;
            // 
            // textBox_날짜
            // 
            this.textBox_날짜.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_날짜.Location = new System.Drawing.Point(346, 14);
            this.textBox_날짜.Name = "textBox_날짜";
            this.textBox_날짜.ReadOnly = true;
            this.textBox_날짜.Size = new System.Drawing.Size(114, 21);
            this.textBox_날짜.TabIndex = 8;
            this.textBox_날짜.TabStop = false;
            this.textBox_날짜.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(248, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "날짜";
            // 
            // textBox_도착시간
            // 
            this.textBox_도착시간.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_도착시간.Location = new System.Drawing.Point(346, 50);
            this.textBox_도착시간.Name = "textBox_도착시간";
            this.textBox_도착시간.ReadOnly = true;
            this.textBox_도착시간.Size = new System.Drawing.Size(114, 21);
            this.textBox_도착시간.TabIndex = 6;
            this.textBox_도착시간.TabStop = false;
            this.textBox_도착시간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(248, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "도착시간";
            // 
            // textBox_출발시간
            // 
            this.textBox_출발시간.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_출발시간.Location = new System.Drawing.Point(117, 50);
            this.textBox_출발시간.Name = "textBox_출발시간";
            this.textBox_출발시간.ReadOnly = true;
            this.textBox_출발시간.Size = new System.Drawing.Size(114, 21);
            this.textBox_출발시간.TabIndex = 4;
            this.textBox_출발시간.TabStop = false;
            this.textBox_출발시간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(16, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "출발시간";
            // 
            // pictureBox_달력
            // 
            this.pictureBox_달력.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_달력.Image")));
            this.pictureBox_달력.Location = new System.Drawing.Point(196, 9);
            this.pictureBox_달력.Name = "pictureBox_달력";
            this.pictureBox_달력.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_달력.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_달력.TabIndex = 2;
            this.pictureBox_달력.TabStop = false;
            this.pictureBox_달력.Click += new System.EventHandler(this.pictureBox_달력_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(114, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "조회하기>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "운행스케줄";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_좌석);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox_호차);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.pictureBox_좌석배치도);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(15, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 91);
            this.panel3.TabIndex = 4;
            // 
            // textBox_좌석
            // 
            this.textBox_좌석.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_좌석.Location = new System.Drawing.Point(346, 50);
            this.textBox_좌석.Name = "textBox_좌석";
            this.textBox_좌석.ReadOnly = true;
            this.textBox_좌석.Size = new System.Drawing.Size(114, 21);
            this.textBox_좌석.TabIndex = 6;
            this.textBox_좌석.TabStop = false;
            this.textBox_좌석.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(248, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "좌석";
            // 
            // textBox_호차
            // 
            this.textBox_호차.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_호차.Location = new System.Drawing.Point(117, 50);
            this.textBox_호차.Name = "textBox_호차";
            this.textBox_호차.ReadOnly = true;
            this.textBox_호차.Size = new System.Drawing.Size(114, 21);
            this.textBox_호차.TabIndex = 4;
            this.textBox_호차.TabStop = false;
            this.textBox_호차.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(16, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "호차";
            // 
            // pictureBox_좌석배치도
            // 
            this.pictureBox_좌석배치도.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_좌석배치도.Image")));
            this.pictureBox_좌석배치도.Location = new System.Drawing.Point(196, 9);
            this.pictureBox_좌석배치도.Name = "pictureBox_좌석배치도";
            this.pictureBox_좌석배치도.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_좌석배치도.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_좌석배치도.TabIndex = 2;
            this.pictureBox_좌석배치도.TabStop = false;
            this.pictureBox_좌석배치도.Click += new System.EventHandler(this.pictureBox_좌석배치도_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(114, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "조회하기>";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(16, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "좌석배치도";
            // 
            // textBox_할인
            // 
            this.textBox_할인.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_할인.Location = new System.Drawing.Point(194, 347);
            this.textBox_할인.Name = "textBox_할인";
            this.textBox_할인.ReadOnly = true;
            this.textBox_할인.Size = new System.Drawing.Size(114, 21);
            this.textBox_할인.TabIndex = 10;
            this.textBox_할인.TabStop = false;
            this.textBox_할인.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(147, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "할인";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(314, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "원";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(315, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "원";
            // 
            // textBox_금액
            // 
            this.textBox_금액.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_금액.Location = new System.Drawing.Point(195, 374);
            this.textBox_금액.Name = "textBox_금액";
            this.textBox_금액.ReadOnly = true;
            this.textBox_금액.Size = new System.Drawing.Size(114, 21);
            this.textBox_금액.TabIndex = 22;
            this.textBox_금액.TabStop = false;
            this.textBox_금액.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(148, 375);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "금액";
            // 
            // button_예매
            // 
            this.button_예매.BackColor = System.Drawing.Color.Blue;
            this.button_예매.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_예매.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_예매.ForeColor = System.Drawing.Color.White;
            this.button_예매.Location = new System.Drawing.Point(150, 407);
            this.button_예매.Name = "button_예매";
            this.button_예매.Size = new System.Drawing.Size(188, 29);
            this.button_예매.TabIndex = 24;
            this.button_예매.Text = "예매";
            this.button_예매.UseVisualStyleBackColor = false;
            this.button_예매.Click += new System.EventHandler(this.button_예매_Click);
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 448);
            this.Controls.Add(this.button_예매);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_금액);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_할인);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "예매";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_달력)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_좌석배치도)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_출발지;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_도착지;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_달력;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_날짜;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_도착시간;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_출발시간;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_좌석;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_호차;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox_좌석배치도;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_할인;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_금액;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_예매;
    }
}