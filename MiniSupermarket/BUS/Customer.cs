using System;
using System.Data;

public class Customer {
    private string customerID;
    private string name;
    private string phoneNumber;
    private string sex;
    private string point;
    private string isDeleted;

    // Constructor mặc định
    public Customer() {
        // Khởi tạo giá trị mặc định (nếu cần)
        CustomerID = "";
        Name = "";
        PhoneNumber = "";
        Sex = "";
        Point = "";
        IsDeleted = "";
    }

    // Constructor với tham số
    public Customer(string customerId, string name, string phoneNumber, string sex, string point, string isDeleted) {
        CustomerID = customerId;
        Name = name;
        PhoneNumber = phoneNumber;
        Sex = sex;
        Point = point;
        IsDeleted = isDeleted;
    }

    // Constructor với tham số là DataRow
    public Customer(DataRow row) {
        SetPropertiesFromDataRow(row);
    }

    // Hàm cập nhật thuộc tính từ DataRow
    public void SetPropertiesFromDataRow(DataRow row) {
        if (row != null) {
            CustomerID = row["CustomerID"].ToString();
            Name = row["Name"].ToString();
            PhoneNumber = row["PhoneNumber"].ToString();
            Sex = row["Sex"].ToString();
            Point = row["Point"].ToString();
            IsDeleted = row["IsDeleted"].ToString();
        }
    }

    //// Hàm chuyển đổi đối tượng Customer thành DataRow
    //public DataRow GetDataRow(DataTable table) {
    //    DataRow row = table.NewRow();
    //    row["CustomerID"] = CustomerID;
    //    row["Name"] = Name;
    //    row["PhoneNumber"] = PhoneNumber;
    //    row["Sex"] = Sex;
    //    row["Point"] = Point;
    //    row["IsDeleted"] = IsDeleted;
    //    return row;
    //}

    public string CustomerID {
        get { return customerID; }
        set { customerID = value; }
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string PhoneNumber {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public string Sex {
        get { return sex; }
        set { sex = value; } 
    }

    public string Point {
        get { return point; }
        set { point = value; }
    }

    public string IsDeleted {
        get { return isDeleted; }
        set { isDeleted = value; }
    }

}
