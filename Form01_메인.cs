using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form01_메인 : Form
    {
        // 현재 로그인이 되어 있는 상태인지 저장하고 싶다.
        bool isLoogedIn = false;
        // 현재 로그인이 되어있다면 회원 정보를 저장하고 싶다.
        User user = null;

        public Form01_메인()
        {
            InitializeComponent();

            // 1. 예약현황테이블의 도착지가 가장 많은 1~5위의 지역이미지와 예약 건수를 알고 싶다.
            // 2. 처음에 가장 높은 순위의 지역 이미지와 예약 건수를 띄우고 샆다.
            // 3. 1초마다 자동으로 다음 순위의 지역 이미지와 예약 건수를 띄우고 싶다.
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            if(isLoogedIn == false)
            {
                // 로그인이 되어있지 않다면 로그인 폼으로 이동하고 싶다.
                this.Visible = false;
                Form02_로그인 formLogin = new Form02_로그인();
                DialogResult result = formLogin.ShowDialog(this);
                if(result == DialogResult.OK)
                {
                    button_left.Text = "회원 메뉴";
                    button_center.Text = "로그아웃";
                    // 만약, 로그인에 성공했다면, 바로 회원메뉴 폼으로 이동하고 싶다.
                    user = formLogin.user;
                    isLoogedIn = true;
                    this.Visible = false;
                    Form03_회원메뉴 formUserMenu = new Form03_회원메뉴(user);
                    formUserMenu.ShowDialog(this);
                    this.Visible = true;
                }
                this.Visible = true;
            }
            else
            {
                // 로그인이 되어있다면 회원메뉴 폼으로 이동하고 싶다.
                this.Visible = false;
                Form03_회원메뉴 formUserMenu = new Form03_회원메뉴(user);
                formUserMenu.ShowDialog(this);
                this.Visible = true;
            }
        }

        private void button_center_Click(object sender, EventArgs e)
        {
            if(isLoogedIn == false)
            {
                // 로그인이 되어있지 않다면 관리자 로그인 폼으로 이동하고 싶다.
                this.Visible = false;
                Form10_관리자로그인 formLoginManager = new Form10_관리자로그인();
                DialogResult result = formLoginManager.ShowDialog(this);
                this.Visible = true;
            }
            else
            {
                // 로그인이 되어있다면 로그아웃 처리를 하고 싶다.
                isLoogedIn = false;
                button_left.Text = "로그인";
                button_center.Text = "관리자";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
