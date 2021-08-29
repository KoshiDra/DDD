using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public sealed class Condition : ValueObject<Condition>
    {
        /// <summary>
        /// 不明
        /// </summary>
        public static readonly Condition None = new Condition(0);

        /// <summary>
        /// 晴れ
        /// </summary>
        public static readonly Condition Sunny = new Condition(1);

        /// <summary>
        /// 曇り
        /// </summary>
        public static readonly Condition Cloud = new Condition(2);

        /// <summary>
        /// 雨
        /// </summary>
        public static readonly Condition Rain = new Condition(3);

        public Condition(int value)
        {
            this.Value = value;
        }

        public int Value { get; }

        public string DisplayValue { 
            get
            {
                if (this == Condition.Sunny)
                {
                    return "晴れ";
                }

                if (this == Condition.Cloud)
                {
                    return "曇り";
                }

                if (this == Condition.Rain)
                {
                    return "雨";
                }

                return "不明";
            } 
        }

        protected override bool EqualCore(Condition other)
        {
            return this.Value == other.Value;
        }
    }
}
