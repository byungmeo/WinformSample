using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMyPage : Form
    {
        // 폼이 시작될 때 어떤 회원이 예약을 하는지 알고 싶다.
        User user = null;

        FlowLayoutPanel BeforeSelectedPanel = null;

        public FormMyPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormMyPage_Load(object sender, System.EventArgs e)
        {

        }

        private void button_left_Click(object sender, System.EventArgs e)
        {

        }

        private void button_right_Click(object sender, System.EventArgs e)
        {

        }

        private void flowLayoutPanel_Click(object sender, System.EventArgs e)
        {
            FlowLayoutPanel SelectedPanel = (FlowLayoutPanel)sender;
            if(SelectedPanel != BeforeSelectedPanel)
            {
                if(BeforeSelectedPanel != null)
                {
                    BeforeSelectedPanel.BackColor = Color.White;
                }
                SelectedPanel.BackColor = SystemColors.ScrollBar;
                BeforeSelectedPanel = SelectedPanel;
            }
        }
    }
}
