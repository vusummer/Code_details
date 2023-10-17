namespace ASM.UI_Đăng_Nhập
{
    partial class FrmForgot
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
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            btGui = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 122);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 61);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập Email để lấy lại mật khẩu";
            // 
            // btGui
            // 
            btGui.Location = new Point(142, 181);
            btGui.Name = "btGui";
            btGui.Size = new Size(119, 43);
            btGui.TabIndex = 3;
            btGui.Text = "Gửi";
            btGui.UseVisualStyleBackColor = true;
            btGui.Click += btGui_Click;
            // 
            // FrmForgot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 267);
            Controls.Add(btGui);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "FrmForgot";
            Text = "FrmForgot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Button btGui;
    }
}