using System;
using System.Collections.Generic;
using System.Text;
using TDD_Entities;

namespace TDD_DAL
{
    public interface IPMS_DAL
    {
        int Insert(Product product);
        IEnumerable<Product> SelectAll();
        Product SearchById(int id);
    }
}
