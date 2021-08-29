using DDD.WinForm.Helpers;

namespace DDD.Domain.ValueObjects
{
    public sealed class Temperature : ValueObject<Temperature>
    {
        // バリューオブジェクトは完全コンストラクタパターンで作成
        // 値とロジックを一つのオブジェクトにまとめる。

        public static readonly string UnitName = "℃";
        public static readonly int DecimalPoint = 2;

        public Temperature(float value)
        {
            Value = value;
        }

        public float Value { get; }
        public string DiaplayValue {
            get
            {
                return Value.RoundString(DecimalPoint);
            }
        }

        public string DiaplayValueWithUnit
        {
            get
            {
                return string.Format("{0}{1}"
                        , Value.RoundString(DecimalPoint)
                        , UnitName);
            }
        }

        protected override bool EqualCore(Temperature obj)
        {
            return Value == obj.Value;
        }
    }
}
