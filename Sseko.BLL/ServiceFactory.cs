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

        public IReportService ReportService()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                return scope.Resolve<IReportService>();
            }
        }

        public IRoleService RoleService()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                return scope.Resolve<IRoleService>();
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

            containerBuilder.RegisterType<ReportService>().As<IReportService>();
            containerBuilder.RegisterType<RoleService>().As<IRoleService>();
            containerBuilder.RegisterType<UserService>().As<IUserService>();

            _container = containerBuilder.Build();
            return _container;
        }

        public static IContainer Get => _container ?? Init();
    }
}