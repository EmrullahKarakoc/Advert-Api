using Adverts.Application.Common.Persistence;
using Adverts.Domain.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adverts.Infrastructure.Persistence.Repositories
{
    public class AdvertRepository : IAdvertRepository
    {
        private readonly IConfiguration _configuration;

        public AdvertRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<Advert>> GetAllAsync()
        {
            await using var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var sql = "Select * FROM public.\"Advert\" ORDER BY id";
            await connection.OpenAsync();

            var result = connection.Query<Advert>(sql).ToList();

            await connection.CloseAsync();
            return result;
        }

        public async Task<Advert> GetByIdAsync(int id)
        {
            await using var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var sql = "Select * FROM public.\"Advert\" WHERE id='" + id + "'";
            await connection.OpenAsync();

            var result = connection.QueryFirstOrDefault<Advert>(sql);

            await connection.CloseAsync();
            return result;
        }
    }
}
