namespace MiniSupermarket.GUI
{
    partial class formLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panel1 = new Panel();
            chbxShowPassword = new CheckBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pbxImage = new PictureBox();
            tmrChangedImage = new System.Windows.Forms.Timer(components);
            ImageListShow = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(chbxShowPassword);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(529, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 439);
            panel1.TabIndex = 0;
            // 
            // chbxShowPassword
            // 
            chbxShowPassword.AutoSize = true;
            chbxShowPassword.Location = new Point(101, 310);
            chbxShowPassword.Name = "chbxShowPassword";
            chbxShowPassword.Size = new Size(173, 29);
            chbxShowPassword.TabIndex = 7;
            chbxShowPassword.Text = "Show password";
            chbxShowPassword.UseVisualStyleBackColor = true;
            chbxShowPassword.CheckedChanged += chbxShowPassword_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.BackgroundImage = Properties.Resources.LoginLogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(76, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.BackgroundImage = Properties.Resources.right_arrow;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(76, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 40);
            btnLogin.TabIndex = 5;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyPress += btnLogin_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 258);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(184, 30);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 204);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(184, 30);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 207);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 130);
            label1.Name = "label1";
            label1.Size = new Size(176, 69);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.Controls.Add(pbxImage);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 415);
            panel2.TabIndex = 0;
            // 
            // pbxImage
            // 
            pbxImage.BackgroundImageLayout = ImageLayout.None;
            pbxImage.Image = (Image)resources.GetObject("pbxImage.Image");
            pbxImage.Location = new Point(-8, -8);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(519, 436);
            pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImage.TabIndex = 0;
            pbxImage.TabStop = false;
            pbxImage.WaitOnLoad = true;
            // 
            // tmrChangedImage
            // 
            tmrChangedImage.Enabled = true;
            tmrChangedImage.Interval = 2000;
            tmrChangedImage.Tick += tmrChangedImage_Tick_1;
            // 
            // ImageListShow
            // 
            ImageListShow.ColorDepth = ColorDepth.Depth24Bit;
            ImageListShow.ImageStream = (ImageListStreamer)resources.GetObject("ImageListShow.ImageStream");
            ImageListShow.TransparentColor = Color.Transparent;
            ImageListShow.Images.SetKeyName(0, "miniMarketLogo.jpg");
            ImageListShow.Images.SetKeyName(1, "miniMarketLogo2.jpg");
            ImageListShow.Images.SetKeyName(2, "miniMarketLogo3.jpg");
            ImageListShow.Images.SetKeyName(3, "z5283188828608_6c68638c35b9029764b5c22983b4d2c9.jpg");
            // 
            // formLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 439);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HelpButton = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = SystemColors.ActiveCaptionText;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pbxImage;
        private System.Windows.Forms.Timer tmrChangedImage;
        private PictureBox pictureBox1;
        private CheckBox chbxShowPassword;
        private ImageList ImageListShow;
    }
}

