using System.Collections.Generic;
using HashPass.Models;

namespace HashPass.Data
{
    public interface IHashPassRepo
    {
        IEnumerable<HashPassModel> GetAllHashPass();
        HashPassModel GetHashPassById(int id);
    }
}