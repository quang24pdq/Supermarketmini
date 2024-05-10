using ClosedXML.Excel;
using MiniSupermarket.BUS;
using MiniSupermarket.DAO;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI {

    public partial class ProductManage : Form {
        private string[] names;
        private string[] ids;
        private string[] typeids;

        // khai bao controller
        private ProductBUS ptBus = new ProductBUS();
        AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();

        public ProductManage() {
            InitializeComponent();

            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            txt_TimKiem.Font = ProjectFont.getNormalFont();
            txt_MaSp.Font = ProjectFont.getNormalFont();
            cbx_MaLoai.Font = ProjectFont.getNormalFont();
            cbx_MaKm.Font = ProjectFont.getNormalFont();
            txt_TenSp.Font = ProjectFont.getNormalFont();
            txt_SoLuong.Font = ProjectFont.getNormalFont();
            txt_DonGia.Font = ProjectFont.getNormalFont();
            txt_MoTa.Font = ProjectFont.getNormalFont();
            txt_Kieu.Font = ProjectFont.getNormalFont();
            txt_SoLuong.ReadOnly = true;

            cbx_TimKiem.Font = ProjectFont.getNormalFont();
            lb_MaSp.Font = ProjectFont.getNormalFont();
            lb_MaLoaiSp.Font = ProjectFont.getNormalFont();
            lb_TenSp.Font = ProjectFont.getNormalFont();
            lb_Soluong.Font = ProjectFont.getNormalFont();
            lb_DonGia.Font = ProjectFont.getNormalFont();
            lb_MoTa.Font = ProjectFont.getNormalFont();
            lb_Kieu.Font = ProjectFont.getNormalFont();
            lb_MaKm.Font = ProjectFont.getNormalFont();



            //
            cbx_TimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_TimKiem.Items.Add("Mã sản phẩm");
            cbx_TimKiem.Items.Add("Tên sản phẩm");
            cbx_TimKiem.Items.Add("Tên loại sản phẩm");
            cbx_TimKiem.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dssp_DSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dssp_DSSP.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dssp_DSSP.ReadOnly = true;
            // Cho text search sẽ hiển thị suggestion box
            txt_TimKiem.AutoCompleteCustomSource = allowedTypes;
            txt_TimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_TimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void LoadTheme() {
            // Thêm màu và chỉnh font cho các tiêu đề group box
            grb_TimKiem.ForeColor = ThemeColor.SecondaryColor;
            grb_TimKiem.Font = ProjectFont.getTitleFont();
            grb_TextField.ForeColor = ThemeColor.SecondaryColor;
            grb_TextField.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các nút
            foreach (Control btns in this.grb_TextField.Controls) {
                if (btns.GetType() == typeof(Button)) {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = ProjectFont.getNormalFont();
                }
            }
            // Thêm màu và chỉnh font cho các label
            lb_MaSp.Font = ProjectFont.getNormalFont();
            lb_MaLoaiSp.Font = ProjectFont.getNormalFont();
            cbx_MaLoai.Font = ProjectFont.getNormalFont();
            cbx_MaKm.Font = ProjectFont.getNormalFont();
            lb_DonGia.Font = ProjectFont.getNormalFont();
            lb_Kieu.Font = ProjectFont.getNormalFont();
            lb_MoTa.Font = ProjectFont.getNormalFont();
            lb_Soluong.Font = ProjectFont.getNormalFont();
            lb_TenSp.Font = ProjectFont.getNormalFont();
            lb_MaKm.Font = ProjectFont.getNormalFont();

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void dssp_DSSP_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        public void taiDSSP()
        {
            // Tải dữ liệu lên data grid view
            dssp_DSSP.DataSource = ptBus.getAllProducts();
        }

        private void ProductManage_Load(object sender, EventArgs e) {
            // Tải dữ liệu lên data grid view
            dssp_DSSP.DataSource = ptBus.getAllProducts();
            // Đổi tên cột
            dssp_DSSP.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dssp_DSSP.Columns["Name"].HeaderText = "Tên sản phẩm";
            //dssp_DSSP.Columns["TypeID"].HeaderText = "Tên loại";
            dssp_DSSP.Columns["Quantity"].HeaderText = "Số lượng";
            dssp_DSSP.Columns["CurrentPrice"].HeaderText = "Đơn giá";
            dssp_DSSP.Columns["Description"].HeaderText = "Mô tả";
            dssp_DSSP.Columns["Unit"].HeaderText = "Kiểu";
            //dssp_DSSP.Columns["PromotionID"].HeaderText = "Mã khuyến mãi";
            cbx_MaLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_MaKm.DropDownStyle = ComboBoxStyle.DropDownList;


            LoadTheme();
        }
        public void Combobox() {
            // Xóa hết dữ liệu cũ trong ComboBox
            cbx_MaLoai.Items.Clear();
            // Load danh sách loại sản phẩm vào ComboBox
            ProductTypeBUS typeBus = new ProductTypeBUS(); // Tạo đối tượng BUS cho loại sản phẩm
            string[] danhSachLoaiSPNames = typeBus.getProductTypesWithIdAndName(); // Lấy danh sách tên loại sản phẩm
            foreach (var loaiSP in danhSachLoaiSPNames) {

                cbx_MaLoai.Items.Add(loaiSP); // Thêm từng loại sản phẩm vào ComboBox
            }

            // Xóa hết dữ liệu cũ trong ComboBox
            cbx_MaKm.Items.Clear();
            // Load danh sách mã km vào ComboBox
            PromotionBUS promotionBUS = new PromotionBUS();
            string[] danhSachKMNames = promotionBUS.getActivePromotionsWithIdAndName(); // Lấy danh sách tên mã km
            foreach (var loaiKM in danhSachKMNames)
            {
                cbx_MaKm.Items.Add(loaiKM); // Thêm từng loại mã km vào ComboBox
            }

        }
        private void dssp_DSSP_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = dssp_DSSP.Rows[e.RowIndex];
                // Lấy TypeID và name từ DataGridView
                string typeName = row.Cells["ProductTypeName"].Value.ToString();
                ProductTypeBUS typeBus = new ProductTypeBUS();

                // Gọi phương thức trong ProductTypeBUS để lấy TypeID từ TypeID TypeName
                string typeID = typeBus.GetIDFromName(typeName); // Hàm này sẽ trả về ID dựa trên ProductTypeName

                // Hiển thị TypeID và name trong ComboBox
                string displayText = $"[{typeID}] {typeName}";
                cbx_MaLoai.Text = displayText;


                txt_MaSp.Text = row.Cells["ProductID"].Value.ToString();
                txt_TenSp.Text = row.Cells["Name"].Value.ToString();

                txt_SoLuong.Text = row.Cells["Quantity"].Value.ToString();
                txt_DonGia.Text = row.Cells["CurrentPrice"].Value.ToString();
                txt_MoTa.Text = row.Cells["Description"].Value.ToString();
                txt_Kieu.Text = row.Cells["Unit"].Value.ToString();


                if (row.Cells["PromotionName"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["PromotionName"].Value.ToString())) {
                    // Kiểm tra xem PromotionID có giá trị rỗng không
                    string ProMoName = row.Cells["PromotionName"].Value.ToString();
                    PromotionBUS promotionBUS = new PromotionBUS();
                    string promoID = promotionBUS.GetIDFromName(ProMoName);
                    string display = $"[{promoID}] {ProMoName}";
                    cbx_MaKm.Text = display;
                } else {
                    // PromotionID rỗng, có thể đặt giá trị mặc định cho cbx_MaKm
                    cbx_MaKm.SelectedIndex = -1;
                    
                }

            }
        }
        private void btn_NhapExcel_Click(object sender, EventArgs e) {
            try {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx;*.xls" }) {
                    if (ofd.ShowDialog() == DialogResult.OK) {
                        string filePath = ofd.FileName;

                        using (var workbook = new XLWorkbook(filePath)) {
                            var worksheet = workbook.Worksheet(1); // Chọn Worksheet (Sheet) cần đọc, ở đây là Worksheet đầu tiên

                            var rows = worksheet.RowsUsed();

                            dssp_DSSP.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView trước khi nhập dữ liệu mới

                            foreach (var row in rows) {
                                List<string> cellValues = new List<string>();

                                foreach (var cell in row.Cells()) {

                                    if (cell.DataType == XLDataType.DateTime) {
                                        cellValues.Add(cell.GetDateTime().ToString()); // Xử lý kiểu dữ liệu ngày tháng
                                    } else {
                                        cellValues.Add(cell.Value.ToString());
                                    }
                                }

                                dssp_DSSP.Rows.Add(cellValues.ToArray());
                            }

                            MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_XuatExcel_Click(object sender, EventArgs e) {
            // Tạo một Workbook mới
            var workbook = new XLWorkbook();

            // Tạo một Worksheet mới
            var worksheet = workbook.Worksheets.Add("DanhSachSanPham");

            // Lấy dữ liệu từ DataGridView và đưa vào Worksheet
            for (int i = 1; i <= dssp_DSSP.Columns.Count; i++) {
                worksheet.Cell(1, i).Value = dssp_DSSP.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dssp_DSSP.Rows.Count; i++) {
                for (int j = 0; j < dssp_DSSP.Columns.Count; j++) {
                    worksheet.Cell(i + 2, j + 1).Value = dssp_DSSP.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Lưu Workbook vào một file Excel
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" }) {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void btn_Them_Click(object sender, EventArgs e) {
            // Kiểm tra các trường không được nhập và hiển thị thông báo lỗi
            if (string.IsNullOrWhiteSpace(txt_TenSp.Text) || string.IsNullOrWhiteSpace(cbx_MaLoai.Text) || string.IsNullOrWhiteSpace(txt_DonGia.Text) || string.IsNullOrWhiteSpace(txt_MoTa.Text) || string.IsNullOrWhiteSpace(txt_Kieu.Text)) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Thông báo lỗi khi không nhập đủ thông tin
                return;
            }
            // Viết hoa id và chữ cái đầu 
            string id = txt_MaSp.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(txt_TenSp.Text);
            // Lấy chỉ ID từ chuỗi có dạng "[id]name" trong ComboBox cbx_MaLoai
            string selectedValue = cbx_MaLoai.Text;

            // Tìm vị trí của ký tự '[' và ']'
            int indexOfOpenBracket = selectedValue.IndexOf('[');
            int indexOfCloseBracket = selectedValue.IndexOf(']');


            string maloai = selectedValue.Substring(indexOfOpenBracket + 1, indexOfCloseBracket - indexOfOpenBracket - 1).Trim();


            string soluong = "0";
            string dongia = txt_DonGia.Text.Trim();
            string mota = ProjectFont.upperFirstLetter(txt_MoTa.Text);
            string kieu = ProjectFont.upperFirstLetter(txt_Kieu.Text);
            string makm = "";
            
            if (cbx_MaKm.SelectedIndex != -1)
            {
                string selectedValue2 = cbx_MaKm.Text;
                // Tìm vị trí của ký tự '[' và ']'
                int indexOfOpenBracket2 = selectedValue2.IndexOf('[');
                int indexOfCloseBracket2 = selectedValue2.IndexOf(']');


                makm = selectedValue2.Substring(indexOfOpenBracket2 + 1, indexOfCloseBracket2 - indexOfOpenBracket2 - 1).Trim();
            }

            if (id.Length != 0) // Nếu người dùng nhập mã sản phẩm
            {
                // Nếu mã sản phẩm đã tồn tại trong hệ thống thì hiện lỗi
                if (ptBus.checkIdExist(id)) {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                    txt_MaSp.Focus();
                    return;
                }
            }
            // Nếu mà mã sản phẩm rỗng thì sẽ tự tạo mã id
            if (id.Length == 0) {
                if (ptBus.addProduct(name, maloai, soluong, dongia, mota, kieu, makm)) {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công
                    // Xóa nội dung của các ô nhập liệu sau khi thêm thành công
                    txt_MaSp.Clear();
                    txt_TenSp.Clear();
                    cbx_MaLoai.SelectedIndex = -1; // Đặt lại ComboBox để không có mục nào được chọn
                    txt_DonGia.Clear();
                    txt_MoTa.Clear();
                    txt_Kieu.Clear();
                    cbx_MaKm.SelectedIndex = -1;
                } else {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    return;
                }
            } else // Nếu mà nhập đầy đủ thông tin thì thêm đầy đủ
              {
                if (ptBus.addProduct(name, maloai, soluong, dongia, mota, kieu, makm, id)) {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công

                    // Xóa nội dung của các ô nhập liệu sau khi thêm thành công
                    txt_MaSp.Clear();
                    txt_TenSp.Clear();
                    cbx_MaLoai.SelectedIndex = -1; // Đặt lại ComboBox để không có mục nào được chọn
                    txt_DonGia.Clear();
                    txt_MoTa.Clear();
                    txt_Kieu.Clear();
                    cbx_MaKm.SelectedIndex = -1;
                } else {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    txt_MaSp.Focus();
                    return;
                }
            }
            dssp_DSSP.DataSource = ptBus.getAllProducts();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e) {
            // Chỉ cho phép nhập các ký tự số và ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e) {
            // Chỉ cho phép nhập các ký tự số và ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e) {
            if (dssp_DSSP.SelectedCells.Count == 0) {
                MessageBox.Show(
                        "Vui lòng chọn sản phẩm cần xóa",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                return;
            }
            // Lấy id của hàng đang chọn
            string id = dssp_DSSP.CurrentRow.Cells[0].Value.ToString();
            if (ptBus.deleteProduct(id)) {
                MessageBox.Show("Xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Xóa thành công

                // Xóa nội dung của các ô nhập liệu sau khi thêm thành công
                txt_MaSp.Clear();
                txt_TenSp.Clear();
                cbx_MaLoai.SelectedIndex = -1; // Đặt lại ComboBox để không có mục nào được chọn
                txt_DonGia.Clear();
                txt_MoTa.Clear();
                txt_Kieu.Clear();
                cbx_MaKm.SelectedIndex = -1;
                txt_SoLuong.Clear();
            } else {
                MessageBox.Show("Xóa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Xóa thất bại
                return;
            }

            // Tải lại danh sách
            dssp_DSSP.DataSource = ptBus.getAllProducts();
        }


        private void btn_Sua_Click(object sender, EventArgs e) {

            if (dssp_DSSP.SelectedCells.Count == 0) {
                MessageBox.Show(
                        "Vui lòng chọn sản phẩm cần cập nhật",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                return;
            }

            // Kiểm tra các trường không được nhập và hiển thị thông báo lỗi
            if (string.IsNullOrWhiteSpace(txt_TenSp.Text) || string.IsNullOrWhiteSpace(cbx_MaLoai.Text) || string.IsNullOrWhiteSpace(txt_DonGia.Text) || string.IsNullOrWhiteSpace(txt_MoTa.Text) || string.IsNullOrWhiteSpace(txt_Kieu.Text)) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // Thông báo lỗi khi không nhập đủ thông tin
                return;
            }

            // Viết hoa id và chữ cái đầu 
            string id = txt_MaSp.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(txt_TenSp.Text);
            // Lấy chỉ ID từ chuỗi có dạng "[id]name" trong ComboBox cbx_MaLoai
            string selectedValue = cbx_MaLoai.Text;

            // Tìm vị trí của ký tự '[' và ']'
            int indexOfOpenBracket = selectedValue.IndexOf('[');
            int indexOfCloseBracket = selectedValue.IndexOf(']');


            string maloai = selectedValue.Substring(indexOfOpenBracket + 1, indexOfCloseBracket - indexOfOpenBracket - 1).Trim();

            string makm = "";

            if (cbx_MaKm.SelectedIndex != -1)
            {
                string selectedValue2 = cbx_MaKm.Text;
                // Tìm vị trí của ký tự '[' và ']'
                int indexOfOpenBracket2 = selectedValue2.IndexOf('[');
                int indexOfCloseBracket2 = selectedValue2.IndexOf(']');


                makm = selectedValue2.Substring(indexOfOpenBracket2 + 1, indexOfCloseBracket2 - indexOfOpenBracket2 - 1).Trim();
            }
            string soluong = ProjectFont.upperFirstLetter(txt_SoLuong.Text);
            string dongia = ProjectFont.upperFirstLetter(txt_DonGia.Text);
            string mota = ProjectFont.upperFirstLetter(txt_MoTa.Text);
            string kieu = ProjectFont.upperFirstLetter(txt_Kieu.Text);

            if (ptBus.updateProduct(name, id, maloai, soluong, dongia, mota, kieu, makm)) {
                MessageBox.Show("Cập nhật thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Cập nhật thành công
                                                     // Xóa nội dung của các ô nhập liệu sau khi cập nhật thành công
                txt_MaSp.Clear();
                txt_TenSp.Clear();
                cbx_MaLoai.SelectedIndex = -1; // Đặt lại ComboBox để không có mục nào được chọn
                txt_DonGia.Clear();
                txt_MoTa.Clear();
                txt_Kieu.Clear();
                cbx_MaKm.SelectedIndex = -1;
                txt_SoLuong.Clear();
            } else {
                MessageBox.Show("Cập nhật thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cập nhật thất bại

                return;
            }
            // Load lại danh sách
            dssp_DSSP.DataSource = ptBus.getAllProducts();

        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e) {
            string searchText = txt_TimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText)) {
                // Hiển thị toàn bộ danh sách nếu text search rỗng
                dssp_DSSP.DataSource = ptBus.getAllProducts();
            } else {
                if (cbx_TimKiem.Text == "Mã sản phẩm") {
                    dssp_DSSP.DataSource = ptBus.getProductByID(searchText);
                } else if (cbx_TimKiem.Text == "Tên sản phẩm") {
                    dssp_DSSP.DataSource = ptBus.getProductsByProductName(searchText);
                } else if (cbx_TimKiem.Text == "Tên loại sản phẩm") {
                    dssp_DSSP.DataSource = ptBus.getProductsByTypeID(searchText);
                }
            }
        }
        private void txt_TimKiem_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (cbx_TimKiem.Text == "Mã sản phẩm") {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dssp_DSSP.DataSource = ptBus.getProductByID(txt_TimKiem.Text);
                    return;
                } else if (cbx_TimKiem.Text == "Tên sản phẩm") {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dssp_DSSP.DataSource = ptBus.getProductsByProductName(txt_TimKiem.Text);
                    return;
                } else if (cbx_TimKiem.Text == "Tên loại sản phẩm") {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dssp_DSSP.DataSource = ptBus.getProductsByTypeID(txt_TimKiem.Text);
                    return;
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Tải dữ liệu lên data grid view
            dssp_DSSP.DataSource = ptBus.getAllProducts();
            txt_MaSp.Clear();
            txt_TenSp.Clear();
            cbx_MaLoai.SelectedIndex = -1; // Đặt lại ComboBox để không có mục nào được chọn
            txt_DonGia.Clear();
            txt_MoTa.Clear();
            txt_Kieu.Clear();
            txt_SoLuong.Clear();
            cbx_MaKm.SelectedIndex = -1;
        }
    }
}
