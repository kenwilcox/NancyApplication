namespace NancyApplication
{
    using Nancy;
    
    public class ProductsModule : NancyModule
    {
        public ProductsModule()
        {
            Get["/products/{id}"] = _ =>
            {
                return "The product is " + _.id + "<br>" + _.id.Value.GetType();
            };
        }
    }
}