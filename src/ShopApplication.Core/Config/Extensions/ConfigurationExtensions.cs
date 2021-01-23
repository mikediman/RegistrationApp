using Microsoft.Extensions.Configuration;

namespace ShopApplication.Core.Config.Extensions
{
    public static class ConfigurationExtensions
    {
        public static AppConfig ReadAppConfiguration(this IConfiguration @this)
        {
            var connectionString = @this.GetConnectionString("ShopDb");

            AppConfig appConfig = new AppConfig();
            appConfig.DbConnectionString = connectionString;
            return appConfig;
        }
    }
}
