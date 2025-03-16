using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormReservation : Form
    {
        // 폼이 시작될 때 어떤 회원이 예약을 하는지 알고 싶다.
        User user = null;
        int 나이;

        // 출발지와 도착지 등을 저장할 변수를 만들어둔다.
        string 출발지명 = "";
        int 출발지번호;
        string 도착지명 = "";
        int 도착지번호;

        public FormReservation(User user, int 나이)
        {
            InitializeComponent();
            this.user = user;
            this.나이 = 나이;
        }

        private void button_출발지_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            FormSelect formSelect = new FormSelect(true, "");
            DialogResult dr = formSelect.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                button_출발지.Text = formSelect.선택지역명;
                출발지명 = formSelect.선택지역명;
                출발지번호 = formSelect.선택지역번호;
            }
            this.Visible = true;

            항목초기화();
        }

        private void button_도착지_Click(object sender, System.EventArgs e)
        {
            if(출발지명 == "")
            {
                MessageBox.Show("먼저 출발지를 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            this.Visible = false;
            FormSelect formSelect = new FormSelect(false, 출발지명);
            DialogResult dr = formSelect.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                button_도착지.Text = formSelect.선택지역명;
                도착지명 = formSelect.선택지역명;
                도착지번호 = formSelect.선택지역번호;
            }
            this.Visible = true;

            항목초기화();
        }

        void 항목초기화()
        {
            textBox_날짜.Text = "";
            textBox_출발시간.Text = "";
            textBox_도착시간.Text = "";
            textBox_호차.Text = "";
            textBox_좌석.Text = "";
            textBox_할인.Text = "";
            textBox_금액.Text = "";
        }

        private void pictureBox_달력_Click(object sender, EventArgs e)
        {
            if(출발지명 == "" || 도착지명 == "")
            {
                MessageBox.Show("먼저 출발지와 도착지를 모두 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 열차 예매 금액은 ‘기본 요금 5000원 + 출발지와 도착지의 거리(번호 차이)*1000원’이다.
            // Math.Abs : 절대값(번호 차이)을 구하는 함수
            int 금액 = 5000 + Math.Abs(출발지번호 * 도착지번호);
            // 연령별 할인율 적용 (값이 예상과 다르게 뜬다면 소수점 올림/내림/반올림 처리를 해야 할 수도 있습니다.)
            if(나이 >= 19)
            {
                // 할인율 0%
            }
            else if(나이 >= 13)
            {
                // 할인율 20% (1.0 - 0.2)
                금액 = (int)(금액 * 0.8);
            }
            else if(나이 >= 5)
            {
                // 할인율 40% (1.0 - 0.4)
                금액 = (int)(금액 * 0.6);
            }
            else
            {
                // 할인율 100%
                금액 = 0;
            }


            this.Visible = false;
            FormCalendar formCalendar = new FormCalendar(출발지명, 출발지번호, 도착지명, 도착지번호, 금액);
            DialogResult dr = formCalendar.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                textBox_날짜.Text = formCalendar.선택날짜.ToShortDateString();
                textBox_출발시간.Text = formCalendar.출발시간.ToString();
                textBox_도착시간.Text = formCalendar.도착시간.ToString();
            }
            this.Visible = true;
        }
    }
}
