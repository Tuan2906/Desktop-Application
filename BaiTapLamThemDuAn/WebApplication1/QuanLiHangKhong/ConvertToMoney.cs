using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHangKhong
{
    public class ConvertToMoney
    {
        static string[] onesPlace = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        static string[] tensPlace = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        static string[] thousandsPlace = { "", "nghìn", "triệu", "tỷ" };
        public string ConvertToText(int number)//100000
        {
            if (number == 0)
                return "không";

            string text = "";
            int index = 0;

            while (number > 0)
            {
                string groupText = ConvertGroupToText(number % 1000);//0
                if (groupText != "")
                {
                    text = groupText + " " + thousandsPlace[index] + " " + text;
                   
                }


                index++;
                number /= 1000;
                if (number == 0)
                {
                    text += "đồng";
                }
            }

            return text.Trim();
        }

        public string ConvertGroupToText(int number)
        {
            string text = "";

            int hundreds = number / 100;//1
            int tens = number % 100;
            int ones = number % 10;

            if (hundreds > 0)
                text += onesPlace[hundreds] + " trăm ";

            if (tens >= 10 && tens <= 19)
            {
                text += "mười ";
                ones = tens % 10;
            }
            else if (tens > 19)
            {
                text += tensPlace[tens / 10] +" ";
                ones = tens % 10;
            }

            if (ones > 0)
                text += onesPlace[ones];

            return text.Trim();
        }
    }
}
