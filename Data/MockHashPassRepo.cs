using System.Collections.Generic;
using HashPass.Data;
using HashPass.Models;

namespace MockHasPass.Data
{
    public class MockHashPassRepo : IHashPassRepo
    {
        public void CreateHashPass(HashPassModel hashPass)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteHashPass(HashPassModel hashPass)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<HashPassModel> GetAllHashPass()
        {
            var hashPassLista = new List<HashPassModel>
            {
                new HashPassModel
                {
                    Id = 0,
                    PassText = "Teste",
                    HashPass = "!8*@#$",
                    CreationDate = "2022-01-19 22:51:53.123"
                },
                new HashPassModel
                {
                    Id = 1,
                    PassText = "Senha",
                    HashPass = "*7&Ç##",
                    CreationDate = "2022-01-19 22:52:12.000"
                },
                new HashPassModel
                {
                    Id = 2,
                    PassText = "Numero3",
                    HashPass = "#rBe&*!!",
                    CreationDate = "2022-01-19 22:55:55.568"
                }
            };

            return hashPassLista;
        }

        public HashPassModel GetHashPassById(int id)
        {
            return new HashPassModel
            {
                Id = 0,
                PassText = "Teste",
                HashPass = "!8*@#$",
                CreationDate = "2022-01-19 22:51:53.123"
            };
        }

        public HashPassModel GetHashPassTextDecrypted(string hashPass)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateHashPass(HashPassModel hashPass)
        {
            throw new System.NotImplementedException();
        }
    }
}