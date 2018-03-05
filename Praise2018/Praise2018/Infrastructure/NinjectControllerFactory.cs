using Ninject;
using Praise2018.Abstract;
using Praise2018.Concrete;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Praise2018.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext
            requestContext, Type controllerType)
        {

            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IAccountsRepo>().To<EFAccountRepo>();
            ninjectKernel.Bind<IDetailesRepo>().To<EFDetailRepo>();



        }
    }
}