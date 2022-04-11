
namespace 冰店訂購系統
{
    partial class OrderDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrderPage = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbtnWrite = new System.Windows.Forms.RadioButton();
            this.rdbtnSame = new System.Windows.Forms.RadioButton();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.lblttl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderPage
            // 
            this.btnOrderPage.BackColor = System.Drawing.Color.Orange;
            this.btnOrderPage.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderPage.Location = new System.Drawing.Point(500, 43);
            this.btnOrderPage.Name = "btnOrderPage";
            this.btnOrderPage.Size = new System.Drawing.Size(159, 41);
            this.btnOrderPage.TabIndex = 69;
            this.btnOrderPage.Text = "返回選購頁";
            this.btnOrderPage.UseVisualStyleBackColor = false;
            this.btnOrderPage.Click += new System.EventHandler(this.btnOrderPage_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.Location = new System.Drawing.Point(500, 519);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(159, 41);
            this.btnOrder.TabIndex = 68;
            this.btnOrder.Text = "下單去";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "今天確定要來點...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 31);
            this.label2.TabIndex = 67;
            this.label2.Text = "................................................................................." +
    "...............";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDrinks.Location = new System.Drawing.Point(43, 94);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(0, 22);
            this.lblDrinks.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "取單時間:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpOrderDate.Location = new System.Drawing.Point(131, 24);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(392, 27);
            this.dtpOrderDate.TabIndex = 71;
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(27, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 73;
            this.label10.Text = "訂購人資訊:";
            // 
            // rdbtnWrite
            // 
            this.rdbtnWrite.AutoSize = true;
            this.rdbtnWrite.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbtnWrite.Location = new System.Drawing.Point(245, 94);
            this.rdbtnWrite.Name = "rdbtnWrite";
            this.rdbtnWrite.Size = new System.Drawing.Size(90, 23);
            this.rdbtnWrite.TabIndex = 77;
            this.rdbtnWrite.TabStop = true;
            this.rdbtnWrite.Text = "自行輸入";
            this.rdbtnWrite.UseVisualStyleBackColor = true;
            this.rdbtnWrite.CheckedChanged += new System.EventHandler(this.rdbtnWrite_CheckedChanged);
            // 
            // rdbtnSame
            // 
            this.rdbtnSame.AutoSize = true;
            this.rdbtnSame.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbtnSame.Location = new System.Drawing.Point(134, 93);
            this.rdbtnSame.Name = "rdbtnSame";
            this.rdbtnSame.Size = new System.Drawing.Size(105, 23);
            this.rdbtnSame.TabIndex = 76;
            this.rdbtnSame.TabStop = true;
            this.rdbtnSame.Text = "同會員資料";
            this.rdbtnSame.UseVisualStyleBackColor = true;
            this.rdbtnSame.CheckedChanged += new System.EventHandler(this.rdbtnSame_CheckedChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Orange;
            this.btnDeleteAll.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteAll.Location = new System.Drawing.Point(316, 519);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(159, 41);
            this.btnDeleteAll.TabIndex = 79;
            this.btnDeleteAll.Text = "刪除全部";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.BackColor = System.Drawing.Color.Orange;
            this.btnDeleteOne.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteOne.Location = new System.Drawing.Point(130, 519);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(159, 41);
            this.btnDeleteOne.TabIndex = 78;
            this.btnDeleteOne.Text = "刪除此項";
            this.btnDeleteOne.UseVisualStyleBackColor = false;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // lblttl
            // 
            this.lblttl.AutoSize = true;
            this.lblttl.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblttl.Location = new System.Drawing.Point(526, 473);
            this.lblttl.Name = "lblttl";
            this.lblttl.Size = new System.Drawing.Size(108, 22);
            this.lblttl.TabIndex = 80;
            this.lblttl.Text = "總金額: XX元";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDrinks);
            this.groupBox1.Controls.Add(this.rdbtnWrite);
            this.groupBox1.Controls.Add(this.rdbtnSame);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(58, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 126);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(314, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 81;
            this.label6.Text = "電話:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTel.Location = new System.Drawing.Point(364, 59);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(159, 27);
            this.txtTel.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(130, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(180, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 27);
            this.txtName.TabIndex = 78;
            // 
            // listViewOrder
            // 
            this.listViewOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(49, 238);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(642, 232);
            this.listViewOrder.TabIndex = 82;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(726, 617);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblttl);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnOrderPage);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "OrderDetail";
            this.Text = "餐點確認";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderPage;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbtnWrite;
        private System.Windows.Forms.RadioButton rdbtnSame;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.Label lblttl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
    }
}