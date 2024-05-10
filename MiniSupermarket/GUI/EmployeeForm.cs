using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System.Data;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ClosedXML.Excel;

namespace MiniSupermarket.BUS
{
    public partial class EmployeeForm : Form
    {
        private EmployeeBUS employeeBUS = new EmployeeBUS();
        public EmployeeForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);

            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Items.Add("Chọn giới tính");
            cb_sex.Items.Add("Nam");
            cb_sex.Items.Add("Nữ");
            cb_sex.SelectedIndex = 0;

            cb_find.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_find.Items.Add("Tìm kiếm");
            cb_find.Items.Add("Mã nhân viên");
            cb_find.Items.Add("Tên nhân viên");
            cb_find.SelectedIndex = 0;

            ds_qlnv.BackgroundColor = Color.White;
            ds_qlnv.ReadOnly = true;
            ds_qlnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ds_qlnv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ds_qlnv.SelectionChanged += DataGridView_SelectionChanged;

            tb_id.ReadOnly = true;
        }

        public void LoadTheme()
        {
            // Thêm màu và chỉnh font cho các group box
            gb_Function.ForeColor = ThemeColor.SecondaryColor;
            gb_Function.Font = ProjectFont.getTitleFont();
            gb_Info.ForeColor = ThemeColor.SecondaryColor;
            gb_Info.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các button
            foreach (Control btns in this.gb_Function.Controls)
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

            foreach (Control control in this.gb_Info.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.Font = ProjectFont.getNormalFont();
                }
                else if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Font = ProjectFont.getNormalFont();
                }
                else if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)control;
                    cb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Viết hoa id và chữ cái đầu 
            string id = tb_id.Text.Trim().ToUpper();
            string name = ProjectFont.CapitalizeEachWord(tb_name.Text);
            string address = ProjectFont.upperFirstLetter(tb_address.Text);
            string pnumber = tb_pNumber.Text;
            string email = tb_email.Text.Trim();
            string password = tb_pass.Text;
            string sex = cb_sex.Text;
            string username = txtUserName.Text.Trim();
            string roleid = cb_role.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(tb_name.Text) ||
              string.IsNullOrWhiteSpace(tb_address.Text) ||
              string.IsNullOrWhiteSpace(tb_pNumber.Text) ||
              string.IsNullOrWhiteSpace(tb_email.Text) ||
              string.IsNullOrWhiteSpace(tb_pass.Text) ||
              string.IsNullOrWhiteSpace(txtUserName.Text) ||
              cb_sex.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập theo định dạng username@gmail.com.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsNameValid(name))
            {
                MessageBox.Show("Tên chỉ được chứa chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(pnumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập theo định dạng Việt Nam.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedGender = cb_sex.SelectedItem.ToString().ToUpper();
            if (selectedGender != "NAM" && selectedGender != "NỮ")
            {
                MessageBox.Show("Vui lòng chọn giới tính 'Nam' hoặc 'Nữ'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id.Length != 0) // Nếu người dùng nhập mã loại
            {
                // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                if (employeeBUS.checkIdExist(id))
                {
                    MessageBox.Show(
                        "Mã nhân viên đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                    tb_id.Focus();
                    return;
                }
            }
            // Nếu mà mã loại rỗng thì sẽ tự tạo mã id
            if (id.Length == 0)
            {
                if (employeeBUS.addEmployee(id, username, name, address, pnumber, email, dtp_birth.Value, password, sex, roleid))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công
                    ds_qlnv.DataSource = employeeBUS.getAllEmployee();

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
                if (employeeBUS.addEmployee(id, username, name, address, pnumber, email, dtp_birth.Value, password, sex, roleid))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công
                    ds_qlnv.DataSource = employeeBUS.getAllEmployee();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    tb_id.Focus();
                    return;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ds_qlnv.DataSource = employeeBUS.getAllEmployee();
            EmployeeBUS.Reset(gb_Info.Controls, ds_qlnv, gb_Function.Controls);
            Roles();
        }

        void setNull()
        {
            tb_name.Text = "";
            tb_pass.Text = "";
            tb_email.Text = "";
            tb_address.Text = "";
            tb_pNumber.Text = "";
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            setNull();

            ds_qlnv.DataSource = employeeBUS.getAllEmployee();

            if (ds_qlnv.RowCount > 0)
            {
                ds_qlnv.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
                ds_qlnv.Columns["Name"].HeaderText = "Tên nhân viên";
                ds_qlnv.Columns["BirthDate"].HeaderText = "Ngày sinh";
                if (ds_qlnv.Columns["BirthDate"] != null)
                {
                    ds_qlnv.Columns["BirthDate"].HeaderText = "Ngày sinh";
                }
                ds_qlnv.Columns["Address"].HeaderText = "Địa chỉ";
                ds_qlnv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                ds_qlnv.Columns["Email"].HeaderText = "Email";
                ds_qlnv.Columns["Sex"].HeaderText = "Giới tính";
                ds_qlnv.Columns["Password"].HeaderText = "Mật khẩu";
                ds_qlnv.Columns["RoleName"].HeaderText = "Quyền";
            }

            ds_qlnv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            LoadTheme();
            Roles();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ds_qlnv.SelectedRows.Count > 0)
            {
                // Assuming you have textboxes named txtEmployeeID, txtName, etc.
                tb_id.Text = ds_qlnv.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
                tb_name.Text = ds_qlnv.SelectedRows[0].Cells["Name"].Value.ToString();
                tb_address.Text = ds_qlnv.SelectedRows[0].Cells["Address"].Value.ToString();
                tb_pNumber.Text = ds_qlnv.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                tb_email.Text = ds_qlnv.SelectedRows[0].Cells["Email"].Value.ToString();
                cb_sex.Text = ds_qlnv.SelectedRows[0].Cells["Sex"].Value.ToString();
                tb_pass.Text = ds_qlnv.SelectedRows[0].Cells["Password"].Value.ToString();
                txtUserName.Text = ds_qlnv.SelectedRows[0].Cells["UserName"].Value.ToString();

                object birthDateValue = ds_qlnv.SelectedRows[0].Cells["BirthDate"].Value;
                if (birthDateValue != DBNull.Value)
                {
                    DateTime BirthDate = (DateTime)birthDateValue;
                    dtp_birth.Text = BirthDate.ToShortDateString();
                }
                else
                {
                    dtp_birth.Text = string.Empty; // Handle the case when BirthDate is DBNull
                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ds_qlnv.SelectedRows.Count > 0)
            {
                // Get the employee ID from the selected row
                string employeeId = ds_qlnv.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                // Prompt the user for confirmation before deleting
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Attempt to delete the employee
                    bool deleteResult = employeeBUS.deleteEmployee(employeeId);

                    // Check if the deletion was successful
                    if (deleteResult)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView after deletion
                        ds_qlnv.DataSource = employeeBUS.getAllEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (ds_qlnv.SelectedRows.Count > 0)
            {
                // Viết hoa id và chữ cái đầu 
                string id = tb_id.Text.Trim().ToUpper();
                string name = ProjectFont.CapitalizeEachWord(tb_name.Text);
                string address = ProjectFont.upperFirstLetter(tb_address.Text);
                string pnumber = tb_pNumber.Text;
                string email = tb_email.Text.Trim();
                string password = tb_pass.Text;
                string sex = cb_sex.Text;
                string username = txtUserName.Text.Trim();
                string roleid = cb_role.SelectedValue.ToString();

                if (string.IsNullOrWhiteSpace(tb_name.Text) ||
                  string.IsNullOrWhiteSpace(tb_address.Text) ||
                  string.IsNullOrWhiteSpace(tb_pNumber.Text) ||
                  string.IsNullOrWhiteSpace(tb_email.Text) ||
                  string.IsNullOrWhiteSpace(tb_pass.Text) ||
                  string.IsNullOrWhiteSpace(txtUserName.Text) ||
                  cb_sex.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập theo định dạng username@gmail.com.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsNameValid(name))
                {
                    MessageBox.Show("Tên chỉ được chứa chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPhoneNumber(pnumber))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập theo định dạng Việt Nam.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedGender = cb_sex.SelectedItem.ToString().ToUpper();
                if (selectedGender != "NAM" && selectedGender != "NỮ")
                {
                    MessageBox.Show("Vui lòng chọn giới tính 'Nam' hoặc 'Nữ'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool editResult = employeeBUS.editEmployee(id, name, address, pnumber, email, sex, dtp_birth.Value, password, username, roleid);

                // Kiểm tra kết quả chỉnh sửa
                if (editResult)
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView sau khi chỉnh sửa
                    ds_qlnv.DataSource = employeeBUS.getAllEmployee();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string searchTerm = tb_find.Text.Trim();

            string searchType = cb_find.SelectedItem.ToString();


            DataTable searchResult = null;

            if (cb_find.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm (Mã nhân viên hoặc Tên nhân viên).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_find.Text))
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (searchType == "Mã nhân viên")
            {
                // Gọi phương thức tìm kiếm theo ID
                searchResult = employeeBUS.SearchEmployeeByID(searchTerm);
            }
            else if (searchType == "Tên nhân viên")
            {
                // Gọi phương thức tìm kiếm theo Tên
                searchResult = employeeBUS.SearchEmployeeByName(searchTerm);
            }

            // Hiển thị kết quả trong DataGridView hoặc bảng dữ liệu của bạn
            ds_qlnv.DataSource = searchResult;
        }

        public void Roles()
        {
            DataTable roles = employeeBUS.GetRoles();

            if (roles != null && roles.Rows.Count > 0)
            {
                cb_role.ValueMember = "RoleID";
                cb_role.DisplayMember = "Name";
                cb_role.DataSource = roles;
                cb_role.SelectedIndex = 0;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy cho định dạng số điện thoại ở Việt Nam
            string pattern = @"^(0[0-9]{9})$";

            // Kiểm tra xem chuỗi nhập vào có khớp với biểu thức chính quy không
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsNameValid(string name)
        {
            // Kiểm tra từng ký tự trong tên
            foreach (char character in name)
            {
                if (!char.IsLetter(character) && !char.IsWhiteSpace(character))
                {
                    // Nếu ký tự không phải là chữ cái hoặc khoảng trắng, trả về false
                    return false;
                }
            }

            // Nếu tất cả các ký tự đều là chữ cái hoặc khoảng trắng, trả về true
            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy cho định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            // Kiểm tra xem chuỗi nhập vào có khớp với biểu thức chính quy không
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(ds_qlnv);
        }

        private void ExportToExcel(DataGridView gridView)
        {

            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add();

                Excel.Worksheet worksheet = workbook.Sheets[1];

                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < gridView.Columns.Count; j++)
                    {
                        object cellValue = gridView.Rows[i].Cells[j].Value;

                        if (cellValue != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = cellValue.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "BackUp_Employee";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    excelApp.Quit();

                    MessageBox.Show("Exported successfully!");
                }
                else
                {
                    excelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}