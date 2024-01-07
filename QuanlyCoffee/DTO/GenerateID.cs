using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class GenerateID
    {
        //Get Random String
        private static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public static string getRanDomId()
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(5, false));
            builder.Append(random.Next(10000, 99999));
            return builder.ToString();
        }
    }
}
