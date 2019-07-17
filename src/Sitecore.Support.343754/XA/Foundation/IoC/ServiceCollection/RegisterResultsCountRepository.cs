#region Added code
namespace Sitecore.Support.XA.Foundation.IoC.ServiceCollection
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;
    using Sitecore.XA.Feature.Search.Repositories;

    public class RegisterResultsCountRepository : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            var descriptor = new ServiceDescriptor(typeof(IResultsCountRepository), ServiceLifetime.Transient);
            serviceCollection.Remove(descriptor);
            serviceCollection.AddTransient<IResultsCountRepository, Sitecore.Support.XA.Feature.Search.Repositories.ResultsCountRepository>();
        }
    }
} 
#endregion