using System;

namespace NameGenerator
{
    public static class RandomExtensions
    {
        public static T Pick<T>(this Random random, params T[] items) => items[random.Next(items.Length)];
        public static bool NextBool(this Random random) => random.Next(2) == 0;
    }
}