﻿using exercise.wwwapi.Model;

namespace exercise.wwwapi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts(string category);
        Task<Product> GetProduct(int id);
        Task<Product> GetProductByName(string name);
        Task<Product> AddProduct(Product product);
        Task UpdateProduct(int id , Product product);
        Task<Product> DeleteProduct(int id);
    }
}
