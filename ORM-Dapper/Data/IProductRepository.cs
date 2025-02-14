using System;
using ORM_Dapper.Models;
namespace ORM_Dapper.Data;

	public interface IProductRepository
	{
		public IEnumerable<Product> GetAllProducts();

	public void UpdateProduct(int productId, string newName, double newPrice, int categoryId, bool onSale, int stockLevel);
	public void CreateProduct(string name, double price, int categoryId, bool onSale, int stockLevel);
	public void DeleteProduct(int productId);
	

	}

