using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;


// https://www.odata.org/documentation/odata-version-2-0/uri-conventions/
// http://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html

namespace EifelMono.OLinq
{
    public class ODataLinqBuilder<TModel> where TModel : class
    {

        public ODataLinqBuilder()
        {
            _modelType = typeof(TModel);
        }

        #region Common
        internal Type _modelType;
        internal Type _resultType = null;
        internal string _uri { get; set; }
        #endregion

        #region Where/FirstOrDefault
        internal string _whereAsString;
        internal Expression<Func<TModel, bool>> _whereExpressionFunction = null;

        public ODataLinqBuilder<TModel> WhereInternal(Expression<Func<TModel, bool>> whereExpressionFunc)
        {
            if (whereExpressionFunc != null)
            {
                _whereAsString = whereExpressionFunc.ToString();
                _whereExpressionFunction = whereExpressionFunc;
            }
            return this;
        }

        public ODataLinqBuilder<TModel> Where(Expression<Func<TModel, bool>> whereExpressionFunc)
            => WhereInternal(whereExpressionFunc);
        #endregion

        #region OrderBy
        internal string _orderByAsString;
        internal Type _orderByType = null;
        internal bool _orderByAsc = true;

        protected ODataLinqBuilder<TModel> OrderByInternal<T>(Expression<Func<TModel, T>> orderByExpression, bool asc)
        {
            _orderByAsString = orderByExpression.ToString();
            _orderByType = typeof(T);
            _orderByAsc = asc;
            return this;
        }

        public ODataLinqBuilder<TModel> OrderBy<T>(Expression<Func<TModel, T>> orderByExpressionFunc)
            => OrderByInternal(orderByExpressionFunc, asc: true);

        public ODataLinqBuilder<TModel> OrderByDescending<T>(Expression<Func<TModel, T>> orderByExpressionFunc)
            => OrderByInternal(orderByExpressionFunc, asc: false);
        #endregion

        #region select
        internal Expression<Func<bool, TModel>> _selectExpressionFunction = null;
        internal Type _selectType  = null;
        #endregion

        #region Skip/Top/Take
        internal int _skip = -1;
        internal int _take = -1;

        public ODataLinqBuilder<TModel> Skip(int skip)
        {
            _skip = skip;
            return this;
        }

        public ODataLinqBuilder<TModel> Take(int take)
        {
            _take = take;
            return this;
        }
        #endregion
    }
}
