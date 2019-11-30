using CoinmarketDataBackend.Db;
using CoinmarketDataBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoinmarketDataBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoinmarketDataController : ControllerBase
    {
        public CoinmarketDataController(lab360Context context)
        {
            _dbManager = new DbManager(context);
        }
        private DbManager _dbManager;

        [HttpGet]
        public IEnumerable<Cryptocurrency> Get()
        {
            return _dbManager.LoadAll();
        }
    }
}