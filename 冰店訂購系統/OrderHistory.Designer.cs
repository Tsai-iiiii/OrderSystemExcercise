
namespace 冰店訂購系統
{
    partial class OrderHistory
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.rdbtnDone = new System.Windows.Forms.RadioButton();
            this.rdbtnPending = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.Location = new System.Drawing.Point(568, 48);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(134, 39);
            this.btnReload.TabIndex = 88;
            this.btnReload.Text = "重新整理";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(708, 48);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 39);
            this.btnBack.TabIndex = 87;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(53, 107);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(812, 424);
            this.listViewOrder.TabIndex = 86;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.Click += new System.EventHandler(this.listViewOrder_Click);
            // 
            // rdbtnDone
            // 
            this.rdbtnDone.AutoSize = true;
            this.rdbtnDone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbtnDone.Location = new System.Drawing.Point(164, 48);
            this.rdbtnDone.Name = "rdbtnDone";
            this.rdbtnDone.Size = new System.Drawing.Size(75, 23);
            this.rdbtnDone.TabIndex = 85;
            this.rdbtnDone.Text = "已結單";
            this.rdbtnDone.UseVisualStyleBackColor = true;
            this.rdbtnDone.CheckedChanged += new System.EventHandler(this.rdbtnDone_CheckedChanged);
            // 
            // rdbtnPending
            // 
            this.rdbtnPending.AutoSize = true;
            this.rdbtnPending.Checked = true;
            this.rdbtnPending.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbtnPending.Location = new System.Drawing.Point(53, 48);
            this.rdbtnPending.Name = "rdbtnPending";
            this.rdbtnPending.Size = new System.Drawing.Size(75, 23);
            this.rdbtnPending.TabIndex = 84;
            this.rdbtnPending.TabStop = true;
            this.rdbtnPending.Text = "未結單";
            this.rdbtnPending.UseVisualStyleBackColor = true;
            this.rdbtnPending.CheckedChanged += new System.EventHandler(this.rdbtnPending_CheckedChanged);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 578);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.rdbtnDone);
            this.Controls.Add(this.rdbtnPending);
            this.Name = "OrderHistory";
            this.Text = "歷史訂單";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.RadioButton rdbtnDone;
        private System.Windows.Forms.RadioButton rdbtnPending;
    }
}