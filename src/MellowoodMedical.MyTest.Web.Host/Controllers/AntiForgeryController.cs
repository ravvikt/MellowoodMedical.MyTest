using Microsoft.AspNetCore.Antiforgery;
using MellowoodMedical.MyTest.Controllers;

namespace MellowoodMedical.MyTest.Web.Host.Controllers
{
    public class AntiForgeryController : MyTestControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
