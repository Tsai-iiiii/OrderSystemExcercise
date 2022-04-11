
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
    public partial class OrderDetailAll : Form
    {
        public string orderID = "";
        public int status = 0;
        int newstatus = 0;


        public OrderDetailAll()
        {
            InitializeComponent();
        }

        private void OrderDetailAll_Load(object sender, EventArgs e)
        {
            Console.WriteLine(orderID);
            GlobalVar.ConnectDB();

            listViewOrderDetail.Clear();
            listViewOrderDetail.View = View.Details;
            listViewOrderDetail.Columns.Add("項目", 150);
            listViewOrderDetail.Columns.Add("品項", 50);
            listViewOrderDetail.Columns.Add("甜度", 150);
            listViewOrderDetail.Columns.Add("冰塊", 150);
            listViewOrderDetail.Columns.Add("數量", 150);
            listViewOrderDetail.Columns.Add("備註", 150);
            listViewOrderDetail.Columns.Add("單價", 150);
            listViewOrderDetail.FullRowSelect = true;

            listViewOrderDetail.Columns[0].Width = 60;
            listViewOrderDetail.Columns[1].Width = 120;
            listViewOrderDetail.Columns[2].Width = 80;
            listViewOrderDetail.Columns[3].Width = 80;
            listViewOrderDetail.Columns[4].Width = 80;
            listViewOrderDetail.Columns[5].Width = 100;
            listViewOrderDetail.Columns[6].Width = 80;

            GlobalVar.ConnectDB();
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string strSQL = " select * from OrderDetails where OrderID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", orderID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["SN"].ToString();
                item.SubItems.Add((string)reader["item"]);
                item.SubItems.Add((string)reader["Sugar"]);
                item.SubItems.Add((string)reader["Ice"]);
                item.SubItems.Add(reader["Qty"].ToString());
                item.SubItems.Add((string)reader["Remark"]);
                item.SubItems.Add(reader["UnitPrice"].ToString());

                listViewOrderDetail.Items.Add(item);
            }

            reader.Close();
            con.Close();

            {
                if (status == 0)
                {
                    rdbtnPending.Checked = true;
                }
                else if (status == 1)
                {
                    rdbtnClosed.Checked = true;
                }

            }
        }
        private void rdbtnPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPending.Checked)
            {
                rdbtnClosed.Checked = false;
            }
            else if (rdbtnPending.Checked == false)
            {
                rdbtnClosed.Checked = true;
            }
        }

        private void rdbtnClosed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPending.Checked)
            {
                rdbtnClosed.Checked = false;
            }
            else if (rdbtnPending.Checked == false)
            {
                rdbtnClosed.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbtnPending.Checked)
            {
                newstatus = 0;
            }
            else if (rdbtnClosed.Checked)
            {
                newstatus = 1;
            }

            DialogResult r = MessageBox.Show("是否儲存修改?", "", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                con.Open();
                string sqlupdate = "update OrderMaster set Status = @NewStatus, EmployeeID = @NewEmployeeID where OrderID = @SearchOrderID";
                SqlCommand cmd = new SqlCommand(sqlupdate, con);
                cmd.Parameters.AddWithValue("@SearchOrderID", orderID);
                if (newstatus == 0)
                {
                    cmd.Parameters.AddWithValue("@NewStatus", "未處理");
                    cmd.Parameters.AddWithValue("@NewEmployeeID", GlobalVar.Account);

                }
                else if (newstatus == 1)
                {
                    cmd.Parameters.AddWithValue("@NewStatus", "已結單");
                    cmd.Parameters.AddWithValue("@NewEmployeeID", GlobalVar.Account);

                }

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rows}筆資料更新成功");

                MessageBox.Show("更新成功。");
                con.Close();

            }
            else
            {
                return;
            }

        }
    }
}
