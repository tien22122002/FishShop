namespace FishShop.View
{
    partial class FormDSCa
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
            listFishLabel = new Label();
            dataGridListCa = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnDongCa = new DataGridViewTextBoxColumn();
            ColumnImage = new DataGridViewImageColumn();
            ColumnColor = new DataGridViewTextBoxColumn();
            ColumnOrigin = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnSoLuong = new DataGridViewTextBoxColumn();
            tb_search = new TextBox();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            groupBox1 = new GroupBox();
            txtImage = new TextBox();
            numberUpDown = new NumericUpDown();
            label_soluong = new Label();
            txtDonGia = new TextBox();
            label_gia = new Label();
            txtNguonGoc = new TextBox();
            label_nguongoc = new Label();
            txtColor = new TextBox();
            label_mausac = new Label();
            btn_choosefile = new Button();
            label_hinhanh = new Label();
            cbbMaCa = new ComboBox();
            label_dongca = new Label();
            txtTenCa = new TextBox();
            label_tenca = new Label();
            ID = new DataGridViewTextBoxColumn();
            fishName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridListCa).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberUpDown).BeginInit();
            SuspendLayout();
            // 
            // listFishLabel
            // 
            listFishLabel.AutoSize = true;
            listFishLabel.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            listFishLabel.ForeColor = Color.ForestGreen;
            listFishLabel.Location = new Point(461, 18);
            listFishLabel.Name = "listFishLabel";
            listFishLabel.Size = new Size(238, 46);
            listFishLabel.TabIndex = 9;
            listFishLabel.Text = "LIST OF FISH";
            // 
            // dataGridListCa
            // 
            dataGridListCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridListCa.BackgroundColor = SystemColors.Control;
            dataGridListCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListCa.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName, ColumnDongCa, ColumnImage, ColumnColor, ColumnOrigin, ColumnPrice, ColumnSoLuong });
            dataGridListCa.Location = new Point(11, 310);
            dataGridListCa.Name = "dataGridListCa";
            dataGridListCa.RowTemplate.Height = 25;
            dataGridListCa.Size = new Size(1158, 563);
            dataGridListCa.TabIndex = 10;
            dataGridListCa.CellClick += dataGridListCa_CellClick;
            dataGridListCa.CellFormatting += dgv_listFish_CellFormatting;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 60;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Tên Cá";
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 250;
            // 
            // ColumnDongCa
            // 
            ColumnDongCa.HeaderText = "Dòng Cá";
            ColumnDongCa.Name = "ColumnDongCa";
            ColumnDongCa.Width = 200;
            // 
            // ColumnImage
            // 
            ColumnImage.HeaderText = "Hình Ảnh";
            ColumnImage.Name = "ColumnImage";
            ColumnImage.Width = 80;
            // 
            // ColumnColor
            // 
            ColumnColor.HeaderText = "Màu";
            ColumnColor.Name = "ColumnColor";
            ColumnColor.Width = 120;
            // 
            // ColumnOrigin
            // 
            ColumnOrigin.HeaderText = "Nguồn Gốc";
            ColumnOrigin.Name = "ColumnOrigin";
            ColumnOrigin.Width = 120;
            // 
            // ColumnPrice
            // 
            ColumnPrice.HeaderText = "Đơn Giá";
            ColumnPrice.Name = "ColumnPrice";
            ColumnPrice.Width = 150;
            // 
            // ColumnSoLuong
            // 
            ColumnSoLuong.HeaderText = "Số Lượng";
            ColumnSoLuong.Name = "ColumnSoLuong";
            // 
            // tb_search
            // 
            tb_search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.Location = new Point(731, 173);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Search ...";
            tb_search.Size = new Size(299, 33);
            tb_search.TabIndex = 11;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.OliveDrab;
            btn_insert.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insert.Location = new Point(31, 173);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(128, 35);
            btn_insert.TabIndex = 13;
            btn_insert.Text = "INSERT";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Goldenrod;
            btn_update.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(178, 174);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(128, 34);
            btn_update.TabIndex = 14;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(328, 174);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(128, 34);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "REMOVE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(txtImage);
            groupBox1.Controls.Add(tb_search);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(numberUpDown);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(btn_insert);
            groupBox1.Controls.Add(label_soluong);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label_gia);
            groupBox1.Controls.Add(txtNguonGoc);
            groupBox1.Controls.Add(label_nguongoc);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label_mausac);
            groupBox1.Controls.Add(btn_choosefile);
            groupBox1.Controls.Add(label_hinhanh);
            groupBox1.Controls.Add(cbbMaCa);
            groupBox1.Controls.Add(label_dongca);
            groupBox1.Controls.Add(txtTenCa);
            groupBox1.Controls.Add(label_tenca);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(52, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1068, 224);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loài Cá";
            // 
            // txtImage
            // 
            txtImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtImage.Location = new Point(108, 87);
            txtImage.Name = "txtImage";
            txtImage.ReadOnly = true;
            txtImage.Size = new Size(148, 27);
            txtImage.TabIndex = 61;
            // 
            // numberUpDown
            // 
            numberUpDown.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numberUpDown.Location = new Point(881, 104);
            numberUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numberUpDown.Name = "numberUpDown";
            numberUpDown.Size = new Size(149, 27);
            numberUpDown.TabIndex = 60;
            // 
            // label_soluong
            // 
            label_soluong.AutoSize = true;
            label_soluong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_soluong.Location = new Point(803, 106);
            label_soluong.Name = "label_soluong";
            label_soluong.Size = new Size(72, 20);
            label_soluong.TabIndex = 59;
            label_soluong.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(659, 42);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(149, 27);
            txtDonGia.TabIndex = 58;
            // 
            // label_gia
            // 
            label_gia.AutoSize = true;
            label_gia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_gia.Location = new Point(574, 45);
            label_gia.Name = "label_gia";
            label_gia.Size = new Size(79, 20);
            label_gia.TabIndex = 57;
            label_gia.Text = "Giá (VNĐ):";
            // 
            // txtNguonGoc
            // 
            txtNguonGoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNguonGoc.Location = new Point(448, 87);
            txtNguonGoc.Name = "txtNguonGoc";
            txtNguonGoc.Size = new Size(112, 27);
            txtNguonGoc.TabIndex = 54;
            // 
            // label_nguongoc
            // 
            label_nguongoc.AutoSize = true;
            label_nguongoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_nguongoc.Location = new Point(356, 90);
            label_nguongoc.Name = "label_nguongoc";
            label_nguongoc.Size = new Size(86, 20);
            label_nguongoc.TabIndex = 53;
            label_nguongoc.Text = "Nguồn gốc:";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.Location = new Point(448, 41);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(112, 27);
            txtColor.TabIndex = 52;
            // 
            // label_mausac
            // 
            label_mausac.AutoSize = true;
            label_mausac.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_mausac.Location = new Point(356, 44);
            label_mausac.Name = "label_mausac";
            label_mausac.Size = new Size(66, 20);
            label_mausac.TabIndex = 51;
            label_mausac.Text = "Màu sắc:";
            // 
            // btn_choosefile
            // 
            btn_choosefile.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_choosefile.Location = new Point(262, 87);
            btn_choosefile.Name = "btn_choosefile";
            btn_choosefile.Size = new Size(82, 27);
            btn_choosefile.TabIndex = 50;
            btn_choosefile.Text = "Choose File";
            btn_choosefile.UseVisualStyleBackColor = true;
            btn_choosefile.Click += btn_choosefile_Click;
            // 
            // label_hinhanh
            // 
            label_hinhanh.AutoSize = true;
            label_hinhanh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_hinhanh.Location = new Point(31, 90);
            label_hinhanh.Name = "label_hinhanh";
            label_hinhanh.Size = new Size(71, 20);
            label_hinhanh.TabIndex = 49;
            label_hinhanh.Text = "Hình ảnh:";
            // 
            // cbbMaCa
            // 
            cbbMaCa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaCa.FormattingEnabled = true;
            cbbMaCa.Location = new Point(881, 41);
            cbbMaCa.Name = "cbbMaCa";
            cbbMaCa.Size = new Size(149, 28);
            cbbMaCa.TabIndex = 48;
            // 
            // label_dongca
            // 
            label_dongca.AutoSize = true;
            label_dongca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_dongca.Location = new Point(803, 44);
            label_dongca.Name = "label_dongca";
            label_dongca.Size = new Size(68, 20);
            label_dongca.TabIndex = 47;
            label_dongca.Text = "Dòng cá:";
            // 
            // txtTenCa
            // 
            txtTenCa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenCa.Location = new Point(106, 41);
            txtTenCa.Name = "txtTenCa";
            txtTenCa.Size = new Size(238, 27);
            txtTenCa.TabIndex = 46;
            // 
            // label_tenca
            // 
            label_tenca.AutoSize = true;
            label_tenca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_tenca.Location = new Point(29, 47);
            label_tenca.Name = "label_tenca";
            label_tenca.Size = new Size(54, 20);
            label_tenca.TabIndex = 45;
            label_tenca.Text = "Tên cá:";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 60;
            // 
            // fishName
            // 
            fishName.HeaderText = "Tên cá";
            fishName.Name = "fishName";
            fishName.Width = 200;
            // 
            // FormDSCa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1173, 878);
            Controls.Add(groupBox1);
            Controls.Add(dataGridListCa);
            Controls.Add(listFishLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDSCa";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH SÁCH CÁ CẢNH";
            Load += DSCa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridListCa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label listFishLabel;
        private DataGridView dataGridListCa;
        private TextBox tb_search;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox1;
        private TextBox txtImage;
        private NumericUpDown numberUpDown;
        private Label label_soluong;
        private TextBox txtNguonGoc;
        private Label label_gia;
        private TextBox txtNguoiGoc;
        private Label label_nguongoc;
        private TextBox txtColor;
        private Label label_mausac;
        private Button btn_choosefile;
        private Label label_hinhanh;
        private ComboBox cbbMaCa;
        private Label label_dongca;
        private TextBox txtTenCa;
        private Label label_tenca;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn fishName;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDongCa;
        private DataGridViewImageColumn ColumnImage;
        private DataGridViewTextBoxColumn ColumnColor;
        private DataGridViewTextBoxColumn ColumnOrigin;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnSoLuong;
        private TextBox txtDonGia;
    }
}