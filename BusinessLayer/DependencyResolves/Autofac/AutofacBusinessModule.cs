
using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;

namespace BusinessLayer.DependencyResolves.Autofac
{
    public  class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SuperHeroManager>().As<ISuperHeroService>();
            builder.RegisterType<SuperHeroDAL>().As<ISuperHeroDAL>();
          
        }
    }
}
