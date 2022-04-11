
namespace 冰店訂購系統
{
    partial class OrderDetailAll
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
            this.listViewOrderDetail = new System.Windows.Forms.ListView();
            this.rdbtnPending = new System.Windows.Forms.RadioButton();
            this.rdbtnClosed = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOrderDetail
            // 
            this.listViewOrderDetail.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewOrderDetail.HideSelection = false;
            this.listViewOrderDetail.Location = new System.Drawing.Point(58, 71);
            this.listViewOrderDetail.Name = "listViewOrderDetail";
            this.listViewOrderDetail.Size = new System.Drawing.Size(812, 427);
            this.listViewOrderDetail.TabIndex = 82;
            this.listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            // 
            // rdbtnPending
            // 
            this.rdbtnPending.AutoSize = true;
            this.rdbtnPending.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbtnPending.Location = new System.Drawing.Point(66, 34);
            this.rdbtnPending.Name = "rdbtnPending";
            this.rdbtnPending.Size = new System.Drawing.Size(105, 23);
            this.rdbtnPending.TabIndex = 83;
            this.rdbtnPending.TabStop = true;
            this.rdbtnPending.Text = "未處理訂單";
            this.rdbtnPending.UseVisualStyleBackColor = true;
            this.rdbtnPending.CheckedChanged += new System.EventHandler(this.rdbtnPending_CheckedChanged);
            // 
            // rdbtnClosed
            // 
            this.rdbtnClosed.AutoSize = true;
            this.rdbtnClosed.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdbtnClosed.Location = new System.Drawing.Point(221, 34);
            this.rdbtnClosed.Name = "rdbtnClosed";
            this.rdbtnClosed.Size = new System.Drawing.Size(75, 23);
            this.rdbtnClosed.TabIndex = 84;
            this.rdbtnClosed.TabStop = true;
            this.rdbtnClosed.Text = "已結單";
            this.rdbtnClosed.UseVisualStyleBackColor = true;
            this.rdbtnClosed.CheckedChanged += new System.EventHandler(this.rdbtnClosed_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(768, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OrderDetailAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbtnClosed);
            this.Controls.Add(this.rdbtnPending);
            this.Controls.Add(this.listViewOrderDetail);
            this.Name = "OrderDetailAll";
            this.Text = " 訂單明細";
            this.Load += new System.EventHandler(this.OrderDetailAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrderDetail;
        private System.Windows.Forms.RadioButton rdbtnPending;
        private System.Windows.Forms.RadioButton rdbtnClosed;
        private System.Windows.Forms.Button btnSave;
    }
}