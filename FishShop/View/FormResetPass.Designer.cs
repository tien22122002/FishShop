namespace FishShop.View
{
    partial class FormResetPass
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
            label2 = new Label();
            txtTK = new TextBox();
            btnLuuMK = new Button();
            btnExit = new Button();
            txtPassOld = new TextBox();
            label3 = new Label();
            txtPassNew = new TextBox();
            label4 = new Label();
            txtPassCheck = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 13);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 0;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 100);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTK.Location = new Point(343, 97);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(170, 25);
            txtTK.TabIndex = 4;
            // 
            // btnLuuMK
            // 
            btnLuuMK.BackColor = Color.Lime;
            btnLuuMK.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuuMK.ForeColor = SystemColors.ButtonHighlight;
            btnLuuMK.Location = new Point(343, 284);
            btnLuuMK.Name = "btnLuuMK";
            btnLuuMK.Size = new Size(75, 34);
            btnLuuMK.TabIndex = 9;
            btnLuuMK.Text = "lưu";
            btnLuuMK.UseVisualStyleBackColor = false;
            btnLuuMK.Click += btnLuuMK_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(438, 284);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Hủy";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtPassOld
            // 
            txtPassOld.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassOld.Location = new Point(343, 143);
            txtPassOld.Name = "txtPassOld";
            txtPassOld.Size = new Size(170, 25);
            txtPassOld.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(189, 146);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu cũ";
            // 
            // txtPassNew
            // 
            txtPassNew.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassNew.Location = new Point(343, 190);
            txtPassNew.Name = "txtPassNew";
            txtPassNew.Size = new Size(170, 25);
            txtPassNew.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(189, 193);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 13;
            label4.Text = "Mật khẩu mới";
            // 
            // txtPassCheck
            // 
            txtPassCheck.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassCheck.Location = new Point(343, 236);
            txtPassCheck.Name = "txtPassCheck";
            txtPassCheck.Size = new Size(170, 25);
            txtPassCheck.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(189, 239);
            label5.Name = "label5";
            label5.Size = new Size(131, 19);
            label5.TabIndex = 15;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // FormResetPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background3;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(698, 351);
            Controls.Add(txtPassCheck);
            Controls.Add(label5);
            Controls.Add(txtPassNew);
            Controls.Add(label4);
            Controls.Add(txtPassOld);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnLuuMK);
            Controls.Add(txtTK);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormResetPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += FormResetPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTK;
        private Button btnLuuMK;
        private Button btnExit;
        private TextBox txtPassOld;
        private Label label3;
        private TextBox txtPassNew;
        private Label label4;
        private TextBox txtPassCheck;
        private Label label5;
    }
}