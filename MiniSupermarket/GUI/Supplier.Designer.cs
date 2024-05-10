namespace MiniSupermarket.GUI
{
    partial class Supplier
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
            groupBoxThongTinNCC = new GroupBox();
            dateTimePickerNgayNhap = new DateTimePicker();
            textBoxEmail = new TextBox();
            textBoxSDT = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxTen = new TextBox();
            textBoxID = new TextBox();
            labelNgayNhap = new Label();
            labelEmail = new Label();
            labelSoDienThoai = new Label();
            labelDiaChi = new Label();
            labelTen = new Label();
            labelID = new Label();
            groupBoxLoaiSanPham = new GroupBox();
            btnXoaLoai = new Button();
            btnXacNhanLoai = new Button();
            btnHuyThemLoai = new Button();
            btnThemLoai = new Button();
            dtgvLoaiSanPham = new DataGridView();
            dtgvSupplier = new DataGridView();
            groupBoxChucNang = new GroupBox();
            btnXoa = new Button();
            btnHuy = new Button();
            btnXacNhan = new Button();
            btnSua = new Button();
            btnThem = new Button();
            textBoxTimKiem = new TextBox();
            comboBoxTimKiem = new ComboBox();
            btnTimKiem = new Button();
            btnLoad = new Button();
            groupBoxThongTinNCC.SuspendLayout();
            groupBoxLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLoaiSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSupplier).BeginInit();
            groupBoxChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxThongTinNCC
            // 
            groupBoxThongTinNCC.Anchor = AnchorStyles.Top;
            groupBoxThongTinNCC.Controls.Add(dateTimePickerNgayNhap);
            groupBoxThongTinNCC.Controls.Add(textBoxEmail);
            groupBoxThongTinNCC.Controls.Add(textBoxSDT);
            groupBoxThongTinNCC.Controls.Add(textBoxDiaChi);
            groupBoxThongTinNCC.Controls.Add(textBoxTen);
            groupBoxThongTinNCC.Controls.Add(textBoxID);
            groupBoxThongTinNCC.Controls.Add(labelNgayNhap);
            groupBoxThongTinNCC.Controls.Add(labelEmail);
            groupBoxThongTinNCC.Controls.Add(labelSoDienThoai);
            groupBoxThongTinNCC.Controls.Add(labelDiaChi);
            groupBoxThongTinNCC.Controls.Add(labelTen);
            groupBoxThongTinNCC.Controls.Add(labelID);
            groupBoxThongTinNCC.Location = new Point(12, 0);
            groupBoxThongTinNCC.Name = "groupBoxThongTinNCC";
            groupBoxThongTinNCC.Size = new Size(395, 230);
            groupBoxThongTinNCC.TabIndex = 0;
            groupBoxThongTinNCC.TabStop = false;
            groupBoxThongTinNCC.Text = "Thông tin nhà cung cấp";
            // 
            // dateTimePickerNgayNhap
            // 
            dateTimePickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayNhap.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayNhap.Location = new Point(124, 175);
            dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            dateTimePickerNgayNhap.Size = new Size(233, 23);
            dateTimePickerNgayNhap.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(124, 141);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(233, 23);
            textBoxEmail.TabIndex = 10;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(124, 114);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(233, 23);
            textBoxSDT.TabIndex = 9;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(124, 87);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(233, 23);
            textBoxDiaChi.TabIndex = 8;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(124, 60);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(233, 23);
            textBoxTen.TabIndex = 7;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(124, 33);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(233, 23);
            textBoxID.TabIndex = 6;
            // 
            // labelNgayNhap
            // 
            labelNgayNhap.AutoSize = true;
            labelNgayNhap.Location = new Point(6, 183);
            labelNgayNhap.Name = "labelNgayNhap";
            labelNgayNhap.Size = new Size(65, 15);
            labelNgayNhap.TabIndex = 5;
            labelNgayNhap.Text = "Ngày nhập";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(6, 152);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // labelSoDienThoai
            // 
            labelSoDienThoai.AutoSize = true;
            labelSoDienThoai.Location = new Point(6, 124);
            labelSoDienThoai.Name = "labelSoDienThoai";
            labelSoDienThoai.Size = new Size(27, 15);
            labelSoDienThoai.TabIndex = 3;
            labelSoDienThoai.Text = "SĐT";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(6, 96);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(43, 15);
            labelDiaChi.TabIndex = 2;
            labelDiaChi.Text = "Địa chỉ";
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(6, 68);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(25, 15);
            labelTen.TabIndex = 1;
            labelTen.Text = "Tên";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(6, 40);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 0;
            labelID.Text = "ID";
            // 
            // groupBoxLoaiSanPham
            // 
            groupBoxLoaiSanPham.Anchor = AnchorStyles.Top;
            groupBoxLoaiSanPham.Controls.Add(btnXoaLoai);
            groupBoxLoaiSanPham.Controls.Add(btnXacNhanLoai);
            groupBoxLoaiSanPham.Controls.Add(btnHuyThemLoai);
            groupBoxLoaiSanPham.Controls.Add(btnThemLoai);
            groupBoxLoaiSanPham.Controls.Add(dtgvLoaiSanPham);
            groupBoxLoaiSanPham.Location = new Point(413, 0);
            groupBoxLoaiSanPham.Name = "groupBoxLoaiSanPham";
            groupBoxLoaiSanPham.Size = new Size(559, 230);
            groupBoxLoaiSanPham.TabIndex = 1;
            groupBoxLoaiSanPham.TabStop = false;
            groupBoxLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // btnXoaLoai
            // 
            btnXoaLoai.Enabled = false;
            btnXoaLoai.Location = new Point(385, 183);
            btnXoaLoai.Name = "btnXoaLoai";
            btnXoaLoai.Size = new Size(113, 30);
            btnXoaLoai.TabIndex = 4;
            btnXoaLoai.Text = "Xóa loại";
            btnXoaLoai.UseVisualStyleBackColor = true;
            btnXoaLoai.Click += btnXoaLoai_Click;
            // 
            // btnXacNhanLoai
            // 
            btnXacNhanLoai.Enabled = false;
            btnXacNhanLoai.Location = new Point(28, 183);
            btnXacNhanLoai.Name = "btnXacNhanLoai";
            btnXacNhanLoai.Size = new Size(113, 30);
            btnXacNhanLoai.TabIndex = 3;
            btnXacNhanLoai.Text = "Xác nhận";
            btnXacNhanLoai.UseVisualStyleBackColor = true;
            btnXacNhanLoai.Click += btnXacNhanLoai_Click;
            // 
            // btnHuyThemLoai
            // 
            btnHuyThemLoai.Enabled = false;
            btnHuyThemLoai.Location = new Point(266, 183);
            btnHuyThemLoai.Name = "btnHuyThemLoai";
            btnHuyThemLoai.Size = new Size(113, 30);
            btnHuyThemLoai.TabIndex = 2;
            btnHuyThemLoai.Text = "Hủy thêm loại";
            btnHuyThemLoai.UseVisualStyleBackColor = true;
            btnHuyThemLoai.Click += btnHuyThemLoai_Click;
            // 
            // btnThemLoai
            // 
            btnThemLoai.Location = new Point(147, 183);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(113, 30);
            btnThemLoai.TabIndex = 1;
            btnThemLoai.Text = "Thêm loại";
            btnThemLoai.UseVisualStyleBackColor = true;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // dtgvLoaiSanPham
            // 
            dtgvLoaiSanPham.AllowUserToAddRows = false;
            dtgvLoaiSanPham.AllowUserToDeleteRows = false;
            dtgvLoaiSanPham.AllowUserToResizeColumns = false;
            dtgvLoaiSanPham.AllowUserToResizeRows = false;
            dtgvLoaiSanPham.Anchor = AnchorStyles.Top;
            dtgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLoaiSanPham.Location = new Point(-3, 22);
            dtgvLoaiSanPham.Name = "dtgvLoaiSanPham";
            dtgvLoaiSanPham.ReadOnly = true;
            dtgvLoaiSanPham.RowHeadersVisible = false;
            dtgvLoaiSanPham.RowTemplate.Height = 25;
            dtgvLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvLoaiSanPham.Size = new Size(556, 153);
            dtgvLoaiSanPham.TabIndex = 0;
            dtgvLoaiSanPham.CellClick += dtgvLoaiSanPham_CellClick;
            dtgvLoaiSanPham.DataBindingComplete += dtgvLoaiSanPham_DataBindingComplete;
            // 
            // dtgvSupplier
            // 
            dtgvSupplier.AllowUserToAddRows = false;
            dtgvSupplier.AllowUserToDeleteRows = false;
            dtgvSupplier.AllowUserToResizeColumns = false;
            dtgvSupplier.AllowUserToResizeRows = false;
            dtgvSupplier.Anchor = AnchorStyles.Top;
            dtgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSupplier.Location = new Point(12, 404);
            dtgvSupplier.Name = "dtgvSupplier";
            dtgvSupplier.ReadOnly = true;
            dtgvSupplier.RowHeadersVisible = false;
            dtgvSupplier.RowTemplate.Height = 25;
            dtgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvSupplier.Size = new Size(960, 174);
            dtgvSupplier.TabIndex = 3;
            dtgvSupplier.CellClick += dtgvSupplier_CellClick;
            dtgvSupplier.DataBindingComplete += dtgvSupplier_DataBindingComplete;
            // 
            // groupBoxChucNang
            // 
            groupBoxChucNang.Anchor = AnchorStyles.Top;
            groupBoxChucNang.Controls.Add(btnXoa);
            groupBoxChucNang.Controls.Add(btnHuy);
            groupBoxChucNang.Controls.Add(btnXacNhan);
            groupBoxChucNang.Controls.Add(btnSua);
            groupBoxChucNang.Controls.Add(btnThem);
            groupBoxChucNang.Location = new Point(45, 235);
            groupBoxChucNang.Name = "groupBoxChucNang";
            groupBoxChucNang.Size = new Size(895, 103);
            groupBoxChucNang.TabIndex = 4;
            groupBoxChucNang.TabStop = false;
            groupBoxChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(405, 37);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 37);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Location = new Point(562, 37);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(85, 37);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Enabled = false;
            btnXacNhan.Location = new Point(719, 37);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(85, 37);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(248, 37);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 37);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(91, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 37);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Anchor = AnchorStyles.Top;
            textBoxTimKiem.Location = new Point(376, 355);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(233, 23);
            textBoxTimKiem.TabIndex = 12;
            // 
            // comboBoxTimKiem
            // 
            comboBoxTimKiem.Anchor = AnchorStyles.Top;
            comboBoxTimKiem.FormattingEnabled = true;
            comboBoxTimKiem.Items.AddRange(new object[] { "ID", "Tên", "Địa chỉ", "SĐT", "Email" });
            comboBoxTimKiem.Location = new Point(615, 355);
            comboBoxTimKiem.Name = "comboBoxTimKiem";
            comboBoxTimKiem.Size = new Size(77, 23);
            comboBoxTimKiem.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.Location = new Point(295, 355);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top;
            btnLoad.Location = new Point(455, 584);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 618);
            Controls.Add(btnLoad);
            Controls.Add(btnTimKiem);
            Controls.Add(comboBoxTimKiem);
            Controls.Add(textBoxTimKiem);
            Controls.Add(dtgvSupplier);
            Controls.Add(groupBoxLoaiSanPham);
            Controls.Add(groupBoxThongTinNCC);
            Controls.Add(groupBoxChucNang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Supplier";
            Text = "Supplier";
            Load += Supplier_Load;
            groupBoxThongTinNCC.ResumeLayout(false);
            groupBoxThongTinNCC.PerformLayout();
            groupBoxLoaiSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvLoaiSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSupplier).EndInit();
            groupBoxChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxThongTinNCC;
        private GroupBox groupBoxLoaiSanPham;
        private DataGridView dtgvSupplier;
        private GroupBox groupBoxChucNang;
        private DataGridView dtgvLoaiSanPham;
        private Label labelEmail;
        private Label labelSoDienThoai;
        private Label labelDiaChi;
        private Label labelTen;
        private Label labelID;
        private Label labelNgayNhap;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnXacNhan;
        private Button btnSua;
        private Button btnThem;
        private DateTimePicker dateTimePickerNgayNhap;
        private TextBox textBoxEmail;
        private TextBox textBoxSDT;
        private TextBox textBoxDiaChi;
        private TextBox textBoxTen;
        private TextBox textBoxID;
        private TextBox textBoxTimKiem;
        private ComboBox comboBoxTimKiem;
        private Button btnTimKiem;
        private Button btnThemLoai;
        private Button btnXacNhanLoai;
        private Button btnHuyThemLoai;
        private Button btnXoaLoai;
        private Button btnLoad;
    }
}