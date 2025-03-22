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
    public partial class Form08_좌석배치도 : Form
    {
        int 현재호차번호 = 1;

        // 좌석을 선택했을 때 건네줄 정보
        public Reservation 선택좌석정보;

        // 예약폼에게 받는 정보
        int 로그인회원번호;
        int 선택스케쥴번호;

        public Form08_좌석배치도(int uno, int sno)
        {
            InitializeComponent();
            로그인회원번호 = uno;
            선택스케쥴번호 = sno;
            좌석목록로딩();
        }

        private void 좌석목록로딩()
        {
            // 이미 버튼들이 있다면 초기화 
            flowLayoutPanel.Controls.Clear();

            // 현재 스케쥴 & 호차에 있는 예약 목록
            List<Reservation> 예약목록 = DatabaseHelper.GetReservationByScheduleAndCarNumber(선택스케쥴번호, 현재호차번호);

            // 버튼을 생성할 때 좌석번호에 해당하는 예약이 이미 존재하는지 확인하는 용도로 사용
            // 반복문을 사용하지 않아도 seatSet.Contains("A01") 를 사용하여 bool을 반환받는다.
            // true면 예약된 좌석번호라는 뜻이고, false면 예약되지 않았다는 뜻이다.
            HashSet<string> seatSet = new HashSet<string>();
            foreach(var 예약 in 예약목록)
            {
                seatSet.Add(예약.seat);
            }

            // 좌석 버튼 생성
            for(char c = 'A'; c <= 'E'; c++)
            {
                for(int i = 1; i <= 10; i++)
                {
                    Button button = new Button();
                    button.Size = new Size(45, 23);
                    button.BackColor = Color.White;
                    button.FlatStyle = FlatStyle.Popup;

                    if(c == 'D')
                    {
                        // D행 좌석에 Top Margin을 줘서 열차 통행로 표현
                        button.Margin = new Padding(3, 20, 3, 3);
                    }

                    string title = "";
                    title += c;
                    // 만약, 숫자가 10보다 작다면 앞에 0을 붙여서 2자리로 만들자
                    if(i < 10)
                        title += "0" + i;
                    else
                        title += i;
                    button.Text = title;

                    // 만약, 이미 예약이 되어있는 좌석이라면 비활성화
                    if(seatSet.Contains(title))
                    {
                        button.Enabled = false;
                        button.BackColor = Color.DarkGray;
                    }
                    else
                    {
                        // 람다를 활용하여 버튼을 클릭할 때 실행할 기능을 작성 (익명 함수)
                        button.Click += (s, e) =>
                        {
                            // ↓ 버튼을 클릭하면 실행이 되는 코드 ↓

                            // 새로운 예약 정보를 만들고 싶다.
                            선택좌석정보 = new Reservation();
                            // rno는 적을 필요 없다 (데이터베이스에 넣으면 자동 생성해줌)
                            선택좌석정보.uno = 로그인회원번호;
                            선택좌석정보.sno = 선택스케쥴번호;
                            선택좌석정보.carno = 현재호차번호;
                            선택좌석정보.seat = button.Text;

                            // 예약폼에 선택을 완료했다는 신호을 보내고 폼을 종료하고 싶다.
                            DialogResult = DialogResult.OK;
                            Close();
                        };
                    }

                    // 버튼을 Panel에 추가한다.
                    flowLayoutPanel.Controls.Add(button);
                }
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            현재호차번호--;
            if(현재호차번호 == 1)
            {
                // 버튼을 누르지 못하게 막는다
                button_left.Enabled = false;
                // 버튼을 숨긴다
                button_left.Visible = false;
                label_left.Visible = false;
            }

            // 오른쪽 버튼을 누를 수 있게 한다
            button_right.Enabled = true;
            // 오른쪽 버튼을 표시한다
            button_right.Visible = true;
            label_right.Visible = true;

            // 좌우 버튼 텍스트를 변경한다
            label_top.Text = 현재호차번호 + "호차";
            button_left.Text = (현재호차번호 - 1).ToString();
            button_right.Text = (현재호차번호 + 1).ToString();

            좌석목록로딩();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            현재호차번호++;
            if(현재호차번호 == 5)
            {
                // 버튼을 누르지 못하게 막는다
                button_right.Enabled = false;
                // 버튼을 숨긴다
                button_right.Visible = false;
                label_right.Visible = false;
            }

            // 왼쪽 버튼을 누를 수 있게 한다
            button_left.Enabled = true;
            // 왼쪽 버튼을 표시한다
            button_left.Visible = true;
            label_left.Visible = true;

            // 상단 텍스트와 좌우 버튼 텍스트를 변경한다
            label_top.Text = 현재호차번호 + "호차";
            button_left.Text = (현재호차번호 - 1).ToString();
            button_right.Text = (현재호차번호 + 1).ToString();

            좌석목록로딩();
        }
    }
}
