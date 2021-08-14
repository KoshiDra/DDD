using System;

namespace DDD.WinForm.Common
{
    public static class CommonFunc
    {
        public static string RoundString(float val, int decimalPoint)
        {
            var temp = Convert.ToSingle(Math.Round(val, decimalPoint));
            return temp.ToString("F" + decimalPoint);
        }
    }
}
