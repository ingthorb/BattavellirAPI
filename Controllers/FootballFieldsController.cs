using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BattavellirAPI.Domain.Models;
using BattavellirAPI.Domain.Data;


namespace BattavellirAPI.Controllers
{
    [Route("/api/[controller]")]
    public class FootballFieldsController : Controller
    {
        private readonly FootballFieldContext _context;
        
        public FootballFieldsController(FootballFieldContext context)
        {
            _context = context;      
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_context.FootballFields);
        }
    }
}