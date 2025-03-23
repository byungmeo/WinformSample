using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form13_분석 : Form
    {
        List<User> 전체회원목록;
        List<Schedule> 전체스케줄목록;
        List<Reservation> 전체예약목록;

        // Dictionary에 대해 자세히 알아야 합니다. (정답은 없지만 이 방법이 쉽고 편합니다)

        // 회원의 uno로 회원 정보를 찾을 수 있다.
        // <uno, 회원정보>
        // 사용 예시 : 회원Dic[1] -> 강나희 회원에 대한 정보
        Dictionary<int, User> 회원Dic = new Dictionary<int, User>();

        // 지역번호로 지역명을 찾을 수 있다.
        // <lno, 지역명>
        // 사용 예시 : 지역Dic[1] = "강원"
        Dictionary<int, string> 지역Dic = new Dictionary<int, string>();

        // 운항스케줄번호로 스케줄을 찾을 수 있다.
        // <sno, 운행스케줄정보>
        Dictionary<int, Schedule> 스케줄Dic = new Dictionary<int, Schedule>();

        // <연령, <지역, 예약건수>>
        // 사용 예시 : 연령별지역예약건수["전체"]["강원"] -> 전체연령대에서 강원지역을 출발지로 하는 예약건수(int)
        Dictionary<string, Dictionary<string, int>> 연령별지역예약건수 = new Dictionary<string, Dictionary<string, int>>();

        // <연령, 예약건수>
        // 사용 예시 : 연령별예약건수["성인"] -> 593
        Dictionary<string, int> 연령별예약건수 = new Dictionary<string, int>();

        string[] 지역목록 = { "강원", "경기", "경남", "경북", "광주", "대구", "대전", "부산", "서울", "세종", "울산", "인천", "전남", "전북", "충남", "충북" };
        string[] 연령목록 = { "전체", "성인", "청소년", "어린이", "유아" };
        Color[] 색상목록 = { Color.Blue, Color.Orange, Color.Red, Color.SkyBlue, Color.LightBlue };

        public Form13_분석()
        {
            InitializeComponent();

            전체회원목록 = DatabaseHelper.GetUserAll();
            foreach(var 회원정보 in 전체회원목록)
            {
                회원Dic.Add(회원정보.uno, 회원정보);
            }

            // 지역Dic은 굳이 DB를 거칠 필요 없이 직접 넣어도 무방함.
            for(int i = 1; i <= 지역목록.Length; i++)
            {
                // lno는 1부터 시작한다. 하지만, 배열은 0부터 시작하기 때문에 1을 빼줘야 한다.
                지역Dic.Add(i, 지역목록[i - 1]);
            }

            전체스케줄목록 = DatabaseHelper.GetScheduleAll();
            foreach(var 스케줄정보 in 전체스케줄목록)
            {
                스케줄Dic.Add(스케줄정보.sno, 스케줄정보);
            }
            
            foreach(var 연령명 in 연령목록)
            {
                comboBox_연령.Items.Add(연령명);
                연령별지역예약건수.Add(연령명, new Dictionary<string ,int>());
                foreach(var 지역명 in 지역목록)
                {
                    연령별지역예약건수[연령명].Add(지역명, 0);
                }

                연령별예약건수.Add(연령명, 0);
            }

            전체예약목록 = DatabaseHelper.GetReservationAll();
            foreach(var 예약정보 in 전체예약목록)
            {
                int uno = 예약정보.uno;
                string 연령명 = 연령명계산(회원Dic[uno].birth);
                연령별예약건수[연령명]++;

                int sno = 예약정보.sno;
                if(스케줄Dic.ContainsKey(sno) == false)
                {
                    // sno 3321부터 3399까지는 스케줄이 존재하지 않는데, 예약정보에는 sno가 3371인 데이터가 있다.
                    // 이것을 보고 이상 현상(Anomaly)으로 인해 데이터베이스의 무결성(Integrity)이 깨졌다고 한다.
                    // 과제의 의하면 Null값이 존재할 경우 무시하고 처리하라고 명시되어 있다.
                    // 따라서, 그냥 무시한다.
                    // 대회 중 "지정한 키가 사전에 없습니다." 라는 오류가 발생한다면 이런 경우일 수 있다.
                    continue;
                }
                int lno = 스케줄Dic[sno].starting;
                string 지역명 = 지역Dic[lno];
                연령별지역예약건수[연령명][지역명]++;
                연령별지역예약건수["전체"][지역명]++;
            }

            comboBox_연령.SelectedIndex = 0;
        }

        private void comboBox_연령_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chart1 != null)
            {
                Controls.Remove(chart1);
                chart1 = null;
            }
            if(chart2 != null)
            {
                Controls.Remove(chart2);
                chart2 = null;
            }

            string 연령 = comboBox_연령.Text;

            if(연령 == "전체")
            {
                // *******************************************
                // 1. 지역, 연령별 예약건수 막대차트
                // *******************************************
                chart1 = new Chart();
                chart1.Location = new Point(0, 70);
                chart1.Size = new Size(800, 160);
                Controls.Add(chart1);

                ChartArea area1 = new ChartArea();
                chart1.ChartAreas.Add(area1);

                // 범례 추가
                Legend lengend1 = new Legend("범례");
                lengend1.Docking = Docking.Bottom; // 아래에
                lengend1.Alignment = StringAlignment.Far; // 오른쪽에
                chart1.Legends.Add(lengend1);

                // 시리즈 생성 (범례 이름)
                for(int i = 0; i < 5; i++)
                {
                    Series series1 = new Series(연령목록[i]);
                    series1.ChartType = SeriesChartType.Column;
                    series1.Color = 색상목록[i];
                    chart1.Series.Add(series1);
                }

                // 지역 이름 (X축 라벨)

                // 데이터 채우기
                foreach(string 지역명 in 지역목록)
                {
                    foreach(var 연령명 in 연령목록)
                    {
                        chart1.Series[연령명].Points.AddXY(지역명, 연령별지역예약건수[연령명][지역명]);
                    }
                }

                area1.AxisY.Interval = 20; // 예약 건수는 20 간격으로
                area1.AxisX.Interval = 1; // 지역 명은 1개씩 다 뜨게 하고
                area1.AxisX.MajorGrid.Interval = 5; // 세로로 그려지는 눈금선은 5개 간격으로

                // *******************************************
                // 2. 연령대별 예약 현황 차트
                // *******************************************
                chart2 = new Chart();
                chart2.Location = new Point(0, 250);
                chart2.Size = new Size(800, 200);
                Controls.Add(chart2);

                // 차트 영역 추가
                ChartArea area2 = new ChartArea();
                chart2.ChartAreas.Add(area2);

                // 시리즈 생성 및 타입 설정
                Series series2 = new Series();
                series2.ChartType = SeriesChartType.Pie;

                // 데이터 추가 및 색상 지정 (전체는 제외)
                for(int i = 1; i < 5; i++)
                {
                    series2.Points.Add(연령별예약건수[연령목록[i]]);
                    series2.Points[i - 1].Color = 색상목록[i];
                }

                // 숫자가 표시되도록 라벨 지정
                foreach(var pt in series2.Points)
                {
                    pt.Label = pt.YValues[0].ToString(); // 숫자만 표시
                }

                chart2.Series.Add(series2);
            }


            else
            {
                // *******************************************
                // 선택연령대&지역별 예약건수 막대차트
                // *******************************************
                chart1 = new Chart();
                chart1.Location = new Point(0, 70);
                chart1.Size = new Size(800, 160);
                Controls.Add(chart1);

                ChartArea chartArea = new ChartArea();
                chart1.ChartAreas.Add(chartArea);

                // 범례 추가
                Legend 범례 = new Legend("범례");
                범례.Docking = Docking.Bottom; // 아래에
                범례.Alignment = StringAlignment.Far; // 오른쪽에
                chart1.Legends.Add(범례);

                // 시리즈 생성 (범례 이름)
                string selected연령 = comboBox_연령.Text;
                for(int i = 0; i < 5; i++)
                {
                    if(selected연령 == 연령목록[i])
                    {
                        Series series = new Series(selected연령);
                        series.ChartType = SeriesChartType.Column;
                        series.Color = 색상목록[i];
                        chart1.Series.Add(series);
                        break;
                    }
                }

                // 데이터 채우기
                foreach(string 지역명 in 지역목록)
                {
                    chart1.Series[selected연령].Points.AddXY(지역명, 연령별지역예약건수[selected연령][지역명]);
                }

                chartArea.AxisY.Interval = 20; // 예약 건수는 20 간격으로
                chartArea.AxisX.Interval = 1; // 지역 명은 1개씩 다 뜨게 하고
                chartArea.AxisX.MajorGrid.Interval = 5; // 세로로 그려지는 눈금선은 5개 간격으로
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
    }
}