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
    public partial class OrderAll : Form
    {
        public OrderAll()
        {
            InitializeComponent();
        }

        private void OrderAll_Load(object sender, EventArgs e)
        {
            GlobalVar.ConnectDB();
            showUndoList();
        }

        void showUndoList()
        {
            listViewOrder.Clear();
            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("訂單編號", 150);
            listViewOrder.Columns.Add("客戶", 180);
            listViewOrder.Columns.Add("下單日", 50);
            listViewOrder.Columns.Add("訂購人姓名", 150);
            listViewOrder.Columns.Add("訂購人電話", 150);
            listViewOrder.Columns.Add("取單時間", 150);
            listViewOrder.Columns.Add("接單員工", 150);
            listViewOrder.Columns.Add("狀態", 150);
            listViewOrder.FullRowSelect = true;

            listViewOrder.Columns[0].Width = 100;
            listViewOrder.Columns[1].Width = 100;
            listViewOrder.Columns[2].Width = 100;
            listViewOrder.Columns[3].Width = 100;
            listViewOrder.Columns[4].Width = 100;
            listViewOrder.Columns[5].Width = 100;
            listViewOrder.Columns[6].Width = 80;
            listViewOrder.Columns[6].Width = 80;

            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string sqlsearch = "select * from OrderMaster where Status = '未處理' order by 6;";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 8, FontStyle.Regular);
                item.Text = (string)reader["OrderID"];
                item.SubItems.Add((string)reader["CusID"]);
                DateTime dt = (DateTime)reader["Orderdate"];
                item.SubItems.Add(dt.ToString("yyyy/MM/dd"));
                item.SubItems.Add((string)reader["PickupName"]);
                item.SubItems.Add((string)reader["PickupTel"]);
                item.SubItems.Add(reader["PickupTime"].ToString());
                item.SubItems.Add(reader["EmployeeID"].ToString());
                item.SubItems.Add((string)reader["Status"]);

                listViewOrder.Items.Add(item);
            }

            reader.Close();
            con.Close();


        }

        private void rdbtnPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPending.Checked)
            {
                rdbtnDone.Checked = false;
            }

            showUndoList();
        }

        private void rdbtnDone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDone.Checked)
            {
                rdbtnPending.Checked = false;
            }

            listViewOrder.Clear();
            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("訂單編號", 150);
            listViewOrder.Columns.Add("客戶", 150);
            listViewOrder.Columns.Add("下單日", 50);
            listViewOrder.Columns.Add("訂購人姓名", 150);
            listViewOrder.Columns.Add("訂購人電話", 150);
            listViewOrder.Columns.Add("取單時間", 150);
            listViewOrder.Columns.Add("接單員工", 150);
            listViewOrder.Columns.Add("狀態", 150);
            listViewOrder.FullRowSelect = true;

            listViewOrder.Columns[0].Width = 100;
            listViewOrder.Columns[1].Width = 100;
            listViewOrder.Columns[2].Width = 100;
            listViewOrder.Columns[3].Width = 100;
            listViewOrder.Columns[4].Width = 100;
            listViewOrder.Columns[5].Width = 100;
            listViewOrder.Columns[6].Width = 80;
            listViewOrder.Columns[6].Width = 80;

            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string sqlsearch = "select * from OrderMaster where Status = '已結單' order by 6;";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 8, FontStyle.Regular);
                item.Text = (string)reader["OrderID"];
                item.SubItems.Add((string)reader["CusID"]);
                item.SubItems.Add(reader["Orderdate"].ToString());
                item.SubItems.Add((string)reader["PickupName"]);
                item.SubItems.Add((string)reader["PickupTel"]);
                item.SubItems.Add(reader["PickupTime"].ToString());
                item.SubItems.Add(reader["EmployeeID"].ToString());
                item.SubItems.Add((string)reader["Status"]);

                listViewOrder.Items.Add(item);
            }

            reader.Close();
            con.Close();

        }

        private void listViewOrder_ItemActivate(object sender, EventArgs e)
        {
            string SelID = listViewOrder.SelectedItems[0].Text;
            OrderDetailAll OrderDetailAllform = new OrderDetailAll() ;

            OrderDetailAllform.orderID = SelID;
            OrderDetailAllform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginEmployee loginEmployeeForm = new LoginEmployee();
            this.Hide();
            loginEmployeeForm.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (rdbtnPending.Checked)
            {
                showUndoList();
            }
            else if (rdbtnDone.Checked)
            {
                listViewOrder.Clear();
                listViewOrder.View = View.Details;
                listViewOrder.Columns.Add("訂單編號", 150);
                listViewOrder.Columns.Add("客戶", 150);
                listViewOrder.Columns.Add("下單日", 50);
                listViewOrder.Columns.Add("訂購人姓名", 150);
                listViewOrder.Columns.Add("訂購人電話", 150);
                listViewOrder.Columns.Add("取單時間", 150);
                listViewOrder.Columns.Add("接單員工", 150);
                listViewOrder.Columns.Add("狀態", 150);
                listViewOrder.FullRowSelect = true;

                listViewOrder.Columns[0].Width = 100;
                listViewOrder.Columns[1].Width = 100;
                listViewOrder.Columns[2].Width = 100;
                listViewOrder.Columns[3].Width = 100;
                listViewOrder.Columns[4].Width = 100;
                listViewOrder.Columns[5].Width = 100;
                listViewOrder.Columns[6].Width = 80;
                listViewOrder.Columns[6].Width = 80;

                SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                con.Open();
                string sqlsearch = "select * from OrderMaster where Status = '已結單' order by 6;";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 8, FontStyle.Regular);
                    item.Text = (string)reader["OrderID"];
                    item.SubItems.Add((string)reader["CusID"]);
                    item.SubItems.Add(reader["Orderdate"].ToString());
                    item.SubItems.Add((string)reader["PickupName"]);
                    item.SubItems.Add((string)reader["PickupTel"]);
                    item.SubItems.Add(reader["PickupTime"].ToString());
                    item.SubItems.Add(reader["EmployeeID"].ToString());
                    item.SubItems.Add((string)reader["Status"]);

                    listViewOrder.Items.Add(item);
                }


                reader.Close();
                con.Close();

            }
        }
    }
}
