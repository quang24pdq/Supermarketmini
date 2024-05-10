namespace MiniSupermarket.GUI
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); 
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnLogout = new Button();
            btnAccount = new Button();
            btnStatistic = new Button();
            btnSuppliers = new Button();
            btnPromotions = new Button();
            btnRoles = new Button();
            btnEmployees = new Button();
            btnImport = new Button();
            btnSale = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            btnProductType = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            bntMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnStatistic);
            panelMenu.Controls.Add(btnSuppliers);
            panelMenu.Controls.Add(btnPromotions);
            panelMenu.Controls.Add(btnRoles);
            panelMenu.Controls.Add(btnEmployees);
            panelMenu.Controls.Add(btnImport);
            panelMenu.Controls.Add(btnSale);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnProductType);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 867);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Gainsboro;
            btnLogout.Image = Properties.Resources.iconProduct;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 987);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(13, 0, 0, 0);
            btnLogout.Size = new Size(250, 80);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.ForeColor = Color.Gainsboro;
            btnAccount.Image = Properties.Resources.iconProduct;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 907);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(13, 0, 0, 0);
            btnAccount.Size = new Size(250, 80);
            btnAccount.TabIndex = 11;
            btnAccount.Text = "Tài khoản";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Dock = DockStyle.Top;
            btnStatistic.FlatAppearance.BorderSize = 0;
            btnStatistic.FlatStyle = FlatStyle.Flat;
            btnStatistic.ForeColor = Color.Gainsboro;
            btnStatistic.Image = Properties.Resources.iconProduct;
            btnStatistic.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistic.Location = new Point(0, 827);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Padding = new Padding(13, 0, 0, 0);
            btnStatistic.Size = new Size(250, 80);
            btnStatistic.TabIndex = 10;
            btnStatistic.Text = "Thống kê";
            btnStatistic.TextAlign = ContentAlignment.MiddleLeft;
            btnStatistic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.Gainsboro;
            btnSuppliers.Image = Properties.Resources.iconProduct;
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 747);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(13, 0, 0, 0);
            btnSuppliers.Size = new Size(250, 80);
            btnSuppliers.TabIndex = 9;
            btnSuppliers.Text = "Nhà cung cấp";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnPromotions
            // 
            btnPromotions.Dock = DockStyle.Top;
            btnPromotions.FlatAppearance.BorderSize = 0;
            btnPromotions.FlatStyle = FlatStyle.Flat;
            btnPromotions.ForeColor = Color.Gainsboro;
            btnPromotions.Image = Properties.Resources.iconProduct;
            btnPromotions.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromotions.Location = new Point(0, 667);
            btnPromotions.Name = "btnPromotions";
            btnPromotions.Padding = new Padding(13, 0, 0, 0);
            btnPromotions.Size = new Size(250, 80);
            btnPromotions.TabIndex = 8;
            btnPromotions.Text = "Chương trình khuyến mãi";
            btnPromotions.TextAlign = ContentAlignment.MiddleLeft;
            btnPromotions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPromotions.UseVisualStyleBackColor = true;
            btnPromotions.Click += btnPromotions_Click;
            // 
            // btnRoles
            // 
            btnRoles.Dock = DockStyle.Top;
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.ForeColor = Color.Gainsboro;
            btnRoles.Image = Properties.Resources.iconProduct;
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(0, 587);
            btnRoles.Name = "btnRoles";
            btnRoles.Padding = new Padding(13, 0, 0, 0);
            btnRoles.Size = new Size(250, 80);
            btnRoles.TabIndex = 7;
            btnRoles.Text = "Quyền";
            btnRoles.TextAlign = ContentAlignment.MiddleLeft;
            btnRoles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.ForeColor = Color.Gainsboro;
            btnEmployees.Image = Properties.Resources.iconProduct;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 507);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(13, 0, 0, 0);
            btnEmployees.Size = new Size(250, 80);
            btnEmployees.TabIndex = 6;
            btnEmployees.Text = "Nhân viên";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnImport
            // 
            btnImport.Dock = DockStyle.Top;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.ForeColor = Color.Gainsboro;
            btnImport.Image = Properties.Resources.iconProduct;
            btnImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImport.Location = new Point(0, 427);
            btnImport.Name = "btnImport";
            btnImport.Padding = new Padding(13, 0, 0, 0);
            btnImport.Size = new Size(250, 80);
            btnImport.TabIndex = 5;
            btnImport.Text = "Nhập hàng";
            btnImport.TextAlign = ContentAlignment.MiddleLeft;
            btnImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.ForeColor = Color.Gainsboro;
            btnSale.Image = Properties.Resources.iconProduct;
            btnSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnSale.Location = new Point(0, 347);
            btnSale.Name = "btnSale";
            btnSale.Padding = new Padding(13, 0, 0, 0);
            btnSale.Size = new Size(250, 80);
            btnSale.TabIndex = 4;
            btnSale.Text = "Bán hàng";
            btnSale.TextAlign = ContentAlignment.MiddleLeft;
            btnSale.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = Color.Gainsboro;
            btnCustomers.Image = Properties.Resources.iconProduct;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 267);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(13, 0, 0, 0);
            btnCustomers.Size = new Size(250, 80);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Khách hàng";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.Gainsboro;
            btnProducts.Image = Properties.Resources.iconProduct;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 187);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(13, 0, 0, 0);
            btnProducts.Size = new Size(250, 80);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Sản phẩm";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnProductType
            // 
            btnProductType.Dock = DockStyle.Top;
            btnProductType.FlatAppearance.BorderSize = 0;
            btnProductType.FlatStyle = FlatStyle.Flat;
            btnProductType.ForeColor = Color.Gainsboro;
            btnProductType.Image = Properties.Resources.iconProduct;
            btnProductType.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductType.Location = new Point(0, 107);
            btnProductType.Name = "btnProductType";
            btnProductType.Padding = new Padding(13, 0, 0, 0);
            btnProductType.Size = new Size(250, 80);
            btnProductType.TabIndex = 1;
            btnProductType.Text = "Loại sản phẩm";
            btnProductType.TextAlign = ContentAlignment.MiddleLeft;
            btnProductType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductType.UseVisualStyleBackColor = true;
            btnProductType.Click += btnProductType_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 107);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(80, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "TITLE";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Orange;
            panelTitleBar.Controls.Add(bntMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Margin = new Padding(3, 4, 3, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1489, 107);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove;
            // 
            // bntMinimize
            // 
            bntMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntMinimize.FlatAppearance.BorderSize = 0;
            bntMinimize.FlatStyle = FlatStyle.Flat;
            bntMinimize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntMinimize.ForeColor = Color.White;
            bntMinimize.Location = new Point(1369, 4);
            bntMinimize.Margin = new Padding(3, 4, 3, 4);
            bntMinimize.Name = "bntMinimize";
            bntMinimize.Size = new Size(34, 39);
            bntMinimize.TabIndex = 4;
            bntMinimize.Text = "O";
            bntMinimize.UseVisualStyleBackColor = true;
            bntMinimize.Click += bntMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1409, 4);
            btnMaximize.Margin = new Padding(3, 4, 3, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 39);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1450, 4);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 39);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.ForeColor = SystemColors.ActiveCaption;
            btnCloseChildForm.Image = Properties.Resources.iconX;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(94, 107);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(617, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(250, 107);
            panelDesktopPane.Margin = new Padding(3, 4, 3, 4);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1489, 760);
            panelDesktopPane.TabIndex = 2;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 867);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnProductType;
        private Button btnEmployees;
        private Button btnImport;
        private Button btnSale;
        private Button btnCustomers;
        private Button btnProducts;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Button btnClose;
        private Button btnMaximize;
        private Button bntMinimize;
        private Button btnSuppliers;
        private Button btnPromotions;
        private Button btnRoles;
        private Button btnStatistic;
        private Button btnAccount;
        private Button btnLogout;
    }
}