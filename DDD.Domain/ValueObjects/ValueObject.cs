namespace DDD.Domain.ValueObjects
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            var vo = obj as T;
            if (vo == null)
            {
                return false;
            }

            return EqualCore(vo);
        }

        public static bool operator ==(ValueObject<T> t1, ValueObject<T> t2)
        {
            return Equals(t1, t2);
        }

        public static bool operator !=(ValueObject<T> t1, ValueObject<T> t2)
        {
            return !Equals(t1, t2);
        }

        protected abstract bool EqualCore(T other);

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
