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
    public partial class EmployeeInfoAll_Add : Form
    {
        string img_dir = @"images\";
        string img_name;
        string img_default = "defaultphoto.jpg";
        string img_tempname;
        Boolean isImageChange = false;

        public EmployeeInfoAll_Add()
        {
            InitializeComponent();
        }

        private void EmployeeInfoAll_Add_Load(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAccount.Text = "";
            txtPwd.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            txtTLeave.Text = "";
            txtPosition.Text = "";
            txtEmail.Text = "";
            txtALeave.Text = "";
            txtID.Text = "";
            txtAccess.Text = "";

            pictureBox1.Image = Image.FromFile(img_dir + "defaultphoto.jpg");



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
            if (txtAccount.Text == "" || txtName.Text == "" || txtTel.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtALeave.Text == "" || txtTLeave.Text == "" || txtID.Text == "" || txtPosition.Text == "" || txtAccess.Text =="" || txtPwd.Text =="")
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
                    string sqlupdate = "insert Employee values (@NewEmployeeID, @NewLoginID, @NewPwd, @NewName, @NewBirthdate, @NewTel,@NewEmail, @NewAddr, @NewHireDate, @NewPaidLeaveHour, @NewAbsentHour, @LastModifiedDate, @NewTitle, @Newimage, @NewAccess);";
                    SqlCommand cmd = new SqlCommand(sqlupdate, con);
                    cmd.Parameters.AddWithValue("@NewEmployeeID", txtID.Text);
                    cmd.Parameters.AddWithValue("@NewLoginID", txtAccount.Text);
                    cmd.Parameters.AddWithValue("@NewPwd", txtPwd.Text);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewBirthdate", dtpBirth.Value);
                    cmd.Parameters.AddWithValue("@NewTel", txtTel.Text);
                    cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NewAddr", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@NewHireDate", dtpOBD.Value);
                    cmd.Parameters.AddWithValue("@NewPaidLeaveHour", txtALeave.Text);
                    cmd.Parameters.AddWithValue("@NewAbsentHour", txtTLeave.Text);
                    DateTime dt = DateTime.Now;
                    cmd.Parameters.AddWithValue("@LastModifiedDate", dt);
                    cmd.Parameters.AddWithValue("@NewTitle", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@NewAccess", txtAccess.Text);

                    if (isImageChange)
                    {
                        cmd.Parameters.AddWithValue("@NewImage", img_name);
                        pictureBox1.Image.Save(img_dir + img_name);


                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewImage", img_default);
                    }
                    isImageChange = false;

                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rows}行資料更新成功");
                    con.Close();

                    MessageBox.Show("員工資料更新成功。");
                }

            }
        }
    }
}
