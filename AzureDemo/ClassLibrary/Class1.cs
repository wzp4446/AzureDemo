using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Class1
    {
        public static int Sum(int x, int y,out string sReturnCode,out string sReturnMsg)
        {
            if (x >= 0 && y >= 0)
            {
                sReturnCode = "0";
                sReturnMsg = "";
                return x + y;
            }
            else
            {
                sReturnCode = "1";
                sReturnMsg = "数字不能小于0";
                return 0;
            }
        }
    }
}
