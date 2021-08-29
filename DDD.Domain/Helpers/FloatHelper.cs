using System;

namespace DDD.WinForm.Helpers
{
    public static class FloatHelper
    {
        /// <summary>
        /// （拡張メソッド）指定した小数点以下で四捨五入
        /// </summary>
        /// <param name="val"></param>
        /// <param name="decimalPoint"></param>
        /// <returns></returns>
        public static string RoundString(this float val, int decimalPoint)
        {
            var temp = Convert.ToSingle(Math.Round(val, decimalPoint));
            return temp.ToString("F" + decimalPoint);
        }
    }
}
