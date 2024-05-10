namespace MiniSupermarket.GUI
{
    partial class RoleForm
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
            bt_add = new Button();
            gb_Info = new GroupBox();
            btnUpdateFunction = new Button();
            ckStatistic = new CheckBox();
            ckSupplierManage = new CheckBox();
            ckPromotionManage = new CheckBox();
            ckRoleManage = new CheckBox();
            ckEmployeeManage = new CheckBox();
            ckSaleManage = new CheckBox();
            ckImportManage = new CheckBox();
            ckCustomerManage = new CheckBox();
            ckProductTypeManage = new CheckBox();
            ckProductMange = new CheckBox();
            bt_edit = new Button();
            bt_delete = new Button();
            bt_reset = new Button();
            gb_List = new GroupBox();
            ds_qlcv = new DataGridView();
            gb_Function = new GroupBox();
            gb_role = new GroupBox();
            rtb_explain = new RichTextBox();
            lb_explain = new Label();
            lb_name = new Label();
            tb_name = new TextBox();
            gb_Info.SuspendLayout();
            gb_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ds_qlcv).BeginInit();
            gb_Function.SuspendLayout();
            gb_role.SuspendLayout();
            SuspendLayout();
            // 
            // bt_add
            // 
            bt_add.Location = new Point(25, 53);
            bt_add.Margin = new Padding(2);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(90, 32);
            bt_add.TabIndex = 2;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // gb_Info
            // 
            gb_Info.Controls.Add(btnUpdateFunction);
            gb_Info.Controls.Add(ckStatistic);
            gb_Info.Controls.Add(ckSupplierManage);
            gb_Info.Controls.Add(ckPromotionManage);
            gb_Info.Controls.Add(ckRoleManage);
            gb_Info.Controls.Add(ckEmployeeManage);
            gb_Info.Controls.Add(ckSaleManage);
            gb_Info.Controls.Add(ckImportManage);
            gb_Info.Controls.Add(ckCustomerManage);
            gb_Info.Controls.Add(ckProductTypeManage);
            gb_Info.Controls.Add(ckProductMange);
            gb_Info.Location = new Point(10, 206);
            gb_Info.Margin = new Padding(2);
            gb_Info.Name = "gb_Info";
            gb_Info.Padding = new Padding(2);
            gb_Info.Size = new Size(1041, 208);
            gb_Info.TabIndex = 3;
            gb_Info.TabStop = false;
            gb_Info.Text = "Chức năng";
            // 
            // btnUpdateFunction
            // 
            btnUpdateFunction.Location = new Point(896, 128);
            btnUpdateFunction.Name = "btnUpdateFunction";
            btnUpdateFunction.Size = new Size(125, 60);
            btnUpdateFunction.TabIndex = 10;
            btnUpdateFunction.Text = "Cập nhật chức năng";
            btnUpdateFunction.UseVisualStyleBackColor = true;
            btnUpdateFunction.Click += btnUpdateFunction_Click;
            // 
            // ckStatistic
            // 
            ckStatistic.AutoSize = true;
            ckStatistic.Location = new Point(820, 47);
            ckStatistic.Name = "ckStatistic";
            ckStatistic.Size = new Size(92, 24);
            ckStatistic.TabIndex = 9;
            ckStatistic.Tag = "F0010";
            ckStatistic.Text = "Thống kê";
            ckStatistic.UseVisualStyleBackColor = true;
            // 
            // ckSupplierManage
            // 
            ckSupplierManage.AutoSize = true;
            ckSupplierManage.Location = new Point(555, 147);
            ckSupplierManage.Name = "ckSupplierManage";
            ckSupplierManage.Size = new Size(173, 24);
            ckSupplierManage.TabIndex = 8;
            ckSupplierManage.Tag = "F0009";
            ckSupplierManage.Text = "Quản lý nhà cung cấp";
            ckSupplierManage.UseVisualStyleBackColor = true;
            // 
            // ckPromotionManage
            // 
            ckPromotionManage.AutoSize = true;
            ckPromotionManage.Location = new Point(555, 97);
            ckPromotionManage.Name = "ckPromotionManage";
            ckPromotionManage.Size = new Size(248, 24);
            ckPromotionManage.TabIndex = 7;
            ckPromotionManage.Tag = "F0008";
            ckPromotionManage.Text = "Quản lý chương trình khuyến mãi";
            ckPromotionManage.UseVisualStyleBackColor = true;
            // 
            // ckRoleManage
            // 
            ckRoleManage.AutoSize = true;
            ckRoleManage.Location = new Point(555, 47);
            ckRoleManage.Name = "ckRoleManage";
            ckRoleManage.Size = new Size(125, 24);
            ckRoleManage.TabIndex = 6;
            ckRoleManage.Tag = "F0007";
            ckRoleManage.Text = "Quản lý quyền";
            ckRoleManage.UseVisualStyleBackColor = true;
            // 
            // ckEmployeeManage
            // 
            ckEmployeeManage.AutoSize = true;
            ckEmployeeManage.Location = new Point(290, 147);
            ckEmployeeManage.Name = "ckEmployeeManage";
            ckEmployeeManage.Size = new Size(148, 24);
            ckEmployeeManage.TabIndex = 5;
            ckEmployeeManage.Tag = "F0006";
            ckEmployeeManage.Text = "Quản lý nhân viên";
            ckEmployeeManage.UseVisualStyleBackColor = true;
            // 
            // ckSaleManage
            // 
            ckSaleManage.AutoSize = true;
            ckSaleManage.Location = new Point(290, 97);
            ckSaleManage.Name = "ckSaleManage";
            ckSaleManage.Size = new Size(147, 24);
            ckSaleManage.TabIndex = 4;
            ckSaleManage.Tag = "F0005";
            ckSaleManage.Text = "Quản lý bán hàng";
            ckSaleManage.UseVisualStyleBackColor = true;
            // 
            // ckImportManage
            // 
            ckImportManage.AutoSize = true;
            ckImportManage.Location = new Point(290, 47);
            ckImportManage.Name = "ckImportManage";
            ckImportManage.Size = new Size(155, 24);
            ckImportManage.TabIndex = 3;
            ckImportManage.Tag = "F0004";
            ckImportManage.Text = "Quản lý nhập hàng";
            ckImportManage.UseVisualStyleBackColor = true;
            // 
            // ckCustomerManage
            // 
            ckCustomerManage.AutoSize = true;
            ckCustomerManage.Location = new Point(25, 147);
            ckCustomerManage.Name = "ckCustomerManage";
            ckCustomerManage.Size = new Size(160, 24);
            ckCustomerManage.TabIndex = 2;
            ckCustomerManage.Tag = "F0003";
            ckCustomerManage.Text = "Quản lý khách hàng";
            ckCustomerManage.UseVisualStyleBackColor = true;
            // 
            // ckProductTypeManage
            // 
            ckProductTypeManage.AutoSize = true;
            ckProductTypeManage.Location = new Point(25, 97);
            ckProductTypeManage.Name = "ckProductTypeManage";
            ckProductTypeManage.Size = new Size(178, 24);
            ckProductTypeManage.TabIndex = 1;
            ckProductTypeManage.Tag = "F0002";
            ckProductTypeManage.Text = "Quản lý loại sản phẩm";
            ckProductTypeManage.UseVisualStyleBackColor = true;
            // 
            // ckProductMange
            // 
            ckProductMange.AutoSize = true;
            ckProductMange.Location = new Point(25, 47);
            ckProductMange.Name = "ckProductMange";
            ckProductMange.Size = new Size(149, 24);
            ckProductMange.TabIndex = 0;
            ckProductMange.Tag = "F0001";
            ckProductMange.Text = "Quản lý sản phẩm";
            ckProductMange.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(25, 119);
            bt_edit.Margin = new Padding(2);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(90, 32);
            bt_edit.TabIndex = 7;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(25, 186);
            bt_delete.Margin = new Padding(2);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(90, 32);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Xoá";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_reset
            // 
            bt_reset.Location = new Point(25, 252);
            bt_reset.Margin = new Padding(2);
            bt_reset.Name = "bt_reset";
            bt_reset.Size = new Size(90, 32);
            bt_reset.TabIndex = 9;
            bt_reset.Text = "Reset";
            bt_reset.UseVisualStyleBackColor = true;
            bt_reset.Click += bt_reset_Click;
            // 
            // gb_List
            // 
            gb_List.Controls.Add(ds_qlcv);
            gb_List.Location = new Point(10, 419);
            gb_List.Margin = new Padding(2);
            gb_List.Name = "gb_List";
            gb_List.Padding = new Padding(2);
            gb_List.Size = new Size(1230, 340);
            gb_List.TabIndex = 10;
            gb_List.TabStop = false;
            gb_List.Text = "Dach sách quyền";
            // 
            // ds_qlcv
            // 
            ds_qlcv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ds_qlcv.Dock = DockStyle.Fill;
            ds_qlcv.Location = new Point(2, 22);
            ds_qlcv.Margin = new Padding(2);
            ds_qlcv.Name = "ds_qlcv";
            ds_qlcv.RowHeadersWidth = 62;
            ds_qlcv.RowTemplate.Height = 33;
            ds_qlcv.Size = new Size(1226, 316);
            ds_qlcv.TabIndex = 0;
            ds_qlcv.CellClick += ds_qlcv_CellClick;
            // 
            // gb_Function
            // 
            gb_Function.Controls.Add(bt_add);
            gb_Function.Controls.Add(bt_reset);
            gb_Function.Controls.Add(bt_edit);
            gb_Function.Controls.Add(bt_delete);
            gb_Function.Location = new Point(1070, 67);
            gb_Function.Margin = new Padding(2);
            gb_Function.Name = "gb_Function";
            gb_Function.Padding = new Padding(2);
            gb_Function.Size = new Size(170, 347);
            gb_Function.TabIndex = 11;
            gb_Function.TabStop = false;
            gb_Function.Text = "Chức năng";
            // 
            // gb_role
            // 
            gb_role.Controls.Add(rtb_explain);
            gb_role.Controls.Add(lb_explain);
            gb_role.Controls.Add(lb_name);
            gb_role.Controls.Add(tb_name);
            gb_role.Location = new Point(14, 67);
            gb_role.Margin = new Padding(2);
            gb_role.Name = "gb_role";
            gb_role.Padding = new Padding(2);
            gb_role.Size = new Size(1036, 134);
            gb_role.TabIndex = 12;
            gb_role.TabStop = false;
            gb_role.Text = "Quyền";
            // 
            // rtb_explain
            // 
            rtb_explain.Location = new Point(505, 36);
            rtb_explain.Margin = new Padding(2);
            rtb_explain.Name = "rtb_explain";
            rtb_explain.Size = new Size(512, 86);
            rtb_explain.TabIndex = 3;
            rtb_explain.Text = "";
            // 
            // lb_explain
            // 
            lb_explain.AutoSize = true;
            lb_explain.Location = new Point(366, 36);
            lb_explain.Margin = new Padding(2, 0, 2, 0);
            lb_explain.Name = "lb_explain";
            lb_explain.Size = new Size(48, 20);
            lb_explain.TabIndex = 2;
            lb_explain.Text = "Mô tả";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(5, 36);
            lb_name.Margin = new Padding(2, 0, 2, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(76, 20);
            lb_name.TabIndex = 1;
            lb_name.Text = "Tên quyền";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(114, 33);
            tb_name.Margin = new Padding(2);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(199, 27);
            tb_name.TabIndex = 0;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 770);
            Controls.Add(gb_role);
            Controls.Add(gb_Function);
            Controls.Add(gb_List);
            Controls.Add(gb_Info);
            Margin = new Padding(2);
            Name = "RoleForm";
            Text = "RoleForm";
            Load += RoleForm_Load;
            gb_Info.ResumeLayout(false);
            gb_Info.PerformLayout();
            gb_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ds_qlcv).EndInit();
            gb_Function.ResumeLayout(false);
            gb_role.ResumeLayout(false);
            gb_role.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button bt_add;
        private GroupBox gb_Info;
        private Button bt_edit;
        private Button bt_delete;
        private Button bt_reset;
        private GroupBox gb_List;
        private DataGridView ds_qlcv;
        private GroupBox gb_Function;
        private GroupBox gb_role;
        private RichTextBox rtb_explain;
        private Label lb_explain;
        private Label lb_name;
        private TextBox tb_name;
        private CheckBox ckStatistic;
        private CheckBox ckSupplierManage;
        private CheckBox ckPromotionManage;
        private CheckBox ckRoleManage;
        private CheckBox ckEmployeeManage;
        private CheckBox ckSaleManage;
        private CheckBox ckImportManage;
        private CheckBox ckCustomerManage;
        private CheckBox ckProductTypeManage;
        private CheckBox ckProductMange;
        private Button btnUpdateFunction;
    }
}