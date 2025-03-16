using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form운행리스트 : Form
    {
        public TimeSpan 선택출발시간;
        public TimeSpan 선택도착시간;

        public Form운행리스트(DateTime 선택날짜, string 출발지명, int 출발지번호, string 도착지명, int 도착지번호, int 금액)
        {
            InitializeComponent();

            label_top.Text = $"출발지: {출발지명} → 도착지: {도착지명}    금액:{금액:#,##0}원";

            List<Schedule> scheduleList = DatabaseHelper.GetScheduleByDateAndLocation(선택날짜, 출발지번호, 도착지번호);

            // 출발 시간에 대한 오름차순 정렬
            // 람다식을 사용 (두 날짜 a, b가 있을 때 a.time이 b.time보다 작으면 앞에, 크면 뒤에 배치)
            scheduleList.Sort((a, b) => a.time.CompareTo(b.time));

            int no = 1;
            foreach(Schedule schedule in scheduleList)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(no++.ToString());
                item.SubItems.Add(schedule.date.ToShortDateString());
                item.SubItems.Add(schedule.time.ToString());

                // 도착 시간은 ‘출발 시간 + 출발지와 도착지의 거리(번호 차이)*10분’이다.
                // 걸리는 시간(분) = 10 * 절대값(출발지 번호 – 도착지 번호)
                int 차이 = 10 * Math.Abs(schedule.starting - schedule.destination);

                // 예시: 130분일 경우 -> 2시간 10분
                // 130 / 60 = 2, 130 % 60 = 10
                TimeSpan addTime = new TimeSpan(차이 / 60, 차이 % 60, 0);

                // 23:00일 때 2시간 추가하면 01:00이 되어야 하는데,
                // TimeSpan에서 24시간을 넘어가면 1.01:00과 같이 표시되어버린다.
                // 그래서 임시 DateTime을 만들어서 시간을 더해주는 것이다.
                DateTime 도착시간 = new DateTime(1, 1, 1, schedule.time.Hours, schedule.time.Minutes, 0);
                도착시간 = 도착시간.Add(addTime);

                // TimeOfDay : DateTime에서 오직 시간(TimeSpan)만 가져온다.
                item.SubItems.Add(도착시간.TimeOfDay.ToString());

                listView1.Items.Add(item);
            }

            // 번호가 1인 일정이 선택되어 나타나도록 하시오.
            if(listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
        }

        private void button_선택_Click(object sender, EventArgs e)
        {
            // TimeSpan.Parse : string으로 되어있는 데이터를 TimeSpan으로 변환
            // SelectedItems[0] : listView에서 선택한 항목 중 첫 번째 항목 (어차피 하나만 선택 가능)
            // SubItems[3] : 4번째 열(출발시간)의 데이터 (0부터 시작)
            // 4번째 열이 출발시간인 이유는 텍스트 정렬 문제로 0번째 열에 임시 열을 하나 끼워두었기 때문
            선택출발시간 = TimeSpan.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            선택도착시간 = TimeSpan.Parse(listView1.SelectedItems[0].SubItems[4].Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
