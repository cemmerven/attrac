using System.Web.Mvc;
public class 

TimerAttribute : ActionFilterAttribute, IActionFilter
{
    void IActionFilter.OnActionExecuting( ActionExecutingContext filterContext ) {
        this.OnActionExecuting( filterContext );
    }

}