namespace ASM.UI_Đăng_Nhập
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            btExit = new Button();
            btGui = new Button();
            txtPass = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            lbFogotpass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Location = new Point(85, 362);
            btExit.Name = "btExit";
            btExit.Size = new Size(284, 29);
            btExit.TabIndex = 15;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btGui
            // 
            btGui.Location = new Point(85, 327);
            btGui.Name = "btGui";
            btGui.Size = new Size(284, 29);
            btGui.TabIndex = 16;
            btGui.Text = "Đăng Nhập";
            btGui.UseVisualStyleBackColor = true;
            btGui.Click += btGui_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(57, 225);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(341, 27);
            txtPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 202);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Mật Khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 27);
            txtEmail.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 140);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 10;
            label2.Text = "Email Đăng Nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 85);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 6;
            label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(185, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(57, 268);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(164, 24);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ghi Nhớ Đăng Nhập";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbFogotpass
            // 
            lbFogotpass.AutoSize = true;
            lbFogotpass.Location = new Point(262, 268);
            lbFogotpass.Name = "lbFogotpass";
            lbFogotpass.Size = new Size(122, 20);
            lbFogotpass.TabIndex = 18;
            lbFogotpass.Text = "Quên Mật Khẩu ?";
            lbFogotpass.Click += label4_Click;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(lbFogotpass);
            Controls.Add(radioButton1);
            Controls.Add(btExit);
            Controls.Add(btGui);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDangNhap";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "FrmDangNhap";
            Load += FrmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btGui;
        private TextBox txtPass;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private Label lbFogotpass;
    }
}