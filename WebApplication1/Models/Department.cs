using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Selles { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller)
        {
            Selles.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Selles.Sum(sl => sl.TotalSales(initial, final));
        }
    }
}
