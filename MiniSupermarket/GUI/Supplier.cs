using MiniSupermarket.BUS;
using MiniSupermarket.CustomControl;
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

namespace MiniSupermarket.GUI
{
    public partial class Supplier : Form
    {
        SupplierBUS supplierBUS = new SupplierBUS();
        DataTable dataSupplier = new DataTable();
        DataTable dataLoaiSanPham = new DataTable();

        bool clickSua = false;
        public Supplier()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
            textBoxTen.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxDiaChi.ReadOnly = true;
            dateTimePickerNgayNhap.Enabled = false;

        }
        public void LoadTheme()
        {
            // Thêm màu cho tất cả các nút ở panel top
            foreach (Control btns in this.groupBoxChucNang.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (btns.GetType() == typeof(Label))
                {
                    Label lb = (Label)btns;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
            foreach (Control btns in this.groupBoxLoaiSanPham.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (btns.GetType() == typeof(Label))
                {
                    Label lb = (Label)btns;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
            foreach (Control btns in this.groupBoxThongTinNCC.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (btns.GetType() == typeof(Label))
                {
                    Label lb = (Label)btns;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            dataSupplier = supplierBUS.getAllFromSupplier();
            dtgvSupplier.DataSource = dataSupplier;
            comboBoxTimKiem.SelectedText = "ID";
            LoadTheme();
        }

        private void dtgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSupplier.SelectedRows)
            {
                dataLoaiSanPham = supplierBUS.getAllFromSupplierDetail(row.Cells[0].Value.ToString());
                dtgvLoaiSanPham.DataSource = dataLoaiSanPham;

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxTen.Text = row.Cells[1].Value.ToString();
                textBoxDiaChi.Text = row.Cells[2].Value.ToString();
                textBoxSDT.Text = row.Cells[3].Value.ToString();
                textBoxEmail.Text = row.Cells[4].Value.ToString();

            }
        }

        private void dtgvSupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvSupplier.ClearSelection();
        }

        private void dtgvLoaiSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvLoaiSanPham.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxThongTinNCC.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
            DataTable dt = new DataTable();
            dt = supplierBUS.getAllSupplierWithout();
            int count = dt.Rows.Count;
            count = count + 1;

            textBoxID.Text = "S" + count.ToString("D4");


            textBoxTen.ReadOnly = false;
            textBoxSDT.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxDiaChi.ReadOnly = false;
            dateTimePickerNgayNhap.Enabled = true;



            btnHuy.Enabled = true;
            btnXacNhan.Enabled = true;
            btnThem.Enabled = false;

            dataLoaiSanPham = supplierBUS.AllProduct(textBoxID.Text);
            dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
        }
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private string productId;
        private string date;
        private int count;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Control c in groupBoxThongTinNCC.Controls)
            {
                if (c.GetType() == typeof(TextBox) && c.Text.Equals(""))
                {
                    count = count + 1;
                    //MessageBox.Show(c.Name);
                }
            }
            name = textBoxTen.Text;
            address = textBoxDiaChi.Text;

            if (ProjectRegex.IsPhoneNumber(textBoxSDT.Text))
            {
                phoneNumber = textBoxSDT.Text;
            }
            else
            {
                count = count + 1;
            }
            if (ProjectRegex.IsEmail(textBoxEmail.Text))
            {
                email = textBoxEmail.Text;
            }
            else
            {
                count = count + 1;
            }
            if (count == 0)
            {
                supplierBUS.addSupplier(
                    textBoxID.Text,
                    name,
                    address,
                    phoneNumber,
                    email
                    );
                foreach (DataGridViewRow row in dtgvLoaiSanPham.SelectedRows)
                {
                    supplierBUS.AddDetailSupplier(textBoxID.Text, row.Cells[0].Value.ToString(), dateTimePickerNgayNhap.Value.ToString());
                }

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                btnHuy.Enabled = false;
                btnXacNhan.Enabled = false;
                btnThem.Enabled = true;

                dataSupplier = supplierBUS.getAllFromSupplier();
                dtgvSupplier.DataSource = dataSupplier;
                textBoxTen.ReadOnly = true;
                textBoxSDT.ReadOnly = true;
                textBoxEmail.ReadOnly = true;
                textBoxDiaChi.ReadOnly = true;
                dateTimePickerNgayNhap.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thông tin bị bỏ trống hoặc không đúng format");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = true;
            textBoxTen.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxDiaChi.ReadOnly = true;
            dateTimePickerNgayNhap.Enabled = false;

            btnHuy.Enabled = false;
            btnXacNhan.Enabled = false;
            btnThem.Enabled = true;

            clickSua = false;

            foreach (Control c in groupBoxThongTinNCC.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }

            dataSupplier = supplierBUS.getAllFromSupplier();
            dtgvSupplier.DataSource = dataSupplier;

            dataLoaiSanPham = null;
            dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {

            if (dtgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn nhà cung cấp trước khi thêm loại sản phẩm", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                btnXacNhanLoai.Enabled = true;
                btnHuyThemLoai.Enabled = true;
                btnThemLoai.Enabled = false;

                dateTimePickerNgayNhap.Enabled = true;

                dataLoaiSanPham = supplierBUS.AllProduct(textBoxID.Text);
                dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
            }


        }

        private void btnXacNhanLoai_Click(object sender, EventArgs e)
        {

            if (dtgvLoaiSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại sản phẩm cần thêm");
            }
            else
            {
                foreach (DataGridViewRow rows in dtgvLoaiSanPham.SelectedRows)
                {
                    supplierBUS.AddDetailSupplier(textBoxID.Text, rows.Cells[0].Value.ToString(), dateTimePickerNgayNhap.Value.ToString());
                }
                btnHuyThemLoai.Enabled = false;
                btnThemLoai.Enabled = true;
                btnXacNhanLoai.Enabled = false;

                dataLoaiSanPham = supplierBUS.getAllFromSupplierDetail(textBoxID.Text);
                dtgvLoaiSanPham.DataSource = dataLoaiSanPham;

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xác nhận xóa nhà cung cấp", "CONFIRM", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                supplierBUS.delSupplier(textBoxID.Text);
                foreach (Control c in groupBoxThongTinNCC.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = "";
                    }
                }
                dateTimePickerNgayNhap.Value = DateTime.Now;
                dtgvLoaiSanPham.DataSource = null;
                dataSupplier = supplierBUS.getAllFromSupplier();
                dtgvSupplier.DataSource = dataSupplier;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn sản phẩm cần sửa trước", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (clickSua == false)
                {
                    btnThem.Enabled = false;
                    btnHuy.Enabled = true;
                    btnXoa.Enabled = false;
                    clickSua = true;

                    textBoxTen.ReadOnly = false;
                    textBoxDiaChi.ReadOnly = false;
                    textBoxSDT.ReadOnly = false;
                    textBoxEmail.ReadOnly = false;
                    if (dtgvLoaiSanPham.SelectedRows.Count > 0)
                    {
                        dateTimePickerNgayNhap.Enabled = true;
                    }


                }
                else
                {
                    supplierBUS.updateSupplier(
                    textBoxID.Text,
                    textBoxTen.Text,
                    textBoxDiaChi.Text,
                    textBoxSDT.Text,
                    textBoxEmail.Text
                        );
                    foreach (DataGridViewRow row in dtgvLoaiSanPham.SelectedRows)
                    {
                        supplierBUS.updateSupplierDetail(textBoxID.Text, row.Cells[0].Value.ToString(), dateTimePickerNgayNhap.Value.ToString());
                    }
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                    dataSupplier = supplierBUS.getAllFromSupplier();
                    dtgvSupplier.DataSource = dataSupplier;
                    dataLoaiSanPham = supplierBUS.getAllFromSupplierDetail(textBoxID.Text);
                    dtgvLoaiSanPham.DataSource = dataLoaiSanPham;


                    btnThem.Enabled = true;
                    btnHuy.Enabled = false;
                    btnXoa.Enabled = true;
                    clickSua = false;

                    textBoxTen.ReadOnly = true;
                    textBoxDiaChi.ReadOnly = true;
                    textBoxSDT.ReadOnly = true;
                    textBoxEmail.ReadOnly = true;
                    dateTimePickerNgayNhap.Enabled = false;
                }
            }
        }

        private void btnHuyThemLoai_Click(object sender, EventArgs e)
        {
            btnThemLoai.Enabled = true;
            btnXacNhanLoai.Enabled = false;
            btnHuyThemLoai.Enabled = false;

            dataLoaiSanPham = supplierBUS.getAllFromSupplierDetail(textBoxID.Text);
            dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
        }

        private void dtgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            btnXoaLoai.Enabled = true;
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvLoaiSanPham.SelectedRows)
            {
                supplierBUS.delSupplierDetail(textBoxID.Text, row.Cells[0].Value.ToString());
            }
            foreach (DataGridViewRow row in dtgvSupplier.SelectedRows)
            {
                dataLoaiSanPham = supplierBUS.getAllFromSupplierDetail(row.Cells[0].Value.ToString());
                dtgvLoaiSanPham.DataSource = dataLoaiSanPham;

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxTen.Text = row.Cells[1].Value.ToString();
                textBoxDiaChi.Text = row.Cells[2].Value.ToString();
                textBoxSDT.Text = row.Cells[3].Value.ToString();
                textBoxEmail.Text = row.Cells[4].Value.ToString();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string selected = comboBoxTimKiem.Text;
            switch (selected)
            {
                case "ID":
                    dataSupplier = supplierBUS.getSupplierWithIDFromSupplier(textBoxTimKiem.Text);
                    dtgvSupplier.DataSource = dataSupplier;
                    break;
                case "Tên":
                    dataSupplier = supplierBUS.getSupplierWithName(textBoxTimKiem.Text);
                    dtgvSupplier.DataSource = dataSupplier;
                    break;
                case "Địa chỉ":
                    dataSupplier = supplierBUS.getSupplierWithAddress(textBoxTimKiem.Text);
                    dtgvSupplier.DataSource = dataSupplier;
                    break;
                case "SĐT":
                    dataSupplier = supplierBUS.getSupplierWithPhoneNumber(textBoxTimKiem.Text);
                    dtgvSupplier.DataSource = dataSupplier;
                    break;
                case "Email":
                    dataSupplier = supplierBUS.getSupplierWithEmail(textBoxTimKiem.Text);
                    dtgvSupplier.DataSource = dataSupplier;
                    break;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataSupplier = supplierBUS.getAllFromSupplier();
            dtgvSupplier.DataSource = dataSupplier;
        }
    }
}
