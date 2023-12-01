namespace FishShop
{
    partial class FormFishShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFishShop));
            dateSearch = new DateTimePicker();
            btnAddHD = new Button();
            btnQLCa = new Button();
            groupBox1 = new GroupBox();
            dataGridHD = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridCTHD = new DataGridView();
            ColumnNameCa = new DataGridViewTextBoxColumn();
            ColumnImage = new DataGridViewImageColumn();
            ColumnSoLuong = new DataGridViewTextBoxColumn();
            ColumnDonGia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnLoadAll = new Button();
            btnLogOut = new Button();
            btnDeleteHD = new Button();
            btnResetPass = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnKH = new DataGridViewTextBoxColumn();
            ColumnTongTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHD).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCTHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateSearch
            // 
            dateSearch.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateSearch.Location = new Point(514, 207);
            dateSearch.Name = "dateSearch";
            dateSearch.Size = new Size(270, 33);
            dateSearch.TabIndex = 1;
            dateSearch.ValueChanged += dateSearch_ValueChanged;
            // 
            // btnAddHD
            // 
            btnAddHD.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddHD.Location = new Point(977, 168);
            btnAddHD.Name = "btnAddHD";
            btnAddHD.Size = new Size(109, 72);
            btnAddHD.TabIndex = 3;
            btnAddHD.Text = "Hóa Đơn Mới";
            btnAddHD.UseVisualStyleBackColor = true;
            btnAddHD.Click += btnAddHD_Click;
            // 
            // btnQLCa
            // 
            btnQLCa.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCa.Location = new Point(1666, 163);
            btnQLCa.Name = "btnQLCa";
            btnQLCa.Size = new Size(124, 72);
            btnQLCa.TabIndex = 5;
            btnQLCa.Text = "Quản lý loại cá";
            btnQLCa.UseVisualStyleBackColor = true;
            btnQLCa.Click += btnQLCa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridHD);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(118, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(809, 798);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridHD
            // 
            dataGridHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHD.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnDate, ColumnKH, ColumnTongTien });
            dataGridHD.Location = new Point(6, 36);
            dataGridHD.Name = "dataGridHD";
            dataGridHD.RowTemplate.Height = 25;
            dataGridHD.Size = new Size(795, 756);
            dataGridHD.TabIndex = 0;
            dataGridHD.CellClick += dataGridHD_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridCTHD);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(977, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 798);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dataGridCTHD
            // 
            dataGridCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCTHD.Columns.AddRange(new DataGridViewColumn[] { ColumnNameCa, ColumnImage, ColumnSoLuong, ColumnDonGia });
            dataGridCTHD.Location = new Point(6, 36);
            dataGridCTHD.Name = "dataGridCTHD";
            dataGridCTHD.RowTemplate.Height = 25;
            dataGridCTHD.Size = new Size(796, 756);
            dataGridCTHD.TabIndex = 0;
            dataGridCTHD.CellFormatting += dataGridCTHD_CellFormatting;
            // 
            // ColumnNameCa
            // 
            ColumnNameCa.HeaderText = "Tên Cá";
            ColumnNameCa.Name = "ColumnNameCa";
            ColumnNameCa.Width = 300;
            // 
            // ColumnImage
            // 
            ColumnImage.HeaderText = "Hình ảnh";
            ColumnImage.Name = "ColumnImage";
            // 
            // ColumnSoLuong
            // 
            ColumnSoLuong.HeaderText = "Số Lượng";
            ColumnSoLuong.Name = "ColumnSoLuong";
            ColumnSoLuong.Resizable = DataGridViewTriState.True;
            ColumnSoLuong.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnSoLuong.Width = 150;
            // 
            // ColumnDonGia
            // 
            ColumnDonGia.HeaderText = "Đơn Giá";
            ColumnDonGia.Name = "ColumnDonGia";
            ColumnDonGia.Resizable = DataGridViewTriState.True;
            ColumnDonGia.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnDonGia.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(732, 12);
            label1.Name = "label1";
            label1.Size = new Size(433, 98);
            label1.TabIndex = 8;
            label1.Text = "FishShop";
            // 
            // btnLoadAll
            // 
            btnLoadAll.BackColor = SystemColors.MenuHighlight;
            btnLoadAll.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadAll.ForeColor = SystemColors.ButtonFace;
            btnLoadAll.Location = new Point(810, 168);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(117, 77);
            btnLoadAll.TabIndex = 2;
            btnLoadAll.Text = "Tất cả hóa đơn";
            btnLoadAll.UseVisualStyleBackColor = false;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Gold;
            btnLogOut.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Location = new Point(1654, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(136, 42);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDeleteHD
            // 
            btnDeleteHD.BackColor = Color.Firebrick;
            btnDeleteHD.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteHD.ForeColor = SystemColors.ButtonFace;
            btnDeleteHD.Location = new Point(1452, 168);
            btnDeleteHD.Name = "btnDeleteHD";
            btnDeleteHD.Size = new Size(109, 72);
            btnDeleteHD.TabIndex = 4;
            btnDeleteHD.Text = "Xóa Hóa Đơn";
            btnDeleteHD.UseVisualStyleBackColor = false;
            btnDeleteHD.Click += btnDeleteHD_Click;
            // 
            // btnResetPass
            // 
            btnResetPass.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetPass.Location = new Point(1477, 12);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(158, 42);
            btnResetPass.TabIndex = 6;
            btnResetPass.Text = "Đổi mật khẩu";
            btnResetPass.UseVisualStyleBackColor = true;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(1816, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 42);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "Mã hóa đơn";
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 120;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Ngày";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.Width = 230;
            // 
            // ColumnKH
            // 
            ColumnKH.HeaderText = "Khách hàng";
            ColumnKH.Name = "ColumnKH";
            ColumnKH.Width = 200;
            // 
            // ColumnTongTien
            // 
            ColumnTongTien.HeaderText = "Tổng tiền";
            ColumnTongTien.Name = "ColumnTongTien";
            ColumnTongTien.Width = 200;
            // 
            // FormFishShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1918, 1061);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnResetPass);
            Controls.Add(btnDeleteHD);
            Controls.Add(btnLogOut);
            Controls.Add(btnLoadAll);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnQLCa);
            Controls.Add(btnAddHD);
            Controls.Add(dateSearch);
            MaximizeBox = false;
            Name = "FormFishShop";
            ShowIcon = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Maximized;
            Load += FishShop_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHD).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCTHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateSearch;
        private Button btnAddHD;
        private Button btnQLCa;
        private GroupBox groupBox1;
        private DataGridView dataGridHD;
        private GroupBox groupBox2;
        private DataGridView dataGridCTHD;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnNameCa;
        private DataGridViewImageColumn ColumnImage;
        private DataGridViewTextBoxColumn ColumnSoLuong;
        private DataGridViewTextBoxColumn ColumnDonGia;
        private Button btnLoadAll;
        private Button btnLogOut;
        private Button btnExit;
        private Button btnDeleteHD;
        private Button btnResetPass;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnKH;
        private DataGridViewTextBoxColumn ColumnTongTien;
    }
}