using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.customScripts
{
    class Trimmer
    {
        public static string TrimString(string text)
        {
            char[] charsToTrim = { ' ' };
            text = text.TrimEnd(charsToTrim);
            return text = text.TrimStart(charsToTrim);
        }
    }
}
