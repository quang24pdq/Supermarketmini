using DocumentFormat.OpenXml.Drawing.Charts;
using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using MiniSupermarket.RegularExpression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniSupermarket.GUI {
    public partial class DetailBillForm : Form {
        string idBill;
        bool isdeleted;
        ProductBUS productBUS = new ProductBUS();
        DetalBillBus detalBillBus = new DetalBillBus();
        AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();

        public DetailBillForm(string idBill, bool isDeleted) {
            this.idBill = idBill;
            this.isdeleted = isDeleted;

            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);

            cbx_TimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_TimKiem.Items.Add("Mã sản phẩm");
            cbx_TimKiem.Items.Add("Tên sản phẩm");
            cbx_TimKiem.Items.Add("Tên loại sản phẩm");
            cbx_TimKiem.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dgvProduct.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dgvProduct.ReadOnly = true;
            // Cho text search sẽ hiển thị suggestion box
            txt_TimKiem.AutoCompleteCustomSource = allowedTypes;
            txt_TimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_TimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (isDeleted) {
                enableButton();
            }
        }

        public void LoadTheme() {
            // Thêm màu cho tất cả các nút ở panel top
            foreach (Control btns in this.pnlInformation.Controls) {
                if (btns.GetType() == typeof(Button)) {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                } else if (btns.GetType() == typeof(Label)) {
                    Label lb = (Label)btns;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        private void DetailFormMuaHang_Load(object sender, EventArgs e) {
            load_dtgv();
            //LoadTheme();
        }

        private void enableButton() {
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThanhToan.Enabled = false;
        }

        private void load_dtgv() {

            // Lấy dữ liệu chi tiết hóa đơn từ Bus
            dgvDetalBill.DataSource = detalBillBus.getDetalBill(this.idBill);

            // Điều chỉnh tiêu đề cột
            dgvDetalBill.Columns["Name"].HeaderText = "Tên Sản Phẩm";
            dgvDetalBill.Columns["TotalQuantity"].HeaderText = "Số lượng";
            dgvDetalBill.Columns["TotalSalePrice"].HeaderText = "Tổng Đơn giá";
            dgvDetalBill.Columns["PromotionID"].HeaderText = "Mã giảm giá";

            // Ẩn các cột không cần thiết
            dgvDetalBill.Columns["BillID"].Visible = false;
            dgvDetalBill.Columns["ProductID"].Visible = false;
            


            dgvProduct.DataSource = productBUS.getAllProduct();
            dgvProduct.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns["Name"].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns["ProductTypeName"].HeaderText = "Mã loại";
            dgvProduct.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProduct.Columns["CurrentPrice"].HeaderText = "Đơn giá";
            dgvProduct.Columns["Description"].HeaderText = "Mô tả";
            dgvProduct.Columns["Unit"].HeaderText = "Kiểu";
            dgvProduct.Columns["PromotionName"].HeaderText = "Tên khuyến mãi";
            dgvProduct.Columns["isDeleted"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn trong dgvProduct hay không
            if (dgvProduct.SelectedRows.Count > 0 && dgvProduct.SelectedRows[0].Cells[0].Value != null) {
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                int productQuantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());
                if (!detalBillBus.checkIdExist(this.idBill, productID)) {
                    if (ProjectRegex.checkSoNguyenDuong(txtQuantity.Text)) {
                        int newQuantity = int.Parse(txtQuantity.Text);
                        if (newQuantity <= productQuantity) {
                            detalBillBus.AddDetailBill(this.idBill, productID, newQuantity);
                            load_dtgv();
                        } else {
                            MessageBox.Show("Sản phẩm không đủ số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } else {
                        MessageBox.Show("Số lượng phải là số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (dgvDetalBill.SelectedRows.Count > 0 && dgvDetalBill.SelectedRows[0].Cells[0].Value != null) {
                DataGridViewRow selectedRow = dgvDetalBill.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();

                // Tìm hàng thỏa mãn điều kiện
                DataRow[] foundRows = productBUS.getAllProduct().Select($"ProductID = '{productID}'");
                int productQuantity = Convert.ToInt32(foundRows[0]["Quantity"]);
                int detailQuantity = int.Parse(selectedRow.Cells["TotalQuantity"].Value.ToString());

                if (detalBillBus.checkIdExist(this.idBill, productID)) {
                    if (ProjectRegex.checkSoNguyenDuong(txtQuantity.Text)) {
                        int newQuantity = int.Parse(txtQuantity.Text);
                        if (newQuantity - detailQuantity <= productQuantity) {
                            detalBillBus.DeleteDetailBill(this.idBill, productID);
                            detalBillBus.AddDetailBill(this.idBill, productID, newQuantity);
                            detalBillBus.updateBillPrice(this.idBill);

                            load_dtgv();
                        } else {
                            MessageBox.Show("Sản phẩm không đủ số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } else {
                        MessageBox.Show("Số lượng phải là số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Sản phẩm không tồn tại trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn trong dgvDetalBill hay không
            if (dgvDetalBill.SelectedRows.Count > 0 && dgvDetalBill.SelectedRows[0].Cells[0].Value != null) {
                DataGridViewRow selectedRow = dgvDetalBill.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                detalBillBus.DeleteDetailBill(this.idBill, productID);
                detalBillBus.updateBillPrice(this.idBill);
                load_dtgv();
                //MessageBox.Show("Xóa thành công.");
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDetalBill.Rows.Count > 1)
            {
                // Cập nhật giá và thanh toán hóa đơn
                detalBillBus.updateBillPrice(this.idBill);
                detalBillBus.payTheBill(this.idBill);
                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Thông báo giỏ hàng đang rỗng
                MessageBox.Show("Giỏ hàng đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e) {
            string searchText = txt_TimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText)) {
                // Hiển thị toàn bộ danh sách nếu text search rỗng
                dgvProduct.DataSource = productBUS.getAllProducts();
            } else {
                if (cbx_TimKiem.Text == "Mã sản phẩm") {
                    dgvProduct.DataSource = productBUS.getProductByID(searchText);
                } else if (cbx_TimKiem.Text == "Tên sản phẩm") {
                    dgvProduct.DataSource = productBUS.getProductsByProductName(searchText);
                } else if (cbx_TimKiem.Text == "Tên loại sản phẩm") {
                    dgvProduct.DataSource = productBUS.getProductsByTypeID(searchText);
                }
            }
        }
        private void txt_TimKiem_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (cbx_TimKiem.Text == "Mã sản phẩm") {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgvProduct.DataSource = productBUS.getProductByID(txt_TimKiem.Text);
                    return;
                } else if (cbx_TimKiem.Text == "Tên sản phẩm") {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgvProduct.DataSource = productBUS.getProductsByProductName(txt_TimKiem.Text);
                    return;
                } else if (cbx_TimKiem.Text == "Tên loại sản phẩm") {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgvProduct.DataSource = productBUS.getProductsByTypeID(txt_TimKiem.Text);
                    return;
                }
            }
        }
    }
}
