namespace MiniSupermarket.GUI {
    partial class CustomerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) { 
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            pnlInformation = new Panel();
            rdoNu = new RadioButton();
            btnUpdate = new Button();
            rdoNam = new RadioButton();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            lblCustomerID = new Label();
            txtCustomerID = new TextBox();
            lblPoint = new Label();
            txtPoint = new TextBox();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblTitle = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            grb_rdoNu = new RadioButton();
            grb_rdoNam = new RadioButton();
            groupBox1 = new GroupBox();
            txtFind = new TextBox();
            cboFind = new ComboBox();
            lblTitleProduct = new Label();
            panel3 = new Panel();
            dgvCustomer = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            pnlInformation.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(rdoNu);
            pnlInformation.Controls.Add(btnUpdate);
            pnlInformation.Controls.Add(rdoNam);
            pnlInformation.Controls.Add(btnDelete);
            pnlInformation.Controls.Add(btnRefresh);
            pnlInformation.Controls.Add(btnAdd);
            pnlInformation.Controls.Add(lblCustomerID);
            pnlInformation.Controls.Add(txtCustomerID);
            pnlInformation.Controls.Add(lblPoint);
            pnlInformation.Controls.Add(txtPoint);
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(txtPhoneNumber);
            pnlInformation.Controls.Add(lblPhoneNumber);
            pnlInformation.Controls.Add(lblCustomerName);
            pnlInformation.Controls.Add(txtCustomerName);
            pnlInformation.Controls.Add(lblTitle);
            pnlInformation.Dock = DockStyle.Top;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Margin = new Padding(3, 2, 3, 2);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(1132, 253);
            pnlInformation.TabIndex = 0;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(921, 102);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 0;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(714, 204);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 23);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(830, 102);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(883, 204);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 23);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(1012, 204);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 23);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Làm Mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(585, 204);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 23);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(51, 101);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(92, 15);
            lblCustomerID.TabIndex = 12;
            lblCustomerID.Text = "Mã Khách Hàng";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(218, 99);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(188, 23);
            txtCustomerID.TabIndex = 11;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(720, 147);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(35, 15);
            lblPoint.TabIndex = 4;
            lblPoint.Text = "Điểm";
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(830, 141);
            txtPoint.Margin = new Padding(3, 2, 3, 2);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(132, 23);
            txtPoint.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 187);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(218, 183);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(188, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(701, 102);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(54, 15);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Giới Tính";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(50, 144);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(93, 15);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên Khách Hàng";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(218, 141);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(188, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(506, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblTitleProduct);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 253);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 94);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grb_rdoNu);
            groupBox2.Controls.Add(grb_rdoNam);
            groupBox2.Location = new Point(816, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(175, 45);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giới tính";
            // 
            // grb_rdoNu
            // 
            grb_rdoNu.AutoSize = true;
            grb_rdoNu.Location = new Point(97, 16);
            grb_rdoNu.Name = "grb_rdoNu";
            grb_rdoNu.Size = new Size(41, 19);
            grb_rdoNu.TabIndex = 0;
            grb_rdoNu.TabStop = true;
            grb_rdoNu.Text = "Nữ";
            grb_rdoNu.UseVisualStyleBackColor = true;
            grb_rdoNu.CheckedChanged += Find_Changed;
            // 
            // grb_rdoNam
            // 
            grb_rdoNam.AutoSize = true;
            grb_rdoNam.Location = new Point(20, 16);
            grb_rdoNam.Name = "grb_rdoNam";
            grb_rdoNam.Size = new Size(51, 19);
            grb_rdoNam.TabIndex = 0;
            grb_rdoNam.TabStop = true;
            grb_rdoNam.Text = "Nam";
            grb_rdoNam.UseVisualStyleBackColor = true;
            grb_rdoNam.CheckedChanged += Find_Changed;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFind);
            groupBox1.Controls.Add(cboFind);
            groupBox1.Location = new Point(252, 23);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(529, 50);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(267, 20);
            txtFind.Margin = new Padding(3, 2, 3, 2);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(250, 23);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += Find_Changed;
            // 
            // cboFind
            // 
            cboFind.FormattingEnabled = true;
            cboFind.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Số điện thoại", "" });
            cboFind.Location = new Point(19, 20);
            cboFind.Margin = new Padding(3, 2, 3, 2);
            cboFind.Name = "cboFind";
            cboFind.Size = new Size(213, 23);
            cboFind.TabIndex = 0;
            cboFind.SelectedIndexChanged += Find_Changed;
            // 
            // lblTitleProduct
            // 
            lblTitleProduct.AutoSize = true;
            lblTitleProduct.Location = new Point(536, 2);
            lblTitleProduct.Name = "lblTitleProduct";
            lblTitleProduct.Size = new Size(131, 15);
            lblTitleProduct.TabIndex = 3;
            lblTitleProduct.Text = "Danh Sách Khách Hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCustomer);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 347);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1132, 283);
            panel3.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 0);
            dgvCustomer.Margin = new Padding(3, 2, 3, 2);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(1132, 283);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 630);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlInformation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerForm";
            Text = "PromotionForm";
            Load += CustomerForm_Load;
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInformation;
        private Panel panel2;
        private Panel panel3;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Label lblPhoneNumber;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblTitle;

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnAdd;
        private DataGridView dgvCustomer;
        private Label lblPoint;
        private TextBox txtPoint;
        private GroupBox groupBox1;
        private TextBox txtFind;
        private ComboBox cboFind;
        private Label lblTitleProduct;
        private Label label1;
        private TextBox txtPhoneNumber;
        private GroupBox groupBox2;
        private RadioButton grb_rdoNu;
        private RadioButton grb_rdoNam;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private ErrorProvider errorProvider1;
    }
}