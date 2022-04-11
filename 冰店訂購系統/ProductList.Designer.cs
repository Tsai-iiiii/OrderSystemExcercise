
namespace 冰店訂購系統
{
    partial class ProductList
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "產品列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = ".............................................................................";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 288);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 400);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ProductList";
            this.Text = "產品列表";
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
    }
}