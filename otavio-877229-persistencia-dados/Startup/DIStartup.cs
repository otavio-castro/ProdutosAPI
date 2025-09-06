using Microsoft.EntityFrameworkCore;
using otavio_877229_persistencia_dados.Context;

namespace otavio_877229_persistencia_dados.Startup
{
    public class DIStartup
    {
        public static void ConfigureServices(IHostApplicationBuilder builder)
        {
            #region DbContext

            //Realização do DI da conexão ao banco
            var minhaConexaoSqlServer = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(minhaConexaoSqlServer));

            #endregion DbContext
        }
    }
}
