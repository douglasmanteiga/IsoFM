using IsoFM.WebSite.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IsoFM.WebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Configurando o AutoMapper para registrar os profiles
            // de mapeamento durante a inicialização da aplicação.
            AutoMapperConfig.RegisterMappings();
        }
    }
}
