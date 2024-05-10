using MiniSupermarket.BUS;
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

namespace MiniSupermarket.GUI
{
    public partial class DetailPurchaseOrderForm : Form
    {
        private string purchaseOrderID, status, supplierID;
        private DetailPurchaseOrderBUS bus = new DetailPurchaseOrderBUS();
        private PurchaseOderForm OrderForm;
        public DetailPurchaseOrderForm(string PurchaseOrderID, string Status, string SupplierID, PurchaseOderForm OrderForm)
        {
            InitializeComponent();
            purchaseOrderID = PurchaseOrderID;
            status = Status;
            supplierID = SupplierID;
            this.OrderForm = OrderForm;
        }

        private void DetailPurchaseOrderForm_Load(object sender, EventArgs e)
        {
            lblProductOrder.Text = lblProductOrder.Text + " " + purchaseOrderID;
            ShowProducts();
            LoadTheme();
            nudQuantity.Value = 0;
            txtProductID.ReadOnly = true;
            txtProductName.ReadOnly = true;
            dgvProductOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (status.Equals("1"))
            {
                Payed();
            }
            dgvProducts.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProducts.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProducts.Columns[2].HeaderText = "Số lượng";
            dgvProducts.Columns[3].HeaderText = "Đơn vị";

            dgvProductOrders.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProductOrders.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProductOrders.Columns[2].HeaderText = "Số lượng";
            dgvProductOrders.Columns[3].HeaderText = "Đơn vị";
            dgvProductOrders.Columns[4].HeaderText = "Giá nhập";
            cbxTypeOfSearch.SelectedIndex = 0;
            cbxTypeOfSearchOrder.SelectedIndex = 0;

            nudQuantity.Maximum = int.MaxValue;
        }

        void Payed()
        {
            txtOrderPrice.ReadOnly = true;
            nudQuantity.ReadOnly = true;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnPay.Enabled = false;
        }

        void LoadTheme()
        {
            foreach (Control controls in this.pnlInformation.Controls)
            {
                if (controls.GetType() == typeof(Label))
                {
                    Label lb = (Label)controls;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }

                else if (controls.GetType() == typeof(Button))
                {
                    Button btn = (Button)controls;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                lblProduct.Font = ProjectFont.getTitleFont();
                lblProductOrder.Font = ProjectFont.getTitleFont();
                btnPay.BackColor = ThemeColor.PrimaryColor;
                btnPay.ForeColor = Color.White;
                btnPay.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }

        public void ShowProducts()
        {
            dgvProducts.DataSource = bus.getProducts(purchaseOrderID, supplierID);
            dgvProductOrders.DataSource = bus.getProductOrders(purchaseOrderID);
        }



        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (status.Equals("0"))
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                txtProductID.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                txtOrderPrice.Text = "";
                nudQuantity.Value = 0;
            }
            else
            {
                MessageBox.Show("Bạn không thể thao tác khi phiếu nhập đã thanh toán",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setNull();
            ShowProducts();
        }

        void setNull()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtOrderPrice.Text = "";
            nudQuantity.Value = 0;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string orderID = purchaseOrderID;
            string productID = txtProductID.Text;
            string orderPrice = txtOrderPrice.Text;
            string quantity = nudQuantity.Value.ToString();
            if (orderID.Length == 0)
            {
                MessageBox.Show("Vui lòng để chọn sản phẩm bên dưới",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (orderPrice.Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống giá nhập vủa sản phẩm",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (quantity.Length == 0)
            {
                MessageBox.Show("Vui lòng không để số lượng nhập vủa sản phẩm",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            int orderPriceInt = Convert.ToInt32(orderPrice);
            int quantityInt = Convert.ToInt32(quantity);
            if (orderPriceInt <= 0)
            {
                MessageBox.Show("Giá nhập của sản phẩm phải là số nguyên dương",
                           "Thông báo",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                return;
            }
            if (quantityInt <= 0)
            {
                MessageBox.Show("Số lượng nhập của sản phẩm phải là số nguyên dương",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (bus.AddProductToDetailOrder(orderID, productID, orderPrice, quantity))
            {
                MessageBox.Show("Thêm sản phẩm vào chi tiết phiếu nhập thành công.", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowProducts();
                setNull();
                return;
            }
        }

        private void dgvProductOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status.Equals("0"))
            {
                DataGridViewRow row = dgvProductOrders.SelectedRows[0];
                string OrderID = purchaseOrderID;
                string ProductID = row.Cells[0].Value.ToString();
                DialogResult choice = MessageBox.Show($"Bạn có muốn chắc muốn xoá sản phẩm {ProductID} khỏi phiếu nhập không?", "Xoá sản phẩm khỏi phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    if (bus.DeleteProductFromDetailOrder(OrderID, ProductID))
                    {
                        MessageBox.Show($"Xoá sản phẩm {ProductID} khỏi chi tiết phiếu nhập thành công.", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowProducts();
                        setNull();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không thể sửa phiếu nhập đã thanh toán",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (bus.getProductOrders(purchaseOrderID).Rows.Count <= 0)
            {
                MessageBox.Show("Phiếu nhập không có sản phẩm để thanh toán",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (bus.PayPurchaseOrder(purchaseOrderID))
                {
                    MessageBox.Show($"Thanh toán phiếu nhập {purchaseOrderID} thành công", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowProducts();
                    setNull();
                    Payed();
                    OrderForm.HienThiPhieuNhap();
                    this.Close();
                    return;
                }
            }
        }

        public void FilterProducts()
        {
            int index_Type_Search = cbxTypeOfSearch.SelectedIndex;
            string key_Search = txtSearch.Text.ToLower();

            DataTable promotions = bus.getProducts(purchaseOrderID, supplierID);
            DataTable searchPromotion = promotions.Clone();

            foreach (DataRow row in promotions.Rows)
            {
                string rowID = row[0].ToString().ToLower();
                string rowName = row[1].ToString().ToLower();

                switch (index_Type_Search)
                {
                    case 0:
                        if (rowID.Contains(key_Search))
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                    case 1:
                        if (rowName.Contains(key_Search))
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                }
            }
            dgvProducts.DataSource = searchPromotion;
        }

        public void FilterProductOrders()
        {
            int index_Type_Search = cbxTypeOfSearchOrder.SelectedIndex;
            string key_Search = txtSearchOrder.Text.ToLower();

            DataTable promotions = bus.getProductOrders(purchaseOrderID);
            DataTable searchPromotion = promotions.Clone();

            foreach (DataRow row in promotions.Rows)
            {
                string rowID = row[0].ToString().ToLower();
                string rowName = row[1].ToString().ToLower();

                switch (index_Type_Search)
                {
                    case 0:
                        if (rowID.Contains(key_Search))
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                    case 1:
                        if (rowName.Contains(key_Search))
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                }
            }
            dgvProductOrders.DataSource = searchPromotion;
        }

        private void txtSearchOrder_KeyUp(object sender, KeyEventArgs e)
        {
            FilterProductOrders();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FilterProducts();
        }

        private void txtOrderPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
