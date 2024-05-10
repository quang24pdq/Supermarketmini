namespace MiniSupermarket.GUI
{
    partial class UserAccount
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
            pnlLeft = new Panel();
            txtPhone = new TextBox();
            btnReload = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtEmName = new TextBox();
            txtEmID = new TextBox();
            lbEmail = new Label();
            lbPhone = new Label();
            lbAddress = new Label();
            lbEmName = new Label();
            lbEmID = new Label();
            lbInfor = new Label();
            pnlRight = new Panel();
            chkShowPassword = new CheckBox();
            btnChangePass = new Button();
            lbChangePass = new Label();
            txtConfirmPass = new TextBox();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            lbOldPass = new Label();
            lbNewPass = new Label();
            lbComfirmPass = new Label();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(txtPhone);
            pnlLeft.Controls.Add(btnReload);
            pnlLeft.Controls.Add(btnUpdate);
            pnlLeft.Controls.Add(txtEmail);
            pnlLeft.Controls.Add(txtAddress);
            pnlLeft.Controls.Add(txtEmName);
            pnlLeft.Controls.Add(txtEmID);
            pnlLeft.Controls.Add(lbEmail);
            pnlLeft.Controls.Add(lbPhone);
            pnlLeft.Controls.Add(lbAddress);
            pnlLeft.Controls.Add(lbEmName);
            pnlLeft.Controls.Add(lbEmID);
            pnlLeft.Controls.Add(lbInfor);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(412, 450);
            pnlLeft.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(151, 238);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(241, 27);
            txtPhone.TabIndex = 2;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // btnReload
            // 
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Location = new Point(225, 351);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(151, 50);
            btnReload.TabIndex = 12;
            btnReload.TabStop = false;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(38, 351);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 50);
            btnUpdate.TabIndex = 11;
            btnUpdate.TabStop = false;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 3;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(151, 165);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(241, 50);
            txtAddress.TabIndex = 1;
            // 
            // txtEmName
            // 
            txtEmName.Location = new Point(151, 115);
            txtEmName.Name = "txtEmName";
            txtEmName.Size = new Size(241, 27);
            txtEmName.TabIndex = 7;
            txtEmName.TabStop = false;
            // 
            // txtEmID
            // 
            txtEmID.Location = new Point(151, 65);
            txtEmID.Name = "txtEmID";
            txtEmID.Size = new Size(241, 27);
            txtEmID.TabIndex = 6;
            txtEmID.TabStop = false;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(12, 292);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(12, 237);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(97, 20);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Số điện thoại";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(12, 182);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(55, 20);
            lbAddress.TabIndex = 3;
            lbAddress.Text = "Địa chỉ";
            // 
            // lbEmName
            // 
            lbEmName.AutoSize = true;
            lbEmName.Location = new Point(12, 127);
            lbEmName.Name = "lbEmName";
            lbEmName.Size = new Size(99, 20);
            lbEmName.TabIndex = 2;
            lbEmName.Text = "Tên nhân viên";
            // 
            // lbEmID
            // 
            lbEmID.AutoSize = true;
            lbEmID.Location = new Point(12, 72);
            lbEmID.Name = "lbEmID";
            lbEmID.Size = new Size(97, 20);
            lbEmID.TabIndex = 1;
            lbEmID.Text = "Mã nhân viên";
            // 
            // lbInfor
            // 
            lbInfor.AutoSize = true;
            lbInfor.Location = new Point(125, 19);
            lbInfor.Name = "lbInfor";
            lbInfor.Size = new Size(127, 20);
            lbInfor.TabIndex = 0;
            lbInfor.Text = "Thông tin cá nhân";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(chkShowPassword);
            pnlRight.Controls.Add(btnChangePass);
            pnlRight.Controls.Add(lbChangePass);
            pnlRight.Controls.Add(txtConfirmPass);
            pnlRight.Controls.Add(txtOldPass);
            pnlRight.Controls.Add(txtNewPass);
            pnlRight.Controls.Add(lbOldPass);
            pnlRight.Controls.Add(lbNewPass);
            pnlRight.Controls.Add(lbComfirmPass);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(412, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(483, 450);
            pnlRight.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(84, 246);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(127, 24);
            chkShowPassword.TabIndex = 15;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnChangePass
            // 
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Location = new Point(259, 232);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(151, 50);
            btnChangePass.TabIndex = 12;
            btnChangePass.TabStop = false;
            btnChangePass.Text = "Đổi mật khẩu";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // lbChangePass
            // 
            lbChangePass.AutoSize = true;
            lbChangePass.Location = new Point(160, 19);
            lbChangePass.Name = "lbChangePass";
            lbChangePass.Size = new Size(98, 20);
            lbChangePass.TabIndex = 12;
            lbChangePass.Text = "Đổi mật khẩu";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(214, 177);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(241, 27);
            txtConfirmPass.TabIndex = 6;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(214, 65);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(241, 27);
            txtOldPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(214, 121);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(241, 27);
            txtNewPass.TabIndex = 5;
            // 
            // lbOldPass
            // 
            lbOldPass.AutoSize = true;
            lbOldPass.Location = new Point(30, 72);
            lbOldPass.Name = "lbOldPass";
            lbOldPass.Size = new Size(89, 20);
            lbOldPass.TabIndex = 12;
            lbOldPass.Text = "Mật khẩu cũ";
            // 
            // lbNewPass
            // 
            lbNewPass.AutoSize = true;
            lbNewPass.Location = new Point(30, 127);
            lbNewPass.Name = "lbNewPass";
            lbNewPass.Size = new Size(100, 20);
            lbNewPass.TabIndex = 13;
            lbNewPass.Text = "Mật khẩu mới";
            // 
            // lbComfirmPass
            // 
            lbComfirmPass.AutoSize = true;
            lbComfirmPass.Location = new Point(30, 182);
            lbComfirmPass.Name = "lbComfirmPass";
            lbComfirmPass.Size = new Size(130, 20);
            lbComfirmPass.TabIndex = 14;
            lbComfirmPass.Text = "Nhập lại mật khẩu";
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Name = "UserAccount";
            Text = "UserAccount";
            Load += UserAccount_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlRight;
        private Label lbInfor;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbAddress;
        private Label lbEmName;
        private Label lbEmID;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtEmName;
        private TextBox txtEmID;
        private Button btnUpdate;
        private TextBox txtConfirmPass;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private Label lbOldPass;
        private Label lbNewPass;
        private Label lbComfirmPass;
        private Label lbChangePass;
        private Button btnChangePass;
        private Button btnReload;
        private TextBox txtPhone;
        private CheckBox chkShowPassword;
    }
}