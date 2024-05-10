using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.ImageAndFont
{
    internal static class ProjectFont
    {
        private static Font titleFont = new Font("microsoft sans serif", 16);
        private static Font normalFont = new Font("microsoft sans serif", 12);

        public static Font getTitleFont()
        {
            return titleFont;
        }

        public static Font getNormalFont()
        {
            return normalFont;
        }

        // Viết hoa chữ cái đầu
        public static string upperFirstLetter(string str)
        {
            string temp = str.Trim();
            if (temp.Length > 0)
            {
                return Char.ToUpper(temp[0]) + temp.Substring(1).ToLower();
            }
            return temp;
        }

        public static string CapitalizeEachWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            // Tách chuỗi theo khoảng trắng
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Viết hoa chữ cái đầu của mỗi từ
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length > 0)
                {
                    words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
            }

            // Nối lại các từ với nhau, cách nhau 1 khoảng trắng
            return string.Join(" ", words);
        }
    }
}
