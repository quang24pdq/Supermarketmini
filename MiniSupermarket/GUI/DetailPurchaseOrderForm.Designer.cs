namespace MiniSupermarket.GUI
{
    partial class DetailPurchaseOrderForm
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
            pnlDetailOrders = new Panel();
            groupBox2 = new GroupBox();
            txtSearchOrder = new TextBox();
            cbxTypeOfSearchOrder = new ComboBox();
            btnPay = new Button();
            dgvProductOrders = new DataGridView();
            lblProductOrder = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dgvProducts = new DataGridView();
            pnlInformation = new Panel();
            btnReset = new Button();
            btnAdd = new Button();
            nudQuantity = new NumericUpDown();
            txtOrderPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtProductID = new TextBox();
            label1 = new Label();
            lblProduct = new Label();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            cbxTypeOfSearch = new ComboBox();
            pnlDetailOrders.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductOrders).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDetailOrders
            // 
            pnlDetailOrders.Controls.Add(groupBox2);
            pnlDetailOrders.Controls.Add(btnPay);
            pnlDetailOrders.Controls.Add(dgvProductOrders);
            pnlDetailOrders.Controls.Add(lblProductOrder);
            pnlDetailOrders.Dock = DockStyle.Left;
            pnlDetailOrders.Location = new Point(0, 0);
            pnlDetailOrders.Margin = new Padding(3, 4, 3, 4);
            pnlDetailOrders.Name = "pnlDetailOrders";
            pnlDetailOrders.Size = new Size(557, 596);
            pnlDetailOrders.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearchOrder);
            groupBox2.Controls.Add(cbxTypeOfSearchOrder);
            groupBox2.Location = new Point(8, 67);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(543, 63);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm theo";
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Location = new Point(178, 24);
            txtSearchOrder.Margin = new Padding(3, 4, 3, 4);
            txtSearchOrder.Name = "txtSearchOrder";
            txtSearchOrder.Size = new Size(359, 27);
            txtSearchOrder.TabIndex = 1;
            txtSearchOrder.KeyUp += txtSearchOrder_KeyUp;
            // 
            // cbxTypeOfSearchOrder
            // 
            cbxTypeOfSearchOrder.FormattingEnabled = true;
            cbxTypeOfSearchOrder.Items.AddRange(new object[] { "Mã sản phẩm", "Tên sản phẩm" });
            cbxTypeOfSearchOrder.Location = new Point(7, 24);
            cbxTypeOfSearchOrder.Margin = new Padding(3, 4, 3, 4);
            cbxTypeOfSearchOrder.Name = "cbxTypeOfSearchOrder";
            cbxTypeOfSearchOrder.Size = new Size(138, 28);
            cbxTypeOfSearchOrder.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Location = new Point(207, 547);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(119, 37);
            btnPay.TabIndex = 22;
            btnPay.Text = "Thanh Toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // dgvProductOrders
            // 
            dgvProductOrders.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProductOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductOrders.Location = new Point(0, 138);
            dgvProductOrders.Margin = new Padding(3, 4, 3, 4);
            dgvProductOrders.Name = "dgvProductOrders";
            dgvProductOrders.RowHeadersWidth = 51;
            dgvProductOrders.RowTemplate.Height = 25;
            dgvProductOrders.Size = new Size(557, 402);
            dgvProductOrders.TabIndex = 1;
            dgvProductOrders.CellDoubleClick += dgvProductOrders_CellDoubleClick;
            // 
            // lblProductOrder
            // 
            lblProductOrder.AutoSize = true;
            lblProductOrder.Location = new Point(68, 24);
            lblProductOrder.Name = "lblProductOrder";
            lblProductOrder.Size = new Size(184, 20);
            lblProductOrder.TabIndex = 0;
            lblProductOrder.Text = "DANH SÁCH NHẬP HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, -1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 596);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(pnlDetailOrders);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1132, 596);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(pnlInformation);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(557, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(575, 596);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvProducts);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(575, 340);
            panel5.TabIndex = 6;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(575, 340);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellMouseClick += dgvProducts_CellMouseClick;
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(btnReset);
            pnlInformation.Controls.Add(btnAdd);
            pnlInformation.Controls.Add(nudQuantity);
            pnlInformation.Controls.Add(txtOrderPrice);
            pnlInformation.Controls.Add(label4);
            pnlInformation.Controls.Add(label3);
            pnlInformation.Controls.Add(txtProductName);
            pnlInformation.Controls.Add(label2);
            pnlInformation.Controls.Add(txtProductID);
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(lblProduct);
            pnlInformation.Controls.Add(groupBox1);
            pnlInformation.Dock = DockStyle.Top;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Margin = new Padding(3, 4, 3, 4);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(575, 256);
            pnlInformation.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(297, 152);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 31);
            btnReset.TabIndex = 21;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(162, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(449, 99);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(114, 27);
            nudQuantity.TabIndex = 13;
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new Point(449, 64);
            txtOrderPrice.Margin = new Padding(3, 4, 3, 4);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.Size = new Size(114, 27);
            txtOrderPrice.TabIndex = 12;
            txtOrderPrice.KeyPress += txtOrderPrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 67);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 11;
            label4.Text = "Giá nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Số lượng:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(185, 99);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(114, 27);
            txtProductName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(185, 64);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(114, 27);
            txtProductID.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 67);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã sản phẩm:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(97, 12);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(173, 20);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(cbxTypeOfSearch);
            groupBox1.Location = new Point(6, 190);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(566, 63);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(178, 24);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(382, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // cbxTypeOfSearch
            // 
            cbxTypeOfSearch.FormattingEnabled = true;
            cbxTypeOfSearch.Items.AddRange(new object[] { "Mã sản phẩm", "Tên sản phẩm" });
            cbxTypeOfSearch.Location = new Point(7, 24);
            cbxTypeOfSearch.Margin = new Padding(3, 4, 3, 4);
            cbxTypeOfSearch.Name = "cbxTypeOfSearch";
            cbxTypeOfSearch.Size = new Size(138, 28);
            cbxTypeOfSearch.TabIndex = 0;
            // 
            // DetailPurchaseOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 595);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailPurchaseOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            Load += DetailPurchaseOrderForm_Load;
            pnlDetailOrders.ResumeLayout(false);
            pnlDetailOrders.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductOrders).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDetailOrders;
        private Label lblProductOrder;
        private Panel panel2;
        private Label lblProduct;
        private DataGridView dgvProductOrders;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private ComboBox cbxTypeOfSearch;
        private Panel panel4;
        private Panel pnlInformation;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtProductID;
        private Label label1;
        private DataGridView dgvProducts;
        private TextBox txtOrderPrice;
        private Label label4;
        private NumericUpDown nudQuantity;
        private Button btnReset;
        private Button btnAdd;
        private Panel panel3;
        private Panel panel5;
        private Button btnPay;
        private GroupBox groupBox2;
        private TextBox txtSearchOrder;
        private ComboBox cbxTypeOfSearchOrder;
    }
}