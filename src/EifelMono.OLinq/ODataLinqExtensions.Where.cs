using System;
namespace EifelMono.OLinq
{
    public static partial class ODataLinqExtensions
    {
        public static IODataLinqBuilderWhere<T> Where<T>(this IODataLinqBuilderCreate<T> thisValue) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
