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
     class GlobalVar
    {
        public static string Account = "";
        public static string Password = "";
        public static string Name = "";
        public static string Tel = "";

        //下單-未登入
        public static string temp_Name = "";
        public static string temp_Tel = "";
        public static DateTime temp_PickupTime = DateTime.Now;

        public static int Access = 0;
        public static List<ArrayList> OrderList = new List<ArrayList>();
        public static string mydbConnectionString = "";

        public static string OrderID;
        public static void ConnectDB()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "VegIceStore";
            scsb.IntegratedSecurity = true;
            mydbConnectionString = scsb.ToString();
        }
    }
}
