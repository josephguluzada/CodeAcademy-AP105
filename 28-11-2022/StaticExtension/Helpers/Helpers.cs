using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class Helpers
    {
        public static bool CheckPassword(string pass) // Yusif123
        {
            int digitCounter = 0;
            if (!string.IsNullOrWhiteSpace(pass) && pass.Length > 6 && char.IsUpper(pass[0]))
            {
                for (int i = 1; i < pass.Length; i++)
                {
                    if (char.IsDigit(pass[i])) return true;
                }
            }
            return false;
        }
    }
}
