using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDuyDat_QLQuanGame_CDTH17.Libraries
{
    public static class IdValidation
    {
        public static int validateNumberInput(string input)
        {
            int output;
            if (int.TryParse(input, out output) && output > 0)
            {
                return output;
            }
            return -1;
        }

        public static bool validateEmptyInput(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static bool checkLength(string input, int length)
        {
            return (input.Length > length);
        }
    }
}
