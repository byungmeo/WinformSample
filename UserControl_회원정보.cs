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
    public partial class UserControl_회원정보 : UserControl
    {
        public User 유저정보 = null;

        public UserControl_회원정보(User user)
        {
            InitializeComponent();

            유저정보 = user;
            연령대계산(user.birth);
            label_이름.Text = user.name;
            label_아이디.Text = user.id;
            label_생년월일.Text = user.birth.ToShortDateString();
            label_전화번호.Text = user.phone;
            label_이메일.Text = user.email;
            
            // 기본적으로 이 컨트롤을 더블클릭 해도 자식 컨트롤들이 가리고 있으면 더블클릭 기능 호출이 안된다.
            // 이 문제를 해결하려면 이 컨트롤의 자식으로 있는 모든 컨트롤들에게
            // "너희가 더블클릭을 당하면 내 더블클릭 기능을 호출시켜"
            // 라는 명령을 내리면 된다.
            foreach(Control control in Controls)
            {
                control.DoubleClick += (s, e) => OnDoubleClick(e);
            }
        }

        public void 연령대계산(DateTime birth)
        {
            int 현재연도 = DateTime.Now.Year;
            int 유저생일연도 = birth.Year;
            int 나이 = 현재연도 - 유저생일연도;
            if(나이 >= 19)
            {
                label_연령.BackColor = Color.Orange;
                label_연령.Text = "성인";
            }
            else if(나이 >= 13)
            {
                label_연령.BackColor = Color.Red;
                label_연령.Text = "청소년";
            }
            else if(나이 >= 5)
            {
                label_연령.BackColor = Color.SteelBlue;
                label_연령.Text = "어린이";
            }
            else
            {
                label_연령.BackColor = Color.Yellow;
                label_연령.Text = "유아";
            }
        }
    }
}
