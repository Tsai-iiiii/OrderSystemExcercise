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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            GlobalVar.ConnectDB();
            SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
            con.Open();
            string sqlproduct = "select * from Products;";
            SqlCommand cmdviewproduct = new SqlCommand(sqlproduct, con);
            SqlDataReader reader = cmdviewproduct.ExecuteReader();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("商品編號", 100);
            listView1.Columns.Add("商品名稱", 200);
            listView1.Columns.Add("產地", 80);
            listView1.Columns.Add("售價", 80);
            listView1.FullRowSelect = true; //選取一格, 整行都會被選取
            listView1.Columns[0].Width = 120;
            listView1.Columns[1].Width = 120;
            listView1.Columns[2].Width = 60;
            listView1.Columns[3].Width = 60;

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 8, FontStyle.Regular);
                item.Text = reader["ProductID"].ToString(); 
                item.SubItems.Add((string)reader["Name"]); 
                item.SubItems.Add((string)reader["Origin"]);
                item.SubItems.Add(reader["SP"].ToString());

                listView1.Items.Add(item);
            }
           


        }
    }
}
