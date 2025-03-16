using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormUserMenu : Form
    {
        User loginUser = null;
        int 나이;

        public FormUserMenu(User user)
        {
            InitializeComponent();
            loginUser = user;
            
            DateTime birth = loginUser.birth;
            int 현재연도 = DateTime.Now.Year;
            int 유저생일연도 = birth.Year;
            나이 = 현재연도 - 유저생일연도;
            if(나이 >= 19)
            {
                label_userName.Text = $"{loginUser.name} [{"성인"}]";
            }
            else if(나이 >= 13)
            {
                label_userName.Text = $"{loginUser.name} [{"청소년"}]";
            }
            else if(나이 >= 5)
            {
                label_userName.Text = $"{loginUser.name} [{"어린이"}]";
            }
            else
            {
                label_userName.Text = $"{loginUser.name} [{"유아"}]";
            }
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            // 열차예매 폼으로 이동하고 싶다.
            this.Visible = false;
            FormReservation formReservation = new FormReservation(loginUser, 나이);
            formReservation.ShowDialog(this);
            this.Visible = true;
        }

        private void button_myPage_Click(object sender, EventArgs e)
        {
            // 마이페이지 폼으로 이동하고 싶다.
            this.Visible = false;
            FormMyPage formMyPage = new FormMyPage(loginUser);
            formMyPage.ShowDialog(this);
            this.Visible = true;
        }
    }
}
