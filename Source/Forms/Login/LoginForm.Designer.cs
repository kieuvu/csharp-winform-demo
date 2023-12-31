﻿namespace RestaurantManagement.Source.Forms.Login
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            LoginHandlerButton = new Button();
            LoginPassword = new TextBox();
            LoginUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(this.components);
            errorProvider2 = new ErrorProvider(this.components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(LoginHandlerButton);
            groupBox1.Controls.Add(LoginPassword);
            groupBox1.Controls.Add(LoginUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(97, 116);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "Nhân viên";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += this.radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(16, 116);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Quản lý";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // LoginHandlerButton
            // 
            LoginHandlerButton.Cursor = Cursors.Hand;
            LoginHandlerButton.Location = new Point(200, 108);
            LoginHandlerButton.Name = "LoginHandlerButton";
            LoginHandlerButton.Size = new Size(97, 35);
            LoginHandlerButton.TabIndex = 5;
            LoginHandlerButton.Text = "Đăng nhập";
            LoginHandlerButton.UseVisualStyleBackColor = true;
            LoginHandlerButton.Click += this.LoginHandlerButton_Click;
            // 
            // LoginPassword
            // 
            LoginPassword.Location = new Point(107, 71);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.PasswordChar = '*';
            LoginPassword.Size = new Size(190, 23);
            LoginPassword.TabIndex = 3;
            // 
            // LoginUsername
            // 
            LoginUsername.Location = new Point(107, 40);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(190, 23);
            LoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(344, 181);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = new Size(360, 220);
            this.MinimumSize = new Size(360, 220);
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Vukm";
            this.Load += this.LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox LoginPassword;
        private TextBox LoginUsername;
        private Label label2;
        private Label label1;
        private Button LoginHandlerButton;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}