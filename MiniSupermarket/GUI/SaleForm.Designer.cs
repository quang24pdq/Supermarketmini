namespace MiniSupermarket.GUI
{
    partial class SaleForm
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
            pnl_top = new Panel();
            pnlAddBill = new Panel();
            pnlAddBtn = new Panel();
            btnDelBill = new Button();
            btnAddBill = new Button();
            grbCustomerInfo = new GroupBox();
            btnInHoaDon = new Button();
            btnReset = new Button();
            ckNewCustomer = new CheckBox();
            txtSearchCustomer = new TextBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            txtPhone = new TextBox();
            txtCustomerName = new TextBox();
            lbSex = new Label();
            lbPhone = new Label();
            lbCustomerName = new Label();
            cbChooseCustomer = new ComboBox();
            lbChooseCustomer = new Label();
            gbSearch = new GroupBox();
            cbChonDenNgay = new CheckBox();
            cbChonTuNgay = new CheckBox();
            cbNotPay = new CheckBox();
            txtToTotal = new TextBox();
            txtFromTotal = new TextBox();
            lbTotal = new Label();
            btnClearSearch = new Button();
            lbEmployee = new Label();
            lbCustomer = new Label();
            btnSearch = new Button();
            cbPay = new CheckBox();
            txtEmployeeSearch = new TextBox();
            txtCustomerSearch = new TextBox();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            lbToDate = new Label();
            lbFromDate = new Label();
            pnl_bottom = new Panel();
            dgv_bill = new DataGridView();
            pnl_top.SuspendLayout();
            pnlAddBill.SuspendLayout();
            pnlAddBtn.SuspendLayout();
            grbCustomerInfo.SuspendLayout();
            gbSearch.SuspendLayout();
            pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_bill).BeginInit();
            SuspendLayout();
            // 
            // pnl_top
            // 
            pnl_top.Controls.Add(pnlAddBill);
            pnl_top.Controls.Add(gbSearch);
            pnl_top.Dock = DockStyle.Top;
            pnl_top.Location = new Point(0, 0);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new Size(1183, 352);
            pnl_top.TabIndex = 0;
            // 
            // pnlAddBill
            // 
            pnlAddBill.Controls.Add(pnlAddBtn);
            pnlAddBill.Controls.Add(grbCustomerInfo);
            pnlAddBill.Dock = DockStyle.Fill;
            pnlAddBill.Location = new Point(0, 0);
            pnlAddBill.Name = "pnlAddBill";
            pnlAddBill.Size = new Size(621, 352);
            pnlAddBill.TabIndex = 2;
            // 
            // pnlAddBtn
            // 
            pnlAddBtn.Controls.Add(btnDelBill);
            pnlAddBtn.Controls.Add(btnAddBill);
            pnlAddBtn.Dock = DockStyle.Fill;
            pnlAddBtn.Location = new Point(0, 283);
            pnlAddBtn.Name = "pnlAddBtn";
            pnlAddBtn.Size = new Size(621, 69);
            pnlAddBtn.TabIndex = 2;
            // 
            // btnDelBill
            // 
            btnDelBill.Dock = DockStyle.Fill;
            btnDelBill.FlatStyle = FlatStyle.Flat;
            btnDelBill.Location = new Point(351, 0);
            btnDelBill.Name = "btnDelBill";
            btnDelBill.Size = new Size(270, 69);
            btnDelBill.TabIndex = 10;
            btnDelBill.Text = "Xóa hóa đơn";
            btnDelBill.UseVisualStyleBackColor = true;
            btnDelBill.Click += btnDelBill_Click;
            // 
            // btnAddBill
            // 
            btnAddBill.Dock = DockStyle.Left;
            btnAddBill.FlatAppearance.BorderSize = 0;
            btnAddBill.FlatStyle = FlatStyle.Flat;
            btnAddBill.Location = new Point(0, 0);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(351, 69);
            btnAddBill.TabIndex = 0;
            btnAddBill.Text = "Thêm hóa đơn";
            btnAddBill.UseVisualStyleBackColor = true;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // grbCustomerInfo
            // 
            grbCustomerInfo.Controls.Add(btnInHoaDon);
            grbCustomerInfo.Controls.Add(btnReset);
            grbCustomerInfo.Controls.Add(ckNewCustomer);
            grbCustomerInfo.Controls.Add(txtSearchCustomer);
            grbCustomerInfo.Controls.Add(rdFemale);
            grbCustomerInfo.Controls.Add(rdMale);
            grbCustomerInfo.Controls.Add(txtPhone);
            grbCustomerInfo.Controls.Add(txtCustomerName);
            grbCustomerInfo.Controls.Add(lbSex);
            grbCustomerInfo.Controls.Add(lbPhone);
            grbCustomerInfo.Controls.Add(lbCustomerName);
            grbCustomerInfo.Controls.Add(cbChooseCustomer);
            grbCustomerInfo.Controls.Add(lbChooseCustomer);
            grbCustomerInfo.Dock = DockStyle.Top;
            grbCustomerInfo.Location = new Point(0, 0);
            grbCustomerInfo.Name = "grbCustomerInfo";
            grbCustomerInfo.Padding = new Padding(3, 2, 3, 2);
            grbCustomerInfo.Size = new Size(621, 283);
            grbCustomerInfo.TabIndex = 1;
            grbCustomerInfo.TabStop = false;
            grbCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(472, 211);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(143, 55);
            btnInHoaDon.TabIndex = 10;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(366, 219);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(91, 37);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // ckNewCustomer
            // 
            ckNewCustomer.AutoSize = true;
            ckNewCustomer.Location = new Point(11, 92);
            ckNewCustomer.Name = "ckNewCustomer";
            ckNewCustomer.Size = new Size(165, 24);
            ckNewCustomer.TabIndex = 9;
            ckNewCustomer.Text = "Tạo khách hàng mới";
            ckNewCustomer.UseVisualStyleBackColor = true;
            ckNewCustomer.CheckedChanged += ckNewCustomer_CheckedChanged;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(111, 35);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(239, 27);
            txtSearchCustomer.TabIndex = 8;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(219, 219);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(50, 24);
            rdFemale.TabIndex = 7;
            rdFemale.TabStop = true;
            rdFemale.Text = "Nữ";
            rdFemale.UseVisualStyleBackColor = true;
            rdFemale.CheckedChanged += rdFemale_CheckedChanged;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(111, 219);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(62, 24);
            rdMale.TabIndex = 7;
            rdMale.TabStop = true;
            rdMale.Text = "Nam";
            rdMale.UseVisualStyleBackColor = true;
            rdMale.CheckedChanged += rdMale_CheckedChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(111, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 27);
            txtPhone.TabIndex = 6;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(111, 128);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(239, 27);
            txtCustomerName.TabIndex = 5;
            txtCustomerName.KeyPress += txtCustomerName_KeyPress;
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(11, 220);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(65, 20);
            lbSex.TabIndex = 4;
            lbSex.Text = "Giới tính";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(11, 171);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(49, 20);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Số ĐT";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(11, 131);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(54, 20);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Họ tên";
            // 
            // cbChooseCustomer
            // 
            cbChooseCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChooseCustomer.FormattingEnabled = true;
            cbChooseCustomer.Location = new Point(376, 35);
            cbChooseCustomer.Name = "cbChooseCustomer";
            cbChooseCustomer.Size = new Size(239, 28);
            cbChooseCustomer.TabIndex = 1;
            cbChooseCustomer.SelectedIndexChanged += cbChooseCustomer_SelectedIndexChanged;
            // 
            // lbChooseCustomer
            // 
            lbChooseCustomer.AutoSize = true;
            lbChooseCustomer.Location = new Point(11, 37);
            lbChooseCustomer.Name = "lbChooseCustomer";
            lbChooseCustomer.Size = new Size(67, 20);
            lbChooseCustomer.TabIndex = 0;
            lbChooseCustomer.Text = "Chọn KH";
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(cbChonDenNgay);
            gbSearch.Controls.Add(cbChonTuNgay);
            gbSearch.Controls.Add(cbNotPay);
            gbSearch.Controls.Add(txtToTotal);
            gbSearch.Controls.Add(txtFromTotal);
            gbSearch.Controls.Add(lbTotal);
            gbSearch.Controls.Add(btnClearSearch);
            gbSearch.Controls.Add(lbEmployee);
            gbSearch.Controls.Add(lbCustomer);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(cbPay);
            gbSearch.Controls.Add(txtEmployeeSearch);
            gbSearch.Controls.Add(txtCustomerSearch);
            gbSearch.Controls.Add(dtpToDate);
            gbSearch.Controls.Add(dtpFromDate);
            gbSearch.Controls.Add(lbToDate);
            gbSearch.Controls.Add(lbFromDate);
            gbSearch.Dock = DockStyle.Right;

            gbSearch.Location = new Point(709, 0);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(562, 352);
            gbSearch.TabIndex = 1;
            gbSearch.TabStop = false;
            gbSearch.Text = "Tìm kiếm";
            gbSearch.Enter += gbSearch_Enter;
            // 
            // cbChonDenNgay
            // 
            cbChonDenNgay.AutoSize = true;
            cbChonDenNgay.Location = new Point(387, 77);
            cbChonDenNgay.Margin = new Padding(3, 2, 3, 2);
            cbChonDenNgay.Name = "cbChonDenNgay";
            cbChonDenNgay.Size = new Size(130, 24);
            cbChonDenNgay.TabIndex = 16;
            cbChonDenNgay.Text = "Chọn đến ngày";
            cbChonDenNgay.UseVisualStyleBackColor = true;
            cbChonDenNgay.CheckedChanged += cbChonDenNgay_CheckedChanged;
            // 
            // cbChonTuNgay
            // 
            cbChonTuNgay.AutoSize = true;
            cbChonTuNgay.Location = new Point(387, 33);
            cbChonTuNgay.Margin = new Padding(3, 2, 3, 2);
            cbChonTuNgay.Name = "cbChonTuNgay";
            cbChonTuNgay.Size = new Size(119, 24);
            cbChonTuNgay.TabIndex = 16;
            cbChonTuNgay.Text = "Chọn từ ngày";
            cbChonTuNgay.UseVisualStyleBackColor = true;
            cbChonTuNgay.CheckedChanged += cbChonTuNgay_CheckedChanged;
            // 
            // cbNotPay
            // 
            cbNotPay.AutoSize = true;
            cbNotPay.Location = new Point(174, 259);
            cbNotPay.Margin = new Padding(3, 2, 3, 2);
            cbNotPay.Name = "cbNotPay";
            cbNotPay.Size = new Size(140, 24);
            cbNotPay.TabIndex = 15;
            cbNotPay.Text = "Chưa thanh toán";
            cbNotPay.UseVisualStyleBackColor = true;
            cbNotPay.CheckedChanged += cbNotPay_CheckedChanged;
            // 
            // txtToTotal
            // 
            txtToTotal.Location = new Point(248, 208);
            txtToTotal.Margin = new Padding(3, 2, 3, 2);
            txtToTotal.Name = "txtToTotal";
            txtToTotal.Size = new Size(106, 27);
            txtToTotal.TabIndex = 14;
            txtToTotal.Enter += txtToTotal_Enter;
            txtToTotal.KeyPress += txtToTotal_KeyPress;
            txtToTotal.Leave += txtToTotal_Leave;
            // 
            // txtFromTotal
            // 
            txtFromTotal.Location = new Point(122, 208);
            txtFromTotal.Margin = new Padding(3, 2, 3, 2);
            txtFromTotal.Name = "txtFromTotal";
            txtFromTotal.Size = new Size(106, 27);
            txtFromTotal.TabIndex = 14;
            txtFromTotal.Enter += txtFromTotal_Enter;
            txtFromTotal.KeyPress += txtFromTotal_KeyPress;
            txtFromTotal.Leave += txtFromTotal_Leave;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(6, 211);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(72, 20);
            lbTotal.TabIndex = 13;
            lbTotal.Text = "Tổng tiền";
            // 
            // btnClearSearch
            // 
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Location = new Point(314, 291);
            btnClearSearch.Margin = new Padding(3, 2, 3, 2);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(117, 53);
            btnClearSearch.TabIndex = 12;
            btnClearSearch.Text = "Tải lại";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // lbEmployee
            // 
            lbEmployee.AutoSize = true;
            lbEmployee.Location = new Point(6, 167);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(75, 20);
            lbEmployee.TabIndex = 11;
            lbEmployee.Text = "Nhân viên";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(6, 123);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(86, 20);
            lbCustomer.TabIndex = 10;
            lbCustomer.Text = "Khách hàng";
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(168, 291);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 53);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbPay
            // 
            cbPay.AutoSize = true;
            cbPay.Location = new Point(6, 259);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(125, 24);
            cbPay.TabIndex = 7;
            cbPay.Text = "Đã thanh toán";
            cbPay.UseVisualStyleBackColor = true;
            cbPay.CheckedChanged += cbPay_CheckedChanged;
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Location = new Point(122, 164);
            txtEmployeeSearch.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.Size = new Size(250, 27);
            txtEmployeeSearch.TabIndex = 6;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(122, 120);
            txtCustomerSearch.Margin = new Padding(3, 2, 3, 2);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(250, 27);
            txtCustomerSearch.TabIndex = 5;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(122, 76);
            dtpToDate.Margin = new Padding(3, 2, 3, 2);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 2;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            dtpToDate.KeyDown += dtpToDate_KeyDown;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(122, 32);
            dtpFromDate.Margin = new Padding(3, 2, 3, 2);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 1;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            dtpFromDate.KeyDown += dtpFromDate_KeyDown;
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new Point(6, 79);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new Size(72, 20);
            lbToDate.TabIndex = 0;
            lbToDate.Text = "Đến ngày";
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new Point(6, 35);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new Size(62, 20);
            lbFromDate.TabIndex = 0;
            lbFromDate.Text = "Từ ngày";
            // 
            // pnl_bottom
            // 
            pnl_bottom.Controls.Add(dgv_bill);
            pnl_bottom.Dock = DockStyle.Fill;
            pnl_bottom.Location = new Point(0, 352);
            pnl_bottom.Name = "pnl_bottom";
            pnl_bottom.Size = new Size(1183, 175);
            pnl_bottom.TabIndex = 1;
            // 
            // dgv_bill
            // 
            dgv_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_bill.Dock = DockStyle.Fill;
            dgv_bill.Location = new Point(0, 0);
            dgv_bill.MultiSelect = false;
            dgv_bill.Name = "dgv_bill";
            dgv_bill.RowHeadersWidth = 51;
            dgv_bill.RowTemplate.Height = 29;
            dgv_bill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bill.Size = new Size(1183, 175);
            dgv_bill.TabIndex = 0;
            dgv_bill.CellClick += dgv_bill_CellClick;
            dgv_bill.DoubleClick += dgv_bill_DoubleClick;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 527);
            Controls.Add(pnl_bottom);
            Controls.Add(pnl_top);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            pnl_top.ResumeLayout(false);
            pnlAddBill.ResumeLayout(false);
            pnlAddBtn.ResumeLayout(false);
            grbCustomerInfo.ResumeLayout(false);
            grbCustomerInfo.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            pnl_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_bill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_top;
        private Panel pnl_bottom;
        private DataGridView dgv_bill;
        private Button btnAddBill;
        private GroupBox gbSearch;
        private Label lbFromDate;
        private Label lbToDate;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private TextBox txtEmployeeSearch;
        private TextBox txtCustomerSearch;
        private CheckBox cbPay;
        private Panel pnlAddBill;
        private GroupBox grbCustomerInfo;
        private Panel pnlAddBtn;
        private ComboBox cbChooseCustomer;
        private Label lbChooseCustomer;
        private Label lbSex;
        private Label lbPhone;
        private Label lbCustomerName;
        private TextBox txtPhone;
        private TextBox txtCustomerName;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private TextBox txtSearchCustomer;
        private Button btnSearch;
        private CheckBox ckNewCustomer;
        private Button btnReset;
        private Label lbEmployee;
        private Label lbCustomer;
        private Button btnDelBill;
        private Button btnClearSearch;
        private Label lbTotal;
        private TextBox txtToTotal;
        private TextBox txtFromTotal;
        private CheckBox cbNotPay;
        private CheckBox cbChonTuNgay;
        private CheckBox cbChonDenNgay;
        private Button btnInHoaDon;

        //private Button btnDetalBill;
        //private CheckBox cbNotPay;
        //private CheckBox cbChonTuNgay;
        //private CheckBox cbChonDenNgay;
    }
}