using System;
using System.Collections.Generic;
using System.Linq;
using TDD_Entities;

namespace TDD_DAL
{
    public class PMS_EFSQL_Repo : IPMS_DAL
    {
        private readonly PMS_DbContext dbContext = null;
        public PMS_EFSQL_Repo(PMS_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int Insert(Product product)
        {
            try
            {
                var prodId = dbContext.Products.Add(product).Entity.ProductId;
                dbContext.SaveChanges();
                return prodId;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Product SearchById(int id)
        {
            try
            {
                Product prod = dbContext.Products.Find(id);
                return prod;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Product> SelectAll()
        {
            try
            {
                return dbContext.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
