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
    public partial class MemberInfo : Form
    {
        string mydbConnectionString = "";
        string img_dir = @"images\";
        string img_name = "";
        bool isImageChange = false;
        string temp_pwd = "";
        string temp_Email = "";
        string temp_Addr = "";
        string temp_Tel = "";
        string temp_img = "";
        string temp_name = "";



        public MemberInfo()
        {
            InitializeComponent();
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "VegIceStore";
            scsb.IntegratedSecurity = true;
            mydbConnectionString = scsb.ToString();

            SqlConnection con = new SqlConnection(mydbConnectionString);
            con.Open();
            string SQLmemberinfo = " select * from customers where LoginID = @loginID";
            SqlCommand cmd = new SqlCommand(SQLmemberinfo, con);
            cmd.Parameters.AddWithValue("@loginID", GlobalVar.Account);
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                txtAccount.Text = (string)Reader["LoginID"];
                txtPwd.Text = (string)Reader["Pwd"];
                txtEmail.Text = (string)Reader["Email"];
                txtPoint.Text = Reader["Point"].ToString();
                txtTel.Text = (string)Reader["Tel"];
                txtAddress.Text = (string)Reader["Addr"];
                DateTime dt = (DateTime)Reader["Birthdate"];
                txtBirth.Text = dt.ToString("yyyy/MM/dd");
                txtName.Text = Reader["Name"].ToString();

                temp_pwd = txtPwd.Text;
                temp_Email = txtEmail.Text;
                temp_Addr = txtAddress.Text;
                temp_Tel = txtTel.Text;
                temp_name = txtName.Text;
          

                try
                {
                    pictureBox1.Image = Image.FromFile(img_dir + Reader["Cimage"]);
                    temp_img = Reader["Cimage"].ToString();
                }
                catch (Exception)
                {
                    pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");
                    temp_img = "defaultphoto.jpg";
                }

            }
            Reader.Close();
            con.Close();


        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            DialogResult Result = f.ShowDialog();

            if(Result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = Path.GetExtension(f.SafeFileName);
                Random rnd = new Random();
                img_name = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(1000, 9999).ToString() + fileExt;
                isImageChange = true;
                Console.WriteLine(img_name);



            }
        }

        void Save()
        {
            SqlConnection con = new SqlConnection(mydbConnectionString);
            con.Open();
            string SQLupdate = "update Customers set Pwd = @NewPwd, Name = @NewName, Addr = @NewAddr, Tel = @NewTel, Email = @NewEmail, Cimage = @NewCimage where LoginID = @SearchID;";
            SqlCommand cmdupdate = new SqlCommand(SQLupdate, con);
            cmdupdate.Parameters.AddWithValue("@SearchID",txtAccount.Text);
            cmdupdate.Parameters.AddWithValue("@NewPwd", txtPwd.Text);
            cmdupdate.Parameters.AddWithValue("@NewName", txtName.Text);
            cmdupdate.Parameters.AddWithValue("@NewAddr",txtAddress.Text);
            cmdupdate.Parameters.AddWithValue("@NewTel",txtTel.Text);
            cmdupdate.Parameters.AddWithValue("@NewEmail", txtEmail.Text);

            if (isImageChange)
            {
                pictureBox1.Image.Save(img_dir + img_name);
                cmdupdate.Parameters.AddWithValue("@NewCimage", img_name);
                
                isImageChange = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(img_dir + temp_img);
                cmdupdate.Parameters.AddWithValue("@NewCimage", "");
                isImageChange = false;
            }

            int rows = cmdupdate.ExecuteNonQuery();
            Console.WriteLine($"{rows}筆資料修改成功");

            con.Close();
            MessageBox.Show("會員資料修改成功!");

            temp_pwd = txtPwd.Text;
            temp_Email = txtEmail.Text;
            temp_Addr = txtAddress.Text;
            temp_Tel = txtTel.Text;
            temp_img = img_name;
            temp_name = txtName.Text;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (txtName.Enabled == true) 
            {
                if (txtPwd.Text.Length < 8 )
                {
                    MessageBox.Show("密碼長度不足, 請輸入八位以上英數字或符號。");
                }
                //else if (txtPwd.Text != temp_acc)
                //{
                // Open Confirm Pwd ...   
                //}
                else if (txtEmail.Text != "" && txtEmail.Text != "" && txtTel.Text != "")
                {
                    Save();
                    CloseEdit();

                }
            }
            else if (isImageChange)
            {
                Save();
            }


        }

        void CloseEdit()
        {
            txtName.Enabled = false;
            txtName.ReadOnly = true;
            txtName.BorderStyle = BorderStyle.None;
            txtName.BackColor = Color.LemonChiffon;

            txtPwd.Enabled = false;
            txtPwd.ReadOnly = true;
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.BackColor = Color.LemonChiffon;

            txtEmail.Enabled = false;
            txtEmail.ReadOnly = true;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.BackColor = Color.LemonChiffon;

            txtAddress.Enabled = false;
            txtAddress.ReadOnly = true;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.BackColor = Color.LemonChiffon;


            txtTel.Enabled = false;
            txtTel.ReadOnly = true;
            txtTel.BorderStyle = BorderStyle.None;
            txtTel.BackColor = Color.LemonChiffon;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (txtPwd.Enabled)
            {
                if (temp_pwd != txtPwd.Text || temp_Email != txtEmail.Text || temp_Addr != txtAddress.Text || temp_Tel != txtTel.Text || temp_name != txtName.Text || isImageChange == true)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("是否儲存修改?", "", MessageBoxButtons.OKCancel);

                    if (r == DialogResult.OK)
                    {
                        if (txtPwd.Text.Length < 8)
                        {
                            MessageBox.Show("密碼長度不足, 請輸入八位以上英數字或符號。");
                        }
                        else
                        {
                            Save();
                            CloseEdit();
                        }


                        
                    }
                    else if( r == DialogResult.Cancel)
                    {
                        txtPwd.Text = temp_pwd;
                        txtEmail.Text = temp_Email;
                        txtAddress.Text = temp_Addr;
                        txtTel.Text = temp_Tel;
                        txtName.Text = temp_name;

                        if (temp_img == "")
                        {
                            pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");
                        }
                        else
                        {
                            pictureBox1.Image = Image.FromFile(img_dir + temp_img);
                        }


                        CloseEdit();
                    }
                }
      
            }
            else
            {
                txtPwd.Enabled = true;
                txtPwd.ReadOnly = false;
                txtPwd.BorderStyle = BorderStyle.Fixed3D;
                txtPwd.BackColor = Color.White;

                txtName.Enabled = true;
                txtName.ReadOnly = false;
                txtName.BorderStyle = BorderStyle.Fixed3D;
                txtName.BackColor = Color.White;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;
                txtEmail.BorderStyle = BorderStyle.Fixed3D;
                txtEmail.BackColor = Color.White;

                txtAddress.Enabled = true;
                txtAddress.BackColor = Color.White;
                txtAddress.BorderStyle = BorderStyle.Fixed3D;
                txtAddress.ReadOnly = false;

                txtTel.Enabled = true;
                txtTel.ReadOnly = false;
                txtTel.BorderStyle = BorderStyle.Fixed3D;
                txtTel.BackColor = Color.White;
            }
         
        }
    }
}
