using System.Collections.Generic;

namespace Utils
{
    public static class IntegerHelper
    {
        public static int? ToNullableInt(this object value)
        {
            var @int = string.IsNullOrEmpty((string) value) || !int.TryParse(value.ToString(), out var @try)
                ? default(int?)
                : @try;

            return @int;
        }

        public static IEnumerable<int> Integers(int from, int to)
        {
            for (; to >= from; from++)
            {
                yield return from;
            }
        }
    }
}
