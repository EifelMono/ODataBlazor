namespace EifelMono.OLinq
{
    public static class ODataLinq
    {
        public static ODataLinqBuilder<TModel> Get<TModel>(string uri) where TModel : class
            => new ODataLinqBuilder<TModel>
            {
                _uri = uri
            };
    }

}
