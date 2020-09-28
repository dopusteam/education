using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Dopusteam.Education.AspNetCore.Filters.Infrastructure.Filters
{
    public class EarlyReturnResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            context.Result = new ContentResult
            {
                Content = "Результат из фильтра"
            };
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
        }
    }

}
