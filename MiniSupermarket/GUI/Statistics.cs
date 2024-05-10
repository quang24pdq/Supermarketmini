using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI {
    public partial class Statistics : Form {
        SaleBUS saleBUS = new SaleBUS();
        StatisticsBUS statisticsBUS = new StatisticsBUS();
        DetalBillBus DetalBillBus = new DetalBillBus();
        ProductBUS productBUS = new ProductBUS();
        public Statistics() {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            cbx_TimKiem.Font = ProjectFont.getNormalFont();
            lb_DenNgay.Font = ProjectFont.getNormalFont();
            lb_TuNgay.Font = ProjectFont.getNormalFont();
            dtp_DenNgay.Font = ProjectFont.getNormalFont();
            dtp_TuNgay.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_DoanhThu.Font = ProjectFont.getNormalFont();
            lb_ThongKeTheo.Font = ProjectFont.getNormalFont();
            lb_HoaDonCaoNhat.Font = ProjectFont.getNormalFont();
            lb_HoaDonThapNhat.Font = ProjectFont.getNormalFont();
            lb_DTHDCaoNhat.Font = ProjectFont.getNormalFont();
            lb_DTHDThapNhat.Font = ProjectFont.getNormalFont();
            lb_DoanhThuMaxNv.Font = ProjectFont.getNormalFont();
            lb_DoanhThuMinNv.Font = ProjectFont.getNormalFont();

            cbx_TimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_TimKiem.Items.Add("Hóa đơn");
            cbx_TimKiem.Items.Add("Nhân viên");
            cbx_TimKiem.Items.Add("Sản phẩm");
            cbx_TimKiem.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dshd_sp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dshd_sp.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dshd_sp.ReadOnly = true;

        }
        public void LoadTheme() {
            // Thêm màu và chỉnh font cho các tiêu đề group box
            grb_ThongTin.ForeColor = ThemeColor.SecondaryColor;
            grb_ThongTin.Font = ProjectFont.getTitleFont();
            grb_ChiTiet.ForeColor = ThemeColor.SecondaryColor;
            grb_ChiTiet.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các nút
            foreach (Control btns in this.grb_ThongTin.Controls) {
                if (btns.GetType() == typeof(Button)) {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = ProjectFont.getNormalFont();
                }
            }
            //Thêm màu và chỉnh font cho các label
            cbx_TimKiem.Font = ProjectFont.getNormalFont();
            lb_DenNgay.Font = ProjectFont.getNormalFont();
            lb_TuNgay.Font = ProjectFont.getNormalFont();
            dtp_DenNgay.Font = ProjectFont.getNormalFont();
            dtp_TuNgay.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_DoanhThu.Font = ProjectFont.getNormalFont();
            lb_ThongKeTheo.Font = ProjectFont.getNormalFont();
            lb_HoaDonCaoNhat.Font = ProjectFont.getNormalFont();
            lb_HoaDonThapNhat.Font = ProjectFont.getNormalFont();
            lb_DTHDCaoNhat.Font = ProjectFont.getNormalFont();
            lb_DTHDThapNhat.Font = ProjectFont.getNormalFont();
            lb_DoanhThuMinNv.Font = ProjectFont.getNormalFont();
            lb_DoanhThuMaxNv.Font = ProjectFont.getNormalFont();

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void Statistics_Load(object sender, EventArgs e) {



        }

        private void lb_DoanhThu_Click(object sender, EventArgs e) {

        }

        private void grb_ThongTin_Enter(object sender, EventArgs e) {

        }

        private void lb_TongDoanhThu_Click(object sender, EventArgs e) {

        }

        private void cbx_TimKiem_SelectedIndexChanged(object sender, EventArgs e) {


        }

        private void cbx_TimKiem_TextChanged(object sender, EventArgs e) {

            if (cbx_TimKiem.Text == "Hóa đơn") {
                // Tải dữ liệu lên data grid view
                dshd_sp.DataSource = saleBUS.getAllBillsForStatus();
                if (dshd_sp.RowCount > 0)
                {
                    // Đổi tên cột
                    dshd_sp.Columns["BillID"].HeaderText = "Mã hóa đơn";
                    dshd_sp.Columns["Date"].HeaderText = "Ngày tạo";
                    dshd_sp.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
                    dshd_sp.Columns["CustomerID"].HeaderText = "Mã khách hàng";
                    dshd_sp.Columns["EstimatedPrice"].HeaderText = "Giá ước tính";
                    dshd_sp.Columns["ReducePrice"].HeaderText = "Giá giảm";
                    dshd_sp.Columns["TotalPrice"].HeaderText = "Tổng giá";
                    dshd_sp.Columns["Status"].HeaderText = "status";
                }
                dtp_TuNgay.Visible = true;
                dtp_DenNgay.Visible = true;
                lb_TuNgay.Visible = true;
                lb_DenNgay.Visible = true;
                lb_DoanhThu.Visible = true;
                lb_TongDoanhThu.Visible = true;
                lb_DoanhThuMaxNv.Visible = false;
                lb_DoanhThuMinNv.Visible = false;

                // Tính tổng doanh thu của tất cả hóa đơn
                decimal totalRevenueForAllBills = saleBUS.CalculateTotalRevenueForAllBills();

                // Hiển thị tổng doanh thu lên label hoặc nơi mong muốn
                lb_DoanhThu.Text = $" {totalRevenueForAllBills.ToString()}";
                LoadTheme();

                // Lấy tổng tiền cao nhất từ tất cả hóa đơn
                decimal maxTotalPriceForAllBills = saleBUS.GetMaxTotalPriceForAllBills();

                // Lấy tổng tiền bé nhất từ tất cả hóa đơn
                decimal minTotalPriceForAllBills = saleBUS.GetMinTotalPriceForAllBills();

                lb_HoaDonCaoNhat.Text = $"Hóa đơn cao nhất            :";
                lb_HoaDonThapNhat.Text = $"Hóa đơn thấp nhất           :";
                string MaxBillID = saleBUS.GetIDfromTotalPrice(maxTotalPriceForAllBills);
                string MinID = saleBUS.GetIDfromTotalPrice(minTotalPriceForAllBills);
                lb_DTHDCaoNhat.Text = $" [{MaxBillID}] Giá: {maxTotalPriceForAllBills.ToString()}";
                lb_DTHDThapNhat.Text = $" [{MinID}] Giá: {minTotalPriceForAllBills.ToString()}";
                // Hiển thị hóa đơn khi chọn giá trị "Hóa đơn"
                btn_ThongKe.Text = "Hiển thị Hóa đơn";
                btn_ThongKe.Click -= new EventHandler(button1_Click);
                btn_ThongKe.Click += new EventHandler(ShowInvoices);

            } else if (cbx_TimKiem.Text == "Sản phẩm") {
                dshd_sp.DataSource = DetalBillBus.getAllDetalBill();
                if (dshd_sp.RowCount > 0 )
                {
                    // Đổi tên cột
                    dshd_sp.Columns["BillID"].HeaderText = "Mã hóa đơn";
                    dshd_sp.Columns["ProductID"].HeaderText = "Mã sản phẩm";
                    dshd_sp.Columns["OrderID"].HeaderText = "Mã nhà cung cấp";
                    dshd_sp.Columns["SalePrice"].HeaderText = "Giá bán";
                    dshd_sp.Columns["Quantity"].HeaderText = "Số lượng";
                }

                btn_ThongKe.Text = "Thống kê";
                btn_ThongKe.Click -= new EventHandler(button1_Click);
                btn_ThongKe.Click += new EventHandler(ShowProducts);

                lb_DoanhThu.Visible = false;
                lb_TongDoanhThu.Visible = false;
                dtp_TuNgay.Visible = false;
                dtp_DenNgay.Visible = false;
                lb_TuNgay.Visible = false;
                lb_DenNgay.Visible = false;
                lb_DoanhThuMaxNv.Visible = true;
                lb_DoanhThuMinNv.Visible = true;

                lb_HoaDonCaoNhat.Text = $"Sản phẩm bán chạy nhất:";
                lb_DTHDCaoNhat.Text = $"";
                lb_DoanhThuMaxNv.Text = $"-> Số lượng bán ra: ";
                lb_HoaDonThapNhat.Text = $"Sản phẩm bán ít nhất:";
                lb_DTHDThapNhat.Text = $"";
                lb_DoanhThuMinNv.Text = $"-> Số lượng bán ra: ";
            } else if (cbx_TimKiem.Text == "Nhân viên") {
                dshd_sp.DataSource = statisticsBUS.getAllBillInfor();
                if (dshd_sp.RowCount > 0 )
                {
                    // Đổi tên cột
                    dshd_sp.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
                    dshd_sp.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
                    dshd_sp.Columns["BillID"].HeaderText = "Mã hóa đơn";
                    dshd_sp.Columns["Date"].HeaderText = "Ngày tạo";
                    dshd_sp.Columns["TotalPrice"].HeaderText = "Tổng giá";
                }

                lb_DoanhThu.Visible = false;
                dtp_TuNgay.Visible = true;
                dtp_DenNgay.Visible = true;
                lb_TuNgay.Visible = true;
                lb_DenNgay.Visible = true;
                lb_TongDoanhThu.Visible = false;
                lb_DoanhThuMaxNv.Visible = true;
                lb_DoanhThuMinNv.Visible = true;

                //Lấy thông tin mã nhân viên
                string maxTotalPriceForAllBills = statisticsBUS.GetEmployeeWithMaxTotalSales();
                string minTotalPriceForAllBills = statisticsBUS.GetEmployeeWithMinTotalSales();

                // Lấy thông tin nhân viên từ ID
                string employeeWithMaxSalesName = statisticsBUS.GetNameFromId(maxTotalPriceForAllBills);
                string employeeWithMinSalesName = statisticsBUS.GetNameFromId(minTotalPriceForAllBills);

                //lấy thông tin doanh thu của nhân viên 
                Decimal MaxNv = statisticsBUS.GetMaxTotalSalesAll();
                Decimal MinNv = statisticsBUS.GetMinTotalSalesAll();

                lb_HoaDonCaoNhat.Text = $"Nhân viên bán nhiều nhất     :";
                lb_DTHDCaoNhat.Text = $"[{maxTotalPriceForAllBills}]  {employeeWithMaxSalesName}";
                lb_DoanhThuMaxNv.Text = $"-> Doanh thu: {MaxNv}";
                lb_HoaDonThapNhat.Text = $"Nhân viên bán ít nhất             :";
                lb_DTHDThapNhat.Text = $"[{minTotalPriceForAllBills}]  {employeeWithMinSalesName}";
                lb_DoanhThuMinNv.Text = $"-> Doanh thu: {MinNv}";


                btn_ThongKe.Text = "Hiển thị nhân viên";
                btn_ThongKe.Click -= new EventHandler(button1_Click);
                btn_ThongKe.Click += new EventHandler(ShowEmployeeInfo);

            }
        }
        private void ShowInvoices(object sender, EventArgs e) {
            lb_HoaDonCaoNhat.Text = $"Hóa đơn cao nhất            :";
            lb_HoaDonThapNhat.Text = $"Hóa đơn thấp nhất           :";
            DateTime fromDate = dtp_TuNgay.Value;
            DateTime toDate = dtp_DenNgay.Value;

            DataTable billsByDateRange = saleBUS.GetBillsByDateRange(fromDate, toDate);
            dshd_sp.DataSource = billsByDateRange;

            //Tổng doanh thu theo khoảng thời gian
            decimal totalRevenue = saleBUS.CalculateTotalRevenue(billsByDateRange);
            lb_DoanhThu.Text = $" {totalRevenue.ToString()}"; // Hiển thị tổng doanh thu trên label

            // Hiển thị hóa đơn có tổng tiền cao nhất và thấp nhất
            decimal maxTotalPrice = saleBUS.GetMaxTotalPrice(billsByDateRange);
            decimal minTotalPrice = saleBUS.GetMinTotalPrice(billsByDateRange);

            string MaxBillID = saleBUS.GetIDfromTotalPrice(maxTotalPrice);
            string MinID = saleBUS.GetIDfromTotalPrice(minTotalPrice);
            lb_DTHDCaoNhat.Text = $" [{MaxBillID}] Giá: {maxTotalPrice.ToString()}";
            lb_DTHDThapNhat.Text = $" [{MinID}] Giá: {minTotalPrice.ToString()}";

        }

        private void ShowProducts(object sender, EventArgs e) {
            dshd_sp.DataSource = DetalBillBus.getAllDetalBill();
            if (dshd_sp.RowCount > 0 )
            {
                // Đổi tên cột
                dshd_sp.Columns["BillID"].HeaderText = "Mã hóa đơn";
                dshd_sp.Columns["ProductID"].HeaderText = "Mã sản phẩm";
                dshd_sp.Columns["OrderID"].HeaderText = "Mã nhà cung cấp";
                dshd_sp.Columns["SalePrice"].HeaderText = "Giá bán";
                dshd_sp.Columns["Quantity"].HeaderText = "Số lượng";
            }

            //Mã sản phẩm
            string MaxProductIdSale = DetalBillBus.GetMostSoldProduct();
            string MinProductIdSale = DetalBillBus.GetLeastSoldProduct();

            // Số lượng bán ra
            int QuantityMax = DetalBillBus.GetMostSoldProductQuantity();
            int QuantityMin = DetalBillBus.GetLeastSoldProductQuantity();

            //Tên sản phẩm dựa trên mã
            string nameProductMax = productBUS.GetNameFromId(MaxProductIdSale);
            string nameProductMin = productBUS.GetNameFromId(MinProductIdSale);

            lb_HoaDonCaoNhat.Text = $"Sản phẩm bán chạy nhất:";
            lb_DTHDCaoNhat.Text = $"[{MaxProductIdSale}] {nameProductMax}";
            lb_DoanhThuMaxNv.Text = $"-> Số lượng bán ra: {QuantityMax} ";
            lb_HoaDonThapNhat.Text = $"Sản phẩm bán ít nhất:";
            lb_DTHDThapNhat.Text = $"[{MinProductIdSale}] {nameProductMin}";
            lb_DoanhThuMinNv.Text = $"-> Số lượng bán ra: {QuantityMin}";

        }

        private void ShowEmployeeInfo(object sender, EventArgs e) {

            DateTime fromDate = dtp_TuNgay.Value;
            DateTime toDate = dtp_DenNgay.Value;

            DataTable billsByDateRange = statisticsBUS.GetEmployEEsByDateRange(fromDate, toDate);
            dshd_sp.DataSource = billsByDateRange;

            // Tính và hiển thị nhân viên có doanh thu cao nhất
            string employeeWithMaxSales = statisticsBUS.GetEmployeeWithMaxTotalSalesTIme(fromDate, toDate);
            string employeeWithMinSales = statisticsBUS.GetEmployeeWithMinTotalSalesTime(fromDate, toDate);

            // Lấy thông tin nhân viên từ ID
            string employeeWithMaxSalesName = statisticsBUS.GetNameFromId(employeeWithMaxSales);
            string employeeWithMinSalesName = statisticsBUS.GetNameFromId(employeeWithMinSales);
            //lấy thông tin doanh thu của nhân viên 
            Decimal MaxNv = statisticsBUS.GetMaxTotalSales(fromDate, toDate);
            Decimal MinNv = statisticsBUS.GetMinTotalSales(fromDate, toDate);

            lb_HoaDonCaoNhat.Text = $"Nhân viên bán nhiều nhất:";
            lb_DTHDCaoNhat.Text = $"[{employeeWithMaxSales}]  {employeeWithMaxSalesName}";
            lb_DoanhThuMaxNv.Text = $"-> Doanh thu: {MaxNv}";
            lb_HoaDonThapNhat.Text = $"Nhân viên bán ít nhất:";
            lb_DTHDThapNhat.Text = $"[{employeeWithMinSales}]  {employeeWithMinSalesName}";
            lb_DoanhThuMinNv.Text = $"-> Doanh thu: {MinNv}";
        }

        private void label2_Click_1(object sender, EventArgs e) {

        }
    }
}