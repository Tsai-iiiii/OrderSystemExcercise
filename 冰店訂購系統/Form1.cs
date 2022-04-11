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
    public partial class Form1 : Form
    {
        string mydbConnectionString = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalVar.Account = "";
            GlobalVar.Password = "";
            GlobalVar.temp_Name = "";
            GlobalVar.temp_PickupTime = DateTime.Now;
            GlobalVar.temp_Tel = "";

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "VegIceStore";
            scsb.IntegratedSecurity = true;
            mydbConnectionString = scsb.ToString();
        }


        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(mydbConnectionString);
            con.Open();
            string strSqlEmployee = " select * from Employee";
            string strsqlCustomer = " select * from Customers";
            SqlCommand cmdE = new SqlCommand(strSqlEmployee, con);
            SqlCommand cmdC = new SqlCommand(strsqlCustomer, con);
            SqlDataReader readerE = cmdE.ExecuteReader();
            Boolean isLogin = false;

            while (readerE.Read())
            {
                if (readerE["LoginID"].ToString() == txtAccount.Text && readerE["Pwd"].ToString() == txtPwd.Text)
                {
                    MessageBox.Show("成功登入");
                    isLogin = true;
                    GlobalVar.Access = (int)readerE["Access"];

                    GlobalVar.Account = txtAccount.Text;
                    GlobalVar.Password = txtPwd.Text;

                    LoginEmployee LoginEmployeeForm = new LoginEmployee();
                    this.Hide();
                    LoginEmployeeForm.ShowDialog();



                }
              
                
            }
            readerE.Close();

            if (isLogin)
            {

            }
            else
            {
                SqlDataReader readerC = cmdC.ExecuteReader();
                while (readerC.Read())
                {
                    if (readerC["LoginID"].ToString() == txtAccount.Text && readerC["Pwd"].ToString() == txtPwd.Text)
                    {
                        MessageBox.Show("成功登入");
                        isLogin = true;

                        this.Hide();

                        Login loginform = new Login();
                        loginform.Show();
                    }

                }

                if (isLogin != true)
                {
                    if (txtAccount.Text == "" || txtPwd.Text == "")
                    {
                        MessageBox.Show("請輸入帳號及密碼。");
                    }
                    else
                    {
                        MessageBox.Show("帳號密碼有誤, 請重新輸入");
                        txtPwd.Clear();
                    }
                }
                else
                {
                    GlobalVar.Account = txtAccount.Text;
                    GlobalVar.Password = txtPwd.Text;
                }
                readerC.Close();

            }
            con.Close();

        }        
    


        private void btnJoin_Click(object sender, EventArgs e)
        {
            JoinMember joinmemberform = new JoinMember();
            joinmemberform.ShowDialog();
        }

        private void btnDirectBuy_Click(object sender, EventArgs e)
        {
            Order OrderForm = new Order();
            OrderForm.Show();
            this.Hide();
        }


    }
}
