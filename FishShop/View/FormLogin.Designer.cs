namespace FishShop.view
{
    partial class FormLogin
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
            loginLabel = new Label();
            tb_userName = new TextBox();
            tb_password = new TextBox();
            userNameLable = new Label();
            passwordLabel = new Label();
            btn_login = new Button();
            btn_reset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.ForestGreen;
            loginLabel.Location = new Point(156, 59);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(259, 30);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "LOGIN ADMIN SYSTEM";
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(251, 144);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(191, 23);
            tb_userName.TabIndex = 8;
            tb_userName.KeyDown += tb_userName_KeyDown;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(251, 190);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(191, 23);
            tb_password.TabIndex = 9;
            tb_password.KeyDown += tb_password_KeyDown;
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLable.ForeColor = Color.DarkGreen;
            userNameLable.Location = new Point(142, 144);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(83, 20);
            userNameLable.TabIndex = 10;
            userNameLable.Text = "UserName";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.DarkGreen;
            passwordLabel.Location = new Point(142, 190);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.OliveDrab;
            btn_login.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(142, 241);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(147, 30);
            btn_login.TabIndex = 12;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.DarkOrange;
            btn_reset.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reset.Location = new Point(295, 241);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(147, 30);
            btn_reset.TabIndex = 13;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(479, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 30);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 354);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btn_reset);
            Controls.Add(btn_login);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLable);
            Controls.Add(tb_password);
            Controls.Add(tb_userName);
            Controls.Add(loginLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private TextBox tb_userName;
        private TextBox tb_password;
        private Label userNameLable;
        private Label passwordLabel;
        private Button btn_login;
        private Button btn_reset;
        private Button btnExit;
    }
}