
namespace Givestar.API
{
    internal class Injector
    {
        public static void Register(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<DataAccess.DbPramHandler.IDocument, DataAccess.DbPramHandler.Document>();
            builder.Services.AddScoped<BusinessLogic.IDocument, BusinessLogic.Document>();
            builder.Services.AddScoped<DataAccess.DbAccess.ISqlDataAccess, DataAccess.DbAccess.SqlDataAccess>();
        }


    }

    public class ConfigurationHelper
    {
        public static IConfiguration _config;
        public static void Initialize(IConfiguration Configuration)
        {
            _config = Configuration;
        }
    }
}
