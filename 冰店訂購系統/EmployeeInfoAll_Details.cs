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
using System.IO;

namespace 冰店訂購系統
{
    public partial class EmployeeInfoAll_Details : Form
    {
        public string selectID;
        string img_dir = @"images\";
        string img_name;
        string img_default = "defaultphoto.jpg";
        string img_tempname;
        Boolean isImageChange = false;

        public EmployeeInfoAll_Details()
        {
            InitializeComponent();
        }

        private void EmployeeInfoAll_Details_Load(object sender, EventArgs e)
        {
            Console.WriteLine(selectID);

            GlobalVar.ConnectDB();
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string sqlsearch = "select * from Employee where EmployeeID = @SearchID;";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("@SearchID", selectID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtAccount.Text = (string)reader["LoginID"];
                txtName.Text = (String)reader["Name"];
                DateTime dt = (DateTime)reader["Birthdate"];
                dtpBirth.Value = dt;
                txtEmail.Text = reader["Email"].ToString();
                txtID.Text = reader["EmployeeID"].ToString();
                txtAddress.Text = (string)reader["Addr"];
                txtPosition.Text = (string)reader["Title"];
                txtTel.Text = (string)reader["Tel"];
                DateTime dt1 = (DateTime)reader["HireDate"];
                dtpOBD.Value = dt1;
                txtALeave.Text = reader["PaidLeaveHour"].ToString();
                txtTLeave.Text = reader["AbsentHour"].ToString();
                txtPwd.Text = (string)reader["Pwd"];
                txtAccess.Text = reader["Access"].ToString();
                img_tempname = reader["image"].ToString();

                Console.WriteLine(img_tempname);

                try
                {
                    if (reader["image"].ToString() == "")
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");
                        img_tempname = "defaultphotp.jpg";

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + img_tempname);

                    }
                }
                catch (Exception)
                {

                    pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");
                }

            }

            reader.Close();
            con.Close();
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            DialogResult Result = f.ShowDialog();

            if (Result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = Path.GetExtension(f.SafeFileName);
                Random rnd = new Random();
                img_name = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(1000, 9999).ToString() + fileExt;
                isImageChange = true;
                Console.WriteLine(img_name);



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "" || txtName.Text == "" || txtTel.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtALeave.Text == "" || txtTLeave.Text == "" || txtID.Text == "" || txtPosition.Text == "")
            {
                MessageBox.Show("請將欄位填寫完整。");
            }
            else
            {
                DialogResult Result = MessageBox.Show("確定儲存修改?", "", MessageBoxButtons.OKCancel);

                if (Result == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                    con.Open();
                    string sqlupdate = "update Employee set Pwd = @NewPwd, Name = @NewName, Tel = @NewTel, Email = @NewEmail, Addr = @NewAddr, PaidLeaveHour = @NewPaidLeaveHour, AbsentHour = @NewAbsentHour, LastModifiedDate = GETDATE(), Title = @NewTitle, image = @Newimage, Access = @NewAccess where EmployeeID =@SearchID;";
                    SqlCommand cmd = new SqlCommand(sqlupdate, con);
                    cmd.Parameters.AddWithValue("@SearchID", selectID);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewPwd", txtPwd.Text);
                    cmd.Parameters.AddWithValue("@NewTel", txtTel.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewAddr", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@NewPaidLeaveHour", txtALeave.Text);
                    cmd.Parameters.AddWithValue("@NewAbsentHour", txtTLeave.Text);
                    cmd.Parameters.AddWithValue("@NewTitle", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@NewAccess", txtAccess.Text);

                    if (isImageChange)
                    {
                        cmd.Parameters.AddWithValue("@NewImage", img_name);
                        pictureBox1.Image.Save(img_dir + img_name);


                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewImage", img_tempname);
                    }
                    isImageChange = false;

                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rows}行資料更新成功");
                    con.Close();

                    MessageBox.Show("員工資料更新成功。");
                }

            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string sqlsearch = "select * from Employee where EmployeeID = @SearchID;";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("@SearchID", selectID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtAccount.Text = (string)reader["LoginID"];
                txtName.Text = (String)reader["Name"];
                DateTime dt = (DateTime)reader["Birthdate"];
                dtpBirth.Value = dt;
                txtEmail.Text = reader["Email"].ToString();
                txtID.Text = reader["EmployeeID"].ToString();
                txtAddress.Text = (string)reader["Addr"];
                txtPosition.Text = (string)reader["Title"];
                txtTel.Text = (string)reader["Tel"];
                DateTime dt1 = (DateTime)reader["HireDate"];
                dtpOBD.Value = dt1;
                txtALeave.Text = reader["PaidLeaveHour"].ToString();
                txtTLeave.Text = reader["AbsentHour"].ToString();
                txtPwd.Text = (string)reader["Pwd"];
                txtAccess.Text = reader["Access"].ToString();
                img_tempname = reader["image"].ToString();

                try
                {
                    if (reader["image"].ToString() == null)
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + img_default);
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + img_tempname);
                    }
                }
                catch (Exception)
                {

                    pictureBox1.Image = Image.FromFile(img_dir + img_default);

                }

            }
            reader.Close();
            con.Close();
        }
    }
}
