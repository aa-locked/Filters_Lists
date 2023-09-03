using Microsoft.AspNetCore.Mvc.Filters;

namespace FixedAsset.Filters
{
    public class ResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("Resource Filter Executing.");
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("Resource Filter Executed.");
        }


    }
}
