namespace MiniSupermarket.BUS
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            btn_xuatexcel = new Button();
            cb_role = new ComboBox();
            ds_qlnv = new DataGridView();
            btn_reset = new Button();
            label5 = new Label();
            tb_pass = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gb_Info = new GroupBox();
            tb_address = new TextBox();
            tb_email = new TextBox();
            label1 = new Label();
            cb_sex = new ComboBox();
            label8 = new Label();
            tb_pNumber = new TextBox();
            label7 = new Label();
            dtp_birth = new DateTimePicker();
            label6 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtUserName = new TextBox();
            gb_Function = new GroupBox();
            tb_find = new TextBox();
            cb_find = new ComboBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_find = new Button();
            gb_List = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ds_qlnv).BeginInit();
            gb_Info.SuspendLayout();
            gb_Function.SuspendLayout();
            gb_List.SuspendLayout();
            SuspendLayout();
            // 
            // btn_xuatexcel
            // 
            btn_xuatexcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xuatexcel.Image = (Image)resources.GetObject("btn_xuatexcel.Image");
            btn_xuatexcel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xuatexcel.Location = new Point(148, 158);
            btn_xuatexcel.Margin = new Padding(2);
            btn_xuatexcel.Name = "btn_xuatexcel";
            btn_xuatexcel.Size = new Size(131, 42);
            btn_xuatexcel.TabIndex = 2;
            btn_xuatexcel.Text = "Xuất File";
            btn_xuatexcel.TextAlign = ContentAlignment.MiddleRight;
            btn_xuatexcel.UseVisualStyleBackColor = true;
            btn_xuatexcel.Click += btn_xuatexcel_Click;
            // 
            // cb_role
            // 
            cb_role.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_role.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(606, 289);
            cb_role.Margin = new Padding(2);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(241, 38);
            cb_role.TabIndex = 7;
            cb_role.TabStop = false;
            // 
            // ds_qlnv
            // 
            ds_qlnv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ds_qlnv.Dock = DockStyle.Fill;
            ds_qlnv.Location = new Point(2, 29);
            ds_qlnv.Margin = new Padding(2);
            ds_qlnv.Name = "ds_qlnv";
            ds_qlnv.RowHeadersVisible = false;
            ds_qlnv.RowHeadersWidth = 62;
            ds_qlnv.RowTemplate.Height = 33;
            ds_qlnv.Size = new Size(1482, 267);
            ds_qlnv.TabIndex = 9;
            // 
            // btn_reset
            // 
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reset.Image = (Image)resources.GetObject("btn_reset.Image");
            btn_reset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reset.Location = new Point(23, 95);
            btn_reset.Margin = new Padding(2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(102, 38);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.TextAlign = ContentAlignment.MiddleRight;
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(5, 294);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 23;
            label5.Text = "Giới Tính:";
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(186, 223);
            tb_pass.Margin = new Padding(2);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(241, 34);
            tb_pass.TabIndex = 4;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(186, 95);
            tb_name.Margin = new Padding(2);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(241, 34);
            tb_name.TabIndex = 2;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(186, 34);
            tb_id.Margin = new Padding(2);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(241, 34);
            tb_id.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(5, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 19;
            label4.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 226);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 18;
            label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 17;
            label2.Text = "Mã Nhân Viên:";
            // 
            // gb_Info
            // 
            gb_Info.Controls.Add(tb_address);
            gb_Info.Controls.Add(tb_email);
            gb_Info.Controls.Add(label1);
            gb_Info.Controls.Add(cb_sex);
            gb_Info.Controls.Add(cb_role);
            gb_Info.Controls.Add(label8);
            gb_Info.Controls.Add(tb_pNumber);
            gb_Info.Controls.Add(label7);
            gb_Info.Controls.Add(dtp_birth);
            gb_Info.Controls.Add(label6);
            gb_Info.Controls.Add(label2);
            gb_Info.Controls.Add(label10);
            gb_Info.Controls.Add(label3);
            gb_Info.Controls.Add(label9);
            gb_Info.Controls.Add(label5);
            gb_Info.Controls.Add(label4);
            gb_Info.Controls.Add(txtUserName);
            gb_Info.Controls.Add(tb_pass);
            gb_Info.Controls.Add(tb_id);
            gb_Info.Controls.Add(tb_name);
            gb_Info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_Info.Location = new Point(10, 40);
            gb_Info.Margin = new Padding(2);
            gb_Info.Name = "gb_Info";
            gb_Info.Padding = new Padding(2);
            gb_Info.Size = new Size(962, 333);
            gb_Info.TabIndex = 25;
            gb_Info.TabStop = false;
            gb_Info.Text = "Thông Tin Nhân Viên";
            // 
            // tb_address
            // 
            tb_address.Location = new Point(606, 223);
            tb_address.Margin = new Padding(2);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(333, 34);
            tb_address.TabIndex = 7;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(606, 160);
            tb_email.Margin = new Padding(2);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(333, 34);
            tb_email.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(464, 226);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 30;
            label1.Text = "Địa Chỉ:";
            // 
            // cb_sex
            // 
            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cb_sex.FormattingEnabled = true;
            cb_sex.Location = new Point(186, 289);
            cb_sex.Margin = new Padding(2);
            cb_sex.Name = "cb_sex";
            cb_sex.Size = new Size(241, 38);
            cb_sex.TabIndex = 5;
            cb_sex.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(464, 158);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 30;
            label8.Text = "Email:";
            // 
            // tb_pNumber
            // 
            tb_pNumber.Location = new Point(606, 95);
            tb_pNumber.Margin = new Padding(2);
            tb_pNumber.Name = "tb_pNumber";
            tb_pNumber.Size = new Size(333, 34);
            tb_pNumber.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(464, 96);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 32);
            label7.TabIndex = 28;
            label7.Text = "SĐT:";
            // 
            // dtp_birth
            // 
            dtp_birth.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtp_birth.Location = new Point(606, 35);
            dtp_birth.Margin = new Padding(2);
            dtp_birth.Name = "dtp_birth";
            dtp_birth.Size = new Size(333, 30);
            dtp_birth.TabIndex = 27;
            dtp_birth.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(464, 36);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 32);
            label6.TabIndex = 26;
            label6.Text = "Ngày Sinh:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(5, 158);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 32);
            label10.TabIndex = 18;
            label10.Text = "Username:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(464, 294);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(143, 32);
            label9.TabIndex = 23;
            label9.Text = "Phân quyền";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(186, 160);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(241, 34);
            txtUserName.TabIndex = 3;
            // 
            // gb_Function
            // 
            gb_Function.Controls.Add(tb_find);
            gb_Function.Controls.Add(cb_find);
            gb_Function.Controls.Add(btn_add);
            gb_Function.Controls.Add(btn_edit);
            gb_Function.Controls.Add(btn_xuatexcel);
            gb_Function.Controls.Add(btn_delete);
            gb_Function.Controls.Add(btn_reset);
            gb_Function.Controls.Add(btn_find);
            gb_Function.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_Function.Location = new Point(953, 40);
            gb_Function.Margin = new Padding(2);
            gb_Function.Name = "gb_Function";
            gb_Function.Padding = new Padding(2);
            gb_Function.Size = new Size(293, 333);
            gb_Function.TabIndex = 27;
            gb_Function.TabStop = false;
            gb_Function.Text = "Chức Năng";
            // 
            // tb_find
            // 
            tb_find.Location = new Point(23, 278);
            tb_find.Margin = new Padding(2);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(228, 34);
            tb_find.TabIndex = 8;
            // 
            // cb_find
            // 
            cb_find.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_find.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cb_find.FormattingEnabled = true;
            cb_find.Location = new Point(23, 220);
            cb_find.Margin = new Padding(2);
            cb_find.Name = "cb_find";
            cb_find.Size = new Size(228, 39);
            cb_find.TabIndex = 25;
            cb_find.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(23, 36);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(102, 39);
            btn_add.TabIndex = 22;
            btn_add.Text = "Thêm";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(148, 36);
            btn_edit.Margin = new Padding(2);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(102, 39);
            btn_edit.TabIndex = 22;
            btn_edit.Text = "Sửa";
            btn_edit.TextAlign = ContentAlignment.MiddleRight;
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(148, 96);
            btn_delete.Margin = new Padding(2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 39);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "Xoá";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_find.Image = (Image)resources.GetObject("btn_find.Image");
            btn_find.ImageAlign = ContentAlignment.MiddleLeft;
            btn_find.Location = new Point(23, 160);
            btn_find.Margin = new Padding(2);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(102, 45);
            btn_find.TabIndex = 8;
            btn_find.Text = "Tìm";
            btn_find.TextAlign = ContentAlignment.MiddleRight;
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // gb_List
            // 
            gb_List.Controls.Add(ds_qlnv);
            gb_List.Dock = DockStyle.Bottom;
            gb_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_List.Location = new Point(0, 377);
            gb_List.Margin = new Padding(2);
            gb_List.Name = "gb_List";
            gb_List.Padding = new Padding(2);
            gb_List.Size = new Size(1486, 298);
            gb_List.TabIndex = 28;
            gb_List.TabStop = false;
            gb_List.Text = "Danh Sách Nhân Viên";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 675);
            Controls.Add(gb_List);
            Controls.Add(gb_Function);
            Controls.Add(gb_Info);
            Margin = new Padding(2);
            Name = "EmployeeForm";
            Text = "EmployeeManage";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)ds_qlnv).EndInit();
            gb_Info.ResumeLayout(false);
            gb_Info.PerformLayout();
            gb_Function.ResumeLayout(false);
            gb_Function.PerformLayout();
            gb_List.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_exel;
        private ComboBox cb_role;
        private DataGridView ds_qlnv;
        private Button btn_reset;
        private Label label5;
        private TextBox tb_pass;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox gb_Info;
        private TextBox tb_email;
        private Label label8;
        private TextBox tb_pNumber;
        private Label label7;
        private DateTimePicker dtp_birth;
        private Label label6;
        private GroupBox gb_Function;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_find;
        private GroupBox gb_List;
        private Button btn_add;
        private Label label1;
        private TextBox tb_address;
        private TextBox tb_find;
        private ComboBox cb_find;
        private Label label9;
        private ComboBox cb_sex;
        private Button btn_xuatexcel;
        private Label label10;
        private Label label11;
        private TextBox txtUserName;
        private TextBox textBox2;
    }
}