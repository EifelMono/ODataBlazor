namespace EifelMono.OLinq
{
    public static class ODataLinq
    {

        public static IODataLinqBuilderCreate<T> Get<T>(string uri) where T : class
        {
            var oDataLinqBuilder = new ODataLinqBuilder<T>();
            oDataLinqBuilder.Self = oDataLinqBuilder;
            oDataLinqBuilder.Uri = uri;
            oDataLinqBuilder.ModelType = typeof(T);
            return oDataLinqBuilder;
        }
    }

}
