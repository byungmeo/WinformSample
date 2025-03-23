namespace WindowsFormsApp1
{
    partial class UserControl_예약정보
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
            this.label_rno = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label_startLocationName = new System.Windows.Forms.Label();
            this.label_destinationLocationName = new System.Windows.Forms.Label();
            this.label_pee = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.label_arriveTime = new System.Windows.Forms.Label();
            this.label_carno = new System.Windows.Forms.Label();
            this.label_seat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_rno
            // 
            this.label_rno.AutoSize = true;
            this.label_rno.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_rno.Location = new System.Drawing.Point(16, 21);
            this.label_rno.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_rno.Name = "label_rno";
            this.label_rno.Size = new System.Drawing.Size(42, 19);
            this.label_rno.TabIndex = 9;
            this.label_rno.Text = "424";
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_day.Location = new System.Drawing.Point(81, 21);
            this.label_day.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(51, 19);
            this.label_day.TabIndex = 10;
            this.label_day.Text = "14일";
            // 
            // label_startLocationName
            // 
            this.label_startLocationName.AutoSize = true;
            this.label_startLocationName.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_startLocationName.Location = new System.Drawing.Point(155, 21);
            this.label_startLocationName.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_startLocationName.Name = "label_startLocationName";
            this.label_startLocationName.Size = new System.Drawing.Size(49, 19);
            this.label_startLocationName.TabIndex = 11;
            this.label_startLocationName.Text = "충북";
            // 
            // label_destinationLocationName
            // 
            this.label_destinationLocationName.AutoSize = true;
            this.label_destinationLocationName.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_destinationLocationName.Location = new System.Drawing.Point(227, 21);
            this.label_destinationLocationName.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_destinationLocationName.Name = "label_destinationLocationName";
            this.label_destinationLocationName.Size = new System.Drawing.Size(49, 19);
            this.label_destinationLocationName.TabIndex = 12;
            this.label_destinationLocationName.Text = "부산";
            // 
            // label_pee
            // 
            this.label_pee.AutoSize = true;
            this.label_pee.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_pee.Location = new System.Drawing.Point(299, 21);
            this.label_pee.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_pee.Name = "label_pee";
            this.label_pee.Size = new System.Drawing.Size(71, 19);
            this.label_pee.TabIndex = 13;
            this.label_pee.Text = "10,400";
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_startTime.Location = new System.Drawing.Point(393, 21);
            this.label_startTime.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(60, 19);
            this.label_startTime.TabIndex = 14;
            this.label_startTime.Text = "16:33";
            // 
            // label_arriveTime
            // 
            this.label_arriveTime.AutoSize = true;
            this.label_arriveTime.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_arriveTime.Location = new System.Drawing.Point(476, 21);
            this.label_arriveTime.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_arriveTime.Name = "label_arriveTime";
            this.label_arriveTime.Size = new System.Drawing.Size(60, 19);
            this.label_arriveTime.TabIndex = 15;
            this.label_arriveTime.Text = "17:53";
            // 
            // label_carno
            // 
            this.label_carno.AutoSize = true;
            this.label_carno.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_carno.Location = new System.Drawing.Point(559, 21);
            this.label_carno.Margin = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.label_carno.Name = "label_carno";
            this.label_carno.Size = new System.Drawing.Size(20, 19);
            this.label_carno.TabIndex = 16;
            this.label_carno.Text = "1";
            // 
            // label_seat
            // 
            this.label_seat.AutoSize = true;
            this.label_seat.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_seat.Location = new System.Drawing.Point(602, 21);
            this.label_seat.Margin = new System.Windows.Forms.Padding(0);
            this.label_seat.Name = "label_seat";
            this.label_seat.Size = new System.Drawing.Size(44, 19);
            this.label_seat.TabIndex = 17;
            this.label_seat.Text = "A04";
            // 
            // UserControl_예약정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_rno);
            this.Controls.Add(this.label_day);
            this.Controls.Add(this.label_startLocationName);
            this.Controls.Add(this.label_destinationLocationName);
            this.Controls.Add(this.label_pee);
            this.Controls.Add(this.label_startTime);
            this.Controls.Add(this.label_arriveTime);
            this.Controls.Add(this.label_carno);
            this.Controls.Add(this.label_seat);
            this.Name = "UserControl_예약정보";
            this.Size = new System.Drawing.Size(666, 61);
            this.MouseEnter += new System.EventHandler(this.UserControl_예약정보_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControl_예약정보_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rno;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label_startLocationName;
        private System.Windows.Forms.Label label_destinationLocationName;
        private System.Windows.Forms.Label label_pee;
        private System.Windows.Forms.Label label_startTime;
        private System.Windows.Forms.Label label_arriveTime;
        private System.Windows.Forms.Label label_carno;
        private System.Windows.Forms.Label label_seat;
    }
}
