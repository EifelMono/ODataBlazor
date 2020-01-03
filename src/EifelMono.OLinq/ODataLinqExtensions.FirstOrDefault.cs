using System;
using System.Linq.Expressions;

namespace EifelMono.OLinq
{
    public static partial class ODataLinqExtensions
    {
        public static T FirstOrDefault<T>(this IODataLinqBuilderGet<T> thisValue, Expression<Func<T, bool>> expressionFunc) where T : class, new()
        {
            return new T();
        }
    }
}
