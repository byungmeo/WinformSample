using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCalendar : Form
    {
        public DateTime 선택날짜;
        public TimeSpan 출발시간;
        public TimeSpan 도착시간;

        // 운행리스트폼에서 사용할 수 있도록 저장
        string 출발지명;
        int 출발지번호;
        string 도착지명;
        int 도착지번호;
        int 금액;

        public FormCalendar(string 출발지명, int 출발지번호, string 도착지명, int 도착지번호, int 금액)
        {
            InitializeComponent();
            this.출발지명 = 출발지명;
            this.출발지번호 = 출발지번호;
            this.도착지명 = 도착지명;
            this.도착지번호 = 도착지번호;
            this.금액 = 금액;

            // 하나만 선택 가능
            monthCalendar1.MaxSelectionCount = 1;
            // 오늘 날짜로 일단 선택해놓음
            monthCalendar1.SelectionRange.Start = DateTime.Now;
            monthCalendar1.SelectionRange.End = DateTime.Now;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(e.Start < DateTime.Now)
            {
                MessageBox.Show("이전 날짜는 선택할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            선택날짜 = e.Start;

            this.Visible = false;
            Form운행리스트 form운행리스트 = new Form운행리스트(선택날짜, 출발지명, 출발지번호, 도착지명, 도착지번호, 금액);
            DialogResult dr = form운행리스트.ShowDialog(this);
            if(dr == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                출발시간 = form운행리스트.선택출발시간;
                도착시간 = form운행리스트.선택도착시간;
            }
            this.Visible = true;
            Close();
        }
    }
}
