using System;
namespace EifelMono.OLinq
{
    public static partial class ODataLinqExtensions
    {
        public static IODataLinqBuilderWhere<T> InternalOrderBy<T>(this IODataLinqBuilderGet<T> thisValue, bool descanding) where T : class, new()
        {
            throw new NotImplementedException();
        }


        public static IODataLinqBuilderWhere<T> OrderBy<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static IODataLinqBuilderWhere<T> OrderByDescanding<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
