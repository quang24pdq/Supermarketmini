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
    public partial class DetailPronmotionForm : Form
    {
        private DetailPromotionBUS bus = new DetailPromotionBUS();
        private string promotionID;
        public DetailPronmotionForm(string PromotionID)
        {
            InitializeComponent();
            promotionID = PromotionID;
        }

        void LoadTheme()
        {
            lblTitleProduct.Font = ProjectFont.getTitleFont();
            lblTitleProduct.ForeColor = ThemeColor.SecondaryColor;

            lblTitlePromotion.Font = ProjectFont.getTitleFont();
            lblTitlePromotion.ForeColor = ThemeColor.SecondaryColor;
        }

        public void ShowListProduct()
        {
            dgvProductPromotions.DataSource = bus.getProductPromotions(promotionID);
            dgvProducts.DataSource = bus.getProducts(promotionID);

        }

        private void dgvProductPromotions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProductPromotions.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            if (bus.DeleteProductFromDetailPromotion(id))
            {
                MessageBox.Show("Xoá sản phẩm khỏi danh sách khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowListProduct();
            }
        }

        private void dgvProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProducts.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            string ingPromotionID = bus.getPromotionIDFromProductID(id);
            string currentPromtotionID = promotionID;
            if (!ingPromotionID.Equals(""))
            {
                DialogResult choice = MessageBox.Show($"Sản phẩm này đang được khuyến mãi ở chương trình khuyến mãi {ingPromotionID}, bạn có muốn thay đổi sang chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (choice == DialogResult.Yes)
                {
                    if (bus.AddProductFromDetailPromotion(id, currentPromtotionID))
                    {
                        MessageBox.Show("Thêm sản phẩm vào danh sách khuyến mãi thành công danh sách khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowListProduct();
                    }
                }
            }
            else
            {
                if (bus.AddProductFromDetailPromotion(id, currentPromtotionID))
                {
                    MessageBox.Show("Thêm sản phẩm vào danh sách khuyến mãi thành công danh sách khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowListProduct();
                }
            }
        }

        private void DetailPronmotionForm_Load_1(object sender, EventArgs e)
        {
            ShowListProduct();
            lblTitlePromotion.Text = lblTitlePromotion.Text + " " + promotionID;
            dgvProductPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProducts.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProducts.Columns[2].HeaderText = "Loại sản phẩm";
            dgvProducts.Columns[3].HeaderText = "Mã CTKM";
            dgvProducts.Columns[4].HeaderText = "Mô tả";

            dgvProductPromotions.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProductPromotions.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProductPromotions.Columns[2].HeaderText = "Loại sản phẩm";
            dgvProductPromotions.Columns[3].HeaderText = "Mô tả";
            LoadTheme();
            cbxTypeSearch.SelectedIndex = 0;
            cbxTypeOfSearchPromotion.SelectedIndex = 0;
        }

        public void FilterProducts()
        {
            int index_Type_Search = cbxTypeSearch.SelectedIndex;
            string key_Search = txtSearch.Text.ToLower();

            DataTable promotions = bus.getProducts(promotionID);
            DataTable searchPromotion = promotions.Clone();

            foreach (DataRow row in promotions.Rows)
            {
                string rowID = row[0].ToString().ToLower();
                string rowName = row[1].ToString().ToLower();
                string rowType = row[2].ToString().ToLower();

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
                    case 2:
                        if (rowType.Contains(key_Search))
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                }
            }
            dgvProducts.DataSource = searchPromotion;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FilterProducts();
        }

        public void FilterProductPromotions()
        {
            int index_Type_Search = cbxTypeOfSearchPromotion.SelectedIndex;
            string key_Search = txtSearchPromotion.Text.ToLower();

            DataTable promotions = bus.getProductPromotions(promotionID);
            DataTable searchPromotion = promotions.Clone();

            foreach (DataRow row in promotions.Rows)
            {
                string rowID = row[0].ToString().ToLower();
                string rowName = row[1].ToString().ToLower();
                string rowType = row[2].ToString().ToLower();

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
                    case 2:
                        if (rowType.Contains(key_Search))
                        {
                            searchPromotion.ImportRow(row);
                        }
                        break;
                }
            }
            dgvProductPromotions.DataSource = searchPromotion;
        }

        private void txtSearchPromotion_KeyUp(object sender, KeyEventArgs e)
        {
            FilterProductPromotions();
        }
    }
}
