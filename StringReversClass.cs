using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseLibrary
{
    public class StringReversClass
    {
        /// <summary>
        /// В качестве параметра передается строка, представляющая одно слово и содержащая ноль или более символов.
        /// </summary>
        /// <param name="textString"></param>
        /// <returns>Возвращается “перевернутая” строка, в которой последний символ станет первым, предпоследний вторым и т. д. Все символы возвращаются в нижнем регистре</returns>
        public string ReverseString(string textString)
        {
            if (textString == String.Empty) 
            { 
                throw new Exception("text");
            }
            textString= textString.ToLower();
            char[] chars = textString.ToCharArray();
            Array.Reverse(chars);
            string result = new string(chars);
            return result;
            
        }
    }
}
