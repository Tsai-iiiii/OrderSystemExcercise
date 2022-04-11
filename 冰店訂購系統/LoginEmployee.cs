using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 冰店訂購系統
{
    public partial class LoginEmployee : Form
    {
        public LoginEmployee()
        {
            InitializeComponent();
        }

        private void LoginEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVar.Access == 100)
                {   //Manager
                    btnEmployeeInfo.Visible = true;
                }
                else
                {
                    btnEmployeeInfo.Visible = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("請確認此帳號權限");
            }
            
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            MemberInfoAll memberInfoAllForm = new MemberInfoAll();
            this.Hide();
            memberInfoAllForm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product productform = new Product();
            this.Hide();
            productform.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderAll orderallForm = new OrderAll();
            this.Hide();
            orderallForm.ShowDialog();
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmployeeInfoForm = new EmployeeInfo();
            EmployeeInfoForm.ShowDialog();

        }

        private void btnEmployeeInfo_Click(object sender, EventArgs e)
        {
            EmployeeInfoAll employeeInfoAllForm = new EmployeeInfoAll();
            this.Hide();
            employeeInfoAllForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalVar.Access = 0;
            GlobalVar.Account = "";
            GlobalVar.Password = "";
            Form1 form1form = new Form1();
            this.Hide();
            form1form.Show();
        }
    }
}
