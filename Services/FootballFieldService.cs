using System.Collections.Generic;
using System.Threading.Tasks;
using BattavellirAPI.Domain.Models;
using BattavellirAPI.Domain.Services;
using BattavellirAPI.Domain.Repositories;

namespace BattavellirAPI.Services
{
    public class FootballFieldService : IFootballFieldService
    {
        private readonly IFootballFieldRepository _footballFieldRepository;

        public FootballFieldService(IFootballFieldRepository footballFieldRepository)
        {
            this._footballFieldRepository = footballFieldRepository;
        }

        public async Task<IEnumerable<FootballField>> ListAsync()
        { 
            return await _footballFieldRepository.ListAsync();
        }
    }
}