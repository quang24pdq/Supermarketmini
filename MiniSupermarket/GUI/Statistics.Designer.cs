namespace MiniSupermarket.GUI {
    partial class Statistics {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.grb_ChiTiet = new System.Windows.Forms.GroupBox();
            this.lb_DoanhThuMinNv = new System.Windows.Forms.Label();
            this.lb_DoanhThuMaxNv = new System.Windows.Forms.Label();
            this.lb_DTHDThapNhat = new System.Windows.Forms.Label();
            this.lb_HoaDonThapNhat = new System.Windows.Forms.Label();
            this.lb_DTHDCaoNhat = new System.Windows.Forms.Label();
            this.lb_HoaDonCaoNhat = new System.Windows.Forms.Label();
            this.lb_TongDoanhThu = new System.Windows.Forms.Label();
            this.lb_DoanhThu = new System.Windows.Forms.Label();
            this.lb_ThongKeTheo = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.lb_DenNgay = new System.Windows.Forms.Label();
            this.cbx_TimKiem = new System.Windows.Forms.ComboBox();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.lb_TuNgay = new System.Windows.Forms.Label();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dshd_sp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grb_ThongTin.SuspendLayout();
            this.grb_ChiTiet.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dshd_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_ThongTin);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 227);
            this.panel1.TabIndex = 0;
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.grb_ChiTiet);
            this.grb_ThongTin.Controls.Add(this.lb_ThongKeTheo);
            this.grb_ThongTin.Controls.Add(this.dtp_DenNgay);
            this.grb_ThongTin.Controls.Add(this.lb_DenNgay);
            this.grb_ThongTin.Controls.Add(this.cbx_TimKiem);
            this.grb_ThongTin.Controls.Add(this.dtp_TuNgay);
            this.grb_ThongTin.Controls.Add(this.lb_TuNgay);
            this.grb_ThongTin.Controls.Add(this.btn_ThongKe);
            this.grb_ThongTin.Location = new System.Drawing.Point(0, 3);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(1165, 221);
            this.grb_ThongTin.TabIndex = 0;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            // 
            // grb_ChiTiet
            // 
            this.grb_ChiTiet.Controls.Add(this.lb_DoanhThuMinNv);
            this.grb_ChiTiet.Controls.Add(this.lb_DoanhThuMaxNv);
            this.grb_ChiTiet.Controls.Add(this.lb_DTHDThapNhat);
            this.grb_ChiTiet.Controls.Add(this.lb_HoaDonThapNhat);
            this.grb_ChiTiet.Controls.Add(this.lb_DTHDCaoNhat);
            this.grb_ChiTiet.Controls.Add(this.lb_HoaDonCaoNhat);
            this.grb_ChiTiet.Controls.Add(this.lb_TongDoanhThu);
            this.grb_ChiTiet.Controls.Add(this.lb_DoanhThu);
            this.grb_ChiTiet.Location = new System.Drawing.Point(527, 20);
            this.grb_ChiTiet.Name = "grb_ChiTiet";
            this.grb_ChiTiet.Size = new System.Drawing.Size(632, 195);
            this.grb_ChiTiet.TabIndex = 9;
            this.grb_ChiTiet.TabStop = false;
            this.grb_ChiTiet.Text = "Chi tiết";
            // 
            // lb_DoanhThuMinNv
            // 
            this.lb_DoanhThuMinNv.AutoSize = true;
            this.lb_DoanhThuMinNv.Location = new System.Drawing.Point(186, 138);
            this.lb_DoanhThuMinNv.Name = "lb_DoanhThuMinNv";
            this.lb_DoanhThuMinNv.Size = new System.Drawing.Size(50, 20);
            this.lb_DoanhThuMinNv.TabIndex = 13;
            this.lb_DoanhThuMinNv.Text = "label2";
            this.lb_DoanhThuMinNv.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lb_DoanhThuMaxNv
            // 
            this.lb_DoanhThuMaxNv.AutoSize = true;
            this.lb_DoanhThuMaxNv.Location = new System.Drawing.Point(186, 69);
            this.lb_DoanhThuMaxNv.Name = "lb_DoanhThuMaxNv";
            this.lb_DoanhThuMaxNv.Size = new System.Drawing.Size(50, 20);
            this.lb_DoanhThuMaxNv.TabIndex = 12;
            this.lb_DoanhThuMaxNv.Text = "label1";
            // 
            // lb_DTHDThapNhat
            // 
            this.lb_DTHDThapNhat.AutoSize = true;
            this.lb_DTHDThapNhat.Location = new System.Drawing.Point(387, 103);
            this.lb_DTHDThapNhat.Name = "lb_DTHDThapNhat";
            this.lb_DTHDThapNhat.Size = new System.Drawing.Size(17, 20);
            this.lb_DTHDThapNhat.TabIndex = 11;
            this.lb_DTHDThapNhat.Text = "0";
            // 
            // lb_HoaDonThapNhat
            // 
            this.lb_HoaDonThapNhat.AutoSize = true;
            this.lb_HoaDonThapNhat.Location = new System.Drawing.Point(62, 103);
            this.lb_HoaDonThapNhat.Name = "lb_HoaDonThapNhat";
            this.lb_HoaDonThapNhat.Size = new System.Drawing.Size(134, 20);
            this.lb_HoaDonThapNhat.TabIndex = 10;
            this.lb_HoaDonThapNhat.Text = "Hóa đơn thấp nhất";
            // 
            // lb_DTHDCaoNhat
            // 
            this.lb_DTHDCaoNhat.AutoSize = true;
            this.lb_DTHDCaoNhat.Location = new System.Drawing.Point(387, 32);
            this.lb_DTHDCaoNhat.Name = "lb_DTHDCaoNhat";
            this.lb_DTHDCaoNhat.Size = new System.Drawing.Size(17, 20);
            this.lb_DTHDCaoNhat.TabIndex = 9;
            this.lb_DTHDCaoNhat.Text = "0";
            // 
            // lb_HoaDonCaoNhat
            // 
            this.lb_HoaDonCaoNhat.AutoSize = true;
            this.lb_HoaDonCaoNhat.Location = new System.Drawing.Point(62, 32);
            this.lb_HoaDonCaoNhat.Name = "lb_HoaDonCaoNhat";
            this.lb_HoaDonCaoNhat.Size = new System.Drawing.Size(128, 20);
            this.lb_HoaDonCaoNhat.TabIndex = 8;
            this.lb_HoaDonCaoNhat.Text = "Hóa đơn cao nhất";
            // 
            // lb_TongDoanhThu
            // 
            this.lb_TongDoanhThu.AutoSize = true;
            this.lb_TongDoanhThu.Location = new System.Drawing.Point(156, 158);
            this.lb_TongDoanhThu.Name = "lb_TongDoanhThu";
            this.lb_TongDoanhThu.Size = new System.Drawing.Size(117, 20);
            this.lb_TongDoanhThu.TabIndex = 6;
            this.lb_TongDoanhThu.Text = "Tổng doanh thu:";
            this.lb_TongDoanhThu.Click += new System.EventHandler(this.lb_TongDoanhThu_Click);
            // 
            // lb_DoanhThu
            // 
            this.lb_DoanhThu.AutoSize = true;
            this.lb_DoanhThu.Location = new System.Drawing.Point(387, 158);
            this.lb_DoanhThu.Name = "lb_DoanhThu";
            this.lb_DoanhThu.Size = new System.Drawing.Size(17, 20);
            this.lb_DoanhThu.TabIndex = 7;
            this.lb_DoanhThu.Text = "0";
            // 
            // lb_ThongKeTheo
            // 
            this.lb_ThongKeTheo.AutoSize = true;
            this.lb_ThongKeTheo.Location = new System.Drawing.Point(21, 35);
            this.lb_ThongKeTheo.Name = "lb_ThongKeTheo";
            this.lb_ThongKeTheo.Size = new System.Drawing.Size(104, 20);
            this.lb_ThongKeTheo.TabIndex = 8;
            this.lb_ThongKeTheo.Text = "Thống kê theo";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.Location = new System.Drawing.Point(190, 116);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(311, 27);
            this.dtp_DenNgay.TabIndex = 1;
            // 
            // lb_DenNgay
            // 
            this.lb_DenNgay.AutoSize = true;
            this.lb_DenNgay.Location = new System.Drawing.Point(21, 116);
            this.lb_DenNgay.Name = "lb_DenNgay";
            this.lb_DenNgay.Size = new System.Drawing.Size(72, 20);
            this.lb_DenNgay.TabIndex = 3;
            this.lb_DenNgay.Text = "Đến ngày";
            // 
            // cbx_TimKiem
            // 
            this.cbx_TimKiem.FormattingEnabled = true;
            this.cbx_TimKiem.Location = new System.Drawing.Point(190, 32);
            this.cbx_TimKiem.Name = "cbx_TimKiem";
            this.cbx_TimKiem.Size = new System.Drawing.Size(311, 28);
            this.cbx_TimKiem.TabIndex = 4;
            this.cbx_TimKiem.SelectedIndexChanged += new System.EventHandler(this.cbx_TimKiem_SelectedIndexChanged);
            this.cbx_TimKiem.TextChanged += new System.EventHandler(this.cbx_TimKiem_TextChanged);
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Location = new System.Drawing.Point(190, 77);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(311, 27);
            this.dtp_TuNgay.TabIndex = 0;
            // 
            // lb_TuNgay
            // 
            this.lb_TuNgay.AutoSize = true;
            this.lb_TuNgay.Location = new System.Drawing.Point(21, 77);
            this.lb_TuNgay.Name = "lb_TuNgay";
            this.lb_TuNgay.Size = new System.Drawing.Size(62, 20);
            this.lb_TuNgay.TabIndex = 2;
            this.lb_TuNgay.Text = "Từ ngày";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(21, 162);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(480, 52);
            this.btn_ThongKe.TabIndex = 5;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dshd_sp);
            this.panel2.Location = new System.Drawing.Point(1, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 448);
            this.panel2.TabIndex = 1;
            // 
            // dshd_sp
            // 
            this.dshd_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dshd_sp.Location = new System.Drawing.Point(3, 3);
            this.dshd_sp.Name = "dshd_sp";
            this.dshd_sp.RowHeadersWidth = 51;
            this.dshd_sp.RowTemplate.Height = 29;
            this.dshd_sp.Size = new System.Drawing.Size(1175, 442);
            this.dshd_sp.TabIndex = 0;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.panel1.ResumeLayout(false);
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.grb_ChiTiet.ResumeLayout(false);
            this.grb_ChiTiet.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dshd_sp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lb_TuNgay;
        private DateTimePicker dtp_DenNgay;
        private DateTimePicker dtp_TuNgay;
        private Label lb_DenNgay;
        private Button btn_ThongKe;
        private ComboBox cbx_TimKiem;
        private Label lb_DoanhThu;
        private Label lb_TongDoanhThu;
        private GroupBox grb_ThongTin;
        private DataGridView dshd_sp;
        private GroupBox grb_ChiTiet;
        private Label lb_ThongKeTheo;
        private Label lb_DTHDThapNhat;
        private Label lb_HoaDonThapNhat;
        private Label lb_DTHDCaoNhat;
        private Label lb_HoaDonCaoNhat;
        private Label lb_DoanhThuMinNv;
        private Label lb_DoanhThuMaxNv;
    }
}