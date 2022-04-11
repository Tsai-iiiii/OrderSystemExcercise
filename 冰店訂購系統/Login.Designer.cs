
namespace 冰店訂購系統
{
    partial class Login
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
            this.btnMemberInfo = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnHis = new System.Windows.Forms.Button();
            this.btnrelogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.BackColor = System.Drawing.Color.Orange;
            this.btnMemberInfo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMemberInfo.Location = new System.Drawing.Point(97, 125);
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.Size = new System.Drawing.Size(184, 63);
            this.btnMemberInfo.TabIndex = 0;
            this.btnMemberInfo.Text = "查看會員資料";
            this.btnMemberInfo.UseVisualStyleBackColor = false;
            this.btnMemberInfo.Click += new System.EventHandler(this.btnMemberInfo_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Orange;
            this.btnOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOrder.Location = new System.Drawing.Point(97, 37);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(184, 70);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "開始訂購";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnHis
            // 
            this.btnHis.BackColor = System.Drawing.Color.Orange;
            this.btnHis.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHis.Location = new System.Drawing.Point(97, 208);
            this.btnHis.Name = "btnHis";
            this.btnHis.Size = new System.Drawing.Size(184, 63);
            this.btnHis.TabIndex = 2;
            this.btnHis.Text = "查看歷史訂單";
            this.btnHis.UseVisualStyleBackColor = false;
            this.btnHis.Click += new System.EventHandler(this.btnHis_Click);
            // 
            // btnrelogin
            // 
            this.btnrelogin.BackColor = System.Drawing.Color.Orange;
            this.btnrelogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnrelogin.Location = new System.Drawing.Point(97, 292);
            this.btnrelogin.Name = "btnrelogin";
            this.btnrelogin.Size = new System.Drawing.Size(184, 63);
            this.btnrelogin.TabIndex = 3;
            this.btnrelogin.Text = "重新登入";
            this.btnrelogin.UseVisualStyleBackColor = false;
            this.btnrelogin.Click += new System.EventHandler(this.btnrelogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(384, 400);
            this.Controls.Add(this.btnrelogin);
            this.Controls.Add(this.btnHis);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnMemberInfo);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Login";
            this.Text = "選單";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMemberInfo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnHis;
        private System.Windows.Forms.Button btnrelogin;
    }
}