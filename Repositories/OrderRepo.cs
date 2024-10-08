﻿using E_Commerce.Interfaces;
using E_Commerce.Models;
using E_Commerce.Models.DbModels;

namespace E_Commerce.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        readonly ShopContext _context;
        public OrderRepo(ShopContext context) => _context = context;

        public ICollection<Order> GetAll() => _context.Orders.ToList();

        public Order? GetById(int id) => _context.Orders.SingleOrDefault(o => o.Id == id);

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
        public void Delete(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public bool OrderExist(int customerId) => _context.Orders.Any(o => o.CustomerId == customerId);
    }
}