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
    public partial class EmployeeInfo : Form
    {
        string img_dir = @"images\";

        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            Console.WriteLine(GlobalVar.Account);
            GlobalVar.ConnectDB();

            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string SQLmemberinfo = " select * from Employee where LoginID = @LoginID ;";
            SqlCommand cmd = new SqlCommand(SQLmemberinfo, con);
            cmd.Parameters.AddWithValue("@LoginID", GlobalVar.Account);
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                txtAccount.Text = (string)Reader["LoginID"];
                DateTime dt = (DateTime)Reader["Birthdate"];
                txtBirth.Text = dt.ToString("yyyy/MM/dd");
                txtEmail.Text = (string)Reader["Email"];
                txtTel.Text = (string)Reader["Tel"];
                txtAddress.Text = (string)Reader["Addr"];
                txtName.Text = Reader["Name"].ToString();
                txtID.Text = Reader["EmployeeID"].ToString();
                txtPosition.Text = (string)Reader["Title"];
                txtALeave.Text = Reader["PaidLeaveHour"].ToString();
                txtTLeave.Text = Reader["AbsentHour"].ToString();


                try
                {
                    pictureBox1.Image = Image.FromFile(img_dir + Reader["image"]);
                }
                catch (Exception)
                {
                    pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");
                }

            }
            Reader.Close();
            con.Close();
        }
    }
}
