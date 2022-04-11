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
    public partial class OrderDetail : Form
    {
        int ttlprice;
        Boolean OrdererSame = true;

        List<string> Item = new List<string>();
        List<string> Sugar = new List<string>();
        List<string> Ice = new List<string>();
        List<string> note = new List<string>();
        List<int> Price = new List<int>();
        List<int> Qty = new List<int>();
        List<int> LineAmt = new List<int>();


        public OrderDetail()
        {
            InitializeComponent();
            
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            showDetails();
            GlobalVar.ConnectDB();

            Console.WriteLine(OrdererSame);

            if (GlobalVar.Name == "")
            {
                rdbtnSame.Checked = false;
                rdbtnSame.Enabled = false;
                rdbtnWrite.Checked = true;
                rdbtnSame.Enabled = false;
                txtName.Text = GlobalVar.temp_Name;
                txtTel.Text = GlobalVar.temp_Tel;
            }
            else if (GlobalVar.Name != "" && OrdererSame)//&& OrdererSame
            {
                rdbtnSame.Checked = true;
                rdbtnSame.Enabled = true;
                rdbtnWrite.Checked = false;
                rdbtnSame.Enabled = true;
                txtName.Text = GlobalVar.Name;
                txtTel.Text = GlobalVar.Tel;

                txtName.ReadOnly = true;
                txtName.Enabled = false;
                txtTel.ReadOnly = true;
                txtTel.Enabled = false;

            }
            else if (GlobalVar.Name != "" && OrdererSame == false)
            {
                rdbtnWrite.Checked = true;
                rdbtnSame.Checked = false;
                txtName.Text = GlobalVar.temp_Name;
                txtTel.Text = GlobalVar.temp_Tel;
            }

            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.CustomFormat = "yyyy-MM-dd HH:mm";


            if (GlobalVar.temp_PickupTime == null)
            {
                return;
            }
            else if(GlobalVar.temp_PickupTime != null)
            {
                dtpOrderDate.Value = GlobalVar.temp_PickupTime;
            }

            ttlprice = LineAmt.Sum();
            lblttl.Text = $"總金額: {ttlprice}元";
        }

        private void btnOrderPage_Click(object sender, EventArgs e)
        {
            if (rdbtnWrite.Checked)
            {
                GlobalVar.temp_Name = txtName.Text;
                GlobalVar.temp_Tel = txtTel.Text;
            }

            GlobalVar.temp_PickupTime = dtpOrderDate.Value;

            this.Close();
            Order OrderForm = new Order();
            OrderForm.Show();
        }


        void showDetails()
        {
            Item.Clear();
            Sugar.Clear();
            Ice.Clear();
            note.Clear();
            Price.Clear();
            Qty.Clear();
            LineAmt.Clear();

            foreach (ArrayList array in GlobalVar.OrderList)
            {
                Console.WriteLine(array[0].ToString());
                Console.WriteLine(array[1].ToString());
                Console.WriteLine(array[2].ToString());
                Console.WriteLine(array[3].ToString());
                Console.WriteLine(array[4].ToString());
                Console.WriteLine(array[5].ToString());
                Console.WriteLine(array[6].ToString());

                Item.Add(array[0].ToString());
                Sugar.Add(array[1].ToString());
                Ice.Add(array[2].ToString());
                note.Add(array[3].ToString());
                Price.Add(Convert.ToInt32(array[4]));
                Qty.Add(Convert.ToInt32(array[5]));
                LineAmt.Add(Convert.ToInt32(array[6]));

            }

            listViewOrder.Clear();
            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("序號", 150);
            listViewOrder.Columns.Add("品項", 50);
            listViewOrder.Columns.Add("甜度", 50);
            listViewOrder.Columns.Add("冰塊", 50);
            listViewOrder.Columns.Add("備註", 150);
            listViewOrder.Columns.Add("單價", 150);
            listViewOrder.Columns.Add("數量", 150);
            listViewOrder.FullRowSelect = true;

            listViewOrder.Columns[0].Width = 40 ;
            listViewOrder.Columns[1].Width = 90;
            listViewOrder.Columns[2].Width = 60;
            listViewOrder.Columns[3].Width = 60;
            listViewOrder.Columns[4].Width = 90;
            listViewOrder.Columns[5].Width = 60;
            listViewOrder.Columns[6].Width = 60;
            //listViewOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listViewOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            for (int i = 0; i < Item.Count; i++)
            {
                ListViewItem LVitem = new ListViewItem();
                LVitem.Font = new Font("微軟正黑體", 8, FontStyle.Regular);

                LVitem.Text = (i+1).ToString();
                LVitem.SubItems.Add(Item[i]);
                LVitem.SubItems.Add(Sugar[i]);
                LVitem.SubItems.Add(Ice[i]);
                LVitem.SubItems.Add(note[i]);
                LVitem.SubItems.Add(Price[i].ToString());
                LVitem.SubItems.Add(Qty[i].ToString());


                listViewOrder.Items.Add(LVitem);
            }



            ttlprice = LineAmt.Sum();
            lblttl.Text = $"總金額: {ttlprice}元";
        }



        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = Convert.ToInt32(listViewOrder.SelectedIndices[0]);  
            }
            catch (Exception)
            {

                index = -1;
            }           
            Console.WriteLine(index);

            if (listViewOrder.Items.Count == 0 )
            {
                MessageBox.Show("清單已空, 請至目錄新增飲品");

            }
            else if (index >= 0)
            {
                GlobalVar.OrderList.RemoveAt(index);
                listViewOrder.Items.Clear();
                showDetails();
            }
            else if(index == -1)
            {
                MessageBox.Show("請選擇要刪除之品項。");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (listViewOrder.Items.Count == 0)
            {
                MessageBox.Show("清單已空, 請至目錄新增飲品");

            }
            else
            {
                DialogResult r = MessageBox.Show("確定清除所有品項?", "", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    listViewOrder.Items.Clear();
                    GlobalVar.OrderList.Clear();
                    showDetails();
                }
                else
                {
                    return;
                }
            }

        }


        private void rdbtnSame_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSame.Checked == true)
            {
                rdbtnWrite.Checked = false;
                txtName.Text = GlobalVar.Name;
                txtTel.Text = GlobalVar.Tel;
                txtName.ReadOnly = true;
                txtName.Enabled = false;
                txtTel.ReadOnly = true;
                txtTel.Enabled = false;

                OrdererSame = true;


            }
            else if (rdbtnWrite.Checked == true)
            {
                rdbtnSame.Checked = false;
                if (GlobalVar.temp_Name != "" || GlobalVar.temp_Tel !="")
                {
                    txtName.Text = GlobalVar.Name;
                    txtTel.Text = GlobalVar.Tel;
                }
                else
                {
                    txtName.Text = "";
                    txtTel.Text = "";
                }
               
                txtName.ReadOnly = false;
                txtName.Enabled = true;
                txtTel.ReadOnly = false;
                txtTel.Enabled = true;
                OrdererSame = false;

            }
        }

        private void rdbtnWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSame.Checked == true)
            {
                rdbtnWrite.Checked = false;
                txtName.Text = GlobalVar.Name;
                txtTel.Text = GlobalVar.Tel;
                txtName.ReadOnly = true;
                txtName.Enabled = false;
                txtTel.ReadOnly = true;
                txtTel.Enabled = false;
                OrdererSame = true;


            }
            else if (rdbtnWrite.Checked == true)
            {
                rdbtnSame.Checked = false;
                if (GlobalVar.temp_Name != "" || GlobalVar.temp_Tel != "")
                {
                    txtName.Text = GlobalVar.Name;
                    txtTel.Text = GlobalVar.Tel;
                }
                else
                {
                    txtName.Text = "";
                    txtTel.Text = "";
                }

                txtName.ReadOnly = false;
                txtName.Enabled = true;
                txtTel.ReadOnly = false;
                txtTel.Enabled = true;
                OrdererSame = false;

            }
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string orderID = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(1000,9999);
            Console.WriteLine(orderID);
            
            if (txtName.Text == "" || txtTel.Text == "" || listViewOrder.Items.Count == 0)
            {
                MessageBox.Show("請完整訂購人資訊及下單品項。");
            } 
            //else if(dtpOrderDate.Value < DateTime.Now)
            //{
            //    MessageBox.Show("取單時間已過，請重新選擇。");
            //    dtpOrderDate.Value = DateTime.Now;
            //}
            else
            {
                DialogResult confirm = MessageBox.Show("確認送出訂單?", "", MessageBoxButtons.OKCancel);

                if (confirm == DialogResult.OK)
                {
                    GlobalVar.ConnectDB();
                    SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                    con.Open();
                    string sqladdmaster = "insert into OrderMaster (OrderID, CusID, OrderDate, PickupName, PickupTel, PickupTime) values (@OrderID, @CusID, GETDATE(), @PName, @PTel, @PTime);";
                    SqlCommand mcmd = new SqlCommand(sqladdmaster, con);

                    mcmd.Parameters.AddWithValue("@OrderID", orderID);

                    if (GlobalVar.Account == "")
                    {
                        mcmd.Parameters.AddWithValue("@CusID", "00000000");
                    }
                    else
                    {
                        mcmd.Parameters.AddWithValue("@CusID", GlobalVar.Account);
                    }
                    mcmd.Parameters.AddWithValue("@PName", txtName.Text);
                    mcmd.Parameters.AddWithValue("@PTel", txtTel.Text);
                    //string dt = dtpOrderDate.Value.ToString("yyyy/MM/dd HH:mm");
                    mcmd.Parameters.AddWithValue("@PTime", dtpOrderDate.Value);

                    int mcheck = mcmd.ExecuteNonQuery();
                    Console.WriteLine($"{mcheck}筆master新增成功");


                    int dcheck = 0;
                    for (int i = 0; i < Item.Count; i++)
                    {
                        string sqladdetails = "insert into OrderDetails values(@OrderID, @SN, @item, @sugar, @ice, @qty, @remark, @UP);";
                        SqlCommand dcmd = new SqlCommand(sqladdetails, con);

                        dcmd.Parameters.AddWithValue("@OrderID", orderID);
                        dcmd.Parameters.AddWithValue("@SN", i + 1);
                        dcmd.Parameters.AddWithValue("@item", Item[i]);
                        dcmd.Parameters.AddWithValue("@sugar", Sugar[i]);
                        dcmd.Parameters.AddWithValue("@ice", Ice[i]);
                        dcmd.Parameters.AddWithValue("@qty", Qty[i]);
                        dcmd.Parameters.AddWithValue("@remark", note[i]);
                        dcmd.Parameters.AddWithValue("@UP", Price[i]);

                        dcheck += dcmd.ExecuteNonQuery();

                    }

                    Console.WriteLine($"{dcheck}筆details新增成功");


                    con.Close();

                    MessageBox.Show("下單成功!");
                }
                else
                {
                    return;
                }
            }

        }


    }
}
