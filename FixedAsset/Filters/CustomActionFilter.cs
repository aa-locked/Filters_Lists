using Microsoft.AspNetCore.Mvc.Filters;

namespace FixedAsset.Filters
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action Filter Executing.");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action Filter Executed.");
        }

       
    }
}
