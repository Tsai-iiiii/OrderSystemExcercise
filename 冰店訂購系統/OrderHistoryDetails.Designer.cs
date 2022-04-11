
namespace 冰店訂購系統
{
    partial class OrderHistoryDetails
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
            this.SuspendLayout();
            // 
            // listViewOrderDetail
            // 
            this.listViewOrderDetail.HideSelection = false;
            this.listViewOrderDetail.Location = new System.Drawing.Point(25, 21);
            this.listViewOrderDetail.Name = "listViewOrderDetail";
            this.listViewOrderDetail.Size = new System.Drawing.Size(812, 322);
            this.listViewOrderDetail.TabIndex = 87;
            this.listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            // 
            // OrderHistoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 366);
            this.Controls.Add(this.listViewOrderDetail);
            this.Name = "OrderHistoryDetails";
            this.Text = "訂單明細";
            this.Load += new System.EventHandler(this.OrderHistoryDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrderDetail;
    }
}