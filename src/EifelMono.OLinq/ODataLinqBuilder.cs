using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace EifelMono.OLinq
{
    public interface IODataLinqBuilderSelf<T> where T : class
    {
        public ODataLinqBuilder<T> Self { get; set; }
    }

    public interface IODataLinqBuilderCreate<T>: IODataLinqBuilderSelf<T> where T : class
    {
    }

    public interface IODataLinqBuilderWhere<T> : IODataLinqBuilderSelf<T> where T : class
    {
    }

    public class ODataLinqBuilder<T> : IODataLinqBuilderSelf<T>,
        IODataLinqBuilderCreate<T>,
        IODataLinqBuilderWhere<T> where T : class
    {
        public ODataLinqBuilder<T> Self { get; set; }

        #region Create
        public string Uri { get; set; }
        public Type ModelType { get; set; }
        #endregion

        #region where 
        public Expression<Func<bool, T>> WhereExpressionFunc { get; set; }
        #endregion

    }
}
