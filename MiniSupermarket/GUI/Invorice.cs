using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Data;
using MiniSupermarket.BUS;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace MiniSupermarket.GUI {
    public partial class Invorice : Form {
        private int pdfInvoiceId;
        public int PdfInvoiceId { get; set; }
        private DataGridViewRow bill;
        private DataTable detailBill;

        public Invorice(DataGridViewRow selectedRow, DataTable detailBillTable) {
            InitializeComponent();
            this.bill = selectedRow;
            this.detailBill = detailBillTable;
            FormatInvoice();
        }

        private void mbtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mbtnPrint_Click(object sender, EventArgs e) {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true }) {
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    try {
                        PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        //BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\cour.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 11);

                        foreach (var paragraph in richTextBox1.Lines) {
                            doc.Add(new iTextSharp.text.Paragraph(new iTextSharp.text.Chunk(paragraph + "\n", font)));
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } finally {
                        doc.Close();
                    }
                }
            }
            this.Dispose();
        }



        // {0, -5}{1,-30}{2, -10}{3,-15}{4,-10};
        private void FormatInvoice() {
            richTextBox1.Clear();
            var rtbString = new System.Text.StringBuilder();

            //richTextBox1.SelectionFont = new System.Drawing.Font("Arial Unicode MS", 11, FontStyle.Regular); // Sửa font thành Arial Unicode MS
            richTextBox1.Font = new System.Drawing.Font("Courier New", 11);
            rtbString.Append(String.Format("{0,52}", "Siêu Thị MiniMarket Family\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0, 65}", "Siêu Thị AHAMART\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0, 52}", "Số điện thoại: 0339276489\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0, 50}", "Đường dây nóng : 1900 1880\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0, 45}", "Hóa Đơn\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,60}", "-----------------------------------------------\n"));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0}\n", $"Mã Nhân Viên: {this.bill.Cells["EmployeeID"].Value.ToString()}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Tên Nhân Viên: {this.bill.Cells["EmployeeName"].Value.ToString()}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Mã Khách Hàng: {this.bill.Cells["CustomerID"].Value.ToString()}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Tên Khách Hàng: {this.bill.Cells["CustomerNAME"].Value.ToString()}"));

            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0, -10}{1, -25}{2, -15}{3, -15}{4, -15}\n", "No.", "Tên Sản Phẩm", "Số lượng", "Tổng đơn giá", "Mã giảm giá"));
            rtbString.Append("\n");

            int rowNumber = 1;
            foreach (DataRow row in detailBill.Rows) {
                string productName = row["Name"].ToString();
                int totalQuantity = Convert.ToInt32(row["TotalQuantity"]);
                decimal totalSalePrice = Convert.ToDecimal(row["TotalSalePrice"]);
                string promotionID = row["PromotionID"].ToString();

                rtbString.Append(String.Format("{0, -10}{1, -25}{2, -20}{3, -15}{4, -15}\n", rowNumber, productName, totalQuantity, totalSalePrice, promotionID));

                rowNumber++;
            }
            rtbString.Append("\n\n\n");
            rtbString.Append(String.Format("{0}\n", $"Tạm tính: {this.bill.Cells["EstimatedPrice"].Value.ToString()}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Số tiền được giảm: {this.bill.Cells["ReducePrice"].Value.ToString()}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Tổng tiền: {this.bill.Cells["TotalPrice"].Value.ToString()}"));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0}\n", "Số tiền viết bằng chữ: " + toVietnameseDong(int.Parse(this.bill.Cells["TotalPrice"].Value.ToString()))));
            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,53}", "Cảm Ơn Quý Khách !n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,50}", "Hẹn Gặp Lại\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,60}", "Phiếu tính tiền có giá trị duy nhất trong sản phẩm hóa đơn VAT trong ngày\n"));

            richTextBox1.AppendText(rtbString.ToString());
        }

        private string toVietnameseDong(int totalPrice) {
            if (totalPrice == 0) return "Khong VND";

            string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười Một", "Mười Hai", "Mười Ba", "Mười Bốn", "Mười Lăm", "Mười Sáu", "Mười Bảy", "Mười Tám", "Mười Chín" };
            string[] tens = { "", "", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };
            string[] thousands = { "", "Nghìn", "Triệu", "Tỉ" };

            string ConvertToVietnameseDongs(int number) {
                if (number == 0) return "";
                else if (number < 10) return ones[number] + "";
                else if (number < 20) return ones[number] + " Muoi ";
                else if (number < 100) return tens[number / 10] + " " + ConvertToVietnameseDongs(number % 10);
                else return ones[number / 100] + " Tram " + ConvertToVietnameseDongs(number % 100);
            }

            int index = 0;
            string words = "";

            while (totalPrice > 0) {
                if (totalPrice % 1000 != 0)
                    words = $"{ConvertToVietnameseDongs(totalPrice % 1000)} {thousands[index]} {words}";

                totalPrice /= 1000;
                index++;
            }

            return $"{words.Trim()} VND";
        }
    }
}
