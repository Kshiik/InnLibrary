using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InnLibrary
{
    public class CheckInn
    {
        /// <summary>
        /// Проверка правильности заполнения ИНН физического лица 
        /// </summary>
        /// <param name="innCode">ИНН</param>
        /// <returns></returns>
        public static bool CorrectFillINN(string innCode)
        {
            if (string.IsNullOrWhiteSpace(innCode))
                return false;
            if (!Regex.Match(innCode, "[0-9]").Success)
            {
                return false;
            }
            
                if (innCode.Length != 12)
                {
                    return false;
                }
           

            int[] k1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0,0};
            int[] k2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };
            char[] chars = innCode.ToCharArray();
            int summ1 = 0;
            int summ2 = 0;

            if(chars.Length > 0) 
                return true;


            for (int i = 0; i < chars.Length; i++)
            {
                summ1 =+ Convert.ToInt32(char.GetNumericValue(chars[i])) * k1[i];
                summ2 =+ Convert.ToInt32(char.GetNumericValue(chars[i])) * k2[i];
            }
            int ostatok1 = summ1 % 11;
            int ostatok2 = summ2 % 11;

            if (ostatok1 > 9)
            {
                ostatok1 = ostatok1 % 10;
            }
            if (ostatok2 > 9)
            {
                ostatok2 = ostatok2 % 10;
            }

            if (Convert.ToInt32(char.GetNumericValue(chars[10])) != ostatok1)
                return false;
            if(Convert.ToInt32(char.GetNumericValue(chars[11])) != ostatok2)
                return false;

            return true;
        }
    }
}
