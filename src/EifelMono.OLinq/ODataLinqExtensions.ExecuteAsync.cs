using System;
namespace EifelMono.OLinq
{
    public static partial class ODataLinqExtensions
    {
        public static IODataLinqBuilderWhere<T> ExecuteAsync<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static IODataLinqBuilderWhere<T> ExecuteToListAsync<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static IODataLinqBuilderWhere<T> ExecuteFirstOrDefaultAsync<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }

        public static IODataLinqBuilderWhere<T> ExecuteCountAsync<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
