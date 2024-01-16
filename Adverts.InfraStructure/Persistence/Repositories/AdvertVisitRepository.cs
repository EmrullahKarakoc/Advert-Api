using Adverts.Application.Common.Persistence;
using Adverts.Domain.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Threading.Tasks;

namespace Adverts.Infrastructure.Persistence.Repositories
{
    public class AdvertVisitRepository : IAdvertVisitRepository
    {
        private readonly IConfiguration _configuration;

        public AdvertVisitRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> AddAsync(AdvertVisit entity)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var sql = "INSERT INTO public.\"AdvertVisit\" (\"advertId\", \"iPAdress\",\"visitDate\") VALUES (" + entity.AdvertId + ",'" + entity.IpAddress + "','" + entity.VisitDate+"')";
            var rowsAffected = await connection.ExecuteAsync(sql);

            await connection.CloseAsync();
            return rowsAffected > 0 ? true : false;
        }
    }
}
