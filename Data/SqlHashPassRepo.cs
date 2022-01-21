using System.Collections.Generic;
using System.Linq;
using HashPass.Data;
using HashPass.Models;

namespace SqlHashPass.Data
{
    public class SqlHashPassRepo : IHashPassRepo
    {
        private readonly HashPassContext _context;

        public SqlHashPassRepo(HashPassContext context)
        {
            _context = context;
        }

        public IEnumerable<HashPassModel> GetAllHashPass()
        {
            return _context.HashPass.ToList();
        }

        public HashPassModel GetHashPassById(int id)
        {
            return _context.HashPass.FirstOrDefault(p => p.Id == id);
        }
    }
}