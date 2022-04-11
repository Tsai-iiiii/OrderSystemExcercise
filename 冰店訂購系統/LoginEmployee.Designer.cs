
namespace 冰店訂購系統
{
    partial class LoginEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMemberInfo = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnEmployeeInfo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(156, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "管理選單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(84, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "...................................";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMemberInfo.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemberInfo.Location = new System.Drawing.Point(92, 130);
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.Size = new System.Drawing.Size(105, 105);
            this.btnMemberInfo.TabIndex = 69;
            this.btnMemberInfo.Text = "會員查詢";
            this.btnMemberInfo.UseVisualStyleBackColor = false;
            this.btnMemberInfo.Click += new System.EventHandler(this.btnMemberInfo_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProduct.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.Location = new System.Drawing.Point(218, 130);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(105, 105);
            this.btnProduct.TabIndex = 70;
            this.btnProduct.Text = "產品管理";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.Location = new System.Drawing.Point(92, 256);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(105, 105);
            this.btnOrder.TabIndex = 71;
            this.btnOrder.Text = "訂單管理";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMyInfo.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMyInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyInfo.Location = new System.Drawing.Point(218, 256);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(105, 105);
            this.btnMyInfo.TabIndex = 72;
            this.btnMyInfo.Text = "個人資訊";
            this.btnMyInfo.UseVisualStyleBackColor = false;
            this.btnMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
            // 
            // btnEmployeeInfo
            // 
            this.btnEmployeeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmployeeInfo.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployeeInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeInfo.Location = new System.Drawing.Point(218, 384);
            this.btnEmployeeInfo.Name = "btnEmployeeInfo";
            this.btnEmployeeInfo.Size = new System.Drawing.Size(105, 88);
            this.btnEmployeeInfo.TabIndex = 73;
            this.btnEmployeeInfo.Text = "員工管理";
            this.btnEmployeeInfo.UseVisualStyleBackColor = false;
            this.btnEmployeeInfo.Click += new System.EventHandler(this.btnEmployeeInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(90, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 88);
            this.btnBack.TabIndex = 86;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoginEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(426, 523);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEmployeeInfo);
            this.Controls.Add(this.btnMyInfo);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnMemberInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "LoginEmployee";
            this.Text = "選單";
            this.Load += new System.EventHandler(this.LoginEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMemberInfo;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnEmployeeInfo;
        private System.Windows.Forms.Button btnBack;
    }
}