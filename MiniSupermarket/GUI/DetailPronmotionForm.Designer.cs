namespace MiniSupermarket.GUI
{
    partial class DetailPronmotionForm
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
            dgvProductPromotions = new DataGridView();
            groupBox4 = new GroupBox();
            txtSearchPromotion = new TextBox();
            cbxTypeOfSearchPromotion = new ComboBox();
            lblTitlePromotion = new Label();
            panel2 = new Panel();
            dgvProducts = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            cbxTypeSearch = new ComboBox();
            lblTitleProduct = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductPromotions).BeginInit();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProductPromotions);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(lblTitlePromotion);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 533);
            panel1.TabIndex = 0;
            // 
            // dgvProductPromotions
            // 
            dgvProductPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductPromotions.Dock = DockStyle.Bottom;
            dgvProductPromotions.Location = new Point(0, 137);
            dgvProductPromotions.Name = "dgvProductPromotions";
            dgvProductPromotions.RowHeadersWidth = 51;
            dgvProductPromotions.RowTemplate.Height = 29;
            dgvProductPromotions.Size = new Size(649, 396);
            dgvProductPromotions.TabIndex = 1;
            dgvProductPromotions.CellMouseDoubleClick += dgvProductPromotions_CellMouseDoubleClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtSearchPromotion);
            groupBox4.Controls.Add(cbxTypeOfSearchPromotion);
            groupBox4.Location = new Point(21, 60);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(622, 71);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm theo";
            // 
            // txtSearchPromotion
            // 
            txtSearchPromotion.Location = new Point(193, 26);
            txtSearchPromotion.Name = "txtSearchPromotion";
            txtSearchPromotion.Size = new Size(423, 27);
            txtSearchPromotion.TabIndex = 1;
            txtSearchPromotion.KeyUp += txtSearchPromotion_KeyUp;
            // 
            // cbxTypeOfSearchPromotion
            // 
            cbxTypeOfSearchPromotion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypeOfSearchPromotion.FormattingEnabled = true;
            cbxTypeOfSearchPromotion.Items.AddRange(new object[] { "Mã sản phẩm", "Tên sản phẩm", "Loại sản phẩm" });
            cbxTypeOfSearchPromotion.Location = new Point(20, 26);
            cbxTypeOfSearchPromotion.Name = "cbxTypeOfSearchPromotion";
            cbxTypeOfSearchPromotion.Size = new Size(151, 28);
            cbxTypeOfSearchPromotion.TabIndex = 0;
            // 
            // lblTitlePromotion
            // 
            lblTitlePromotion.AutoSize = true;
            lblTitlePromotion.Location = new Point(41, 22);
            lblTitlePromotion.Name = "lblTitlePromotion";
            lblTitlePromotion.Size = new Size(265, 20);
            lblTitlePromotion.TabIndex = 0;
            lblTitlePromotion.Text = "DANH SÁCH SẢN PHẨM KHUYẾN MÃI";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvProducts);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblTitleProduct);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(649, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 533);
            panel2.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Bottom;
            dgvProducts.Location = new Point(0, 137);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(619, 396);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellMouseDoubleClick += dgvProducts_CellMouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(cbxTypeSearch);
            groupBox1.Location = new Point(3, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(193, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(405, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // cbxTypeSearch
            // 
            cbxTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypeSearch.FormattingEnabled = true;
            cbxTypeSearch.Items.AddRange(new object[] { "Mã sản phẩm", "Tên sản phẩm", "Loại sản phẩm" });
            cbxTypeSearch.Location = new Point(20, 26);
            cbxTypeSearch.Name = "cbxTypeSearch";
            cbxTypeSearch.Size = new Size(151, 28);
            cbxTypeSearch.TabIndex = 0;
            // 
            // lblTitleProduct
            // 
            lblTitleProduct.AutoSize = true;
            lblTitleProduct.Location = new Point(168, 22);
            lblTitleProduct.Name = "lblTitleProduct";
            lblTitleProduct.Size = new Size(173, 20);
            lblTitleProduct.TabIndex = 0;
            lblTitleProduct.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // DetailPronmotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailPronmotionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết chương trình khuyến mãi";
            Load += DetailPronmotionForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductPromotions).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProductPromotions;
        private Label lblTitlePromotion;
        private DataGridView dgvProducts;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private ComboBox cbxTypeSearch;
        private Label lblTitleProduct;
        private GroupBox groupBox4;
        private TextBox txtSearchPromotion;
        private ComboBox cbxTypeOfSearchPromotion;
    }
}