using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CountVietnameseCharacters
{
    public string CountVietnameseCharactersAl(string inputStr)
    {
        Dictionary<char, string> vietnameseDict = new Dictionary<char, string>
        {
            {'ă', "aw"}, {'â', "aa"}, {'đ', "dd"}, {'ê', "ee"}, {'ô', "oo"}, {'ơ', "ow"}, {'ư', "w"}
        };
        /// Chuối output giống như yêu cầu
        string stringVal = "";
        /// List giá trị thỏa mãn yêu cầu bài toán
        List<string> trueValue = new List<string>();


        // Biến đếm
        int count = 0;
        // Kiểm tra chuỗi đã cho có phần tử nào thỏa mãn đề bài 
        foreach (var element in vietnameseDict)
        {
            char key = element.Key;
            string value = element.Value;
            if (inputStr.ToLower().Contains(value))
            {
                count++;
                trueValue.Add(value);
            }

        }
        // trả về kết quả như theo yêu cầu output
        stringVal = stringVal + count.ToString() + " (";
        for (int i = 0; i < trueValue.Count; i++)
        {
            if (i == 0)
            {

                stringVal = stringVal + trueValue[i];
            }
            else
            {
                stringVal = stringVal + "," + trueValue[i];

            }

        }
        stringVal = stringVal + ")";

        Console.WriteLine($"{stringVal}");
        return stringVal;
    }
}