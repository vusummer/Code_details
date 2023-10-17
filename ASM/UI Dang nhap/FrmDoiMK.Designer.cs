namespace ASM
{
    partial class FrmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMK));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtOldPass = new TextBox();
            label4 = new Label();
            txtNewpass = new TextBox();
            label5 = new Label();
            txtNhaplai = new TextBox();
            btGui = new Button();
            btExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(148, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 91);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "Đổi Mật Khẩu Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 121);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "Email Nhân Viên";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 27);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 183);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu Cũ";
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(22, 206);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(341, 27);
            txtOldPass.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 247);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu Mới";
            // 
            // txtNewpass
            // 
            txtNewpass.Location = new Point(22, 270);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(341, 27);
            txtNewpass.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 311);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 2;
            label5.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtNhaplai
            // 
            txtNhaplai.Location = new Point(22, 334);
            txtNhaplai.Name = "txtNhaplai";
            txtNhaplai.Size = new Size(341, 27);
            txtNhaplai.TabIndex = 3;
            // 
            // btGui
            // 
            btGui.Location = new Point(46, 381);
            btGui.Name = "btGui";
            btGui.Size = new Size(284, 29);
            btGui.TabIndex = 4;
            btGui.Text = "Đổi Mật Khẩu";
            btGui.UseVisualStyleBackColor = true;
            btGui.Click += btGui_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(46, 416);
            btExit.Name = "btExit";
            btExit.Size = new Size(284, 29);
            btExit.TabIndex = 4;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            // 
            // FrmDoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 467);
            Controls.Add(btExit);
            Controls.Add(btGui);
            Controls.Add(txtNhaplai);
            Controls.Add(label5);
            Controls.Add(txtNewpass);
            Controls.Add(label4);
            Controls.Add(txtOldPass);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDoiMK";
            Text = "Form1";
            Load += FrmDoiMK_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtOldPass;
        private Label label4;
        private TextBox txtNewpass;
        private Label label5;
        private TextBox txtNhaplai;
        private Button btGui;
        private Button btExit;
    }
}