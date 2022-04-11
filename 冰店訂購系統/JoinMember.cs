using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 冰店訂購系統
{
    public partial class JoinMember : Form
    {
        string mydbConnectionString = "";

        public JoinMember()
        {
            InitializeComponent();
        }

        private void JoinMember_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "VegIceStore";
            scsb.IntegratedSecurity = true;
            mydbConnectionString = scsb.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int checkdata = 0;

            SqlConnection con = new SqlConnection(mydbConnectionString);
            con.Open();
            string strsqlcheck = " select * from Customers";
            SqlCommand cmdcheck = new SqlCommand(strsqlcheck, con);
            SqlDataReader readercheck = cmdcheck.ExecuteReader();


            //檢查是否已註冊過會員
            while (readercheck.Read())
            {
                if(txtAccount.Text == readercheck["LoginID"].ToString())
                {
                    lblAccount.Text = "此帳號已被註冊, \n請改用其他名稱註冊";
                    checkdata += 1;
                    return;         

                }
                else if (txtAccount.Text != readercheck["LoginID"].ToString())
                {
                    lblAccount.Text = "";
                }
            }
            readercheck.Close();

            //資料檢核
            if (txtPwd1.Text != txtPwd2.Text)
            {
                lblpwd.Text = "兩次密碼必須輸入相同";
                //txtPwd2.Text = "";
                checkdata += 1;
            }
            else if (txtPwd1.Text == txtPwd2.Text)
            {
                lblpwd.Text = "";
            }

            lblEmail.Text = "";



            if (txtAccount.Text == "" || txtPwd1.Text == "" || txtPwd2.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("請填妥所有申請欄位。");
                checkdata += 1;
            }
            else if (txtPwd1.Text.Length < 8)
            {
                lblpwd.Text = "密碼長度不足, \n請輸入八位以上英數字或符號。";
                if (!txtEmail.Text.Contains("@"))
                {
                    lblEmail.Text = "Email格式錯誤";
                    checkdata += 1;
                }
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                lblEmail.Text = "Email格式錯誤";
                checkdata += 1;
            }
            else if (checkdata == 0)
            {
                MessageBox.Show("申請完成！\n請登入後開始點餐，謝謝。");

                string strsqladd = "insert into Customers(LoginID, Pwd, Name, Birthdate, Addr, Tel, Email, RegisterDate, Point, BlackList) values (@NewID,@NewPwd,@NewName,@NewBirthdate,@NewAddr, @NewTel,@NewEmail,GETDATE(), 200, 0);";
                SqlCommand cmdadd = new SqlCommand(strsqladd, con);
                cmdadd.Parameters.AddWithValue("@NewID", txtAccount.Text);
                cmdadd.Parameters.AddWithValue("@NewPwd", txtPwd1.Text);
                cmdadd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmdadd.Parameters.AddWithValue("@NewBirthdate", dtpBirth.Value);
                cmdadd.Parameters.AddWithValue("@NewAddr", txtAddress.Text);
                cmdadd.Parameters.AddWithValue("@NewTel", txtTel.Text);
                cmdadd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);

                int rows = cmdadd.ExecuteNonQuery();
                Console.WriteLine($"{rows}筆資料新增成功");

                con.Close();
                this.Close();

            }

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtPwd1.Text = "";
            txtPwd2.Text = "";
            dtpBirth.Value = Convert.ToDateTime("1990-01-01");
            txtAddress.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
        }
    }
}
