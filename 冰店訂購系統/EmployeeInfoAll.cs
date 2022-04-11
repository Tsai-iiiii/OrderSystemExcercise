using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace 冰店訂購系統
{
    public partial class EmployeeInfoAll : Form
    {
        public EmployeeInfoAll()
        {
            InitializeComponent();
        }

        private void EmployeeInfoAll_Load(object sender, EventArgs e)
        {
            GlobalVar.ConnectDB();

            listViewOrderDetail.Clear();
            listViewOrderDetail.View = View.Details;
            listViewOrderDetail.Columns.Add("工號", 150);
            listViewOrderDetail.Columns.Add("職稱", 150);
            listViewOrderDetail.Columns.Add("登入帳號", 150);
            listViewOrderDetail.Columns.Add("姓名", 150);
            listViewOrderDetail.Columns.Add("生日", 50);
            listViewOrderDetail.Columns.Add("電話", 50);
            listViewOrderDetail.Columns.Add("信箱", 150);
            listViewOrderDetail.Columns.Add("地址", 150);
            listViewOrderDetail.Columns.Add("到職日", 150);
            listViewOrderDetail.Columns.Add("年假", 10);
            listViewOrderDetail.Columns.Add("已請時數", 10);
            listViewOrderDetail.FullRowSelect = true;

            listViewOrderDetail.Columns[0].Width = 80;
            listViewOrderDetail.Columns[1].Width = 80;
            listViewOrderDetail.Columns[2].Width = 80;
            listViewOrderDetail.Columns[3].Width = 80;
            listViewOrderDetail.Columns[4].Width = 80;
            listViewOrderDetail.Columns[5].Width = 80;
            listViewOrderDetail.Columns[6].Width = 80;
            listViewOrderDetail.Columns[7].Width = 80;
            listViewOrderDetail.Columns[8].Width = 100;
            listViewOrderDetail.Columns[9].Width = 80;
            listViewOrderDetail.Columns[10].Width = 80;


            GlobalVar.ConnectDB();
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string strSQL = " select * from Employee";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["EmployeeID"].ToString();
                item.SubItems.Add((string)reader["Title"]);
                item.SubItems.Add((string)reader["LoginID"]);
                item.SubItems.Add((string)reader["Name"]);
                DateTime dt1 = (DateTime)reader["Birthdate"];
                item.SubItems.Add(dt1.ToString("yyyy/MM/dd"));
                item.SubItems.Add((string)reader["Tel"]);
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add((string)reader["Addr"]);
                DateTime dt2 = (DateTime)reader["HireDate"];
                item.SubItems.Add(dt2.ToString("yyyy/MM/dd"));
                item.SubItems.Add(reader["PaidLeaveHour"].ToString());
                item.SubItems.Add(reader["AbsentHour"].ToString());

                listViewOrderDetail.Items.Add(item);
            }

            reader.Close();
            con.Close();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmployee loginEmployeeForm = new LoginEmployee();
            loginEmployeeForm.Show();
        }

        private void listViewOrderDetail_Click(object sender, EventArgs e)
        {
            string SelID = listViewOrderDetail.SelectedItems[0].Text;
            EmployeeInfoAll_Details employeeInfoAll_DetailsForm = new EmployeeInfoAll_Details();
            employeeInfoAll_DetailsForm.selectID = SelID;
            employeeInfoAll_DetailsForm.ShowDialog();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeInfoAll_Add employeeInfoAll_Addform = new EmployeeInfoAll_Add();
            employeeInfoAll_Addform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewOrderDetail.Clear();
            listViewOrderDetail.View = View.Details;
            listViewOrderDetail.Columns.Add("工號", 150);
            listViewOrderDetail.Columns.Add("職稱", 150);
            listViewOrderDetail.Columns.Add("登入帳號", 150);
            listViewOrderDetail.Columns.Add("姓名", 150);
            listViewOrderDetail.Columns.Add("生日", 50);
            listViewOrderDetail.Columns.Add("電話", 50);
            listViewOrderDetail.Columns.Add("信箱", 150);
            listViewOrderDetail.Columns.Add("地址", 150);
            listViewOrderDetail.Columns.Add("到職日", 150);
            listViewOrderDetail.Columns.Add("年假", 10);
            listViewOrderDetail.Columns.Add("已請時數", 10);
            listViewOrderDetail.FullRowSelect = true;

            listViewOrderDetail.Columns[0].Width = 80;
            listViewOrderDetail.Columns[1].Width = 80;
            listViewOrderDetail.Columns[2].Width = 80;
            listViewOrderDetail.Columns[3].Width = 80;
            listViewOrderDetail.Columns[4].Width = 80;
            listViewOrderDetail.Columns[5].Width = 80;
            listViewOrderDetail.Columns[6].Width = 80;
            listViewOrderDetail.Columns[7].Width = 80;
            listViewOrderDetail.Columns[8].Width = 100;
            listViewOrderDetail.Columns[9].Width = 80;
            listViewOrderDetail.Columns[10].Width = 80;


            GlobalVar.ConnectDB();
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string strSQL = " select * from Employee";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 8, FontStyle.Regular);

                item.Text = reader["EmployeeID"].ToString();
                item.SubItems.Add((string)reader["Title"]);
                item.SubItems.Add((string)reader["LoginID"]);
                item.SubItems.Add((string)reader["Name"]);
                DateTime dt1 = (DateTime)reader["Birthdate"];
                item.SubItems.Add(dt1.ToString("yyyy/MM/dd"));
                item.SubItems.Add((string)reader["Tel"]);
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add((string)reader["Addr"]);
                DateTime dt2 = (DateTime)reader["HireDate"];
                item.SubItems.Add(dt2.ToString("yyyy/MM/dd"));
                item.SubItems.Add(reader["PaidLeaveHour"].ToString());
                item.SubItems.Add(reader["AbsentHour"].ToString());

                listViewOrderDetail.Items.Add(item);
            }

            reader.Close();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
