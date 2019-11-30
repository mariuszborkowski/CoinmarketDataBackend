using CoinmarketDataBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoinmarketDataBackend.Db
{
    public class DbManager
    {
        private lab360Context _context;

        public DbManager(lab360Context context)
        {
            _context = context;
        }

        public IEnumerable<Cryptocurrency> LoadAll()
        {
            return _context.Cryptocurrency.ToList<Cryptocurrency>();
        }
    }
}