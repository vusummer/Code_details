namespace ASM.UI_Đăng_Nhập.ForgotPass
{
    partial class FrmForgotwcode
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
            btGui = new Button();
            txtNewpass = new TextBox();
            label4 = new Label();
            txtCode = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btExit = new Button();
            SuspendLayout();
            // 
            // btGui
            // 
            btGui.Location = new Point(54, 314);
            btGui.Name = "btGui";
            btGui.Size = new Size(284, 29);
            btGui.TabIndex = 16;
            btGui.Text = "Đổi Mật Khẩu";
            btGui.UseVisualStyleBackColor = true;
            btGui.Click += btGui_Click;
            // 
            // txtNewpass
            // 
            txtNewpass.Location = new Point(30, 262);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(341, 27);
            txtNewpass.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 239);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu Mới";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(30, 198);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(341, 27);
            txtCode.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 175);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Mã Đặt Lại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 27);
            txtEmail.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 113);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 10;
            label2.Text = "Email Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 48);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 6;
            label1.Text = "Lấy Lại Mật Khẩu";
            label1.Click += label1_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(54, 349);
            btExit.Name = "btExit";
            btExit.Size = new Size(284, 29);
            btExit.TabIndex = 15;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            // 
            // FrmForgotwcode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 390);
            Controls.Add(btExit);
            Controls.Add(btGui);
            Controls.Add(txtNewpass);
            Controls.Add(label4);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmForgotwcode";
            Text = "FrmForgotwcode";
            Load += FrmForgotwcode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btGui;
        private TextBox txtNewpass;
        private Label label4;
        private TextBox txtCode;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Button btExit;
    }
}