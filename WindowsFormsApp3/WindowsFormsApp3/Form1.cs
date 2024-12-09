using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using TennodLib.Database;
using TennodLib;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        OraDB db = new OraDB(ConfigurationManager.ConnectionStrings["MyOraDb"].ConnectionString);
        TennodMessageBox messageBox = new TennodMessageBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT USERNAME FROM TB_USERS WHERE ID=:id and PWD=:pwd";

                Dictionary<string, string> paramInfo = new Dictionary<string, string>();
                paramInfo.Add("id", txtID.Text);
                paramInfo.Add("pwd", txtPassword.Text);

                object username = db.ExecuteSclar(sql, paramInfo);
                if (username != null)
                    messageBox.Show('S', $"{username}님 반갑습니다.");
                else
                    messageBox.Show('F', "해당 사용자 정보가 없습니다.");
            }
            catch (Exception ex)
            {
                messageBox.Show('E', ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInsertId.Text.Length == 0 || txtInsertPwd.Text.Length == 0 || txtInsertUsername.Text.Length == 0)
                {   messageBox.Show('W', "아이디와 이름과 비밀번호를 모두 입력하세요");
                    return;
                }

                if (!checkID())
                {
                    messageBox.Show('F', "중복되는 ID가 존재합니다.");
                    return;
                }
                    

                string sql = "INSERT INTO TB_USERS(ID, PWD, USERNAME) VALUES(:id, :pwd, :username)";
                Dictionary<string, string> paramInfo = new Dictionary<string, string>
                {
                    {"id", txtInsertId.Text},
                    {"pwd",txtInsertPwd.Text },
                    {"username", txtInsertUsername.Text }
                };
                if (db.ExecuteNonQuery(sql, paramInfo) > 0)
                    messageBox.Show('S', "회원가입에 성공했습니다.");
                else
                    messageBox.Show('F', "회원가입에 실패했습니다.");
            }
            catch (Exception ex)
            {
                messageBox.Show('E', ex.Message);
            }
        }

        private bool checkID()
        {
            try
            {
                string sql = "SELECT * FROM TB_USERS WHERE ID=:id";
                Dictionary<string, string> paramInfo = new Dictionary<string, string>
                {
                    {"id",txtInsertId.Text }
                };
                if (db.ExecuteSclar(sql, paramInfo) != null)
                {
                    txtInsertId.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                messageBox.Show('E', ex.Message);
            }
            return true; ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInsertId.Text.Length == 0 || txtInsertPwd.Text.Length == 0 || txtInsertUsername.Text.Length == 0)
                {
                    messageBox.Show('W', "아이디와 이름과 비밀번호를 모두 입력하세요");
                    return;
                }
                
                string sql = "DELETE FROM TB_USERS WHERE ID=:id AND PWD=:pwd AND USERNAME=:username";
                Dictionary<string, string> paramInfo = new Dictionary<string, string>{
                    {"id", txtInsertId.Text},
                    {"pwd",txtInsertPwd.Text },
                    {"username", txtInsertUsername.Text }
                };

                if (db.ExecuteNonQuery(sql, paramInfo) > 0)
                    messageBox.Show('S', "회원이 탈퇴되었습니다.");
                else
                    messageBox.Show('F', "회원탈퇴에 실패하였습니다.");
            }
            catch (Exception ex)
            {
                messageBox.Show('E', ex.Message);
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldID.Text.Length == 0 || txtOldPWD.Text.Length == 0)
                {
                    messageBox.Show('W', "아이디와 이름을 모두 입력하세요");
                    return;
                }

                string sql = "SELECT USERNAME FROM TB_USERS WHERE ID=:id and PWD=:pwd";

                Dictionary<string, string> paramInfo = new Dictionary<string, string>();
                paramInfo.Add("id", txtOldID.Text);
                paramInfo.Add("pwd", txtOldPWD.Text);

                object username = db.ExecuteSclar(sql, paramInfo);
                if (username != null)
                {
                    messageBox.Show('S', $"{username}님 반갑습니다.");
                    txtNewID.Text = txtOldID.Text;
                    txtNewPWD.Text = txtOldPWD.Text;
                    txtNewName.Text = username.ToString();
                }
                    
                else
                    messageBox.Show('F', "해당 사용자 정보가 없습니다.");
            }
            catch (Exception ex)
            {
                messageBox.Show('E', ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtNewID.Text.Length == 0 || txtNewPWD.Text.Length == 0 ||txtCheckPWD.Text.Length ==0 || txtNewName.Text.Length ==0)
            {
                messageBox.Show('W', "필수사항을 모두 입력하세요");
                return;
            }
            if (txtNewPWD.Text != txtCheckPWD.Text)
                messageBox.Show('W', "비밀번호 확인이 일치하지 않습니다");

            try
            {
                string sql = "UPDATE TB_USERS SET ID=:id, PWD=:pwd, USERNAME=:username WHERE ID=:oldId AND PWD=:oldPwd";
                Dictionary<string, string> paramInfo = new Dictionary<string, string>
                {
                    {"id", txtNewID.Text},
                    {"pwd",txtNewPWD.Text },
                    {"username", txtNewName.Text },
                    {"oldId", txtOldID.Text},
                    {"oldPwd", txtOldPWD.Text}
                };

                if (db.ExecuteNonQuery(sql, paramInfo) > 0)
                    messageBox.Show('S', $"{txtNewName.Text}님의 정보가 변경되었습니다.");
                else
                    messageBox.Show('F', "회원정보 변경에 실패했습니다");
            }
            catch (Exception ex)
            {
                messageBox.Show('E', ex.Message);
            }

        }

        private void btnGetUserList_Click(object sender, EventArgs e)
        {
            dtUserList.Rows.Clear();
            string sql = "SELECT * FROM TB_USERS";

            IEnumerable<dynamic> users = db.GetLists(sql).Select(user=>new User {
                Num = Convert.ToInt32(user.NUM),
                Id= user.ID,
                Pwd = user.PWD,
                Username = user.USERNAME
                
            });
            foreach(var user in users)
            {
                dtUserList.Rows.Add(user.Num, user.Id, user.Pwd, user.Username);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtUserList.Rows.Clear();
            string sql = "SELECT * FROM TB_USERS ORDER BY NUM";

            IEnumerable<dynamic> users = db.GetLists(sql);

            var firstUser = users.FirstOrDefault();

            if (firstUser != null)
            {
                dtUserList.Rows.Add(firstUser.NUM, firstUser.ID, firstUser.PWD, firstUser.USERNAME);
            }
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            dtUserList.Rows.Clear();
            string sql = "SELECT * FROM TB_USERS";
            IEnumerable<dynamic> users = db.GetLists(sql);

            var oddUser = users.Where(user => Convert.ToInt32(user.NUM)%2 !=0);
            
            foreach(var user in oddUser)
            {
                dtUserList.Rows.Add(user.NUM, user.ID, user.PWD, user.USERNAME);
            }
        }
    }
    public class User
    {
        public int Num { get; set; }
        public string Id { get; set; }
        public string Pwd { get; set; }
        public string Username { get; set; }
    }
}
