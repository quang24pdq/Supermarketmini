namespace MiniSupermarket.GUI
{
    partial class PurchaseOderForm
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            cbxFilterTotalPrice = new ComboBox();
            groupBox4 = new GroupBox();
            btnFilterDate = new Button();
            lblDateTo = new Label();
            lblDateFrom = new Label();
            dtpkFilterEndDate = new DateTimePicker();
            dtpkFilterStartDate = new DateTimePicker();
            groupBox3 = new GroupBox();
            txtSearch = new TextBox();
            cbxTypeSearch = new ComboBox();
            grbxAddPurchaseOder = new GroupBox();
            btnReset = new Button();
            btnPrintOrder = new Button();
            btnUpdate = new Button();
            btnDeletePurchaseOder = new Button();
            btnAddPurchaseOder = new Button();
            txtOrderID = new TextBox();
            cbxSupplier = new ComboBox();
            lblPurchaseOderID = new Label();
            lblSupplier = new Label();
            label2 = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            dgvPurchaseOders = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            grbxAddPurchaseOder.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(grbxAddPurchaseOder);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 221);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxFilterTotalPrice);
            groupBox1.Location = new Point(1242, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 73);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc theo tổng tiền";
            // 
            // cbxFilterTotalPrice
            // 
            cbxFilterTotalPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFilterTotalPrice.FormattingEnabled = true;
            cbxFilterTotalPrice.Items.AddRange(new object[] { "Tất cả", "Dưới 5 triệu", "Từ 5 triệu đến 15 triệu", "Từ 15 triệu đến 50 triệu", "trên 50 triệu" });
            cbxFilterTotalPrice.Location = new Point(6, 27);
            cbxFilterTotalPrice.Name = "cbxFilterTotalPrice";
            cbxFilterTotalPrice.Size = new Size(167, 28);
            cbxFilterTotalPrice.TabIndex = 0;
            cbxFilterTotalPrice.SelectedIndexChanged += cbxFilterTotalPrice_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnFilterDate);
            groupBox4.Controls.Add(lblDateTo);
            groupBox4.Controls.Add(lblDateFrom);
            groupBox4.Controls.Add(dtpkFilterEndDate);
            groupBox4.Controls.Add(dtpkFilterStartDate);
            groupBox4.Location = new Point(656, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(771, 75);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm theo ngày";
            // 
            // btnFilterDate
            // 
            btnFilterDate.FlatAppearance.BorderSize = 0;
            btnFilterDate.FlatStyle = FlatStyle.Flat;
            btnFilterDate.Location = new Point(671, 24);
            btnFilterDate.Name = "btnFilterDate";
            btnFilterDate.Size = new Size(94, 29);
            btnFilterDate.TabIndex = 7;
            btnFilterDate.Text = "Lọc";
            btnFilterDate.UseVisualStyleBackColor = true;
            btnFilterDate.Click += btnFilterDate_Click;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Location = new Point(340, 33);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(37, 20);
            lblDateTo.TabIndex = 8;
            lblDateTo.Text = "đến:";
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Location = new Point(15, 33);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(26, 20);
            lblDateFrom.TabIndex = 7;
            lblDateFrom.Text = "Từ";
            // 
            // dtpkFilterEndDate
            // 
            dtpkFilterEndDate.Location = new Point(399, 28);
            dtpkFilterEndDate.Name = "dtpkFilterEndDate";
            dtpkFilterEndDate.Size = new Size(250, 27);
            dtpkFilterEndDate.TabIndex = 1;
            // 
            // dtpkFilterStartDate
            // 
            dtpkFilterStartDate.Location = new Point(73, 28);
            dtpkFilterStartDate.Name = "dtpkFilterStartDate";
            dtpkFilterStartDate.Size = new Size(250, 27);
            dtpkFilterStartDate.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(cbxTypeSearch);
            groupBox3.Location = new Point(656, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(580, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm theo";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(417, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // cbxTypeSearch
            // 
            cbxTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypeSearch.FormattingEnabled = true;
            cbxTypeSearch.Items.AddRange(new object[] { "Mã phiếu", "Nhà cung cấp" });
            cbxTypeSearch.Location = new Point(6, 27);
            cbxTypeSearch.Name = "cbxTypeSearch";
            cbxTypeSearch.Size = new Size(141, 28);
            cbxTypeSearch.TabIndex = 0;
            // 
            // grbxAddPurchaseOder
            // 
            grbxAddPurchaseOder.Controls.Add(btnReset);
            grbxAddPurchaseOder.Controls.Add(btnPrintOrder);
            grbxAddPurchaseOder.Controls.Add(btnUpdate);
            grbxAddPurchaseOder.Controls.Add(btnDeletePurchaseOder);
            grbxAddPurchaseOder.Controls.Add(btnAddPurchaseOder);
            grbxAddPurchaseOder.Controls.Add(txtOrderID);
            grbxAddPurchaseOder.Controls.Add(cbxSupplier);
            grbxAddPurchaseOder.Controls.Add(lblPurchaseOderID);
            grbxAddPurchaseOder.Controls.Add(lblSupplier);
            grbxAddPurchaseOder.Location = new Point(21, 53);
            grbxAddPurchaseOder.Name = "grbxAddPurchaseOder";
            grbxAddPurchaseOder.Size = new Size(614, 139);
            grbxAddPurchaseOder.TabIndex = 2;
            grbxAddPurchaseOder.TabStop = false;
            grbxAddPurchaseOder.Text = "Thêm phiếu nhập";
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(360, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnPrintOrder
            // 
            btnPrintOrder.FlatAppearance.BorderSize = 0;
            btnPrintOrder.FlatStyle = FlatStyle.Flat;
            btnPrintOrder.Location = new Point(478, 95);
            btnPrintOrder.Name = "btnPrintOrder";
            btnPrintOrder.Size = new Size(127, 29);
            btnPrintOrder.TabIndex = 5;
            btnPrintOrder.Text = "In phiếu nhập";
            btnPrintOrder.UseVisualStyleBackColor = true;
            btnPrintOrder.Click += btnPrintOrder_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(124, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeletePurchaseOder
            // 
            btnDeletePurchaseOder.FlatAppearance.BorderSize = 0;
            btnDeletePurchaseOder.FlatStyle = FlatStyle.Flat;
            btnDeletePurchaseOder.Location = new Point(242, 95);
            btnDeletePurchaseOder.Name = "btnDeletePurchaseOder";
            btnDeletePurchaseOder.Size = new Size(94, 29);
            btnDeletePurchaseOder.TabIndex = 2;
            btnDeletePurchaseOder.Text = "Xoá";
            btnDeletePurchaseOder.UseVisualStyleBackColor = true;
            btnDeletePurchaseOder.Click += btnDeletePurchaseOder_Click;
            // 
            // btnAddPurchaseOder
            // 
            btnAddPurchaseOder.FlatAppearance.BorderSize = 0;
            btnAddPurchaseOder.FlatStyle = FlatStyle.Flat;
            btnAddPurchaseOder.Location = new Point(6, 95);
            btnAddPurchaseOder.Name = "btnAddPurchaseOder";
            btnAddPurchaseOder.Size = new Size(94, 29);
            btnAddPurchaseOder.TabIndex = 2;
            btnAddPurchaseOder.Text = "Thêm";
            btnAddPurchaseOder.UseVisualStyleBackColor = true;
            btnAddPurchaseOder.Click += btnAddPurchaseOder_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(156, 27);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(125, 27);
            txtOrderID.TabIndex = 3;
            // 
            // cbxSupplier
            // 
            cbxSupplier.FormattingEnabled = true;
            cbxSupplier.Location = new Point(457, 27);
            cbxSupplier.Name = "cbxSupplier";
            cbxSupplier.Size = new Size(151, 28);
            cbxSupplier.TabIndex = 1;
            // 
            // lblPurchaseOderID
            // 
            lblPurchaseOderID.AutoSize = true;
            lblPurchaseOderID.Enabled = false;
            lblPurchaseOderID.Location = new Point(6, 30);
            lblPurchaseOderID.Name = "lblPurchaseOderID";
            lblPurchaseOderID.Size = new Size(111, 20);
            lblPurchaseOderID.TabIndex = 0;
            lblPurchaseOderID.Text = "Mã phiếu nhập:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(310, 30);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(103, 20);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 53);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(574, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPurchaseOders);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(1439, 275);
            panel2.TabIndex = 1;
            // 
            // dgvPurchaseOders
            // 
            dgvPurchaseOders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseOders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseOders.Dock = DockStyle.Fill;
            dgvPurchaseOders.Location = new Point(0, 0);
            dgvPurchaseOders.Name = "dgvPurchaseOders";
            dgvPurchaseOders.RowHeadersWidth = 51;
            dgvPurchaseOders.RowTemplate.Height = 29;
            dgvPurchaseOders.Size = new Size(1439, 275);
            dgvPurchaseOders.TabIndex = 0;
            dgvPurchaseOders.CellDoubleClick += dgvPurchaseOders_CellDoubleClick;
            dgvPurchaseOders.CellMouseClick += dgvPurchaseOders_CellMouseClick;
            // 
            // PurchaseOderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PurchaseOderForm";
            Text = "PurchaseOderForm";
            Load += PurchaseOderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grbxAddPurchaseOder.ResumeLayout(false);
            grbxAddPurchaseOder.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private DataGridView dgvPurchaseOders;
        private GroupBox groupBox3;
        private TextBox txtOrderID;
        private Button btnDeletePurchaseOder;
        private Label lblPurchaseOderID;
        private GroupBox grbxAddPurchaseOder;
        private Button btnAddPurchaseOder;
        private ComboBox cbxSupplier;
        private Label lblSupplier;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox txtSearch;
        private ComboBox cbxTypeSearch;
        private DateTimePicker dtpkFilterDate;
        private Button btnPrintOrder;
        private Button btnUpdate;
        private Button btnReset;
        private DateTimePicker dtpkFilterStartDate;
        private Button btnFilterDate;
        private Label lblDateTo;
        private Label lblDateFrom;
        private DateTimePicker dtpkFilterEndDate;
        private GroupBox groupBox1;
        private ComboBox cbxFilterTotalPrice;
        private SaveFileDialog saveFileDialog1;
    }
}