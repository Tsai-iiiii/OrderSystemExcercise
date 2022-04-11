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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            MemberInfo MemberinfoForm = new MemberInfo();
            MemberinfoForm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order OrderForm = new Order();
            OrderForm.Show();
            this.Hide();
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            OrderHistory orderHistoryform = new OrderHistory();
            this.Hide();
            orderHistoryform.Show();
        }

        private void btnrelogin_Click(object sender, EventArgs e)
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
