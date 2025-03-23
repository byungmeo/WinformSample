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
    public partial class Form10_관리자로그인 : Form
    {
        public Form10_관리자로그인()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text == "" || textBox_pw.Text == "")
            {
                MessageBox.Show("빈칸이 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(textBox_id.Text != "admin" || textBox_pw.Text != "1234")
            {
                MessageBox.Show("올바른 관리자 정보가 아닙니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("관리자님 환영합니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
            Form11_관리자 formManage = new Form11_관리자();
            formManage.ShowDialog(this);
            this.Visible = true;
        }
    }
}
