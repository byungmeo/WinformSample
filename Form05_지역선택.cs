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
    public partial class Form05_지역선택 : Form
    {
        bool 출발지선택;
        public string 선택지역명;
        public int 선택지역번호;
        public Form05_지역선택(bool 출발지선택, string 출발지)
        {
            InitializeComponent();
            this.출발지선택 = 출발지선택;
            if(출발지선택)
                this.Text = "출발지 선택";
            else
                this.Text = "도착지 선택";

            List<Location> locationList = DatabaseHelper.GetLocationList();
            foreach(Location location in locationList)
            {
                // 먼저 디자인창에서 버튼을 하나 만들어 본 뒤 코드에서 그대로 만드는게 쉽습니다.
                Button button = new Button();
                button.Text = location.lname;
                button.Location = new Point(location.lx, location.ly);
                button.Size = new Size(40, 20);
                button.ForeColor = Color.White;
                button.BackColor = Color.Blue;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                // 버튼을 클릭하면 Button_Click이라는 기능을 실행하도록 한다.
                // button.Click += Button_Click;
                // 람다식을 사용하여 간단하게 바꾼다.
                // (sender, e) : 원래 Button의 Click 기능에서 필요한 인자 2개 (object sender, EventArgs e)를 줄여서 사용
                button.Click += (sender, e) =>
                {
                    선택지역명 = location.lname;
                    선택지역번호 = location.lno;
                    DialogResult = DialogResult.OK;
                    this.Close();
                };
                this.Controls.Add(button);
            }
            // 사진을 뒤로 보내기
            pictureBox1.SendToBack();
        }
    }
}
