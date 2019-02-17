using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SellersService
    {
        private readonly WebApplication1Context _webApplication1Context;

        public SellersService(WebApplication1Context webApplication1Context)
        {
            _webApplication1Context = webApplication1Context;
        }

        public List<Seller> FindAll()
        {
            return _webApplication1Context.Seller.ToList();
        }
        public void Insert(Seller seller)
        {
            _webApplication1Context.Add(seller);
            _webApplication1Context.SaveChanges();
        }
    }
}
