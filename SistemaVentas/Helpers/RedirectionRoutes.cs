using Microsoft.AspNetCore.Mvc;

namespace WebApp.SistemaVentas.Helpers
{
    public static class RedirectionRoutes
    {
        public static RedirectToRouteResult ProductHome = new RedirectToRouteResult( new { controller = "Producto", action = "Home" });
        public static RedirectToRouteResult Login = new RedirectToRouteResult(new { controller = "User", action = "Login" });
    }
}
