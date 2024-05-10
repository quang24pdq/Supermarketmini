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

namespace MiniSupermarket.GUI
{
    public partial class PromotionForm : Form
    {
        PromotionBUS promotionBUS = new PromotionBUS();
        public PromotionForm()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            dtpkEndDate.Format = DateTimePickerFormat.Custom;
            dtpkEndDate.CustomFormat = "dd-MM-yyyy";
            dtpkStartDate.Format = DateTimePickerFormat.Custom;
            dtpkStartDate.CustomFormat = "dd-MM-yyyy";
        }

        public void LoadTheme()
        {
            // Thêm màu cho tất cả các nút ở panel top
            foreach (Control btns in this.pnlInformation.Controls)
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

            // Thêm màu cho group box tìm kiếm
            foreach (Control control in this.grbPriceFilter.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }

            }
            foreach (Control control in this.grbDateFilter.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
            btnFilterDate.BackColor = ThemeColor.PrimaryColor;
            btnFilterDate.ForeColor = Color.White;
            btnFilterDate.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblTitle.Font = ProjectFont.getTitleFont();
            lblTitle.ForeColor = ThemeColor.SecondaryColor;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void PromotionForm_Load(object sender, EventArgs e)
        {
            ShowPromotion();
            dgvPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromotions.ReadOnly = true;
            SetNull();
            dgvPromotions.Columns[0].HeaderText = "Mã CTKM";
            dgvPromotions.Columns[1].HeaderText = "Tên CTKM";
            dgvPromotions.Columns[2].HeaderText = "Ngày bắt đầu";
            dgvPromotions.Columns[3].HeaderText = "Ngày kết thúc";
            dgvPromotions.Columns[4].HeaderText = "Giảm (%)";
            dgvPromotions.Columns[5].HeaderText = "Trạng thái";
            LoadTheme();
            cbxTypeOfSearch.Text = "Mã CTKM";
            cbxFilterPrice.Text = "Tất cả";
        }

        public void ShowPromotion()
        {
            dgvPromotions.DataSource = promotionBUS.getAllPromotions();
        }

        void SetNull()
        {
            txtPromotionID.Clear();
            txtPromotionName.Clear();
            txtDiscount.Clear();
            dtpkStartDate.Value = DateTime.Now;
            dtpkEndDate.Value = DateTime.Now;
            cbxTypeOfSearch.SelectedIndex = 0;
            cbxFilterPrice.SelectedIndex = 0;
            txtSearch.Clear();
            dtpkSearchStartDate.Value = DateTime.Now;
            dtpkSearchEndDate.Value = DateTime.Now;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvPromotions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvPromotions.Rows[rowIndex];
            string promotionID = row.Cells[0].Value.ToString();
            DetailPronmotionForm form = new DetailPronmotionForm(promotionID);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtPromotionName.Text.Trim();
            string StartDate = String.Format("{0:dd/MM/yyyy}", dtpkStartDate.Value);
            string EndDate = String.Format("{0:dd/MM/yyyy}", dtpkEndDate.Value);

            //string StartDate = dtpkStartDate.Value.ToString();
            //string EndDate = dtpkEndDate.Value.ToString();
            string Discount = txtDiscount.Text.Trim();
            if (txtPromotionID.Text.Length != 0)
            {
                MessageBox.Show("Vui lòng để trống mã chương trình khuyến mãi! Chọn tải lại để xoá",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Name.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtPromotionName.Focus();
                return;
            }
            if (Discount.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm của chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (!ProjectRegex.checkDayAfterDay(StartDate, EndDate))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(Discount) > 100 || Convert.ToInt32(Discount) < 1)
            {
                MessageBox.Show("Phần trăm giảm không hợp lệ! Hợp lệ trong khoảng 1 đến 100",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (promotionBUS.insertPromotion(Name, StartDate, EndDate, Discount))
            {
                MessageBox.Show("Thêm chương trình khuyến mãi thành công", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowPromotion();
                SetNull();
                return;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowPromotion();
            SetNull();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            string Name = txtPromotionName.Text.Trim();
            string StartDate = String.Format("{0:dd/MM/yyyy}", dtpkStartDate.Value);
            string EndDate = String.Format("{0:dd/MM/yyyy}", dtpkEndDate.Value);
            string Discount = txtDiscount.Text.Trim();
            if (ID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Name.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtPromotionName.Focus();
                return;
            }
            if (Discount.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm của chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (!ProjectRegex.checkDayAfterDay(StartDate, EndDate))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(Discount) > 100 || Convert.ToInt32(Discount) < 1)
            {
                MessageBox.Show("Phần trăm giảm không hợp lệ! Hợp lệ trong khoảng 1 đến 100",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (promotionBUS.updatePromotion(ID, Name, StartDate, EndDate, Discount))
            {
                MessageBox.Show("Sửa thông tin chương trình khuyến mãi thành công", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowPromotion();
                SetNull();
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            if (ID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có muốn chắc muốn xoá chương trình khuyến mãi {ID} không?", "Xoá chương trình khuyến mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (promotionBUS.deletePromotion(ID))
                {
                    MessageBox.Show("Xoá chương trình khuyến mãi thành công", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    promotionBUS.clearAllProductsFromPromotion(ID);
                    ShowPromotion();
                    SetNull();
                    return;
                }
            }

        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            if (ID.Length == 0 || dgvPromotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgvPromotions.SelectedRows[0];
            string status = row.Cells["Status"].Value.ToString();
            string startDate = String.Format("{0:dd/MM/yyyy}", row.Cells["StartDate"].Value);
            string endDate = String.Format("{0:dd/MM/yyyy}", row.Cells["EndDate"].Value);
            if (status.Equals("Đang hoạt động"))
            {
                MessageBox.Show("Chương trình khuyến mãi này đang hoạt động",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (!ProjectRegex.checkDayBelongDay(startDate, endDate))
            {
                MessageBox.Show("Chương trình khuyến mãi này không trong thời gian được hoạt động",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (promotionBUS.startWorkPromotion(ID))
            {
                MessageBox.Show("Chương trình khuyến mãi bắt đầu hoạt động", "Hoạt động chương trình khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowPromotion();
                SetNull();
                return;
            }
        }

        private void btnStopWork_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            if (ID.Length == 0 || dgvPromotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgvPromotions.SelectedRows[0];
            string status = row.Cells["Status"].Value.ToString();
            if (status.Equals("Không hoạt động"))
            {
                MessageBox.Show("Chương trình khuyến mãi này không hoạt động",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có chắc muốn ngưng áp dụng chương trình khuyến mãi {ID} không", "Ngưng hoạt động chương trình khuyến mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (promotionBUS.stopWorkPromotion(ID))
                {
                    MessageBox.Show("Chương trình khuyến mãi ngưng hoạt động thành công", "Ngưng hoạt động chương trình khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowPromotion();
                    SetNull();
                    return;
                }
            }
        }

        private void dgvPromotions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvPromotions.SelectedRows[0];
            txtPromotionID.Text = row.Cells[0].Value.ToString();
            txtPromotionName.Text = row.Cells[1].Value.ToString();
            DateTime startDate = DateTime.Parse(row.Cells[2].Value.ToString());
            DateTime endDate = DateTime.Parse(row.Cells[3].Value.ToString());
            dtpkStartDate.Value = startDate;
            dtpkEndDate.Value = endDate;
            txtDiscount.Text = row.Cells[4].Value.ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(txtSearch.Text);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Filter();
        }

        private void cbxFilterPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            int index_Type_Search = cbxTypeOfSearch.SelectedIndex;
            string key_Search = txtSearch.Text.ToLower();
            int index_Filter_Price = cbxFilterPrice.SelectedIndex;
            DateTime searchStartDate = dtpkSearchStartDate.Value.Date; //== DateTime.Now.Date ? searchStartDate = new DateTime(1970,1,1) : searchStartDate = dtpkSearchStartDate.Value;
            DateTime searchEndDate = dtpkSearchEndDate.Value.Date; //== DateTime.Now.Date ? searchEndDate = new DateTime(2050, 12, 31) : searchEndDate = dtpkSearchEndDate.Value;
            if (searchStartDate == DateTime.Now.Date && searchEndDate == DateTime.Now.Date)
            {
                searchStartDate = new DateTime(1970, 1, 1);
                searchEndDate = new DateTime(2050, 12, 31);
            }
            else
            {
                searchStartDate = dtpkSearchStartDate.Value;
                searchEndDate = dtpkSearchEndDate.Value;
            }
            string searchStartDateString = String.Format("{0:dd/MM/yyyy}", searchStartDate);
            string searchEndDateString = String.Format("{0:dd/MM/yyyy}", searchEndDate);

            if (!ProjectRegex.checkDayAfterDay(searchStartDateString,searchEndDateString))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }

            int startDiscount = 0, endDiscount= 101;
            switch (index_Filter_Price)
            {
                case 0: startDiscount = 0; endDiscount = 101 ; break;
                case 1: startDiscount = 0; endDiscount = 15; break;
                case 2: startDiscount = 15; endDiscount = 40 ; break;
                case 3: startDiscount = 40; endDiscount = 101; break;
            }

            DataTable promotions = promotionBUS.getAllPromotions();
            DataTable searchPromotion = promotions.Clone();

            foreach (DataRow row in promotions.Rows)
            { 
                string rowID = row[0].ToString().ToLower();
                string rowName = row[1].ToString().ToLower();
                DateTime rowStartDate;
                DateTime.TryParse(row[2].ToString(), out rowStartDate);
                DateTime rowEndDate;
                DateTime.TryParse(row[3].ToString(), out rowEndDate);
                string discount = row[4].ToString();
                int discoutnInt = Convert.ToInt32(discount);

                switch (index_Type_Search)
                {
                    case 0: if (rowID.Contains(key_Search) && discoutnInt >= startDiscount && discoutnInt < endDiscount && searchStartDate.Date <= rowStartDate.Date && searchEndDate.Date >= rowEndDate.Date)
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                    case 1:
                        if (rowName.Contains(key_Search) && discoutnInt >= startDiscount && discoutnInt < endDiscount && searchStartDate.Date <= rowStartDate.Date && searchEndDate.Date >= rowEndDate.Date)
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                }
            }
            dgvPromotions.DataSource = searchPromotion;
        }
    }
}
