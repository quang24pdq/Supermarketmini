namespace MiniSupermarket.GUI {
    partial class DetailBillForm {
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
            panel3 = new Panel();
            grb_TimKiem = new GroupBox();
            cbx_TimKiem = new ComboBox();
            txt_TimKiem = new TextBox();
            dgvProduct = new DataGridView();
            panel1 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            txtQuantity = new TextBox();
            btnThanhToan = new Button();
            dgvDetalBill = new DataGridView();
            pnlInformation = new Panel();
            panel3.SuspendLayout();
            grb_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalBill).BeginInit();
            pnlInformation.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(grb_TimKiem);
            panel3.Controls.Add(dgvProduct);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(488, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 630);
            panel3.TabIndex = 2;
            // 
            // grb_TimKiem
            // 
            grb_TimKiem.Controls.Add(cbx_TimKiem);
            grb_TimKiem.Controls.Add(txt_TimKiem);
            grb_TimKiem.Dock = DockStyle.Top;
            grb_TimKiem.Location = new Point(0, 0);
            grb_TimKiem.Margin = new Padding(3, 2, 3, 2);
            grb_TimKiem.Name = "grb_TimKiem";
            grb_TimKiem.Padding = new Padding(3, 2, 3, 2);
            grb_TimKiem.Size = new Size(859, 80);
            grb_TimKiem.TabIndex = 1;
            grb_TimKiem.TabStop = false;
            grb_TimKiem.Text = "Tìm kiếm";
            // 
            // cbx_TimKiem
            // 
            cbx_TimKiem.FormattingEnabled = true;
            cbx_TimKiem.Location = new Point(181, 19);
            cbx_TimKiem.Margin = new Padding(3, 2, 3, 2);
            cbx_TimKiem.Name = "cbx_TimKiem";
            cbx_TimKiem.Size = new Size(177, 23);
            cbx_TimKiem.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(363, 19);
            txt_TimKiem.Margin = new Padding(3, 2, 3, 2);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(284, 23);
            txt_TimKiem.TabIndex = 0;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            txt_TimKiem.KeyDown += txt_TimKiem_KeyDown;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(0, 80);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(859, 550);
            dgvProduct.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 80);
            panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXoa.Location = new Point(308, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(174, 25);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa sản phẩm trong giỏ hàng";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSua.Location = new Point(161, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 25);
            btnSua.TabIndex = 1;
            btnSua.Text = "Cập nhập số lượng";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThem.Location = new Point(12, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 25);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Giỏ Hàng";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(dgvDetalBill);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(488, 550);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtQuantity);
            panel5.Controls.Add(btnThanhToan);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 459);
            panel5.Name = "panel5";
            panel5.Size = new Size(488, 91);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 34);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(89, 26);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(85, 23);
            txtQuantity.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(326, 25);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(139, 33);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // dgvDetalBill
            // 
            dgvDetalBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalBill.Dock = DockStyle.Fill;
            dgvDetalBill.Location = new Point(0, 0);
            dgvDetalBill.Name = "dgvDetalBill";
            dgvDetalBill.RowTemplate.Height = 25;
            dgvDetalBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalBill.Size = new Size(488, 550);
            dgvDetalBill.TabIndex = 0;
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(panel4);
            pnlInformation.Controls.Add(panel1);
            pnlInformation.Dock = DockStyle.Left;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Margin = new Padding(3, 2, 3, 2);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(488, 630);
            pnlInformation.TabIndex = 0;
            // 
            // DetailBillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 630);
            Controls.Add(panel3);
            Controls.Add(pnlInformation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetailBillForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PromotionForm";
            Load += DetailFormMuaHang_Load;
            panel3.ResumeLayout(false);
            grb_TimKiem.ResumeLayout(false);
            grb_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalBill).EndInit();
            pnlInformation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DataGridView dgvProduct;
        private Panel pnlInformation;
        private Panel panel4;
        private DataGridView dgvDetalBill;
        private Panel panel1;
        private Label label1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel5;
        private Button btnThanhToan;
        private Label label2;
        private TextBox txtQuantity;
        private GroupBox grb_TimKiem;
        private ComboBox cbx_TimKiem;
        private TextBox txt_TimKiem;
    }
}