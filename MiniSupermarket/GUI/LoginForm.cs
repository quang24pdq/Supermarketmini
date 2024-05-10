using MiniSupermarket.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI
{
    public partial class formLogin : Form
    {
        private LoginBUS loginBus = new LoginBUS();

        public formLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.txtPassword.PasswordChar = '*';
        }

        int intImage = 0;

        private void tmrChangedImage_Tick_1(object sender, EventArgs e)
        {
            pbxImage.Image = ImageListShow.Images[intImage];
            if (intImage == ImageListShow.Images.Count - 1)
            {
                intImage = 0;
            }
            else
            {
                intImage++;
            }
        }

        // Hàm login cho form
        private void login(string username, string password)
        {
            // Kiểm tra tên đăng nhập có bỏ trống không
            if (username.Trim().Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // Tên đăng nhập không được bỏ trống
                return;
            }
            if (password.Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // Mật khẩu không được bỏ trống
                return;
            }

            switch (loginBus.countAccount(username, password))
            {
                case 0:
                    MessageBox.Show("Tài khoản không có trong hệ thống",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // Tài khoản không có trong hệ thống
                    txtUsername.Select();
                    break;
                case -1:
                    MessageBox.Show("Lỗi hệ thống",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Lỗi hệ thống
                    txtUsername.Select();
                    break;
                default:
                    // Lưu các chức năng của user này vào biến toàn cục
                    GlobalState.funcs = loginBus.getFunctionFromAccount(username, password);
                    // Lưu username này vào biến toàn cục
                    GlobalState.username = username;
                    // Lưu password của user này vào biến toàn cục
                    GlobalState.password = password;
                    MenuForm menu = new MenuForm(this);
                    this.Hide();
                    menu.Show();
                    clearText();
                    break;
            }
        }

        private void clearText()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtUsername.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login(txtUsername.Text, txtPassword.Text);
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi hàm đăng nhập
                login(txtUsername.Text, txtPassword.Text);
            }
        }

        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chbxShowPassword.Checked ? '\0' : '*';
        }
    }
}
