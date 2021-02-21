using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattavellirAPI.Domain.Models;
using BattavellirAPI.Domain.Services;

namespace BattavellirAPI.Controllers
{
    [Route("/api/[controller]")]
    public class FootballFieldsController : Controller
    {
        private readonly IFootballFieldService _footballFieldService;
        
        public FootballFieldsController(IFootballFieldService _footballFieldService)
        {
            _footballFieldService = _footballFieldService;   
        }

        [HttpGet]
        public async Task<IEnumerable<FootballField>> GetAllAsync()
        {
            var footballFields = await _footballFieldService.ListAsync();
            return footballFields;
        }
    }
}