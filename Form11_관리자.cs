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
    public partial class Form11_관리자 : Form
    {
        public Form11_관리자()
        {
            InitializeComponent();
        }
        private void pictureBox_회원정보_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12_회원정보 formAccountManage = new Form12_회원정보();
            formAccountManage.ShowDialog(this);
            this.Visible = true;
        }

        private void pictureBox_분석_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13_분석 formAnalyze = new Form13_분석();
            formAnalyze.ShowDialog(this);
            this.Visible = true;
        }

        private void pictureBox_로그아웃_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
