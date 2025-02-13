using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
