namespace ASM.UI_Nhân_Viên
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            btExit = new Button();
            btShowList = new Button();
            btSkip = new Button();
            btSave = new Button();
            btEdit = new Button();
            btDel = new Button();
            rbQL = new RadioButton();
            rbNV = new RadioButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            btAdd = new Button();
            rtxtAddress = new RichTextBox();
            txtEmail = new TextBox();
            btFind = new Button();
            dataGridViewNhanVien = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rbNHD = new RadioButton();
            rbHD = new RadioButton();
            groupBox1 = new GroupBox();
            txtName = new TextBox();
            txtFindname = new TextBox();
            label7 = new Label();
            txtMatkhau = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Image = Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_1_24;
            btExit.ImageAlign = ContentAlignment.MiddleLeft;
            btExit.Location = new Point(705, 60);
            btExit.Margin = new Padding(3, 4, 3, 4);
            btExit.Name = "btExit";
            btExit.Size = new Size(86, 48);
            btExit.TabIndex = 85;
            btExit.Text = "Đóng";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btShowList
            // 
            btShowList.Image = Properties.Resources.Webalys_Kameleon_pics_Checklist_24;
            btShowList.ImageAlign = ContentAlignment.MiddleLeft;
            btShowList.Location = new Point(584, 60);
            btShowList.Margin = new Padding(3, 4, 3, 4);
            btShowList.Name = "btShowList";
            btShowList.Size = new Size(115, 48);
            btShowList.TabIndex = 86;
            btShowList.Text = "Danh Sách";
            btShowList.TextAlign = ContentAlignment.MiddleRight;
            btShowList.UseVisualStyleBackColor = true;
            btShowList.Click += btShowList_Click;
            // 
            // btSkip
            // 
            btSkip.Image = Properties.Resources.Designbolts_Free_Multimedia_Forward_24;
            btSkip.ImageAlign = ContentAlignment.MiddleLeft;
            btSkip.Location = new Point(484, 62);
            btSkip.Margin = new Padding(3, 4, 3, 4);
            btSkip.Name = "btSkip";
            btSkip.Size = new Size(94, 48);
            btSkip.TabIndex = 84;
            btSkip.Text = "Bỏ Qua";
            btSkip.TextAlign = ContentAlignment.MiddleRight;
            btSkip.UseVisualStyleBackColor = true;
            btSkip.Click += btSkip_Click;
            // 
            // btSave
            // 
            btSave.Image = Properties.Resources.Designbolts_Free_Multimedia_Floppy_24;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(405, 60);
            btSave.Margin = new Padding(3, 4, 3, 4);
            btSave.Name = "btSave";
            btSave.Size = new Size(73, 48);
            btSave.TabIndex = 83;
            btSave.Text = "Lưu";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btEdit
            // 
            btEdit.Image = Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file_32;
            btEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btEdit.Location = new Point(319, 62);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(80, 48);
            btEdit.TabIndex = 82;
            btEdit.Text = "Sửa";
            btEdit.TextAlign = ContentAlignment.MiddleRight;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDel
            // 
            btDel.Image = (Image)resources.GetObject("btDel.Image");
            btDel.ImageAlign = ContentAlignment.MiddleLeft;
            btDel.Location = new Point(237, 60);
            btDel.Margin = new Padding(3, 4, 3, 4);
            btDel.Name = "btDel";
            btDel.Size = new Size(76, 48);
            btDel.TabIndex = 81;
            btDel.Text = "Xóa";
            btDel.TextAlign = ContentAlignment.MiddleRight;
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // rbQL
            // 
            rbQL.AutoSize = true;
            rbQL.Location = new Point(124, 17);
            rbQL.Margin = new Padding(3, 4, 3, 4);
            rbQL.Name = "rbQL";
            rbQL.Size = new Size(82, 24);
            rbQL.TabIndex = 1;
            rbQL.TabStop = true;
            rbQL.Text = "Quản Lý";
            rbQL.UseVisualStyleBackColor = true;
            // 
            // rbNV
            // 
            rbNV.AutoSize = true;
            rbNV.Location = new Point(10, 17);
            rbNV.Margin = new Padding(3, 4, 3, 4);
            rbNV.Name = "rbNV";
            rbNV.Size = new Size(98, 24);
            rbNV.TabIndex = 0;
            rbNV.TabStop = true;
            rbNV.Text = "Nhân Viên";
            rbNV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbQL);
            groupBox2.Controls.Add(rbNV);
            groupBox2.Location = new Point(117, 151);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(227, 43);
            groupBox2.TabIndex = 80;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 168);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 78;
            label6.Text = "Quyền ";
            // 
            // btAdd
            // 
            btAdd.Image = Properties.Resources.add;
            btAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btAdd.Location = new Point(147, 60);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(84, 48);
            btAdd.TabIndex = 79;
            btAdd.Text = "Thêm";
            btAdd.TextAlign = ContentAlignment.MiddleRight;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(553, 52);
            rtxtAddress.Margin = new Padding(3, 4, 3, 4);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(349, 75);
            rtxtAddress.TabIndex = 76;
            rtxtAddress.Text = "";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 70);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 27);
            txtEmail.TabIndex = 74;
            // 
            // btFind
            // 
            btFind.Image = Properties.Resources.Zerode_Plump_Search_24;
            btFind.ImageAlign = ContentAlignment.MiddleLeft;
            btFind.Location = new Point(539, 9);
            btFind.Margin = new Padding(3, 4, 3, 4);
            btFind.Name = "btFind";
            btFind.Size = new Size(113, 45);
            btFind.TabIndex = 72;
            btFind.Text = "Tìm Kiếm";
            btFind.TextAlign = ContentAlignment.MiddleRight;
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanVien.Location = new Point(12, 230);
            dataGridViewNhanVien.Margin = new Padding(3, 4, 3, 4);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.RowTemplate.Height = 25;
            dataGridViewNhanVien.Size = new Size(894, 249);
            dataGridViewNhanVien.TabIndex = 71;
            dataGridViewNhanVien.CellContentClick += dataGridViewNhanVien_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 55);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 69;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 151);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 68;
            label4.Text = "Tình Trạng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 120);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 67;
            label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 55);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 70;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(341, 3);
            label1.Name = "label1";
            label1.Size = new Size(156, 41);
            label1.TabIndex = 66;
            label1.Text = "Nhân Viên";
            // 
            // rbNHD
            // 
            rbNHD.AutoSize = true;
            rbNHD.Location = new Point(120, 16);
            rbNHD.Margin = new Padding(3, 4, 3, 4);
            rbNHD.Name = "rbNHD";
            rbNHD.Size = new Size(154, 24);
            rbNHD.TabIndex = 1;
            rbNHD.TabStop = true;
            rbNHD.Text = "Ngưng Hoạt Động";
            rbNHD.UseVisualStyleBackColor = true;
            // 
            // rbHD
            // 
            rbHD.AutoSize = true;
            rbHD.Location = new Point(6, 16);
            rbHD.Margin = new Padding(3, 4, 3, 4);
            rbHD.Name = "rbHD";
            rbHD.Size = new Size(108, 24);
            rbHD.TabIndex = 0;
            rbHD.TabStop = true;
            rbHD.Text = "Hoạt Động ";
            rbHD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNHD);
            groupBox1.Controls.Add(rbHD);
            groupBox1.Location = new Point(553, 135);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(282, 46);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 116);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 27);
            txtName.TabIndex = 75;
            // 
            // txtFindname
            // 
            txtFindname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFindname.Location = new Point(270, 16);
            txtFindname.Margin = new Padding(3, 4, 3, 4);
            txtFindname.Name = "txtFindname";
            txtFindname.Size = new Size(261, 30);
            txtFindname.TabIndex = 73;
            txtFindname.Text = "Nhập Tên Nhân Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 191);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 68;
            label7.Text = "Mật Khẩu";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(553, 189);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(282, 27);
            txtMatkhau.TabIndex = 87;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewNhanVien);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 604);
            panel1.TabIndex = 88;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btExit);
            panel3.Controls.Add(btShowList);
            panel3.Controls.Add(btSkip);
            panel3.Controls.Add(btSave);
            panel3.Controls.Add(btEdit);
            panel3.Controls.Add(btDel);
            panel3.Controls.Add(btAdd);
            panel3.Controls.Add(btFind);
            panel3.Controls.Add(txtFindname);
            panel3.Location = new Point(0, 481);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 123);
            panel3.TabIndex = 89;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(txtMatkhau);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rtxtAddress);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 220);
            panel2.TabIndex = 88;
            panel2.Paint += panel2_Paint;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 604);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            Load += FrmNhanVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btExit;
        private Button btShowList;
        private Button btSkip;
        private Button btSave;
        private Button btEdit;
        private Button btDel;
        private RadioButton rbQL;
        private RadioButton rbNV;
        private GroupBox groupBox2;
        private Label label6;
        private Button btAdd;
        private RichTextBox rtxtAddress;
        private TextBox txtEmail;
        private Button btFind;
        private DataGridView dataGridViewNhanVien;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbNHD;
        private RadioButton rbHD;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtFindname;
        private Label label7;
        private TextBox txtMatkhau;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}