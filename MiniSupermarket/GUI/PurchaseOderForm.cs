using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using MiniSupermarket.RegularExpression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace MiniSupermarket.GUI
{
    public partial class PurchaseOderForm : Form
    {
        private PurchaseOrderBUS bus = new PurchaseOrderBUS();
        private string status;
        public PurchaseOderForm()
        {
            InitializeComponent();
        }

        void LoadTheme()
        {
            lblTitle.ForeColor = ThemeColor.SecondaryColor;
            lblTitle.Font = ProjectFont.getTitleFont();

            lblSupplier.ForeColor = ThemeColor.SecondaryColor;
            lblSupplier.Font = ProjectFont.getNormalFont();

            lblPurchaseOderID.ForeColor = ThemeColor.SecondaryColor;
            lblPurchaseOderID.Font = ProjectFont.getNormalFont();

            btnAddPurchaseOder.BackColor = ThemeColor.PrimaryColor;
            btnAddPurchaseOder.ForeColor = Color.White;

            btnAddPurchaseOder.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnDeletePurchaseOder.BackColor = ThemeColor.PrimaryColor;
            btnDeletePurchaseOder.ForeColor = Color.White;
            btnDeletePurchaseOder.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            btnUpdate.BackColor = ThemeColor.PrimaryColor;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            btnPrintOrder.BackColor = ThemeColor.PrimaryColor;
            btnPrintOrder.ForeColor = Color.White;
            btnPrintOrder.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            btnReset.BackColor = ThemeColor.PrimaryColor;
            btnReset.ForeColor = Color.White;
            btnReset.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            cbxTypeSearch.SelectedIndex = 0;
            dgvPurchaseOders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblDateTo.ForeColor = ThemeColor.SecondaryColor;
            lblDateTo.Font = ProjectFont.getNormalFont();

            lblDateFrom.ForeColor = ThemeColor.SecondaryColor;
            lblDateFrom.Font = ProjectFont.getNormalFont();

            btnFilterDate.BackColor = ThemeColor.PrimaryColor;
            btnFilterDate.ForeColor = Color.White;
            btnFilterDate.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }

        private void PurchaseOderForm_Load(object sender, EventArgs e)
        {
            txtOrderID.ReadOnly = true;
            dgvPurchaseOders.ReadOnly = true;
            LoadTheme();
            HienThiPhieuNhap();
            dgvPurchaseOders.Columns[0].HeaderText = "Mã phiếu nhập";
            dgvPurchaseOders.Columns[1].HeaderText = "Tên nhân viên";
            dgvPurchaseOders.Columns[2].HeaderText = "Nhà cung cấp";
            dgvPurchaseOders.Columns[3].HeaderText = "Ngày nhập";
            dgvPurchaseOders.Columns[4].HeaderText = "Tổng giá";
            dgvPurchaseOders.Columns[5].HeaderText = "Thanh toán";
            ShowComboboxSupplier();
            cbxFilterTotalPrice.SelectedIndex = 0;
            Payed(true);
        }

        public void HienThiPhieuNhap()
        {
            dgvPurchaseOders.DataSource = bus.getPurchaseOrders(GlobalState.employeeId);
        }

        public void ShowComboboxSupplier()
        {
            DataTable dt = bus.getSuppliers();
            cbxSupplier.DataSource = dt;
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "SupplierID";
        }

        public void setNull()
        {
            txtOrderID.Text = "";
            txtSearch.Text = "";
            cbxSupplier.SelectedIndex = 0;
            cbxTypeSearch.SelectedIndex = 0;
            cbxFilterTotalPrice.SelectedIndex = 0;
            dtpkFilterStartDate.Value = DateTime.Now;
            dtpkFilterEndDate.Value = DateTime.Now;
            dgvPurchaseOders.DataSource = bus.getPurchaseOrders(GlobalState.employeeId);
            Payed(true);

        }

        private void dgvPurchaseOders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvPurchaseOders.Rows[rowIndex];
            string promotionID = row.Cells[0].Value.ToString();
            string supplierID = bus.GetSupplierIDByName(row.Cells[2].Value.ToString());
            DetailPurchaseOrderForm form = new DetailPurchaseOrderForm(promotionID, status, supplierID, this);
            form.ShowDialog();
        }

        private void btnAddPurchaseOder_Click(object sender, EventArgs e)
        {
            string OrderID = txtOrderID.Text;
            string SupplierID = cbxSupplier.SelectedValue.ToString();
            if (OrderID.Length != 0)
            {
                MessageBox.Show("Vui lòng không chọn phiếu nhập! Chọn nút tải lại",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có muốn nhập hàng từ nhà cung cấp {cbxSupplier.Text} không?", "Tạo phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (bus.InsertPurchaseOrder(SupplierID))
                {
                    MessageBox.Show("Tạo phiếu nhập thành công", "Tạo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    return;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string OrderID = txtOrderID.Text;
            string CurrentSupplierID = cbxSupplier.SelectedValue.ToString();
            DataGridViewRow row = dgvPurchaseOders.SelectedRows[0];
            string PassSupplierID = bus.GetSupplierIDByName(row.Cells[2].Value.ToString());
            if (OrderID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn sửa",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (CurrentSupplierID.Equals(PassSupplierID))
            {
                MessageBox.Show("Thông tin sửa giống với ban đầu", "Sửa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bus.UpdatePurchaseOrder(OrderID, CurrentSupplierID))
                {
                    bus.ClearAllProductInDetailOrder(OrderID);
                    MessageBox.Show("Sửa phiếu nhập thành công", "Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    return;
                }
            }
        }

        private void btnDeletePurchaseOder_Click(object sender, EventArgs e)
        {
            string OrderID = txtOrderID.Text;
            if (OrderID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xoá",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có muốn xoá phiếu nhập {OrderID} không?", "Xoá phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (bus.DeletePurchaseOrder(OrderID))
                {
                    MessageBox.Show("Xoá phiếu nhập thành công", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    return;
                }
            }

        }

        private void dgvPurchaseOders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvPurchaseOders.SelectedRows[0];
            txtOrderID.Text = row.Cells[0].Value.ToString();
            cbxSupplier.Text = row.Cells[2].Value.ToString();
            object Status = row.Cells[5].Value;
            if (Status == "")
            {
                Payed(true);
                return;
            }
            bool isCheckOut = (bool)Status;
            if (isCheckOut)
            {
                status = "1";
                Payed(false);
                return;
            }
            else
            {
                status="0";
                Payed(true);
                return;
            }
        }

        void Payed(Boolean yes)
        {
            btnDeletePurchaseOder.Enabled = yes;
            btnUpdate.Enabled = yes;
            btnPrintOrder.Enabled = !yes;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            int index_Type_Search = cbxTypeSearch.SelectedIndex;
            string key_Search = txtSearch.Text.ToLower();
            int index_Filter_Price = cbxFilterTotalPrice.SelectedIndex;
            DateTime searchStartDate = dtpkFilterStartDate.Value.Date; //== DateTime.Now.Date ? searchStartDate = new DateTime(1970,1,1) : searchStartDate = dtpkSearchStartDate.Value;
            DateTime searchEndDate = dtpkFilterEndDate.Value.Date; //== DateTime.Now.Date ? searchEndDate = new DateTime(2050, 12, 31) : searchEndDate = dtpkSearchEndDate.Value;
            if (searchStartDate == DateTime.Now.Date && searchEndDate == DateTime.Now.Date)
            {
                searchStartDate = new DateTime(1970, 1, 1);
                searchEndDate = new DateTime(2050, 12, 31);
            }
            else
            {
                searchStartDate = dtpkFilterStartDate.Value;
                searchEndDate = dtpkFilterEndDate.Value;
            }
            string searchStartDateString = String.Format("{0:dd/MM/yyyy}", searchStartDate);
            string searchEndDateString = String.Format("{0:dd/MM/yyyy}", searchEndDate);

            if (!ProjectRegex.checkDayAfterDay(searchStartDateString, searchEndDateString))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }

            int startPrice = 0, endPrice = 2000000001;
            switch (index_Filter_Price)
            {
                case 0: startPrice = 0; endPrice = 2000000001; break;
                case 1: startPrice = 0; endPrice = 5000000; break;
                case 2: startPrice = 5000000; endPrice = 15000000; break;
                case 3: startPrice = 15000000; endPrice = 50000000; break;
                case 4: startPrice = 50000000; endPrice = 2000000001; break;
            }

            DataTable promotions = bus.getPurchaseOrders(GlobalState.employeeId);
            DataTable searchPromotion = promotions.Clone();

            foreach (DataRow row in promotions.Rows)
            {
                string rowID = row[0].ToString().ToLower();
                string rowSupplier = row[2].ToString().ToLower();
                DateTime rowDateImport;
                DateTime.TryParse(row[3].ToString(), out rowDateImport);
                string totalPrice = row[4].ToString();
                int totalPriceInt = Convert.ToInt32(totalPrice);

                switch (index_Type_Search)
                {
                    case 0:
                        if (rowID.Contains(key_Search) && totalPriceInt >= startPrice && totalPriceInt < endPrice && searchStartDate.Date <= rowDateImport.Date && searchEndDate.Date >= rowDateImport.Date)
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                    case 1:
                        if (rowSupplier.Contains(key_Search) && totalPriceInt >= startPrice && totalPriceInt < endPrice && searchStartDate.Date <= rowDateImport.Date && searchEndDate.Date >= rowDateImport.Date)
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                }
            }
            dgvPurchaseOders.DataSource = searchPromotion;
        }

        private void cbxFilterTotalPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setNull();
            ShowComboboxSupplier();
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                DataGridViewRow row = dgvPurchaseOders.SelectedRows[0];
                string OrderID = row.Cells[0].Value.ToString();
                string EmployeeName = row.Cells[1].Value.ToString();
                string SupplietName = row.Cells[2].Value.ToString();
                DateTime Date;
                DateTime.TryParse(row.Cells[3].Value.ToString(), out Date);

                string DateImport = String.Format("{0:dd/MM/yyyy}", Date);
                string TotalPrice = row.Cells[4].Value.ToString();

                if (bus.ExportTextFile(filename, OrderID, EmployeeName, SupplietName, DateImport, TotalPrice))
                {
                    MessageBox.Show("Xuất phiếu nhập thành công","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    setNull();
                    return;
                }
            }
        }
    }
}
