namespace MiniSupermarket.GUI {
    partial class Invorice {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            richTextBox1 = new RichTextBox();
            mbtnPrint = new Button();
            mbtnCancel = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(758, 448);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // mbtnPrint
            // 
            mbtnPrint.AutoSize = true;
            mbtnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnPrint.Location = new Point(664, 481);
            mbtnPrint.Margin = new Padding(4, 6, 4, 6);
            mbtnPrint.Name = "mbtnPrint";
            mbtnPrint.Size = new Size(106, 25);
            mbtnPrint.TabIndex = 1;
            mbtnPrint.Text = "SAVE AND PRINT";
            mbtnPrint.UseVisualStyleBackColor = true;
            mbtnPrint.Click += mbtnPrint_Click;
            // 
            // mbtnCancel
            // 
            mbtnCancel.AutoSize = true;
            mbtnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnCancel.Location = new Point(570, 481);
            mbtnCancel.Margin = new Padding(4, 6, 4, 6);
            mbtnCancel.Name = "mbtnCancel";
            mbtnCancel.Size = new Size(62, 25);
            mbtnCancel.TabIndex = 2;
            mbtnCancel.Text = "CANCEL";
            mbtnCancel.Click += mbtnCancel_Click;
            // 
            // Invorice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 521);
            Controls.Add(mbtnCancel);
            Controls.Add(mbtnPrint);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Invorice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
         
        private RichTextBox richTextBox1;
        private Button mbtnPrint;
        private Button mbtnCancel;
    }
}