using System;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;
using PersonalSite.Domain.Entities;
using PersonalSite.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using PersonalSite.Domain.Concrete;

namespace PersonalSite.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IPostRepository>().To<EFPostsRepository>();
        }
    }
}