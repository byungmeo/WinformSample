namespace WindowsFormsApp1
{
    partial class UserControl_회원정보
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_연령 = new System.Windows.Forms.Label();
            this.label_이름 = new System.Windows.Forms.Label();
            this.label_아이디 = new System.Windows.Forms.Label();
            this.label_생년월일 = new System.Windows.Forms.Label();
            this.label_전화번호 = new System.Windows.Forms.Label();
            this.label_이메일 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_연령
            // 
            this.label_연령.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_연령.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_연령.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_연령.Location = new System.Drawing.Point(0, 0);
            this.label_연령.Name = "label_연령";
            this.label_연령.Size = new System.Drawing.Size(77, 104);
            this.label_연령.TabIndex = 0;
            this.label_연령.Text = "청소년";
            this.label_연령.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_이름
            // 
            this.label_이름.AutoSize = true;
            this.label_이름.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_이름.Location = new System.Drawing.Point(101, 13);
            this.label_이름.Name = "label_이름";
            this.label_이름.Size = new System.Drawing.Size(58, 16);
            this.label_이름.TabIndex = 1;
            this.label_이름.Text = "강나희";
            // 
            // label_아이디
            // 
            this.label_아이디.AutoSize = true;
            this.label_아이디.Font = new System.Drawing.Font("굴림", 10F);
            this.label_아이디.Location = new System.Drawing.Point(101, 37);
            this.label_아이디.Name = "label_아이디";
            this.label_아이디.Size = new System.Drawing.Size(51, 14);
            this.label_아이디.TabIndex = 2;
            this.label_아이디.Text = "user01";
            // 
            // label_생년월일
            // 
            this.label_생년월일.AutoSize = true;
            this.label_생년월일.Font = new System.Drawing.Font("굴림", 10F);
            this.label_생년월일.Location = new System.Drawing.Point(101, 51);
            this.label_생년월일.Name = "label_생년월일";
            this.label_생년월일.Size = new System.Drawing.Size(87, 14);
            this.label_생년월일.TabIndex = 3;
            this.label_생년월일.Text = "2010-07-17";
            // 
            // label_전화번호
            // 
            this.label_전화번호.AutoSize = true;
            this.label_전화번호.Font = new System.Drawing.Font("굴림", 10F);
            this.label_전화번호.Location = new System.Drawing.Point(101, 65);
            this.label_전화번호.Name = "label_전화번호";
            this.label_전화번호.Size = new System.Drawing.Size(111, 14);
            this.label_전화번호.TabIndex = 4;
            this.label_전화번호.Text = "081-5678-2124";
            // 
            // label_이메일
            // 
            this.label_이메일.AutoSize = true;
            this.label_이메일.Font = new System.Drawing.Font("굴림", 10F);
            this.label_이메일.Location = new System.Drawing.Point(101, 79);
            this.label_이메일.Name = "label_이메일";
            this.label_이메일.Size = new System.Drawing.Size(136, 14);
            this.label_이메일.TabIndex = 5;
            this.label_이메일.Text = "yoon11@gmail.com";
            // 
            // UserControl_회원정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_이메일);
            this.Controls.Add(this.label_전화번호);
            this.Controls.Add(this.label_생년월일);
            this.Controls.Add(this.label_아이디);
            this.Controls.Add(this.label_이름);
            this.Controls.Add(this.label_연령);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserControl_회원정보";
            this.Size = new System.Drawing.Size(290, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_연령;
        private System.Windows.Forms.Label label_이름;
        private System.Windows.Forms.Label label_아이디;
        private System.Windows.Forms.Label label_생년월일;
        private System.Windows.Forms.Label label_전화번호;
        private System.Windows.Forms.Label label_이메일;
    }
}
