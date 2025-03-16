using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        // 로그인에 성공하였다면, 유저 정보를 저장해두고 싶다.
        // 저장한 로그인 정보는 메인 폼에서 사용한다.
        public User user = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void radioButton_idLogin_CheckedChanged(object sender, EventArgs e)
        {
            // 지금 ID 로그인 라디오 버튼이 체크되어 있는지 여부를 알고싶어.
            // bool : true냐 false 2개 뿐
            // isChecked가 true면 체크가 되어있는거고
            // isChecked가 false면 체크가 안되어있는거다.
            bool isChecked = radioButton_idLogin.Checked;

            if(isChecked == true)
            {
                // 체크가 되었으면 Label의 텍스트를 ID로 바꾸고 싶다.
                label_id.Text = "ID";
            }
        }

        private void radioButton_emailLogin_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = radioButton_emailLogin.Checked;

            if(isChecked == true)
            {
                label_id.Text = "Email";
            }
        }

        private void radioButton_phoneLogin_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = radioButton_phoneLogin.Checked;

            if(isChecked == true)
            {
                label_id.Text = "휴대폰";
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // 빈 칸이 있을 경우 경고 창을 띄우고 싶다.
            if(textBox_id.Text == "" || textBox_pw.Text == "")
            {
                MessageBox.Show("빈칸이 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 로그인 종류에 따라 다르게 로그인을 하고 싶다.
            // 로그인을 하면 회원 정보를 저장해두고 싶다.
            if(radioButton_idLogin.Checked == true)
                user = DatabaseHelper.GetUserByIdAndPw(textBox_id.Text, textBox_pw.Text);
            else if(radioButton_emailLogin.Checked == true)
                user = DatabaseHelper.GetUserByEmailAndPw(textBox_id.Text, textBox_pw.Text);
            else if(radioButton_phoneLogin.Checked == true)
                user = DatabaseHelper.GetUserByPhoneAndPw(textBox_id.Text, textBox_pw.Text);

            if(user == null)
            {
                // 만약, 로그인에 실패하여 유저 정보를 받아오지 못하였다면
                // 경고 메시지를 띄운다.
                MessageBox.Show("일치하는 회원 정보가 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // 만약, 로그인에 성공했다면
                // 1. 환영 메시지를 띄운다.
                MessageBox.Show($"{user.name}회원님 환영합니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. 로그인 폼을 닫는다. (회원메뉴 폼은 메인 폼에서 연다)
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
