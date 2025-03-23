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
    public partial class Form12_회원정보 : Form
    {
        public Form12_회원정보()
        {
            InitializeComponent();

            List<User> 회원리스트 = DatabaseHelper.GetUserAll();
            foreach(var 회원정보 in 회원리스트)
            {
                UserControl_회원정보 userControl = new UserControl_회원정보(회원정보);
                userControl.DoubleClick += (s, e) =>
                {
                    // 예 & 아니오가 떠야 하니 YesNo로
                    DialogResult dr = MessageBox.Show("회원을 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    // 예를 누르면 dr이 Yes가 되고, 아니오를 누르면 No가 된다.
                    if(dr == DialogResult.Yes)
                    {
                        // DB에서 회원정보를 삭제하고 싶다.

                        // 만약, settings.sql에서 외래키 설정과 DELETE CASCADE 같은 옵션이 설정되어 있다면
                        // user테이블에서 user만 삭제해도 연관된 데이터들이 삭제되겠지만, 그렇지 않다.
                        // 따라서, 연관된 데이터들을 수작업으로 삭제 해줘야 한다.
                        // location 테이블 : user와 연관 없음. 삭제할 필요 X
                        // schedule 테이블 : user와 연관 없음. 삭제할 필요 X
                        // reservation 테이블 : uno와 연결되어 있음. 같은 uno를 가진 데이터를 삭제해야 함.

                        // 1. uno를 알아낸다. (uno는 user테이블에서 절대 중복되지 않는 데이터 {PK, Primary Key 이기 때문})
                        int uno = userControl.유저정보.uno;

                        // 2. uno를 가지고 삭제 작업을 진행한다.
                        DatabaseHelper.DeleteReservationByUno(uno);
                        DatabaseHelper.DeleteUserByUno(uno);

                        // 3. Panel에서도 삭제한다. (굳이 데이터베이스에서 새로 가져와서 갱신 할 필요는 없다)
                        flowLayoutPanel.Controls.Remove(userControl);
                    }
                };
                flowLayoutPanel.Controls.Add(userControl);
            }
        }

        private void comboBox_연령_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Panel을 초기화 한다.
            flowLayoutPanel.Controls.Clear();

            string 연령 = comboBox_연령.Text;

            // DB에서 birth에 조건을 줘서 해도 되고,
            // 그냥 다 받아와서 자체적으로 걸러내도 된다.
            // 여기서는 후자를 택함.
            // 주의 : 그림13-1에 따르면 유아가 12명 있어야 한다. 하지만, 여기 있는 나이 계산 기준으로는 1명도 없다.
            // 대회에 가면 이런 계산에 대한 기준을 더 명확히 해 달라고 해야한다. (만 나이 계산할 줄 모른다고 틀리면 억울하니까)
            List<User> 회원리스트 = DatabaseHelper.GetUserAll();
            foreach(var 회원정보 in 회원리스트)
            {
                int 현재연도 = DateTime.Now.Year;
                int 유저생일연도 = 회원정보.birth.Year;
                int 나이 = 현재연도 - 유저생일연도;

                // 선택연령이 성인인데 나이가 19보다 작으면 넘어간다.
                if(연령 == "성인" && 나이 < 19)
                {
                    continue;
                }
                // 선택연령이 청소년인데 나이가 19이상이거나 13미만이면 넘어간다.
                else if(연령 == "청소년" && (나이 >= 19 || 나이 < 13))
                {
                    continue;
                }
                // 선택연령이 어린이인데 나이가 13이상이거나 5미만이면 넘어간다.
                else if(연령 == "어린이" && (나이 >= 13 || 나이 < 5))
                {
                    continue;
                }
                // 선택연령이 유아인데 나이가 5이상이면 넘어간다.
                else if(연령 == "유아" && 나이 >= 5)
                {
                    continue;
                }

                UserControl_회원정보 userControl = new UserControl_회원정보(회원정보);
                userControl.DoubleClick += (s, ea) =>
                {
                    // 예 & 아니오가 떠야 하니 YesNo로
                    DialogResult dr = MessageBox.Show("회원을 삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    // 예를 누르면 dr이 Yes가 되고, 아니오를 누르면 No가 된다.
                    if(dr == DialogResult.Yes)
                    {
                        // DB에서 회원정보를 삭제하고 싶다.

                        // 만약, settings.sql에서 외래키 설정과 DELETE CASCADE 같은 옵션이 설정되어 있다면
                        // user테이블에서 user만 삭제해도 연관된 데이터들이 삭제되겠지만, 그렇지 않다.
                        // 따라서, 연관된 데이터들을 수작업으로 삭제 해줘야 한다.
                        // location 테이블 : user와 연관 없음. 삭제할 필요 X
                        // schedule 테이블 : user와 연관 없음. 삭제할 필요 X
                        // reservation 테이블 : uno와 연결되어 있음. 같은 uno를 가진 데이터를 삭제해야 함.

                        // 1. uno를 알아낸다. (uno는 user테이블에서 절대 중복되지 않는 데이터 {PK, Primary Key 이기 때문})
                        int uno = userControl.유저정보.uno;

                        // 2. uno를 가지고 삭제 작업을 진행한다.
                        DatabaseHelper.DeleteReservationByUno(uno);
                        DatabaseHelper.DeleteUserByUno(uno);

                        // 3. Panel에서도 삭제한다. (굳이 데이터베이스에서 새로 가져와서 갱신 할 필요는 없다)
                        flowLayoutPanel.Controls.Remove(userControl);
                    }
                };
                flowLayoutPanel.Controls.Add(userControl);
            }
        }
    }
}
