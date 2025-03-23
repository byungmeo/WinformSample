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
    public partial class UserControl_예약정보 : UserControl
    {
        public UserControl_예약정보(int rno, int day, string startLocationName, string destinationLocationName, TimeSpan startTime, TimeSpan arriveTime, int carno, string seat)
        {
            InitializeComponent();
            label_rno.Text = rno.ToString();
            label_day.Text = day + "일";
            label_startLocationName.Text = startLocationName;
            label_destinationLocationName.Text = destinationLocationName;
            label_startTime.Text = $"{startTime.Hours}:{startTime.Minutes}";
            label_arriveTime.Text = $"{arriveTime.Hours}:{arriveTime.Minutes}";
            label_carno.Text = carno.ToString();
            label_seat.Text = seat;

            foreach(Control control in Controls)
            {
                control.MouseEnter += (s, e) => OnMouseEnter(e);
            }
        }

        private void UserControl_예약정보_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
        }

        private void UserControl_예약정보_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
