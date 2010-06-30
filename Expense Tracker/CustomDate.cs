using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker
{
    class CustomDate
    {
        public static string GetThaiYear(int year)
        {
            return (year + 543).ToString();
        }

        public static string GetThaiMonth(int month)
        {
            string[] thMonths = { 
                "", "มกราคม", "กุมภาพันธ์", "มีนาคม", 
                "เมษายน", "พฤษภาคม", "มิถุนายน", 
                "กรกฏาคม", "สิงหาคม", "กันยายน", 
                "ตุลาคม", "พฤศจิกายน", "ธันวาคม" };
            return thMonths[month];
        }
    }
}
