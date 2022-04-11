
namespace 冰店訂購系統
{
    partial class EmployeeInfoAll
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewOrderDetail
            // 
            this.listViewOrderDetail.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewOrderDetail.HideSelection = false;
            this.listViewOrderDetail.Location = new System.Drawing.Point(46, 72);
            this.listViewOrderDetail.Name = "listViewOrderDetail";
            this.listViewOrderDetail.Size = new System.Drawing.Size(839, 444);
            this.listViewOrderDetail.TabIndex = 83;
            this.listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            this.listViewOrderDetail.Click += new System.EventHandler(this.listViewOrderDetail_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenu.Location = new System.Drawing.Point(721, 24);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(152, 36);
            this.btnMenu.TabIndex = 84;
            this.btnMenu.Text = "返回選單";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(405, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 36);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "新增員工資訊";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(563, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 87;
            this.button1.Text = "重整清單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(104, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 36);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "刪除員工資訊";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EmployeeInfoAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 542);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.listViewOrderDetail);
            this.Name = "EmployeeInfoAll";
            this.Text = "員工清單";
            this.Load += new System.EventHandler(this.EmployeeInfoAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrderDetail;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
    }
}