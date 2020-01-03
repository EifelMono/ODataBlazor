using System;
namespace EifelMono.OLinq
{
    public static partial class ODataLinqExtensions
    {
        public static IODataLinqBuilderWhere<T> Take<T>(this IODataLinqBuilderGet<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
