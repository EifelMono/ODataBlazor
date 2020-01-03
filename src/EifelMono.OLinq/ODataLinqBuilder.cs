using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace EifelMono.OLinq
{
    public interface IODataLinqBuilderSelf<T> where T : class
    {
        public ODataLinqBuilder<T> Self { get; set; }
    }

    public interface IODataLinqBuilderGet<T>: IODataLinqBuilderSelf<T> where T : class
    {
    }

    public interface IODataLinqBuilderWhere<T> : IODataLinqBuilderSelf<T> where T : class
    {
    }

    public class ODataLinqBuilder<T> : IODataLinqBuilderSelf<T>,
        IODataLinqBuilderGet<T>,
        IODataLinqBuilderWhere<T> where T : class
    {

        public ODataLinqBuilder()
        {
            ModelType = typeof(T);
            Self = this;
        }

        public ODataLinqBuilder<T> Self { get; set; }
        public Type ModelType { get; set; }

        #region Get
        public string Uri { get; set; }
     
        #endregion

        #region where 
        public Expression<Func<bool, T>> WhereExpressionFunc { get; set; }
        #endregion

    }
}
