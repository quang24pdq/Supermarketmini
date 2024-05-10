namespace MiniSupermarket.GUI
{
    partial class PromotionForm
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
            pnlInformation = new Panel();
            label1 = new Label();
            dtpkEndDate = new DateTimePicker();
            dtpkStartDate = new DateTimePicker();
            btnStartWork = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnStopWork = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            lblDateStart = new Label();
            lblPromotionID = new Label();
            txtPromotionID = new TextBox();
            lblDateEnd = new Label();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblPromotionName = new Label();
            txtPromotionName = new TextBox();
            lblTitle = new Label();
            panel2 = new Panel();
            grbDateFilter = new GroupBox();
            btnFilterDate = new Button();
            lblDateTo = new Label();
            lblDateFrom = new Label();
            dtpkSearchEndDate = new DateTimePicker();
            dtpkSearchStartDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            cbxTypeOfSearch = new ComboBox();
            grbPriceFilter = new GroupBox();
            cbxFilterPrice = new ComboBox();
            panel3 = new Panel();
            dgvPromotions = new DataGridView();
            pnlInformation.SuspendLayout();
            panel2.SuspendLayout();
            grbDateFilter.SuspendLayout();
            groupBox1.SuspendLayout();
            grbPriceFilter.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).BeginInit();
            SuspendLayout();
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(dtpkEndDate);
            pnlInformation.Controls.Add(dtpkStartDate);
            pnlInformation.Controls.Add(btnStartWork);
            pnlInformation.Controls.Add(btnUpdate);
            pnlInformation.Controls.Add(btnDelete);
            pnlInformation.Controls.Add(btnStopWork);
            pnlInformation.Controls.Add(btnRefresh);
            pnlInformation.Controls.Add(btnAdd);
            pnlInformation.Controls.Add(lblDateStart);
            pnlInformation.Controls.Add(lblPromotionID);
            pnlInformation.Controls.Add(txtPromotionID);
            pnlInformation.Controls.Add(lblDateEnd);
            pnlInformation.Controls.Add(lblDiscount);
            pnlInformation.Controls.Add(txtDiscount);
            pnlInformation.Controls.Add(lblPromotionName);
            pnlInformation.Controls.Add(txtPromotionName);
            pnlInformation.Controls.Add(lblTitle);
            pnlInformation.Dock = DockStyle.Left;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(462, 485);
            pnlInformation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 293);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 32;
            label1.Text = "%";
            // 
            // dtpkEndDate
            // 
            dtpkEndDate.Location = new Point(217, 234);
            dtpkEndDate.Name = "dtpkEndDate";
            dtpkEndDate.Size = new Size(214, 27);
            dtpkEndDate.TabIndex = 31;
            // 
            // dtpkStartDate
            // 
            dtpkStartDate.Location = new Point(217, 178);
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(215, 27);
            dtpkStartDate.TabIndex = 30;
            // 
            // btnStartWork
            // 
            btnStartWork.FlatAppearance.BorderSize = 0;
            btnStartWork.FlatStyle = FlatStyle.Flat;
            btnStartWork.Location = new Point(27, 442);
            btnStartWork.Name = "btnStartWork";
            btnStartWork.Size = new Size(94, 31);
            btnStartWork.TabIndex = 24;
            btnStartWork.Text = "Hoạt động";
            btnStartWork.UseVisualStyleBackColor = true;
            btnStartWork.Click += btnStartWork_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(157, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 31);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(322, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 31);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnStopWork
            // 
            btnStopWork.FlatAppearance.BorderSize = 0;
            btnStopWork.FlatStyle = FlatStyle.Flat;
            btnStopWork.Location = new Point(157, 442);
            btnStopWork.Name = "btnStopWork";
            btnStopWork.Size = new Size(140, 31);
            btnStopWork.TabIndex = 21;
            btnStopWork.Text = "Ngưng hoạt động";
            btnStopWork.UseVisualStyleBackColor = true;
            btnStopWork.Click += btnStopWork_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(322, 442);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 31);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Tải lại";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(26, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
            lblDateStart.Location = new Point(27, 181);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(102, 20);
            lblDateStart.TabIndex = 16;
            lblDateStart.Text = "Ngày bắt dầu:";
            // 
            // lblPromotionID
            // 
            lblPromotionID.AutoSize = true;
            lblPromotionID.Location = new Point(27, 69);
            lblPromotionID.Name = "lblPromotionID";
            lblPromotionID.Size = new Size(76, 20);
            lblPromotionID.TabIndex = 12;
            lblPromotionID.Text = "Mã CTKM:";
            // 
            // txtPromotionID
            // 
            txtPromotionID.Location = new Point(218, 66);
            txtPromotionID.Name = "txtPromotionID";
            txtPromotionID.ReadOnly = true;
            txtPromotionID.Size = new Size(214, 27);
            txtPromotionID.TabIndex = 11;
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(27, 237);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(103, 20);
            lblDateEnd.TabIndex = 6;
            lblDateEnd.Text = "Ngày kết thúc:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(27, 293);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(47, 20);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Giảm:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(217, 290);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(167, 27);
            txtDiscount.TabIndex = 3;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // lblPromotionName
            // 
            lblPromotionName.AutoSize = true;
            lblPromotionName.Location = new Point(27, 125);
            lblPromotionName.Name = "lblPromotionName";
            lblPromotionName.Size = new Size(78, 20);
            lblPromotionName.TabIndex = 2;
            lblPromotionName.Text = "Tên CTKM:";
            // 
            // txtPromotionName
            // 
            txtPromotionName.Location = new Point(217, 122);
            txtPromotionName.Name = "txtPromotionName";
            txtPromotionName.Size = new Size(214, 27);
            txtPromotionName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin chương trình khuyến mãi";
            // 
            // panel2
            // 
            panel2.Controls.Add(grbDateFilter);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(grbPriceFilter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(462, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 169);
            panel2.TabIndex = 1;
            // 
            // grbDateFilter
            // 
            grbDateFilter.Controls.Add(btnFilterDate);
            grbDateFilter.Controls.Add(lblDateTo);
            grbDateFilter.Controls.Add(lblDateFrom);
            grbDateFilter.Controls.Add(dtpkSearchEndDate);
            grbDateFilter.Controls.Add(dtpkSearchStartDate);
            grbDateFilter.Location = new Point(9, 81);
            grbDateFilter.Name = "grbDateFilter";
            grbDateFilter.Size = new Size(904, 64);
            grbDateFilter.TabIndex = 0;
            grbDateFilter.TabStop = false;
            grbDateFilter.Text = "Lọc theo ngày";
            // 
            // btnFilterDate
            // 
            btnFilterDate.FlatAppearance.BorderSize = 0;
            btnFilterDate.FlatStyle = FlatStyle.Flat;
            btnFilterDate.Location = new Point(758, 22);
            btnFilterDate.Name = "btnFilterDate";
            btnFilterDate.Size = new Size(140, 31);
            btnFilterDate.TabIndex = 33;
            btnFilterDate.Text = "Lọc";
            btnFilterDate.UseVisualStyleBackColor = true;
            btnFilterDate.Click += btnFilterDate_Click;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Location = new Point(388, 27);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(37, 20);
            lblDateTo.TabIndex = 29;
            lblDateTo.Text = "đến:";
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Location = new Point(15, 27);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(65, 20);
            lblDateFrom.TabIndex = 28;
            lblDateFrom.Text = "Ngày từ:";
            // 
            // dtpkSearchEndDate
            // 
            dtpkSearchEndDate.Location = new Point(473, 22);
            dtpkSearchEndDate.Name = "dtpkSearchEndDate";
            dtpkSearchEndDate.Size = new Size(214, 27);
            dtpkSearchEndDate.TabIndex = 1;
            // 
            // dtpkSearchStartDate
            // 
            dtpkSearchStartDate.Location = new Point(125, 22);
            dtpkSearchStartDate.Name = "dtpkSearchStartDate";
            dtpkSearchStartDate.Size = new Size(214, 27);
            dtpkSearchStartDate.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(cbxTypeOfSearch);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(157, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(466, 27);
            txtSearch.TabIndex = 12;
            txtSearch.KeyPress += txtSearch_KeyPress;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // cbxTypeOfSearch
            // 
            cbxTypeOfSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypeOfSearch.FormattingEnabled = true;
            cbxTypeOfSearch.Items.AddRange(new object[] { "Mã CTKM", "Tên CTKM" });
            cbxTypeOfSearch.Location = new Point(6, 23);
            cbxTypeOfSearch.Name = "cbxTypeOfSearch";
            cbxTypeOfSearch.Size = new Size(145, 28);
            cbxTypeOfSearch.TabIndex = 0;
            // 
            // grbPriceFilter
            // 
            grbPriceFilter.Controls.Add(cbxFilterPrice);
            grbPriceFilter.Location = new Point(638, 3);
            grbPriceFilter.Name = "grbPriceFilter";
            grbPriceFilter.Size = new Size(281, 71);
            grbPriceFilter.TabIndex = 0;
            grbPriceFilter.TabStop = false;
            grbPriceFilter.Text = "Lọc theo giá";
            // 
            // cbxFilterPrice
            // 
            cbxFilterPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFilterPrice.FormattingEnabled = true;
            cbxFilterPrice.Items.AddRange(new object[] { "Tất cả", "Dưới 15%", "Từ 15 % đến 40%", "Trên 40%" });
            cbxFilterPrice.Location = new Point(18, 26);
            cbxFilterPrice.Name = "cbxFilterPrice";
            cbxFilterPrice.Size = new Size(257, 28);
            cbxFilterPrice.TabIndex = 1;
            cbxFilterPrice.SelectedIndexChanged += cbxFilterPrice_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvPromotions);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(462, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(931, 316);
            panel3.TabIndex = 2;
            // 
            // dgvPromotions
            // 
            dgvPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromotions.Dock = DockStyle.Fill;
            dgvPromotions.Location = new Point(0, 0);
            dgvPromotions.Name = "dgvPromotions";
            dgvPromotions.RowHeadersWidth = 51;
            dgvPromotions.RowTemplate.Height = 29;
            dgvPromotions.Size = new Size(931, 316);
            dgvPromotions.TabIndex = 0;
            dgvPromotions.CellDoubleClick += dgvPromotions_CellDoubleClick;
            dgvPromotions.CellMouseClick += dgvPromotions_CellMouseClick;
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 485);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlInformation);
            Name = "PromotionForm";
            Text = "PromotionForm";
            Load += PromotionForm_Load;
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            panel2.ResumeLayout(false);
            grbDateFilter.ResumeLayout(false);
            grbDateFilter.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbPriceFilter.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInformation;
        private Panel panel2;
        private Panel panel4;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel5;
        private GroupBox grbDateFilter;
        private GroupBox grbPriceFilter;
        private Label lblDateStart;
        private Label lblPromotionID;
        private TextBox txtPromotionID;
        private Label lblDateEnd;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblPromotionName;
        private TextBox txtPromotionName;
        private Label lblTitle;

        private Button btnStartWork;

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnStopWork;
        private Button btnRefresh;
        private Button btnAdd;
        private TextBox txtSearch;
        private DataGridView dgvPromotions;
        private DateTimePicker dtpkSearchStartDate;
        private ComboBox cbxTypeOfSearch;
        private Label lblDateTo;
        private Label lblDateFrom;
        private DateTimePicker dtpkSearchEndDate;
        private DateTimePicker dtpkEndDate;
        private DateTimePicker dtpkStartDate;
        private ComboBox cbxFilterPrice;
        private Label label1;
        private Button btnFilterDate;
    }
}