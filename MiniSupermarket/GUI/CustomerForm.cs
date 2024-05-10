using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniSupermarket.GUI {
    public partial class CustomerForm : Form {
        CustomerBus customerBus = new CustomerBus(); 
        public CustomerForm() {

            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            lblTitle.Font = ProjectFont.getTitleFont();
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            BindingPromotions();
            LoadTheme();
        }

        public void BindingPromotions() {
            BindingSource binding = new BindingSource();
            List<Customer> filteredCustomers = customerBus.getAllCustomers().Where(c => c.IsDeleted == "1").ToList();
            binding.DataSource = filteredCustomers;
            dgvCustomer.DataSource = binding;

            dgvCustomer.Columns["IsDeleted"].Visible = false;

            // Đổi tên các cột
            dgvCustomer.Columns["CustomerID"].HeaderText = "ID Khách Hàng";
            dgvCustomer.Columns["Name"].HeaderText = "Họ Và Tên";
            dgvCustomer.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dgvCustomer.Columns["Sex"].HeaderText = "Giới Tính";
            dgvCustomer.Columns["Point"].HeaderText = "Điểm";
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            txtCustomerID.Text = null;
            txtCustomerName.Text = null;
            txtPhoneNumber.Text = null;
            txtPoint.Text = null;
            txtFind.Text = null;
            cboFind.SelectedItem = null;

            rdoNam.Checked = false;
            rdoNu.Checked = false;
            grb_rdoNam.Checked = false;
            grb_rdoNu.Checked = false;



            errorProvider1.Clear();
        }

        private bool check_empty() {
            errorProvider1.Clear();
            bool result = true;
            if (txtCustomerName.Text == "") {
                result = false;
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống");
            }
            if (txtPhoneNumber.Text == "") {
                result = false;
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                errorProvider1.SetError(txtPhoneNumber, "Số điện thoại không được để trống");
            } else if (!IsValidVietnamesePhoneNumber(txtPhoneNumber.Text)) {
                result = false;
                MessageBox.Show("Số điện thoại không hợp lệ");
                errorProvider1.SetError(txtPhoneNumber, "SDT có dạng 037-6714-453");
            }
            if (rdoNam.Checked == false && rdoNu.Checked == false) {
                result = false;
                MessageBox.Show("Giới tính không được để trống");
                //errorProvider1.SetError(txtGioiTinh, "Giới tính là nam hoặc nữ");
            }
            return result;
        }

        static bool IsValidVietnamesePhoneNumber(string phoneNumber) {
            // Mẫu regex cho số điện thoại ở Việt Nam
            string pattern = @"^(0[0-9]{9}|84[0-9]{9})$";

            // Kiểm tra sự khớp của số điện thoại với mẫu regex
            Match match = Regex.Match(phoneNumber, pattern);

            // Trả về kết quả kiểm tra
            return match.Success;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (txtCustomerID.Text == "") {
                MessageBox.Show("Bạn chưa chọn mã khách khách hàng cần cập nhật");
            } else {
                if (check_empty()) {

                    string id = txtCustomerID.Text.Trim().ToUpper();
                    string name = ProjectFont.upperFirstLetter(txtCustomerName.Text);
                    string phoneNumber = ProjectFont.upperFirstLetter(txtPhoneNumber.Text);
                    string sex = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "";
                    string point = ProjectFont.upperFirstLetter(txtPoint.Text);

                    if (customerBus.updateCustomer(id, name, phoneNumber, sex, point, "1")) {
                        BindingPromotions();
                        MessageBox.Show("Sửa thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); // Thêm thành công

                    } else {
                        MessageBox.Show("Sửa thất bại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error); // Thêm thất bại
                        return;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (txtCustomerID.Text == "") {
                MessageBox.Show("Bạn chưa chọn mã khách khách hàng cần xóa");
            } else {
                string id = txtCustomerID.Text.Trim().ToUpper();
                if (customerBus.deleteCustomer(id)) {
                    BindingPromotions();
                    MessageBox.Show("Xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công

                } else {
                    MessageBox.Show("Xóa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (check_empty()) {
                string id = txtCustomerID.Text.Trim().ToUpper();
                string name = ProjectFont.upperFirstLetter(txtCustomerName.Text);
                string phoneNumber = ProjectFont.upperFirstLetter(txtPhoneNumber.Text);
                string sex = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "";
                string point = ProjectFont.upperFirstLetter(txtPoint.Text);


                if (customerBus.addCustomer(name, phoneNumber, sex, point, "1")) {
                    if (customerBus.checkIdExist(id)) {
                        MessageBox.Show(
                            "Mã Khách Hàng đã tồn tại->Hệ thống sẽ tự động tạo mã khách hàng mới");
                    }
                    BindingPromotions();
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công

                } else {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                }
            }
        }

        private void Find_Changed(object sender, EventArgs e) {
            string selectedValue = cboFind.SelectedItem != null ? cboFind.SelectedItem.ToString() : string.Empty;

            string input = txtFind.Text;
            string sex = "";
            if (grb_rdoNam.Checked) {
                sex = "Nam";
            } else if (grb_rdoNu.Checked) {
                sex = "Nữ";
            }
            dgvCustomer.DataSource = customerBus.FindCustomer(selectedValue, input, sex);
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                DataGridViewRow selectedRow = dgvCustomer.Rows[e.RowIndex];
                // Lấy giá trị từ các ô của hàng được chọn
                txtCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                //txtGioiTinh.Text = selectedRow.Cells["Sex"].Value.ToString();
                txtPoint.Text = selectedRow.Cells["Point"].Value.ToString();
            } catch (Exception ex) {

            }
        }

        private void cboFind_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
