using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace MiniSupermarket.RegularExpression
{
    internal class ProjectRegex
    {
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }

        public static bool IsPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(0|84|\+84)(3[2-9]|5[689]|7[06-9]|8[1-689]|9[0-46-9])\d{7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }

        public static Boolean checkDayAfterDay(string startDate, string endDate)
        {
            string format = "dd/MM/yyyy";
            DateTime StartDate;
            DateTime EndDate;
            DateTime.TryParseExact(startDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out StartDate);
            DateTime.TryParseExact(endDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out EndDate);
            if (StartDate > EndDate)
            {
                return false;
            }
            return true;
        }

        public static Boolean checkDayBelongDay(string startDate, string endDate)
        {
            string format = "dd/MM/yyyy";
            DateTime CurrentDate = DateTime.Now;
            DateTime StartDate;
            DateTime EndDate;
            DateTime.TryParseExact(startDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out StartDate);
            DateTime.TryParseExact(endDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out EndDate);
            if (CurrentDate < StartDate || CurrentDate > EndDate) { 
                return false;
            }
            return true;
        }

        public static bool checkSoNguyenDuong(string input) {
            // Biểu thức chính quy để kiểm tra số nguyên dương
            Regex regex = new Regex(@"^\d+$");

            return regex.IsMatch(input);
        }
    }
}

