namespace EifelMono.OLinq
{
    public static class ODataLinq
    {

        public static IODataLinqBuilderGet<T> Get<T>(string uri) where T : class
            => new ODataLinqBuilder<T>
            {
                Uri = uri
            };
    }

}
