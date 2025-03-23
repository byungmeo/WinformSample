using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form09_마이페이지 : Form
    {
        // 폼이 시작될 때 어떤 회원이 예약을 하는지 알고 싶다.
        User user = null;

        List<Schedule> 스케줄목록;
        List<Reservation> 예약현황목록;

        // 운항스케줄번호로 스케줄을 찾을 수 있다.
        // <sno, 운행스케줄정보>
        Dictionary<int, Schedule> 스케줄Dic = new Dictionary<int, Schedule>();

        // 선택월에 해당하는 예약 리스트를 찾을 수 있다.
        // 사용예시) List<Reservation> 나의4월예약목록 = 월별예약현황[4];
        Dictionary<int, List<Reservation>> 월별예약현황 = new Dictionary<int, List<Reservation>>();

        string[] 지역목록 = { "강원", "경기", "경남", "경북", "광주", "대구", "대전", "부산", "서울", "세종", "울산", "인천", "전남", "전북", "충남", "충북" };

        int 선택월 = DateTime.Now.Month;
        FlowLayoutPanel BeforeSelectedPanel = null;

        public Form09_마이페이지(User user)
        {
            InitializeComponent();
            this.user = user;
            label_회원정보.Text = $"{user.name}  [{연령명계산(user.birth)}]";
            label_month.Text = $"{선택월}월";

            스케줄목록 = DatabaseHelper.GetScheduleAll();
            foreach(var 스케줄정보 in 스케줄목록)
            {
                스케줄Dic.Add(스케줄정보.sno, 스케줄정보);
            }

            for(int m = 1; m <= 12; m++)
            {
                월별예약현황.Add(m, new List<Reservation>());
            }

            예약현황목록 = DatabaseHelper.GetReservationByUno(user.uno);
            foreach(var 예약정보 in 예약현황목록)
            {
                int sno = 예약정보.sno;
                int month = 스케줄Dic[sno].date.Month;
                월별예약현황[month].Add(예약정보);
            }
            foreach(var item in 월별예약현황)
            {
                List<Reservation> list = item.Value;
                // 예약A와 예약B가 있을 때 어떤걸 먼저 나타나게 하고 싶나?
                // 예약A의 일자와 예약B의 일자 중 A의 일자가 더 작으면 먼저 뜨게 한다 (예약A의 일자 - 예약B의 일자) = 오름차순
                // 내림차순을 원한다면 반대로 B - A를 하면 된다.
                list.Sort((예약A, 예약B) => { return 스케줄Dic[예약A.sno].date.Day - 스케줄Dic[예약B.sno].date.Day; });
            }
            예약현황불러오기();
        }

        private void 예약현황불러오기()
        {
            flowLayoutPanel.Controls.Clear();

            // 이미 오름차순 정렬 된 상태
            int 합계 = 0;
            List<Reservation> 선택월예약목록 = 월별예약현황[선택월];
            foreach(var 예약정보 in 선택월예약목록)
            {
                Schedule 스케줄 = 스케줄Dic[예약정보.sno];

                int rno = 예약정보.rno;
                int day = 스케줄.date.Day;
                string startLocationName = 지역목록[스케줄.starting - 1];
                string destinationLocationName = 지역목록[스케줄.destination - 1];
                TimeSpan startTime = 스케줄.time;
                TimeSpan arriveTime = 도착시간계산(startTime, 스케줄.starting, 스케줄.destination);
                int carno = 예약정보.carno;
                string seat = 예약정보.seat;
                UserControl_예약정보 userControl = new UserControl_예약정보(rno, day, startLocationName, destinationLocationName, startTime, arriveTime, carno, seat);
                flowLayoutPanel.Controls.Add(userControl);

                합계 += 금액계산(스케줄.starting, 스케줄.destination, user.birth);
            }
            label_예약건수.Text = $"총 예약 건수:  {선택월예약목록.Count}건";
            label_합계.Text = $"총 합계:  {합계:#,##0}";
        }

        private void button_left_Click(object sender, System.EventArgs e)
        {
            선택월--;
            if(선택월 <= 0)
            {
                선택월 = 12;
            }
            label_month.Text = $"{선택월}월";
            예약현황불러오기();
        }

        private void button_right_Click(object sender, System.EventArgs e)
        {
            선택월++;
            if(선택월 > 12)
            {
                선택월 = 1;
            }
            label_month.Text = $"{선택월}월";
            예약현황불러오기();
        }

        private void flowLayoutPanel_Click(object sender, System.EventArgs e)
        {
            FlowLayoutPanel SelectedPanel = (FlowLayoutPanel)sender;
            if(SelectedPanel != BeforeSelectedPanel)
            {
                if(BeforeSelectedPanel != null)
                {
                    BeforeSelectedPanel.BackColor = Color.White;
                }
                SelectedPanel.BackColor = SystemColors.ScrollBar;
                BeforeSelectedPanel = SelectedPanel;
            }
        }

        public string 연령명계산(DateTime birth)
        {
            int 현재연도 = DateTime.Now.Year;
            int 유저생일연도 = birth.Year;
            int 나이 = 현재연도 - 유저생일연도;
            if(나이 >= 19)
            {
                return "성인";
            }
            else if(나이 >= 13)
            {
                return "청소년";
            }
            else if(나이 >= 5)
            {
                return "어린이";
            }
            else
            {
                return "유아";
            }
        }

        public TimeSpan 도착시간계산(TimeSpan startTime, int starting, int destination)
        {
            // 도착 시간은 ‘출발 시간 + 출발지와 도착지의 거리(번호 차이)*10분’이다.
            // 걸리는 시간(분) = 10 * 절대값(출발지 번호 – 도착지 번호)
            int 차이 = 10 * Math.Abs(starting - destination);

            // 예시: 130분일 경우 -> 2시간 10분
            // 130 / 60 = 2, 130 % 60 = 10
            TimeSpan addTime = new TimeSpan(차이 / 60, 차이 % 60, 0);

            // 23:00일 때 2시간 추가하면 01:00이 되어야 하는데,
            // TimeSpan에서 24시간을 넘어가면 1.01:00과 같이 표시되어버린다.
            // 그래서 임시 DateTime을 만들어서 시간을 더해주는 것이다.
            DateTime 도착시간 = new DateTime(1, 1, 1, startTime.Hours, startTime.Minutes, 0);
            도착시간 = 도착시간.Add(addTime);

            return 도착시간.TimeOfDay;
        }

        public int 금액계산(int starting, int destination, DateTime birth)
        {
            // 열차 예매 금액은 ‘기본 요금 5000원 + 출발지와 도착지의 거리(번호 차이)*1000원’이다.
            // Math.Abs : 절대값(번호 차이)을 구하는 함수
            int 금액 = 5000 + Math.Abs(starting - destination) * 1000;

            int 최종금액 = 금액;

            // 연령별 할인율 적용 (값이 예상과 다르게 뜬다면 소수점 올림/내림/반올림 처리를 해야 할 수도 있습니다.)
            int 현재연도 = DateTime.Now.Year;
            int 유저생일연도 = birth.Year;
            int 나이 = 현재연도 - 유저생일연도;
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

            return 최종금액;
        }
    }
}
