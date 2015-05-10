using System.Collections.Generic;

namespace NancyApplication
{
    using Nancy;
    
    public class ResourceModule : NancyModule
    {
        
        public ResourceModule() : base("/products")
        {
            // would capture routes to /products/list sent as a GET request
            Get["/list"] = parameters => {
                return new List<string>() {"product 1", "product2"};
            };
        }
    }
}