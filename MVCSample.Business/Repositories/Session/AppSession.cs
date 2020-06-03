using Microsoft.Extensions.Options;
using MVCSample.Business.Models.Config;
using Npgsql;
using Smooth.IoC.UnitOfWork.Abstractions;
using Smooth.IoC.UnitOfWork.Interfaces;

namespace MVCSample.Business.Repositories.Session
{
    public interface IAppSession : Smooth.IoC.UnitOfWork.Interfaces.ISession
    {
    }

    public class AppSession : Session<NpgsqlConnection>, IAppSession
    {
        public AppSession(IDbFactory session, IOptions<ConnectionConfig> connectionConfig)
                : base(session, connectionConfig.Value.DefaultConnection)
        {
            Dapper.FastCrud.OrmConfiguration.DefaultDialect = Dapper.FastCrud.SqlDialect.PostgreSql;
        }

    }
}
