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
    public partial class Order : Form
    {
        List<string> ItemList = new List<string>();
        List<string> SugarList = new List<string>();
        List<string> IceList = new List<string>();
        List<int> PriceList = new List<int>();
        
        int UnitPrice, Qty;
        string Item, Sugar, Ice, Remark;

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            GlobalVar.ConnectDB();
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string sqldata = "select * from Products order by 1 desc;";
            SqlCommand cmd = new SqlCommand(sqldata, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["ProductID"].ToString().Contains("HOT"))
                {
                    ItemList.Add("*熱* " + reader["Name"].ToString());
                }
                else
                {
                    ItemList.Add(reader["Name"].ToString());
                }
                PriceList.Add(Convert.ToInt32(reader["SP"]));
            }
            reader.Close();
           

            foreach (string item in ItemList)
            {
                listBoxMenu.Items.Add(item);
            }
            listBoxMenu.SelectedIndex = 1;
            Item = listBoxMenu.SelectedItem.ToString();

            SugarList.Add("多糖");
            SugarList.Add("正常糖");
            SugarList.Add("少糖");
            SugarList.Add("半糖");
            SugarList.Add("微糖");
            SugarList.Add("一分糖");
            SugarList.Add("無糖");

            foreach (string sugar in SugarList)
            {
                comboBoxSugar.Items.Add(sugar);
            }
            comboBoxSugar.SelectedIndex = 1;
            Sugar = comboBoxSugar.SelectedItem.ToString();


            IceList.Add("多冰");
            IceList.Add("正常冰");
            IceList.Add("少冰");
            IceList.Add("微冰");
            IceList.Add("去冰");
            IceList.Add("熱");

            foreach (string ice in IceList)
            {
                comboBoxIce.Items.Add(ice);
            }
            comboBoxIce.SelectedIndex = 1;
            Ice = comboBoxIce.SelectedItem.ToString();

            numericUpDownQty.Value = 1;
            Qty = 1;

            int index = listBoxMenu.SelectedIndex;
            UnitPrice = (int)PriceList[index];

            GETCusInfo();
            con.Close();

        }

        private void GETCusInfo()
        {
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string addOrderMain = "select * from Customers where LoginID = @SearchID;";
            SqlCommand cmd = new SqlCommand(addOrderMain, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.Account);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    GlobalVar.Name = (string)reader["Name"];
                    GlobalVar.Tel = (string)reader["Tel"];
                }
            }
            catch (Exception)
            {

                GlobalVar.Name = "";
                GlobalVar.Tel = "";
            }
           

        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownQty.Value = 1;
            comboBoxIce.SelectedItem = "正常冰";
            comboBoxSugar.SelectedItem = "正常糖";
            txtRemark.Text = "";

            int index = listBoxMenu.SelectedIndex;
            Item = ItemList[index];
            lblUnitPrice.Text = PriceList[index].ToString();
            UnitPrice = (int)PriceList[index];

            Qty = (int)numericUpDownQty.Value;
            lblTotalPrice.Text = (UnitPrice * Qty).ToString();

            string SelectedItem = listBoxMenu.SelectedItem.ToString();
            if (SelectedItem.Contains("熱"))
            {
                comboBoxIce.SelectedIndex = 5;
            }
           

        }

        private void comboBoxSugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sugar = (string)comboBoxSugar.Text;
        }

        private void comboBoxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = listBoxMenu.SelectedItem.ToString();
            if (SelectedItem.Contains("燒仙草") || SelectedItem.Contains("花生湯"))
            {
                comboBoxIce.SelectedIndex = 5;
            }

            Ice = (string)comboBoxIce.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (GlobalVar.Account =="")
            {
                Form1 Form1 = new Form1();
                this.Hide();
                Form1.Show();
            }
            else
            {
                Login LoginForm = new Login();
                this.Hide();
                LoginForm.Show();
            }
        }
         

        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownQty.Value <= 0 )
            {
                numericUpDownQty.Value = 1;
                MessageBox.Show("請選擇訂購數量。");
            }
            else
            {
                Qty = (int)numericUpDownQty.Value;
                lblTotalPrice.Text = (UnitPrice * Qty).ToString();
                
            }


        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {
            Remark = (String)txtRemark.Text;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            Item = listBoxMenu.SelectedItem.ToString();
            Sugar = comboBoxSugar.SelectedItem.ToString();
            Ice = comboBoxIce.SelectedItem.ToString();
            if (txtRemark.Text != "")
            {
                Remark = txtRemark.Text;
            }
            else 
            {
                Remark = "無";
            }
            UnitPrice = PriceList[listBoxMenu.SelectedIndex];
            int numeric = (int)numericUpDownQty.Value;
            int lineAmt = UnitPrice * numeric;
            ArrayList OrderInfo = new ArrayList();
            OrderInfo.Add(Item);
            OrderInfo.Add(Sugar);
            OrderInfo.Add(Ice);
            OrderInfo.Add(Remark);
            OrderInfo.Add(UnitPrice); 
            OrderInfo.Add(numeric);
            OrderInfo.Add(lineAmt);

            GlobalVar.OrderList.Add(OrderInfo);

            MessageBox.Show("已加入訂單");


        }

        private void btnCheckCart_Click(object sender, EventArgs e)
        {

            this.Hide();
            OrderDetail orderDetailForm = new OrderDetail();
            orderDetailForm.ShowDialog();


            
        }
    }
}
