using System.Web.Http;
using System.Web.Http.Cors;
using Sitecore.EntityServiceBoilerplate.Models;
using Sitecore.EntityServiceBoilerplate.Repositories;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace Sitecore.EntityServiceBoilerplate.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ServicesController]
    public class SimpleEntityController : EntityService<SimpleEntity>
    {
        public SimpleEntityController() : this(new SimpleEntityRepository())
        {
        }

        public SimpleEntityController(IRepository<SimpleEntity> repository)
            : base(repository)
        {
        }


        //this is really just to define something
        [ActionName("DefaultAction"), HttpPost]
        public override System.Net.Http.HttpResponseMessage CreateEntity(SimpleEntity entity)
        {
            var response = base.CreateEntity(entity);
            return response;
        }
    }
}