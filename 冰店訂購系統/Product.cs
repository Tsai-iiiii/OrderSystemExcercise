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
    public partial class Product : Form
    {
        string img_dir = @"images\";
        string img_name = "";
        Boolean isImageChange = false;
        string temp_ID;
        string temp_Name;
        string temp_Origin;
        string temp_SP;
        string temp_img_name;

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            GlobalVar.ConnectDB();
            pictureBox1.Image = Image.FromFile(img_dir + "noimage.png");
            if (GlobalVar.Access == 100)
            {
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnSave.Visible = true;
                btnRemove.Visible = true;
                btnCancel.Visible = true;
            }

        }

        void Clearall()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtOrigin.Text = "";
            txtPrice.Text = "";
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            pictureBox1.Image = Image.FromFile(img_dir + "noimage.png");
        }

        void closeEdit()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            txtID.ReadOnly = true;
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtOrigin.ReadOnly = true;
            txtPrice.ReadOnly = true;
            btnUploadPic.Visible = false;
            groupBox1.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly == true)
            {
                //開啟編輯
                Clearall();
                txtID.ReadOnly = false;
                txtID.BackColor = Color.White;
                txtName.ReadOnly = false;
                txtName.BackColor = Color.White;
                txtOrigin.ReadOnly = false;
                txtOrigin.BackColor = Color.White;
                txtPrice.ReadOnly = false;
                txtPrice.BackColor = Color.White;
                btnUploadPic.Visible = true;
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                groupBox1.Enabled = false;
            }
            else
            {
                //詢問是否存檔
                if (txtID.Text !="" || txtName.Text !="" || txtOrigin.Text !="" || txtPrice.Text !="")
                {
                    SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                    con.Open();
                 
                }
                else
                {
                    MessageBox.Show("請完整產品資訊。");
                }
            }


        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (btnAdd.Enabled == true)
            { //開啟編輯
                 if (txtID.Text == "")
                {
                    MessageBox.Show("請先搜尋欲修改之商品。");
                }
                else
                {
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = false;
                    txtName.ReadOnly = false;
                    txtOrigin.ReadOnly = false;
                    txtPrice.ReadOnly = false;
                    btnUploadPic.Visible = true;
                }

            }
            else if(txtID.Text == temp_ID && txtName.Text == temp_Name && txtOrigin.Text == temp_Origin && txtPrice.Text == temp_SP && isImageChange == false)
            {
                closeEdit();
            }
            else if (txtID.Text != temp_ID || txtName.Text != temp_Name || txtOrigin.Text != temp_Origin || txtPrice.Text != temp_SP || isImageChange == true)
            {
                if (txtID.Text != "" && txtName.Text != "" && txtOrigin.Text != "" && txtPrice.Text != "")
                {
                    SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                    con.Open();
                    string sqlsave = " update Products set Name = @NewName, Origin = @NewOrigin, SP = @NewSP, Pimage = @NewPimage where ProductID = @SearchID;";
                    SqlCommand cmdsave = new SqlCommand(sqlsave, con);
                    cmdsave.Parameters.AddWithValue("@SearchID", txtID.Text);
                    cmdsave.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmdsave.Parameters.AddWithValue("@NewOrigin", txtOrigin.Text);
                    cmdsave.Parameters.AddWithValue("@NewSP", txtPrice.Text);
                    if (isImageChange)
                    {
                        cmdsave.Parameters.AddWithValue("@NewPimage", img_name);
                        pictureBox1.Image.Save(img_dir + img_name);

                    }
                    else
                    {
                        cmdsave.Parameters.AddWithValue("@NewPimage", temp_img_name);
                    }
                    int rows = cmdsave.ExecuteNonQuery();
                    Console.WriteLine($"{rows}筆資料修改成功");
                    MessageBox.Show("資料修改成功。");
                    closeEdit();

                }
                else
                {
                    MessageBox.Show("請填妥商品資訊。");
                }



            }


        }

        private void btnDelete(object sender, EventArgs e)
        {
            if (txtID.Text =="")
            {
                MessageBox.Show("請先搜尋欲刪除之商品資訊。");
            }
            else
            {
                DialogResult r = MessageBox.Show("是否確定刪除此品項?", "", MessageBoxButtons.OKCancel);

                if (r == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                    con.Open();
                    string sqldelete = " delete from Products where ProductID = @dID;";
                    SqlCommand cmddelete = new SqlCommand(sqldelete, con);
                    cmddelete.Parameters.AddWithValue("@dID", txtID.Text);

                    int rows = cmddelete.ExecuteNonQuery();
                    Console.WriteLine($"{rows}筆資料刪除成功");
                    MessageBox.Show("資料已刪除。");
                    Clearall();
                    closeEdit();
                }
            }
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductList productListForm = new ProductList();
            productListForm.ShowDialog();
        }

        private void btnSearchbyID_Click(object sender, EventArgs e)
        {
            if (txtSearchID.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                con.Open();
                string sqlsearchID = "select * from Products where ProductID = @SearchID";
                SqlCommand cmdID = new SqlCommand(sqlsearchID, con);
                cmdID.Parameters.AddWithValue("@SearchID", txtSearchID.Text);
                SqlDataReader readID = cmdID.ExecuteReader();

                if (readID.Read())
                {
                    txtID.Text = (string)readID["ProductID"];
                    txtName.Text = (string)readID["Name"];
                    txtOrigin.Text = (string)readID["Origin"];
                    txtPrice.Text = readID["SP"].ToString();

                    try
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + readID["Pimage"]);
                        temp_img_name = (string)readID["Pimage"];
                    }
                    catch (Exception)
                    {

                        pictureBox1.Image = Image.FromFile(img_dir + "noimage.png");

                    }
                    temp_ID = txtID.Text;
                    temp_Name = txtName.Text;
                    temp_Origin = txtOrigin.Text;
                    temp_SP = txtPrice.Text;
                   


                }
                else
                {
                    MessageBox.Show("查無此產品ID，請確認後重新輸入。");
                }
            }
            else
            {
                MessageBox.Show("請輸入產品ID。");
            }
        }

        private void btnSearchbyName_Click(object sender, EventArgs e)
        {
            if (txtSearchName.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                con.Open();
                string sqlsearchName = "select * from Products where Name = @SearchName";
                SqlCommand cmdName = new SqlCommand(sqlsearchName, con);
                cmdName.Parameters.AddWithValue("@SearchName", txtSearchName.Text);
                SqlDataReader readName = cmdName.ExecuteReader();

                if (readName.Read())
                {
                    txtID.Text = (string)readName["ProductID"];
                    txtName.Text = (string)readName["Name"];
                    txtOrigin.Text = (string)readName["Origin"];
                    txtPrice.Text = readName["SP"].ToString();

                    try
                    {
                        pictureBox1.Image = Image.FromFile(img_dir + readName["Pimage"]);
                        temp_img_name = (string)readName["Pimage"];
                    }
                    catch (Exception)
                    {

                        pictureBox1.Image = Image.FromFile(img_dir + "noimage.png");

                    }

                    temp_ID = txtID.Text;
                    temp_Name = txtName.Text;
                    temp_Origin = txtOrigin.Text;
                    temp_SP = txtPrice.Text;
                }
                else
                {
                    MessageBox.Show("查無此產品名稱，請確認後重新輸入。");
                }
            }
            else
            {
                MessageBox.Show("請輸入產品名稱。");
            }
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            DialogResult Result = f.ShowDialog();

            if (Result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = Path.GetExtension(f.SafeFileName);
                Random rnd = new Random();
                img_name = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(1000, 9999).ToString() + fileExt;
                isImageChange = true;
                temp_img_name = img_name;
                Console.WriteLine(img_name);


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (btnEdit.Enabled && btnAdd.Enabled)
                {
                return;
                }
                else if (btnEdit.Enabled)
                {
                    if (txtID.Text == temp_ID && txtName.Text == temp_Name && txtOrigin.Text == temp_Origin && txtPrice.Text == temp_SP && isImageChange == false)
                    {
                        btnAdd.Enabled = true;
                        btnRemove.Enabled = true;
                        txtID.ReadOnly = true;
                        txtName.ReadOnly = true;
                        txtOrigin.ReadOnly = true;
                        txtPrice.ReadOnly = true;

                    }
                    else if (txtID.Text != temp_ID || txtName.Text != temp_Name || txtOrigin.Text != temp_Origin || txtPrice.Text != temp_SP || isImageChange == true)
                    {
                       if (txtID.Text != "" || txtName.Text != "" || txtOrigin.Text != "" || txtPrice.Text != "")
                       {
                        SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                        con.Open();
                        string sqlsave = " update Products set Name = @NewName, Origin = @NewOrigin, SP = @NewSP, Pimage = @NewPimage where ProductID = @SearchID;";
                        SqlCommand cmdsave = new SqlCommand(sqlsave, con);
                        cmdsave.Parameters.AddWithValue("@SearchID", txtID.Text);
                        cmdsave.Parameters.AddWithValue("@NewName", txtName.Text);
                        cmdsave.Parameters.AddWithValue("@NewOrigin", txtOrigin.Text);
                        cmdsave.Parameters.AddWithValue("@NewSP", txtPrice.Text);
                        if (isImageChange)
                        {
                            cmdsave.Parameters.AddWithValue("@NewPimage", img_name);
                            pictureBox1.Image.Save(img_dir + img_name);
    
                        }
                        else
                        {
                            cmdsave.Parameters.AddWithValue("@NewPimage", temp_img_name);
                        }

                        int rows = cmdsave.ExecuteNonQuery();
                        Console.WriteLine($"{rows}筆資料修改成功");
                        MessageBox.Show("資料修改成功。");
                        btnAdd.Enabled = true;
                        btnRemove.Enabled = true;


                    }
                    else
                        {
                          MessageBox.Show("請填妥商品資訊。");
                        }


                    }
                }
                else if (btnAdd.Enabled)
                {
                    Boolean isDuplicate = false;
                    if (txtID.Text == "" || txtName.Text == "" || txtOrigin.Text == "" || txtPrice.Text == "")
                    {
                        MessageBox.Show("商品資訊未填寫完整。");
                    }
                    else if(txtID.Text != "" || txtName.Text != "" || txtOrigin.Text != "" || txtPrice.Text != "")
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.mydbConnectionString);
                        con.Open();
                        string sqlcheck = "select Name from Products;";
                        SqlCommand cmdcheck = new SqlCommand(sqlcheck, con);
                        SqlDataReader readcheck = cmdcheck.ExecuteReader();

                        while (readcheck.Read())
                        {
                            if (readcheck["Name"].ToString() == txtName.Text)
                            {
                                isDuplicate = true;
                            }
                        }

                        readcheck.Close();

                        if (isDuplicate)
                        {
                            MessageBox.Show("此商品已存在。");
                        }
                        else
                        {
                            string sqlsave = " insert Products values (@NewProductID, @NewName, @NewOrigin, @NewSP, @NewPimage)";
                            SqlCommand cmdsave = new SqlCommand(sqlsave, con);
                            cmdsave.Parameters.AddWithValue("@NewProductID", txtID.Text);
                            cmdsave.Parameters.AddWithValue("@NewName", txtName.Text);
                            cmdsave.Parameters.AddWithValue("@NewOrigin", txtOrigin.Text);
                            int intprice = 0;
                            Int32.TryParse(txtPrice.Text, out intprice);
                            cmdsave.Parameters.AddWithValue("@NewSP", intprice);
                            if (isImageChange)
                            {
                                cmdsave.Parameters.AddWithValue("@NewPimage", img_name);
                                pictureBox1.Image.Save(img_dir + img_name);

                            }
                            else
                            {
                                cmdsave.Parameters.AddWithValue("@NewPimage", "");
                            }

                            int rows = cmdsave.ExecuteNonQuery();
                            Console.WriteLine($"{rows}筆資料修改成功");
                            MessageBox.Show("商品新增成功。");
                            closeEdit();
                                groupBox1.Enabled = true;

                    }    
                    con.Close();
                }           
                
            }
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clearall();
            closeEdit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmployee loginEmployeeForm = new LoginEmployee();
            loginEmployeeForm.ShowDialog();
        }
    }
}
