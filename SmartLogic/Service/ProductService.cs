

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SmartDataAccess;
using SmartDomain;
using SmartExtensions;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            try
            {

                Product product = await _context.Products
                   .Where(r => r.ProductID == ProductID)
                    .Include(c => c.Company)
                     .Include(p => p.ProductFees)
                    .ThenInclude(c => c.CalculationType)
                     .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Fee)
               .AsNoTracking().FirstOrDefaultAsync();

                return product;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<Product> GetProduct(string name)
        {
            try
            {
                return await _context.Products.Where(r => r.Name.ToUpper() == name.Trim().ToUpper())
                   .Include(c => c.Company)
                    .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Fee)
                      .Include(p => p.ProductFees)
                   .ThenInclude(p => p.CalculationType)
                  .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<Product>> Products()
        {
            try
            {

                return await _context.Products

                            .Include(c => c.Company)
                                      .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Fee)
                                    .Include(p => p.Country)
                    .AsNoTracking()
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<Product> GetProduct()
        {
            try
            {

                return _context.Products
               .Include(c => c.Company)
                   .Include(m => m.Loans)
                   .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Fee)
                                  .AsNoTracking()
                .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(Product update)
        {
            try
            {

                Product product = _context.Products.Find(update.ProductID);
                Product old_Product = product;
                product.IsActive = update.IsActive;
                product.CountryID = update.CountryID;
                product.CompanyID = update.CompanyID;
                product.Name = update.Name;
                product.CurrencyID = update.CurrencyID;
                product.IsLegibleForPenalties = update.IsLegibleForPenalties;
                product.ProductComputationID = update.ProductComputationID;
                product.ProductCode = update.ProductCode;
                product.LastChangedBy = UserAppData.CurrentUserName;
                product.LastChangedDate = DateTime.Now;
                _context.Update(product);

                // save history
                ProductHistory productHistory = new ProductHistory();
                productHistory.ProductID = old_Product.ProductID;
                productHistory.IsLegibleForPenalties = old_Product.IsLegibleForPenalties;
                productHistory.ProductComputationID = old_Product.ProductComputationID;
                productHistory.CurrencyID = old_Product.CurrencyID;
                productHistory.LastChangedBy = old_Product.LastChangedBy;
                productHistory.LastChangedDate = old_Product.LastChangedDate;
                _context.Add(productHistory);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Save(Product Product)
        {
            try
            {
                Product.LastChangedBy = UserAppData.CurrentUserName;
                Product.LastChangedDate = DateTime.Now;
                _context.Add(Product);
                await _context.SaveChangesAsync();
                return Product.ProductID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Delete(int id)
        {
            try
            {
                var Product = await _context.Products.FindAsync(id);
                _context.Products.Remove(Product);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionProduct(int ProductID, DatabaseAction action)
        {
            try
            {

                Product Product = await GetProduct(ProductID);
                if (DatabaseAction.Remove == action)
                    _context.Products.Remove(Product);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Product.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    Product.LastChangedBy = UserAppData.CurrentUserName;
                    Product.LastChangedDate = DateTime.Now;
                    _context.Update(Product);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<Company> Companies()
        {
            try
            {

                return _context.Companies.Where(c => c.IsActive)
               .AsNoTracking()
                 .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        //Product 
        public async Task<ProductFee> FindProductFee(int id)
        {
            try
            {
                return await _context.ProductFees.
                     Include(p => p.Product).
                    Where(p => p.ProductFeeID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(ProductFee ProductFee)
        {
            try
            {

                ProductFee.LastChangedBy = UserAppData.CurrentUserName;
                ProductFee.LastChangedDate = DateTime.Now;
                _context.Add(ProductFee);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> Update(ProductFee ProductFee)
        {
            try
            {
                ProductFee update = _context.ProductFees.
                Where(t => t.ProductFeeID == ProductFee.ProductFeeID).FirstOrDefault();
                update.FeeID = ProductFee.FeeID;
                update.IsActive = ProductFee.IsActive;
                update.Amount = ProductFee.Amount;
                update.CalculationTypeID = ProductFee.CalculationTypeID;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Entry(update).State = EntityState.Modified;
                AddProductHistory(ProductFee);
                int result= await _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        void AddProductHistory(ProductFee productFee)
        {
            try
            {

                //Fee History
                ProductFeeHistory feeHistory = new ProductFeeHistory();
                feeHistory.Amount = productFee.Amount;
                feeHistory.CalculationTypeID = productFee.CalculationTypeID;
                feeHistory.IsActive = productFee.IsActive;
                feeHistory.FeeID = productFee.FeeID;
                feeHistory.ProductID = productFee.ProductID;
                feeHistory.ProductFeeID = productFee.ProductFeeID;
                feeHistory.LastChangedBy = productFee.LastChangedBy;
                feeHistory.LastChangedDate = productFee.LastChangedDate;
                _context.Add(feeHistory);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }
        public async Task<int> ActionProductFee(int id, DatabaseAction action)
        {
            try
            {

                ProductFee productFee = await FindProductFee(id);
                AddProductHistory(productFee);
                if (DatabaseAction.Remove == action)
                {

                    _context.ProductFees.Remove(productFee);

                }
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    productFee.LastChangedBy = UserAppData.CurrentUserName;
                    productFee.LastChangedDate = DateTime.Now;
                    _context.Update(productFee);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

    }
}

