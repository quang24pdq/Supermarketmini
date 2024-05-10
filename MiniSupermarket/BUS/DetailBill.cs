using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DetailBill {
    public string BillID { get; set; }
    public string ProductID { get; set; }
    public string OrderID { get; set; }
    public string ProductName { get; set; }
    public float ProductCurrentPrice { get; set; } 
    public string ProductUnit { get; set; }
    public float SalePrice { get; set; }
    public int Quantity { get; set; }

    // Constructor mặc định
    public DetailBill() {
        // Khởi tạo giá trị mặc định (nếu cần)
        BillID = "";
        ProductID = "";
        OrderID = "";
        ProductName = "";
        ProductCurrentPrice = 0.0f;
        ProductUnit = "";
        SalePrice = 0.0f;
        Quantity = 0;
    }

    // Constructor với tham số
    public DetailBill(string billID, string productID, string orderID, string productName, float productCurrentPrice, string productUnit, float salePrice, int quantity) {
        BillID = billID;
        ProductID = productID;
        OrderID = orderID;
        ProductName = productName;
        ProductCurrentPrice = productCurrentPrice;
        ProductUnit = productUnit;
        SalePrice = salePrice;
        Quantity = quantity;
    }
}
