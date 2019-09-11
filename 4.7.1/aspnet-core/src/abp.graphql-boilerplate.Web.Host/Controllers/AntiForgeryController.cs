using Microsoft.AspNetCore.Antiforgery;
using abp.graphql-boilerplate.Controllers;

namespace abp.graphql-boilerplate.Web.Host.Controllers
{
    public class AntiForgeryController : graphql-boilerplateControllerBase
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
