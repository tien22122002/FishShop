namespace FishShop.View
{
    partial class FormHoaDon
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
            btn_addHD = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNameKH = new TextBox();
            dataGridCTHD = new DataGridView();
            columeNameFish = new DataGridViewComboBoxColumn();
            Column_number = new DataGridViewTextBoxColumn();
            column_image = new DataGridViewImageColumn();
            column_color = new DataGridViewTextBoxColumn();
            Column_NG = new DataGridViewTextBoxColumn();
            Column_price = new DataGridViewTextBoxColumn();
            column_TT = new DataGridViewTextBoxColumn();
            lbTongTien = new Label();
            btnExit = new Button();
            label3 = new Label();
            lb_Money = new Label();
            txtTienMat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCTHD).BeginInit();
            SuspendLayout();
            // 
            // btn_addHD
            // 
            btn_addHD.BackColor = Color.Green;
            btn_addHD.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addHD.ForeColor = SystemColors.ButtonFace;
            btn_addHD.Location = new Point(536, 591);
            btn_addHD.Name = "btn_addHD";
            btn_addHD.Size = new Size(111, 42);
            btn_addHD.TabIndex = 0;
            btn_addHD.Text = "Lưu + In";
            btn_addHD.UseVisualStyleBackColor = false;
            btn_addHD.Click += btn_addHD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 1;
            label1.Text = "HÓA ĐƠN MỚI";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(225, 493);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng:";
            // 
            // txtNameKH
            // 
            txtNameKH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameKH.Location = new Point(379, 493);
            txtNameKH.Name = "txtNameKH";
            txtNameKH.PlaceholderText = "Tên khách hàng . . .";
            txtNameKH.Size = new Size(141, 25);
            txtNameKH.TabIndex = 3;
            // 
            // dataGridCTHD
            // 
            dataGridCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCTHD.Columns.AddRange(new DataGridViewColumn[] { columeNameFish, Column_number, column_image, column_color, Column_NG, Column_price, column_TT });
            dataGridCTHD.Location = new Point(0, 97);
            dataGridCTHD.Name = "dataGridCTHD";
            dataGridCTHD.RowTemplate.Height = 25;
            dataGridCTHD.Size = new Size(783, 378);
            dataGridCTHD.TabIndex = 4;
            dataGridCTHD.CellEndEdit += dataGridCTHD_CellEndEdit;
            dataGridCTHD.CellFormatting += dataGridCTHD_CellFormatting;
            dataGridCTHD.CellValidating += dataGridCTHD_CellValidating;
            // 
            // columeNameFish
            // 
            columeNameFish.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            columeNameFish.HeaderText = "Cá";
            columeNameFish.Name = "columeNameFish";
            columeNameFish.Width = 180;
            // 
            // Column_number
            // 
            Column_number.HeaderText = "Số lượng";
            Column_number.Name = "Column_number";
            Column_number.Width = 80;
            // 
            // column_image
            // 
            column_image.HeaderText = "Hình ảnh";
            column_image.Name = "column_image";
            column_image.Width = 80;
            // 
            // column_color
            // 
            column_color.HeaderText = "Màu";
            column_color.Name = "column_color";
            // 
            // Column_NG
            // 
            Column_NG.HeaderText = "Nguồn gốc";
            Column_NG.Name = "Column_NG";
            // 
            // Column_price
            // 
            Column_price.HeaderText = "Đơn giá";
            Column_price.Name = "Column_price";
            // 
            // column_TT
            // 
            column_TT.HeaderText = "Thành tiền";
            column_TT.Name = "column_TT";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongTien.Location = new Point(536, 497);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(173, 21);
            lbTongTien.TabIndex = 6;
            lbTongTien.Text = "Tổng hóa đơn: 0 VNĐ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(674, 591);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 42);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(225, 540);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 8;
            label3.Text = "Tiền mặt (VNĐ):";
            // 
            // lb_Money
            // 
            lb_Money.AutoSize = true;
            lb_Money.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Money.Location = new Point(536, 540);
            lb_Money.Name = "lb_Money";
            lb_Money.Size = new Size(158, 21);
            lb_Money.TabIndex = 9;
            lb_Money.Text = "Tiền thối lại: 0 VNĐ";
            // 
            // txtTienMat
            // 
            txtTienMat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTienMat.Location = new Point(379, 538);
            txtTienMat.Name = "txtTienMat";
            txtTienMat.Size = new Size(141, 27);
            txtTienMat.TabIndex = 10;
            txtTienMat.TextChanged += txtTienMat_TextChanged;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 645);
            Controls.Add(txtTienMat);
            Controls.Add(lb_Money);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(lbTongTien);
            Controls.Add(dataGridCTHD);
            Controls.Add(txtNameKH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_addHD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormHoaDon";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCTHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addHD;
        private Label label1;
        private Label label2;
        private TextBox txtNameKH;
        private DataGridView dataGridCTHD;
        private Label lbTongTien;
        private Button btnExit;
        private DataGridViewComboBoxColumn columeNameFish;
        private DataGridViewTextBoxColumn Column_number;
        private DataGridViewImageColumn column_image;
        private DataGridViewTextBoxColumn column_color;
        private DataGridViewTextBoxColumn Column_NG;
        private DataGridViewTextBoxColumn Column_price;
        private DataGridViewTextBoxColumn column_TT;
        private Label label3;
        private Label lb_Money;
        private TextBox txtTienMat;
    }
}