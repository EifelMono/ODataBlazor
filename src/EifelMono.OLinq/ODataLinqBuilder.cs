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

    public class ODataLinqBuilder<TModel> : IODataLinqBuilderSelf<TModel>,
        IODataLinqBuilderGet<TModel>,
        IODataLinqBuilderWhere<TModel> where TModel : class
    {

        public ODataLinqBuilder()
        {
            ModelType = typeof(TModel);
            Self = this;
        }

        public ODataLinqBuilder<TModel> Self { get; set; }
        public Type ModelType { get; set; }

        #region Get
        public string Uri { get; set; }
     
        #endregion

        #region where 
        public Expression<Func<bool, TModel>> WhereExpressionFunc { get; set; }
        #endregion

    }
}
