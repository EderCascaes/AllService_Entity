using Microsoft.Extensions.DependencyInjection;
using System;

namespace AllService.WebApi
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceprovider)
        {
            RepositoryDependence(serviceprovider);
        }

        private static void RepositoryDependence(IServiceCollection serviceprovider)
        {           
        }
    }
}
