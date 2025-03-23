using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form04_예매 : Form
    {
        // 폼이 시작될 때 어떤 회원이 예약을 하는지 알고 싶다.
        User user = null;
        int 나이;

        // 출발지와 도착지 등을 저장할 변수를 만들어둔다.
        string 출발지명 = "";
        int 출발지번호;
        string 도착지명 = "";
        int 도착지번호;

        int 금액;
        public int 최종금액;
        public Schedule 선택스케줄 = null;
        public TimeSpan 도착시간;
        public Reservation 최종예매정보 = null;
        public Form04_예매(User user, int 나이)
        {
            InitializeComponent();
            this.user = user;
            this.나이 = 나이;
        }

        private void button_출발지_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            Form05_지역선택 formSelect = new Form05_지역선택(true, "");
            DialogResult dr = formSelect.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                button_출발지.Text = formSelect.선택지역명;
                출발지명 = formSelect.선택지역명;
                출발지번호 = formSelect.선택지역번호;
            }
            this.Visible = true;

            출발지선택후초기화();
        }
        void 출발지선택후초기화()
        {
            선택스케줄 = null;
            최종예매정보 = null;
            도착지명 = "";

            button_도착지.Text = "도착지 선택>";
            textBox_날짜.Text = "";
            textBox_출발시간.Text = "";
            textBox_도착시간.Text = "";
            textBox_호차.Text = "";
            textBox_좌석.Text = "";
            textBox_할인.Text = "";
            textBox_금액.Text = "";
        }

        private void button_도착지_Click(object sender, System.EventArgs e)
        {
            if(출발지명 == "")
            {
                MessageBox.Show("먼저 출발지를 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            this.Visible = false;
            Form05_지역선택 formSelect = new Form05_지역선택(false, 출발지명);
            DialogResult dr = formSelect.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                button_도착지.Text = formSelect.선택지역명;
                도착지명 = formSelect.선택지역명;
                도착지번호 = formSelect.선택지역번호;
            }
            this.Visible = true;

            도착지선택후초기화();
        }

        void 도착지선택후초기화()
        {
            선택스케줄 = null;
            최종예매정보 = null;
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
            금액 = 5000 + Math.Abs(출발지번호 - 도착지번호) * 1000;

            최종금액 = 금액;
            // 연령별 할인율 적용 (값이 예상과 다르게 뜬다면 소수점 올림/내림/반올림 처리를 해야 할 수도 있습니다.)
            if(나이 >= 19)
            {
                // 할인율 0%
            }
            else if(나이 >= 13)
            {
                // 할인율 20% (1.0 - 0.2)
                최종금액 = (int)(금액 * 0.8);
            }
            else if(나이 >= 5)
            {
                // 할인율 40% (1.0 - 0.4)
                최종금액 = (int)(금액 * 0.6);
            }
            else
            {
                // 할인율 100%
                최종금액 = 0;
            }

            this.Visible = false;
            Form06_달력 formCalendar = new Form06_달력(출발지명, 출발지번호, 도착지명, 도착지번호, 금액);
            DialogResult dr = formCalendar.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                선택스케줄 = formCalendar.선택스케줄;
                textBox_날짜.Text = 선택스케줄.date.ToShortDateString();
                textBox_출발시간.Text = 선택스케줄.time.ToString();
                도착시간 = formCalendar.도착시간;
                textBox_도착시간.Text = 도착시간.ToString();
            }
            this.Visible = true;

            // 스케줄이 바뀌면 선택좌석정보를 초기화
            최종예매정보 = null;
            textBox_호차.Text = "";
            textBox_좌석.Text = "";
            textBox_할인.Text = "";
            textBox_금액.Text = "";
        }

        private void pictureBox_좌석배치도_Click(object sender, EventArgs e)
        {
            if(출발지명 == "" || 도착지명 == "")
            {
                MessageBox.Show("먼저 출발지와 도착지를 모두 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(선택스케줄 == null)
            {
                MessageBox.Show("먼저 운행스케줄을 조회해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            this.Visible = false;
            Form08_좌석배치도 formSeat = new Form08_좌석배치도(user.uno, 선택스케줄.sno);
            DialogResult dr = formSeat.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                최종예매정보 = formSeat.최종예매정보;
                textBox_호차.Text = 최종예매정보.carno.ToString();
                textBox_좌석.Text = 최종예매정보.seat;
            }
            this.Visible = true;

            // 모든 정보가 입력되면 금액 입력
            textBox_할인.Text = "-" + (금액-최종금액).ToString();
            textBox_금액.Text = 금액.ToString() + "원";
        }

        private void button_예매_Click(object sender, EventArgs e)
        {
            // 선택좌석정보가 null이라는 것은 빈칸이 있다는 뜻
            if(최종예매정보 == null)
            {
                MessageBox.Show("선택하지 않은 항목이 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DatabaseHelper.예매(최종예매정보);
            MessageBox.Show("예매가 완료되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
