using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using MiniSupermarket.RegularExpression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Timer = System.Windows.Forms.Timer;

namespace MiniSupermarket.GUI
{
    public partial class UserAccount : Form
    {
        private string EmployeeName;
        private string EmployeeAddress;
        private string EmployeeEmail;
        private string EmployeePhone;
        private Timer timer = new Timer();
        private Timer timerPassword = new Timer();

        private UserAccountBUS userAccountBus = new UserAccountBUS();
        public UserAccount()
        {
            InitializeComponent();
            this.txtOldPass.PasswordChar = '*';
            this.txtNewPass.PasswordChar = '*';
            this.txtConfirmPass.PasswordChar = '*';
            this.txtEmID.ReadOnly = true;
            this.txtEmName.ReadOnly = true;


            this.btnUpdate.Enabled = false;
            this.btnReload.Enabled = false;
            this.btnChangePass.Enabled = false;

            // Đăng ký sự kiện Tick
            timer.Tick += new EventHandler(timer_Tick);

            // Đặt khoảng thời gian cho Timer (ví dụ: 300ms)
            timer.Interval = 300;

            // Đăng ký sự kiện Tick
            timerPassword.Tick += new EventHandler(timerPassword_Tick);

            // Đặt khoảng thời gian cho Timer (ví dụ: 300ms)
            timerPassword.Interval = 300;

            // Tải thông tin nhân viên
            DataTable employInfor = userAccountBus.getInforFromAccount(GlobalState.username);
            // Kiểm tra xem thông tin nhân viên lấy được không
            if (employInfor != null)
            {
                DataRow row = employInfor.Rows[0];
                // Set những trường để theo dõi trạng thái
                GlobalState.employeeId = row["EmployeeID"].ToString();
                EmployeeName = row["Name"].ToString();
                EmployeeAddress = row["Address"].ToString();
                EmployeePhone = row["PhoneNumber"].ToString();
                EmployeeEmail = row["Email"].ToString();

                // Hiển thị thông tin lên text box
                txtEmID.Text = GlobalState.employeeId;
                txtEmName.Text = EmployeeName;
                txtAddress.Text = EmployeeAddress;
                txtPhone.Text = EmployeePhone;
                txtEmail.Text = EmployeeEmail;
            }
        }

        // Hàm tải màu cho label và nút
        public void LoadTheme()
        {
            // Thêm màu cho tất cả các nút và label ở panel left
            foreach (Control control in this.pnlLeft.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (control.GetType() == typeof(Label) && control.Name != "lbInfor")
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }

            // Thêm màu cho tất cả các nút và label ở panel right
            foreach (Control control in this.pnlRight.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (control.GetType() == typeof(Label) && control.Name != "lbChangePass")
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }

            // Thêm size chữ cho label tiêu đề
            lbInfor.ForeColor = ThemeColor.SecondaryColor;
            lbInfor.Font = ProjectFont.getTitleFont();
            lbChangePass.ForeColor = ThemeColor.SecondaryColor;
            lbChangePass.Font = ProjectFont.getTitleFont();

            // Thêm màu cho check box hiện mật khẩu
            chkShowPassword.ForeColor = ThemeColor.SecondaryColor;
            chkShowPassword.Font = ProjectFont.getNormalFont();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            LoadTheme();

            // Thêm sự kiện cho các text box thông tin tài khoản
            foreach (Control control in this.pnlLeft.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.TextChanged += textBoxHandler;
                }
            }

            // Thêm sự kiện cho các text box mật khẩu
            foreach (Control control in this.pnlRight.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.TextChanged += textBoxPasswordHandler;
                }
            }
        }

        // Hàm xử lý sự kiện text change
        private void textBoxHandler(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        // Hàm xử lý sự kiện text change cho password
        private void textBoxPasswordHandler(object sender, EventArgs e)
        {
            timerPassword.Stop();
            timerPassword.Start();
        }

        // Xử lý sự kiện của text change của thông tin tài khoản
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            // Nếu có text box rỗng thì không cho update
            if (txtAddress.Text.Trim().Length == 0 ||
                txtEmail.Text.Trim().Length == 0 ||
                txtPhone.Text.Trim().Length == 0)
            {
                this.btnUpdate.Enabled = false;
                return;
            }

            // Nếu mà giá trị của text box khác với giá trị cũ thì cho tải lại và cập nhật
            if (txtAddress.Text != EmployeeAddress ||
                txtEmail.Text != EmployeeEmail ||
                txtPhone.Text != EmployeePhone)
            {
                this.btnReload.Enabled = true;
                this.btnUpdate.Enabled = true;
            }
            else
            {
                this.btnReload.Enabled = false;
                this.btnUpdate.Enabled = false;
            }
        }

        // Xử lý sự kiện của text change của thông tin tài khoản
        private void timerPassword_Tick(object sender, EventArgs e)
        {
            timerPassword.Stop();

            // Nếu có text box rỗng thì không cho update password
            if (txtOldPass.Text.Length == 0 ||
                txtNewPass.Text.Length == 0 ||
                txtConfirmPass.Text.Length == 0)
            {
                this.btnChangePass.Enabled = false;
                return;
            }

            // Nếu nhập đúng mật khẩu cũ và mật khẩu mới khác với mật khẩu cũ
            // nhập lại mật khẩu đúng thì sẽ cho cập nhật mật khẩu
            if (txtOldPass.Text.Equals(GlobalState.password) &&
                !txtNewPass.Text.Equals(GlobalState.password) &&
                txtConfirmPass.Text.Equals(txtNewPass.Text))
            {
                this.btnChangePass.Enabled = true;
            }
            else
            {
                this.btnChangePass.Enabled = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            // Hiển thị thông tin lên text box
            txtAddress.Text = EmployeeAddress;
            txtPhone.Text = EmployeePhone;
            txtEmail.Text = EmployeeEmail;

            this.btnReload.Enabled = false;
            this.btnUpdate.Enabled = false;
            txtAddress.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra định dạng số điện thoại
            if (!ProjectRegex.IsPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            // Kiểm tra định dạng email
            if (!ProjectRegex.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }


            this.btnUpdate.Enabled = false;
            this.btnReload.Enabled = false;

            // Nếu cập nhật thành công thì set thuộc tính thành thuộc tính mới
            if (userAccountBus.updateAccountInfor(txtEmID.Text, txtAddress.Text.Trim(), txtPhone.Text, txtEmail.Text.Trim()))
            {
                EmployeeAddress = txtAddress.Text.Trim();
                EmployeePhone = txtPhone.Text;
                EmployeeEmail = txtEmail.Text.Trim();

                // Hiện thông báo thành công
                MessageBox.Show("Cập nhật thông tin tài khoản thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                // Nếu cập nhật thông tin bị lỗi
                MessageBox.Show("Cập nhật thông tin tài khoản không thành công",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            txtAddress.Focus();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho phép nhập white space
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // update lại giá trị password
            if (userAccountBus.updateAccountPassword(GlobalState.employeeId, txtNewPass.Text))
            {
                GlobalState.password = txtNewPass.Text;
                // Hiện thông báo
                MessageBox.Show("Cập nhật mật khẩu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                // Nếu cập nhật password bị lỗi
                MessageBox.Show("Cập nhật mật khẩu không thành công",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                txtOldPass.Focus();
                return;
            }

            txtNewPass.Clear();
            txtOldPass.Clear();
            txtConfirmPass.Clear();
            this.btnChangePass.Enabled = false;
            txtAddress.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPass.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtNewPass.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirmPass.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
