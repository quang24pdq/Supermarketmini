using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI
{
    public partial class ProductTypeManage : Form
    {
        // khai bao controller
        private ProductTypeBUS ptBus = new ProductTypeBUS();
        private string[] names;
        private string[] ids;
        AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
        public ProductTypeManage()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            txt_idType.Font = ProjectFont.getNormalFont();
            txt_nameType.Font = ProjectFont.getNormalFont();
            txt_search.Font = ProjectFont.getNormalFont();
            lb_idType.Font = ProjectFont.getNormalFont();
            lb_typeName.Font = ProjectFont.getNormalFont();
            cb_search.Font = ProjectFont.getNormalFont();
            //
            cb_search.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_search.Items.Add("Mã loại");
            cb_search.Items.Add("Tên loại");
            cb_search.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dgv_qllsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dgv_qllsp.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dgv_qllsp.ReadOnly = true;
            // Cho text search sẽ hiển thị suggestion box
            txt_search.AutoCompleteCustomSource = allowedTypes;
            txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void dgv_qllsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = dgv_qllsp.Rows[e.RowIndex];
                txt_idType.Text = row.Cells["TypeID"].Value.ToString();
                txt_nameType.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Viết hoa id và chữ cái đầu của name
            string id = txt_idType.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(txt_nameType.Text);

            if (id.Length != 0) // Nếu người dùng nhập mã loại
            {
                // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                if (ptBus.checkIdExist(id))
                {
                    MessageBox.Show(
                        "Mã loại đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                    txt_idType.Focus();
                    return;
                }
            }
            //Nếu tên loại rỗng thì hiện thông báo warning
            if (name.Length == 0)
            {
                MessageBox.Show(
                    "Không được bỏ trống tên loại sản phẩm",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // cho cảnh báo
                txt_nameType.Focus();
                return;
            }
            // Nếu tên loại đã tồn tại trong hệ thống thì hiện lỗi
            if (ptBus.checkNameExist(name))
            {
                MessageBox.Show(
                    "Tên loại đã tồn tại trong hệ thống",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // cho cảnh báo
                txt_nameType.Focus();
                return;
            }
            // Nếu mà mã loại rỗng thì sẽ tự tạo mã id
            if (id.Length == 0)
            {
                if (ptBus.addProductType(name))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công
                    clearText();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    return;
                }
            }
            else // Nếu mà nhập đầy đủ thông tin thì thêm đầy đủ
            {
                if (ptBus.addProductType(name, id))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công
                    clearText();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    txt_idType.Focus();
                    return;
                }
            }

            // Tải lại danh sách
            dgv_qllsp.DataSource = ptBus.getAllProducts();
        }

        public void LoadTheme()
        {
            // Thêm màu và chỉnh font cho các tiêu đề group box
            grb_search.ForeColor = ThemeColor.SecondaryColor;
            grb_search.Font = ProjectFont.getTitleFont();
            grb_textField.ForeColor = ThemeColor.SecondaryColor;
            grb_textField.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các nút
            foreach (Control btns in this.grb_textField.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = ProjectFont.getNormalFont();
                }
            }
            // Thêm màu và chỉnh font cho các label
            lb_idType.Font = ProjectFont.getNormalFont();

            lb_typeName.Font = ProjectFont.getNormalFont();

            cb_search.Font = ProjectFont.getNormalFont();
        }

        private void ProductTypeManage_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu lên data grid view
            dgv_qllsp.DataSource = ptBus.getAllProducts();
            // Đổi tên cột
            dgv_qllsp.Columns["TypeID"].HeaderText = "Mã loại";
            dgv_qllsp.Columns["Name"].HeaderText = "Tên loại";

            LoadTheme();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgv_qllsp.SelectedRows.Count <= 0)
            {
                MessageBox.Show(
                        "Vui lòng chọn loại sản phẩm cần xóa",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                return;
            }
            // Lấy id của hàng đang chọn
            string id = dgv_qllsp.CurrentRow.Cells[0].Value.ToString();
            if (ptBus.deleteProductType(id))
            {
                MessageBox.Show("Xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Xóa thành công
                clearText();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Xóa thất bại
                return;
            }

            // Tải lại danh sách
            dgv_qllsp.DataSource = ptBus.getAllProducts();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (dgv_qllsp.SelectedRows.Count <= 0)
            {
                MessageBox.Show(
                        "Vui lòng chọn loại sản phẩm cần cập nhật",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                return;
            }
            string name = ProjectFont.upperFirstLetter(txt_nameType.Text);
            // Lấy id của hàng đang chọn
            string id = dgv_qllsp.CurrentRow.Cells[0].Value.ToString();
            // Không được bỏ trống tên loại sản phẩm
            if (name.Length == 0)
            {
                MessageBox.Show(
                    "Không được bỏ trống tên loại sản phẩm",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // cho cảnh báo
                txt_nameType.Focus();
                return;
            }
            // Nếu tên đã tồn tại trong hệ thống
            if (ptBus.checkNameExist(name))
            {
                MessageBox.Show(
                    "Tên loại sản phẩm đã tồn tại",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); // cho cảnh báo
                txt_nameType.Focus();
                return;
            }
            if (ptBus.updateProductType(id, name))
            {
                MessageBox.Show("Cập nhật thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Cập nhật thành công
                clearText();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cập nhật thất bại
                txt_nameType.Focus();
                return;
            }

            // Load lại danh sách
            dgv_qllsp.DataSource = ptBus.getAllProducts();
        }

        // Clear các text box
        private void clearText()
        {
            foreach (Control txt in this.grb_textField.Controls)
            {
                if (txt.GetType() == typeof(TextBox))
                {
                    TextBox temp = (TextBox)txt;
                    temp.Clear();
                }
            }
            selectedIndexChangedHandler();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.AutoCompleteCustomSource.Contains(txt_search.Text))
            {
                if (cb_search.Text == "Mã loại")
                {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgv_qllsp.DataSource = ptBus.getProductsById(txt_search.Text);
                    return;
                }
                else if (cb_search.Text == "Tên loại")
                {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgv_qllsp.DataSource = ptBus.getProductsByName(txt_search.Text);
                    return;
                }
            }
            // Hiển thị hết danh sách nếu text search rỗng
            if (txt_search.Text == "")
            {
                dgv_qllsp.DataSource = ptBus.getAllProducts();
                return;
            }
        }

        // Tải danh sách suggestion box theo mảng str
        private void loadSuggestionBox(string[] str)
        {
            allowedTypes.Clear();
            allowedTypes.AddRange(str);
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexChangedHandler();
        }

        private void selectedIndexChangedHandler()
        {
            if (cb_search.Text == "Mã loại")
            {
                // Lấy tất cả các id cho loại sản phẩm và hiển thị suggestion box
                ids = ptBus.getIdForSuggestionBox();
                loadSuggestionBox(ids);
            }
            else if (cb_search.Text == "Tên loại")
            {
                // Lấy tất cả các tên cho loại sản phẩm và hiển thị suggestion box
                names = ptBus.getNameForSuggestionBox();
                loadSuggestionBox(names);
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cb_search.Text == "Mã loại")
                {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgv_qllsp.DataSource = ptBus.getProductsById(txt_search.Text);
                    return;
                }
                else if (cb_search.Text == "Tên loại")
                {
                    // Người dùng đã chọn một mục từ danh sách gợi ý
                    dgv_qllsp.DataSource = ptBus.getProductsByName(txt_search.Text);
                    return;
                }

            }
        }
    }
}