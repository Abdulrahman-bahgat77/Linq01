using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq01
{
    internal static class inExtension
    {
        public static int Reverse(this int X)
        {
            int ReverseNum=0, Reminder;
            while(X != 0)
            {
                Reminder = X % 10;
                ReverseNum = ReverseNum * 10 + Reminder;
                X /= 10;
            }
            return ReverseNum;
        }
    }
}
