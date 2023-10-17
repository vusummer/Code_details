namespace ASM
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            rbtNu = new RadioButton();
            rbtNam = new RadioButton();
            groupBox1 = new GroupBox();
            rtxtAddress = new RichTextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtFindPhonenumber = new TextBox();
            btFind = new Button();
            dataGridViewKhachhang = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btExit = new Button();
            btShowList = new Button();
            btSkip = new Button();
            btSave = new Button();
            btEdit = new Button();
            btDel = new Button();
            btAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachhang).BeginInit();
            SuspendLayout();
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(102, 27);
            rbtNu.Margin = new Padding(3, 4, 3, 4);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(50, 24);
            rbtNu.TabIndex = 1;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Location = new Point(7, 27);
            rbtNam.Margin = new Padding(3, 4, 3, 4);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(62, 24);
            rbtNam.TabIndex = 0;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtNu);
            groupBox1.Controls.Add(rbtNam);
            groupBox1.Location = new Point(553, 146);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(155, 60);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(553, 62);
            rtxtAddress.Margin = new Padding(3, 4, 3, 4);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(349, 75);
            rtxtAddress.TabIndex = 25;
            rtxtAddress.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 108);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 27);
            txtName.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(130, 62);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(213, 27);
            txtPhone.TabIndex = 23;
            // 
            // txtFindPhonenumber
            // 
            txtFindPhonenumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindPhonenumber.Location = new Point(273, 484);
            txtFindPhonenumber.Margin = new Padding(3, 4, 3, 4);
            txtFindPhonenumber.Name = "txtFindPhonenumber";
            txtFindPhonenumber.Size = new Size(261, 30);
            txtFindPhonenumber.TabIndex = 23;
            txtFindPhonenumber.Text = "Nhập Số Điện Thoại Khách hàng";
            // 
            // btFind
            // 
            btFind.Image = Properties.Resources.Zerode_Plump_Search_24;
            btFind.ImageAlign = ContentAlignment.MiddleLeft;
            btFind.Location = new Point(542, 477);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(113, 45);
            btFind.TabIndex = 20;
            btFind.Text = "Tìm Kiếm";
            btFind.TextAlign = ContentAlignment.MiddleRight;
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dataGridViewKhachhang
            // 
            dataGridViewKhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKhachhang.Location = new Point(12, 220);
            dataGridViewKhachhang.Margin = new Padding(3, 4, 3, 4);
            dataGridViewKhachhang.Name = "dataGridViewKhachhang";
            dataGridViewKhachhang.RowHeadersWidth = 51;
            dataGridViewKhachhang.RowTemplate.Height = 25;
            dataGridViewKhachhang.Size = new Size(889, 249);
            dataGridViewKhachhang.TabIndex = 13;
            dataGridViewKhachhang.CellContentClick += dataGridViewKhachhang_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 66);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 160);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 9;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 112);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 12;
            label2.Text = "Điện Thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(357, 8);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 7;
            label1.Text = "Khách Hàng";
            // 
            // btExit
            // 
            btExit.Image = Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_1_24;
            btExit.ImageAlign = ContentAlignment.MiddleLeft;
            btExit.Location = new Point(708, 528);
            btExit.Margin = new Padding(3, 4, 3, 4);
            btExit.Name = "btExit";
            btExit.Size = new Size(86, 48);
            btExit.TabIndex = 45;
            btExit.Text = "Đóng";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btShowList
            // 
            btShowList.Image = Properties.Resources.Webalys_Kameleon_pics_Checklist_24;
            btShowList.ImageAlign = ContentAlignment.MiddleLeft;
            btShowList.Location = new Point(587, 530);
            btShowList.Margin = new Padding(3, 4, 3, 4);
            btShowList.Name = "btShowList";
            btShowList.Size = new Size(115, 48);
            btShowList.TabIndex = 46;
            btShowList.Text = "Danh Sách";
            btShowList.TextAlign = ContentAlignment.MiddleRight;
            btShowList.UseVisualStyleBackColor = true;
            btShowList.Click += btShowList_Click;
            // 
            // btSkip
            // 
            btSkip.Image = Properties.Resources.Designbolts_Free_Multimedia_Forward_24;
            btSkip.ImageAlign = ContentAlignment.MiddleLeft;
            btSkip.Location = new Point(487, 530);
            btSkip.Margin = new Padding(3, 4, 3, 4);
            btSkip.Name = "btSkip";
            btSkip.Size = new Size(94, 48);
            btSkip.TabIndex = 44;
            btSkip.Text = "Bỏ Qua";
            btSkip.TextAlign = ContentAlignment.MiddleRight;
            btSkip.UseVisualStyleBackColor = true;
            btSkip.Click += btSkip_Click;
            // 
            // btSave
            // 
            btSave.Image = Properties.Resources.Designbolts_Free_Multimedia_Floppy_24;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(408, 528);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(73, 48);
            btSave.TabIndex = 43;
            btSave.Text = "Lưu";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btEdit
            // 
            btEdit.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file_32;
            btEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btEdit.Location = new Point(322, 530);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(80, 48);
            btEdit.TabIndex = 42;
            btEdit.Text = "Sửa";
            btEdit.TextAlign = ContentAlignment.MiddleRight;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDel
            // 
            btDel.Image = (Image)resources.GetObject("btDel.Image");
            btDel.ImageAlign = ContentAlignment.MiddleLeft;
            btDel.Location = new Point(240, 528);
            btDel.Margin = new Padding(3, 4, 3, 4);
            btDel.Name = "btDel";
            btDel.Size = new Size(76, 48);
            btDel.TabIndex = 41;
            btDel.Text = "Xóa";
            btDel.TextAlign = ContentAlignment.MiddleRight;
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btAdd
            // 
            btAdd.Image = Properties.Resources.add;
            btAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btAdd.Location = new Point(150, 528);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(84, 48);
            btAdd.TabIndex = 40;
            btAdd.Text = "Thêm";
            btAdd.TextAlign = ContentAlignment.MiddleRight;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btExit);
            Controls.Add(btShowList);
            Controls.Add(btSkip);
            Controls.Add(btSave);
            Controls.Add(btEdit);
            Controls.Add(btDel);
            Controls.Add(btAdd);
            Controls.Add(groupBox1);
            Controls.Add(rtxtAddress);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(txtFindPhonenumber);
            Controls.Add(btFind);
            Controls.Add(dataGridViewKhachhang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            Load += FrmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachhang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbtNu;
        private RadioButton rbtNam;
        private GroupBox groupBox1;
        private RichTextBox rtxtAddress;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtFindPhonenumber;
        private Button btFind;
        private DataGridView dataGridViewKhachhang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btExit;
        private Button btShowList;
        private Button btSkip;
        private Button btSave;
        private Button btEdit;
        private Button btDel;
        private Button btAdd;
    }
}