using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMyPage : Form
    {
        // 폼이 시작될 때 어떤 회원이 예약을 하는지 알고 싶다.
        User user = null;

        public FormMyPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
