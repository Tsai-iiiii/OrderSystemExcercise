
namespace 冰店訂購系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnDirectBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(130, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "冰店訂購系統";
            // 
            // txtAccount
            // 
            this.txtAccount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAccount.Location = new System.Drawing.Point(107, 129);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(159, 27);
            this.txtAccount.TabIndex = 1;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPwd.Location = new System.Drawing.Point(107, 177);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(159, 27);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Orange;
            this.btnLogin.Location = new System.Drawing.Point(107, 223);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.Orange;
            this.btnJoin.Location = new System.Drawing.Point(107, 264);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(159, 26);
            this.btnJoin.TabIndex = 4;
            this.btnJoin.Text = "加入會員";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnDirectBuy
            // 
            this.btnDirectBuy.BackColor = System.Drawing.Color.Orange;
            this.btnDirectBuy.Location = new System.Drawing.Point(107, 306);
            this.btnDirectBuy.Name = "btnDirectBuy";
            this.btnDirectBuy.Size = new System.Drawing.Size(159, 26);
            this.btnDirectBuy.TabIndex = 5;
            this.btnDirectBuy.Text = "直接選購";
            this.btnDirectBuy.UseVisualStyleBackColor = false;
            this.btnDirectBuy.Click += new System.EventHandler(this.btnDirectBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "................................";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(103, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "帳號:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(103, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "密碼:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(384, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDirectBuy);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "冰店訂購系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnDirectBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

