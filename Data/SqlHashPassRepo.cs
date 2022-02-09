using System;
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

        public void CreateHashPass(HashPassModel hashPass)
        {
            if (hashPass == null)
            {
                throw new ArgumentNullException(nameof(hashPass));
            }

            _context.HashPass.Add(hashPass);
        }

        public void DeleteHashPass(HashPassModel hashPass)
        {
            if (hashPass == null)
            {
                throw new ArgumentNullException(nameof(hashPass));
            }

            _context.HashPass.Remove(hashPass);
        }

        public IEnumerable<HashPassModel> GetAllHashPass()
        {
            return _context.HashPass.ToList();
        }

        public HashPassModel GetHashPassById(int id)
        {
            return _context.HashPass.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateHashPass(HashPassModel hashPass)
        {
            //NADA
        }
    }
}