using Autofac;
using Sseko.BLL.Interfaces;
using Sseko.BLL.Services;

namespace Sseko.BLL
{
    public class ServiceFactory
    {
        private IContainer _container;

        public ServiceFactory()
        {
            _container = DependencyContainer.Get;
        }

        public IMagentoService MagentoService()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                return scope.Resolve<IMagentoService>();
            }
        }

        public IUserService UserService()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                return scope.Resolve<IUserService>();
            }
        }
    }

    public static class DependencyContainer
    {
        private static IContainer _container;

        private static IContainer Init()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<MagentoService>().As<IMagentoService>();
            containerBuilder.RegisterType<UserService>().As<IUserService>();

            _container = containerBuilder.Build();
            return _container;
        }

        public static IContainer Get => _container ?? Init();
    }
}