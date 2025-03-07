using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.MenuComponents
{
    public class _MenuNavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
