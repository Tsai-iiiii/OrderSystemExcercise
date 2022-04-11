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
    public partial class MemberInfoAll : Form
    {
        public MemberInfoAll()
        {
            InitializeComponent();
        }

        private void MemberInfoAll_Load(object sender, EventArgs e)
        {
            GlobalVar.ConnectDB();
            ClearAll();
            OpenEdit();
        }

        private void ClearAll() 
        {
            txtAccount.Text = "";
            txtID.Text = "";
            dtpBirth.Value = Convert.ToDateTime("1990/1/1");
            txtEmail.Text = "";
            txtPwd.Text = "";
            dtpRegister.Value = Convert.ToDateTime("1990/1/1");
            txtPoint.Text = "0";
            txtAddress.Text = "";
            txtTel.Text = "";
            txtName.Text = "";
            pictureBox1.Image = Image.FromFile("images/defaultphoto.jpg");
            checkboxBL.Checked = false;
      
        }
        void CloseEdit()
        {
            dtpRegister.Enabled = false;

            txtID.Enabled = false;
            txtID.ReadOnly = true;

            txtAccount.Enabled = false;
            txtAccount.ReadOnly = true;

            dtpBirth.Enabled = false;

            txtPoint.Enabled = false;
            txtPoint.ReadOnly = true;

            checkboxBL.Enabled = false;

            txtPwd.Enabled = false;
            txtPwd.ReadOnly = true;

            txtEmail.Enabled = false;
            txtEmail.ReadOnly = true;

            txtAddress.Enabled = false;
            txtAddress.ReadOnly = true;

            txtTel.Enabled = false;
            txtTel.ReadOnly = true;

            dtpRegister.Enabled = false;
        }

        void OpenEdit()
        {
            dtpRegister.Enabled = true;


            txtAccount.Enabled = true;
            txtAccount.ReadOnly = false;

            dtpBirth.Enabled = true;

            txtPoint.Enabled = true;
            txtPoint.ReadOnly = false;

            checkboxBL.Enabled = true;

            txtPwd.Enabled = true;
            txtPwd.ReadOnly = false;

            txtEmail.Enabled = true;
            txtEmail.ReadOnly = false;

            txtAddress.Enabled = true;
            txtAddress.ReadOnly = false;

            txtTel.Enabled = true;
            txtTel.ReadOnly = false;



        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                MessageBox.Show("請輸入欲搜尋之會員帳號。");
            }
            else
            {
                string img_dir = @"images\";
                SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                con.Open();
                string strsqlSearch = "select * from Customers where LoginID = @SearchID";
                SqlCommand cmd = new SqlCommand(strsqlSearch, con);
                cmd.Parameters.AddWithValue("@SearchID", txtAccount.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                

                if (reader.Read())
                {
                    txtID.Text = reader["CusID"].ToString(); 
                    txtPwd.Text = (string)reader["Pwd"];
                    dtpBirth.Value = Convert.ToDateTime(reader["Birthdate"]);
                    txtAddress.Text = (string)reader["Addr"];
                    txtTel.Text = (string)reader["Tel"];
                    txtEmail.Text = (string)reader["Email"];
                    txtName.Text = reader["Name"].ToString();
                    txtPoint.Text = reader["Point"].ToString();
                    dtpRegister.Value = Convert.ToDateTime(reader["RegisterDate"]);
                    if (Convert.ToBoolean(reader["BlackList"]) == false)
                    {
                        checkboxBL.Checked = false;
                    }
                    else if (Convert.ToBoolean(reader["BlackList"]) == true)
                    {
                        checkboxBL.Checked = true;
                    };

                    try
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + reader["Cimage"]);
                    }
                    catch (Exception)
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("查無此會員。");

                }


                reader.Close();
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int checkdata = 0;


            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string strsqlcheck = " select * from Customers";
            SqlCommand cmdcheck = new SqlCommand(strsqlcheck, con);
            SqlDataReader readercheck = cmdcheck.ExecuteReader();

            while (readercheck.Read())
            {
                if (txtAccount.Text == readercheck["LoginID"].ToString())
                {
                    MessageBox.Show("此帳號已被註冊, \n請改用其他名稱註冊");
                    checkdata += 1;
                    return;

                }
                else if (txtAccount.Text != readercheck["LoginID"].ToString())
                {
             
                }
            }
            readercheck.Close();

            //加入會員
            if (txtAccount.Text == "" || txtName.Text =="" || txtPwd.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("請填妥所有申請欄位。");
                checkdata += 1;
                return;
            }
            else if (checkdata == 0)
            {
                MessageBox.Show("會員資料新增成功。");

                DateTime Rdate = DateTime.Now;
                dtpRegister.Value = Convert.ToDateTime(Rdate);

                Boolean cbBL = true;
                if (checkboxBL.Checked == false)
                {
                   cbBL = false;
                }
                else if (checkboxBL.Checked == true)
                {
                    cbBL = true;
                };

                string strsqladd = "insert into Customers(LoginID, Pwd, Birthdate, Name, Addr, Tel, Email, RegisterDate, Point, BlackList) values (@NewID,@NewPwd,@NewBirthdate,@NewName ,@NewAddr, @NewTel,@NewEmail,@NewRdate, @NewPoint, @NewBL);";
                SqlCommand cmdadd = new SqlCommand(strsqladd, con);
                cmdadd.Parameters.AddWithValue("@NewID", txtAccount.Text);
                cmdadd.Parameters.AddWithValue("@NewPwd", txtPwd.Text);
                cmdadd.Parameters.AddWithValue("@NewBirthdate", dtpBirth.Value);
                cmdadd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmdadd.Parameters.AddWithValue("@NewAddr", txtAddress.Text);
                cmdadd.Parameters.AddWithValue("@NewTel", txtTel.Text);
                cmdadd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmdadd.Parameters.AddWithValue("@NewPoint", txtPoint.Text);
                cmdadd.Parameters.AddWithValue("@NewRdate", Rdate);
                cmdadd.Parameters.AddWithValue("@NewBL", cbBL.ToString());

                int rows = cmdadd.ExecuteNonQuery();
                Console.WriteLine($"{rows}筆資料新增成功");
            }
      
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtAccount.Text == "")
            {
                MessageBox.Show("請選取欲刪除之會員帳號。");
            }
            else
            {
                DialogResult result  = MessageBox.Show("確認是否刪除此筆資料?", "刪除資料", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                    con.Open();
                    string strsqldelete = "delete from Customers where LoginID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strsqldelete, con);
                    cmd.Parameters.AddWithValue("@SearchID", txtAccount.Text);

                    int drows = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{drows}筆資料刪除成功");

                    con.Close();
                    MessageBox.Show("會員資料刪除成功");
                    ClearAll();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Boolean cbBL = true;
            if (checkboxBL.Checked == false)
            {
                cbBL = false;
            }
            else if (checkboxBL.Checked == true)
            {
                cbBL = true;
            };

            int isExist = 0;


            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string SQLcheck = "select LoginID from Customers;";
            string SQLupdate = "update Customers set Pwd = @NewPwd, Name = @NewName, Addr = @NewAddr, Tel = @NewTel, Email = @NewEmail, Point = @NewPoint, BlackList = @NewBL where LoginID = @SearchID ";
            SqlCommand cmdcheck = new SqlCommand(SQLcheck, con); 
            SqlCommand cmdupdate = new SqlCommand(SQLupdate, con);
            SqlDataReader readercheck = cmdcheck.ExecuteReader();
            while (readercheck.Read())
            {
                if (readercheck["LoginID"].ToString() == txtAccount.Text)
                {
                    isExist += 1;
                }
            }
            readercheck.Close();

            if (isExist >= 1)
            {
                cmdupdate.Parameters.AddWithValue("@SearchID", txtAccount.Text);
                cmdupdate.Parameters.AddWithValue("@NewPwd", txtPwd.Text);
                cmdupdate.Parameters.AddWithValue("@NewName", txtName.Text);
                cmdupdate.Parameters.AddWithValue("@NewAddr", txtAddress.Text);
                cmdupdate.Parameters.AddWithValue("@NewTel", txtTel.Text);
                cmdupdate.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmdupdate.Parameters.AddWithValue("@NewPoint", txtPoint.Text);
                cmdupdate.Parameters.AddWithValue("@NewBL", cbBL.ToString());

                int rows = cmdupdate.ExecuteNonQuery();
                Console.WriteLine($"{rows}筆資料修改成功");

                MessageBox.Show("資料修改成功!");
            }
            else if(isExist == 0)
            {

              
                DialogResult r = MessageBox.Show("查無此人, 是否新增此會員資料?", "", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    DateTime Rdate = DateTime.Now;
                    dtpRegister.Value = Convert.ToDateTime(Rdate);

                    string strsqladd = "insert into Customers(LoginID, Pwd, Birthdate, Name, Addr, Tel, Email, RegisterDate, Point, BlackList) values (@NewID1,@NewPwd1,@NewBirthdate1, @NewName1, @NewAddr1, @NewTel1, @NewEmail1, @NewRdate1, @NewPoint1, @NewBL1);";
                    SqlCommand cmdadd = new SqlCommand(strsqladd, con);
                    cmdadd.Parameters.AddWithValue("@NewID1", txtAccount.Text);
                    cmdadd.Parameters.AddWithValue("@NewPwd1", txtPwd.Text);
                    cmdadd.Parameters.AddWithValue("@NewBirthdate1", dtpBirth.Value);
                    cmdadd.Parameters.AddWithValue("@NewName1", txtName.Text);
                    cmdadd.Parameters.AddWithValue("@NewAddr1", txtAddress.Text);
                    cmdadd.Parameters.AddWithValue("@NewTel1", txtTel.Text);
                    cmdadd.Parameters.AddWithValue("@NewEmail1", txtEmail.Text);
                    cmdadd.Parameters.AddWithValue("@NewPoint1", txtPoint.Text);
                    cmdadd.Parameters.AddWithValue("@NewRdate1", Rdate);
                    cmdadd.Parameters.AddWithValue("@NewBL1", cbBL.ToString());

                    int rows = cmdadd.ExecuteNonQuery();
                    Console.WriteLine($"{rows}筆資料新增成功");

                    MessageBox.Show("資料新增成功!");

                }
                else if (r == DialogResult.Cancel)
                {
                    return;
                }
            }
          
  
            con.Close();
            

        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmployee loginEmployeeForm = new LoginEmployee();
            loginEmployeeForm.ShowDialog();
        }
    }
}
