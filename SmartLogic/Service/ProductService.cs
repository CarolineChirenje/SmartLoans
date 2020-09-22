

using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartLogic
{
    public class ProductService : IProductService
    {
        private readonly DatabaseContext _context;

        public ProductService(DatabaseContext context) => _context = context;

        public async Task<Product> FindProduct(int id = 0) => await GetProduct(id);
        public async Task<Product> GetProduct(int ProductID = 0)
        {
            Product product= await _context.Products
               .Where(r => r.ProductID == ProductID)
                .Include(c => c.Company)
               .Include(m => m.Clients)
              
               .AsNoTracking().FirstOrDefaultAsync();

            return product;
        }

        public int ClientsOnProduct(int ProductID )
        {
          int result=   _context.ClientProducts
               .Where(r => r.ProductID == ProductID).ToList().Count();
              

            return result;
        }
        public async Task<Product> GetProduct(string name)
        {
            return await _context.Products.Where(r => r.Name.ToUpper() == name.Trim().ToUpper())
                           .Include(m => m.Clients)
                           .Include(c => c.Company)
                           .AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<List<Product>> Products()
        {
            return await _context.Products
                        .Include(m => m.Clients)
                        .Include(c => c.Company)
                        .AsNoTracking()
            .ToListAsync();
        }


        public List<Product> GetProduct()
        {
            return _context.Products
            .Include(m => m.Clients)
            .Include(c => c.Company)
            .AsNoTracking()
            .ToList();
        }


        public async Task<int> Update(Product update)
        {
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Save(Product Product)
        {
            Product.LastChangedBy = UtilityService.CurrentUserName;
            Product.LastChangedDate = DateTime.Now;
            _context.Add(Product);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Delete(int id)
        {
            var Product = await _context.Products.FindAsync(id);
            _context.Products.Remove(Product);
            return (await _context.SaveChangesAsync());
        }

        public async Task<int> ActionProduct(int ProductID, DatabaseAction action)
        {
            Product Product = await GetProduct(ProductID);

            if (DatabaseAction.Remove == action)
                _context.Products.Remove(Product);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Product.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Product.LastChangedBy = UtilityService.CurrentUserName;
                Product.LastChangedDate = DateTime.Now;
                _context.Update(Product);
            }

            return (await _context.SaveChangesAsync());
        }



        public List<ProductFrequency> ProductFrequencies()
        {
            return _context.ProductFrequencies
           .AsNoTracking()
             .ToList();
        }

        public List<Company> Companies()
        {
            return _context.Companies.Where(c=>c.IsActive)
           .AsNoTracking()
             .ToList();
        }
    }
}

