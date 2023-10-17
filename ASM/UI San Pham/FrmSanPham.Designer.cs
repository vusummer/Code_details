namespace ASM
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            txtName = new TextBox();
            txtCode = new TextBox();
            textBox1 = new TextBox();
            dataGridViewsanpham = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtSl = new TextBox();
            label7 = new Label();
            txtDonGia = new TextBox();
            label5 = new Label();
            txtDonGiaban = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtHinh = new TextBox();
            richTextBox1 = new RichTextBox();
            btOpen = new Button();
            pictureBox1 = new PictureBox();
            btExit = new Button();
            btShowList = new Button();
            btSkip = new Button();
            btSave = new Button();
            btEdit = new Button();
            btDel = new Button();
            btAdd = new Button();
            btFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsanpham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 104);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 27);
            txtName.TabIndex = 24;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(130, 45);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(213, 27);
            txtCode.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(268, 631);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 34);
            textBox1.TabIndex = 22;
            textBox1.Text = "Nhập Tên Sản phẩm";
            // 
            // dataGridViewsanpham
            // 
            dataGridViewsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsanpham.Location = new Point(14, 337);
            dataGridViewsanpham.Margin = new Padding(3, 4, 3, 4);
            dataGridViewsanpham.Name = "dataGridViewsanpham";
            dataGridViewsanpham.RowHeadersWidth = 51;
            dataGridViewsanpham.RowTemplate.Height = 25;
            dataGridViewsanpham.Size = new Size(887, 249);
            dataGridViewsanpham.TabIndex = 13;
            dataGridViewsanpham.CellContentClick += dataGridViewsanpham_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 108);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Tên Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Mã Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 7;
            label1.Text = "Sản Phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 165);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Số Lượng";
            // 
            // txtSl
            // 
            txtSl.Location = new Point(130, 161);
            txtSl.Margin = new Padding(3, 4, 3, 4);
            txtSl.Name = "txtSl";
            txtSl.Size = new Size(213, 27);
            txtSl.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 220);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 8;
            label7.Text = "Đơn giá nhập";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(130, 216);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(213, 27);
            txtDonGia.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 275);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 8;
            label5.Text = "Đơn giá bán";
            // 
            // txtDonGiaban
            // 
            txtDonGiaban.Location = new Point(130, 271);
            txtDonGiaban.Margin = new Padding(3, 4, 3, 4);
            txtDonGiaban.Name = "txtDonGiaban";
            txtDonGiaban.Size = new Size(213, 27);
            txtDonGiaban.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 51);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 12;
            label6.Text = "Hình";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 117);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 12;
            label8.Text = "Ghi Chú";
            // 
            // txtHinh
            // 
            txtHinh.Location = new Point(413, 75);
            txtHinh.Margin = new Padding(3, 4, 3, 4);
            txtHinh.Name = "txtHinh";
            txtHinh.Size = new Size(179, 27);
            txtHinh.TabIndex = 23;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(413, 141);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(271, 111);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            // 
            // btOpen
            // 
            btOpen.Location = new Point(599, 75);
            btOpen.Margin = new Padding(3, 4, 3, 4);
            btOpen.Name = "btOpen";
            btOpen.Size = new Size(86, 31);
            btOpen.TabIndex = 26;
            btOpen.Text = "Mở hình";
            btOpen.UseVisualStyleBackColor = true;
            btOpen.Click += btOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(705, 49);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btExit
            // 
            btExit.Image = Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_1_24;
            btExit.ImageAlign = ContentAlignment.MiddleLeft;
            btExit.Location = new Point(675, 682);
            btExit.Margin = new Padding(3, 4, 3, 4);
            btExit.Name = "btExit";
            btExit.Size = new Size(86, 48);
            btExit.TabIndex = 53;
            btExit.Text = "Đóng";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btShowList
            // 
            btShowList.Image = Properties.Resources.Webalys_Kameleon_pics_Checklist_24;
            btShowList.ImageAlign = ContentAlignment.MiddleLeft;
            btShowList.Location = new Point(554, 680);
            btShowList.Margin = new Padding(3, 4, 3, 4);
            btShowList.Name = "btShowList";
            btShowList.Size = new Size(115, 48);
            btShowList.TabIndex = 54;
            btShowList.Text = "Danh Sách";
            btShowList.TextAlign = ContentAlignment.MiddleRight;
            btShowList.UseVisualStyleBackColor = true;
            btShowList.Click += btShowList_Click;
            // 
            // btSkip
            // 
            btSkip.Image = Properties.Resources.Designbolts_Free_Multimedia_Forward_24;
            btSkip.ImageAlign = ContentAlignment.MiddleLeft;
            btSkip.Location = new Point(454, 682);
            btSkip.Margin = new Padding(3, 4, 3, 4);
            btSkip.Name = "btSkip";
            btSkip.Size = new Size(94, 48);
            btSkip.TabIndex = 52;
            btSkip.Text = "Bỏ Qua";
            btSkip.TextAlign = ContentAlignment.MiddleRight;
            btSkip.UseVisualStyleBackColor = true;
            btSkip.Click += btSkip_Click;
            // 
            // btSave
            // 
            btSave.Image = Properties.Resources.Designbolts_Free_Multimedia_Floppy_24;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(375, 680);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(73, 48);
            btSave.TabIndex = 51;
            btSave.Text = "Lưu";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btEdit
            // 
            btEdit.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file_32;
            btEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btEdit.Location = new Point(289, 682);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(80, 48);
            btEdit.TabIndex = 50;
            btEdit.Text = "Sửa";
            btEdit.TextAlign = ContentAlignment.MiddleRight;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDel
            // 
            btDel.Image = (Image)resources.GetObject("btDel.Image");
            btDel.ImageAlign = ContentAlignment.MiddleLeft;
            btDel.Location = new Point(207, 680);
            btDel.Margin = new Padding(3, 4, 3, 4);
            btDel.Name = "btDel";
            btDel.Size = new Size(76, 48);
            btDel.TabIndex = 49;
            btDel.Text = "Xóa";
            btDel.TextAlign = ContentAlignment.MiddleRight;
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btAdd
            // 
            btAdd.Image = Properties.Resources.add;
            btAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btAdd.Location = new Point(117, 680);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(84, 48);
            btAdd.TabIndex = 48;
            btAdd.Text = "Thêm";
            btAdd.TextAlign = ContentAlignment.MiddleRight;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btFind
            // 
            btFind.Image = Properties.Resources.Zerode_Plump_Search_24;
            btFind.ImageAlign = ContentAlignment.MiddleLeft;
            btFind.Location = new Point(488, 631);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(104, 34);
            btFind.TabIndex = 47;
            btFind.Text = "Tìm Kiếm";
            btFind.TextAlign = ContentAlignment.MiddleRight;
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 743);
            Controls.Add(btExit);
            Controls.Add(btShowList);
            Controls.Add(btSkip);
            Controls.Add(btSave);
            Controls.Add(btEdit);
            Controls.Add(btDel);
            Controls.Add(btAdd);
            Controls.Add(btFind);
            Controls.Add(pictureBox1);
            Controls.Add(btOpen);
            Controls.Add(richTextBox1);
            Controls.Add(txtDonGiaban);
            Controls.Add(txtDonGia);
            Controls.Add(txtSl);
            Controls.Add(txtName);
            Controls.Add(txtHinh);
            Controls.Add(txtCode);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewsanpham);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSanPham";
            Text = "FrmSanPham";
            Load += FrmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewsanpham).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtCode;
        private TextBox textBox1;
        private DataGridView dataGridViewsanpham;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtSl;
        private Label label7;
        private TextBox txtDonGia;
        private Label label5;
        private TextBox txtDonGiaban;
        private Label label6;
        private Label label8;
        private TextBox txtHinh;
        private RichTextBox richTextBox1;
        private Button btOpen;
        private PictureBox pictureBox1;
        private Button btExit;
        private Button btShowList;
        private Button btSkip;
        private Button btSave;
        private Button btEdit;
        private Button btDel;
        private Button btAdd;
        private Button btFind;
    }
}