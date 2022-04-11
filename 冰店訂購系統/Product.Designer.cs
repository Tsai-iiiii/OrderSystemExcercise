
namespace 冰店訂購系統
{
    partial class Product
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearchbyID = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchbyName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(49, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 42);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "新增產品";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(379, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOrigin
            // 
            this.txtOrigin.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrigin.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtOrigin.Location = new System.Drawing.Point(313, 200);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.ReadOnly = true;
            this.txtOrigin.Size = new System.Drawing.Size(268, 27);
            this.txtOrigin.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(257, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "產地:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtName.Location = new System.Drawing.Point(313, 162);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(268, 27);
            this.txtName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(259, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtID.Location = new System.Drawing.Point(313, 123);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(268, 27);
            this.txtID.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(222, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "商品編號:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "產品管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "................................................................................." +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(59, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(222, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "商品名稱:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtPrice.Location = new System.Drawing.Point(313, 236);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(268, 27);
            this.txtPrice.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(257, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "售價:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.Location = new System.Drawing.Point(269, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 42);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "修改資訊";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(159, 406);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 42);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "刪除產品";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnDelete);
            // 
            // btnSearchbyID
            // 
            this.btnSearchbyID.BackColor = System.Drawing.Color.Orange;
            this.btnSearchbyID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchbyID.Location = new System.Drawing.Point(284, 27);
            this.btnSearchbyID.Name = "btnSearchbyID";
            this.btnSearchbyID.Size = new System.Drawing.Size(100, 28);
            this.btnSearchbyID.TabIndex = 45;
            this.btnSearchbyID.Text = "編號查詢";
            this.btnSearchbyID.UseVisualStyleBackColor = false;
            this.btnSearchbyID.Click += new System.EventHandler(this.btnSearchbyID_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.Orange;
            this.btnProductList.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductList.Location = new System.Drawing.Point(482, 306);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(103, 83);
            this.btnProductList.TabIndex = 46;
            this.btnProductList.Text = "產品列表";
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.BackColor = System.Drawing.Color.White;
            this.txtSearchID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchID.Location = new System.Drawing.Point(40, 29);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(228, 27);
            this.txtSearchID.TabIndex = 47;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.White;
            this.txtSearchName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchName.Location = new System.Drawing.Point(40, 63);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(228, 27);
            this.txtSearchName.TabIndex = 49;
            // 
            // btnSearchbyName
            // 
            this.btnSearchbyName.BackColor = System.Drawing.Color.Orange;
            this.btnSearchbyName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchbyName.Location = new System.Drawing.Point(284, 61);
            this.btnSearchbyName.Name = "btnSearchbyName";
            this.btnSearchbyName.Size = new System.Drawing.Size(100, 28);
            this.btnSearchbyName.TabIndex = 48;
            this.btnSearchbyName.Text = "名稱查詢";
            this.btnSearchbyName.UseVisualStyleBackColor = false;
            this.btnSearchbyName.Click += new System.EventHandler(this.btnSearchbyName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchbyID);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.btnSearchbyName);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(49, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 100);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "關鍵字搜尋";
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUploadPic.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUploadPic.Location = new System.Drawing.Point(67, 251);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(131, 26);
            this.btnUploadPic.TabIndex = 51;
            this.btnUploadPic.Text = "上傳照片";
            this.btnUploadPic.UseVisualStyleBackColor = false;
            this.btnUploadPic.Visible = false;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(489, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 42);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(489, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 42);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "返回選單";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 480);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Product";
            this.Text = "產品管理";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearchbyID;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchbyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
    }
}