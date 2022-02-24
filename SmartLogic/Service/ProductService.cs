

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
                   .Include(m => m.Clients)
                   .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Frequency)
                   .Include(p => p.ProductAsserts)
                   .ThenInclude(p => p.Assert)
                   .ThenInclude(p => p.AssertCategories)
                   .AsNoTracking().FirstOrDefaultAsync();

                return product;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public int ClientsOnProduct(int ProductID)
        {
            try
            {
                int result = _context.ClientProducts
                     .Where(r => r.ProductID == ProductID).ToList().Count();
                return result;
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
                   .Include(m => m.Clients)
                   .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Frequency)
                   .Include(p => p.ProductAsserts)
                   .ThenInclude(p => p.Assert)
                   .ThenInclude(p => p.AssertCategories)
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
                   .Include(m => m.Clients)
                   .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Frequency)
                   .Include(p => p.ProductAsserts)
                   .ThenInclude(p => p.Assert)
                   .ThenInclude(p => p.AssertCategories)
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
                   .Include(m => m.Clients)
                   .Include(p => p.ProductFees)
                   .ThenInclude(p => p.Frequency)
                   .Include(p => p.ProductAsserts)
                   .ThenInclude(p => p.Assert)
                   .ThenInclude(p => p.AssertCategories)
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
                product.IncreamentPercentage = update.IncreamentPercentage;
                product.DeductionPercentage = update.DeductionPercentage;
                product.TransactionalFee = update.TransactionalFee;
                product.ProductCode = update.ProductCode;
                product.LastChangedBy = UserAppData.CurrentUserName;
                product.LastChangedDate = DateTime.Now;
                _context.Update(product);

                // save history
                ProductHistory productHistory = new ProductHistory();
                productHistory.ProductID = old_Product.ProductID;
                productHistory.IncreamentPercentage = old_Product.IncreamentPercentage;
                productHistory.DeductionPercentage = old_Product.DeductionPercentage;
                productHistory.TransactionalLevy = old_Product.TransactionalFee;
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


        public async Task<Assert> FindAssert(int assertID)
        {
            try
            {
                return await _context.Asserts.Where(a => a.AssertID == assertID)
                .Include(a => a.AssertCategories)
                .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Assert Assert)
        {
            try
            {
                Assert.LastChangedBy = UserAppData.CurrentUserName;
                Assert.LastChangedDate = DateTime.Now;
                _context.Add(Assert);
                await _context.SaveChangesAsync();
                return Assert.AssertID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(Assert Assert)
        {
            try
            {
                Assert assert = await _context.Asserts.Where(b => b.Name.Equals(Assert.Name)).FirstOrDefaultAsync();
                return assert.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(Assert Assert)
        {
            try
            {
                Assert assert = _context.Asserts.Find(Assert.AssertID);
                assert.IsActive = Assert.IsActive;
                assert.Name = Assert.Name;
                assert.Description = Assert.Description;
                assert.LastChangedBy = UserAppData.CurrentUserName;
                assert.LastChangedDate = DateTime.Now;
                _context.Update(assert);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionAssert(int assertID, DatabaseAction action)
        {
            try
            {
                Assert Assert = await FindAssert(assertID);
                if (DatabaseAction.Remove == action)
                    _context.Asserts.Remove(Assert);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    Assert.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    Assert.LastChangedBy = UserAppData.CurrentUserName;
                    Assert.LastChangedDate = DateTime.Now;
                    _context.Update(Assert);
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<ProductAssert> GetProductAsserts(int productid)
        {
            try
            {
                return _context.ProductAsserts.Where(p => p.ProductID == productid).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<AssertCategory> GetAssertCategories(int assertid)
        {
            try
            {
                return _context.AssertCategories
    .Where(c => c.AssertID == assertid).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<AssertCategory> FindAssertCategory(int id)
        {
            try
            {
                return await _context.AssertCategories.
                    Include(c => c.Assert).
                  Where(r => r.AssertCategoryID == id)
                     .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(AssertCategory AssertCategory)
        {
            try
            {
                AssertCategory.LastChangedBy = UserAppData.CurrentUserName;
                AssertCategory.LastChangedDate = DateTime.Now;
                _context.Add(AssertCategory);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(AssertCategory AssertCategory)
        {
            try
            {

                AssertCategory assertCategory = _context.AssertCategories.Find(AssertCategory.AssertCategoryID);
                assertCategory.IsActive = AssertCategory.IsActive;
                assertCategory.Name = AssertCategory.Name;
                assertCategory.LastChangedBy = UserAppData.CurrentUserName;
                assertCategory.LastChangedDate = DateTime.Now;
                _context.Update(assertCategory);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionAssertCategory(int id, DatabaseAction action)
        {
            try
            {
                AssertCategory assertCategory = await FindAssertCategory(id);
                if (DatabaseAction.Remove == action)
                    _context.AssertCategories.Remove(assertCategory);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    assertCategory.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    assertCategory.LastChangedBy = UserAppData.CurrentUserName;
                    assertCategory.LastChangedDate = DateTime.Now;
                    _context.Update(assertCategory);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<bool> IsDuplicate(AssertCategory assertCategory)
        {
            try
            {
                AssertCategory _assertCategory = await _context.AssertCategories.Where(b => b.Name.Equals(assertCategory.Name)).FirstOrDefaultAsync();
                return _assertCategory.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }

        }

        public List<ProductAssert> ProductAsserts(int ProductId)
        {
            try
            {
                return _context.ProductAsserts
          .Where(p => p.ProductID == ProductId).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public Task<List<Assert>> Asserts()
        {
            try
            {
                return _context.Asserts
                .Include(a => a.AssertCategories)
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        // Product Assert
        public async Task<int> UpdateProductAsserts(int productID, string[] selectedAsserts)
        {
            int result = 0;
            try
            {
                List<int> old_Asserts = ProductAssertList(productID).ToList();
                List<int> add_Asserts = new List<int>();
                List<int> remove_Asserts = new List<int>();
                int[] updated_Details = selectedAsserts == null ? null : Array.ConvertAll(selectedAsserts, s => int.Parse(s));


                if (old_Asserts == null && old_Asserts.Count == 0)
                {
                    add_Asserts = updated_Details.ToList();
                    return await AddAsserts(productID, add_Asserts);
                }
                foreach (var assert in _context.Asserts)
                {
                    if (selectedAsserts.Contains(assert.AssertID.ToString()))
                    {
                        if (!old_Asserts.Contains(assert.AssertID))
                        {
                            add_Asserts.Add(assert.AssertID);
                        }
                    }
                    else
                    {
                        if (old_Asserts.Contains(assert.AssertID))
                        {
                            remove_Asserts.Add(assert.AssertID);
                        }
                    }
                }
                int _addResult = await AddAsserts(productID, add_Asserts);
                int _removeResult = await RemoveAssertFromProduct(productID, remove_Asserts);
                result = _addResult + _removeResult;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
            return result;
        }

        public async Task<int> AddAsserts(int productid, List<int> asserts)
        {
            try
            {
                foreach (int assertid in asserts)
                {
                    ProductAssert productAssert = new ProductAssert
                    {
                        AssertID = assertid,
                        ProductID = productid,
                        LastChangedBy = UserAppData.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(productAssert);
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
        }
        public async Task<int> RemoveAssertFromProduct(int productid, List<int> asserts)
        {
            try
            {
                List<ProductAssert> productAsserts = await _context.ProductAsserts.Where(p => p.ProductID == productid).ToListAsync();
                var assertsToBeRemoved = productAsserts
                        .Where(x => asserts.Any(y => y == x.AssertID));
                _context.ProductAsserts.RemoveRange(assertsToBeRemoved);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        IEnumerable<int> ProductAssertList(int productID)
        {
            try
            {
                return from c in _context.ProductAsserts
                       where c.ProductID == productID
                       select c.AssertID;
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
                update.Name = ProductFee.Name;
                update.FrequencyID = ProductFee.FrequencyID;
                update.IsActive = ProductFee.IsActive;
                update.Amount = ProductFee.Amount;
                update.Description = ProductFee.Description;
                update.LastChangedBy = UserAppData.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Entry(update).State = EntityState.Modified;
                AddProductHistory(ProductFee);
                return await _context.SaveChangesAsync();
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
            feeHistory.Description = productFee.Description;
            feeHistory.IsActive = productFee.IsActive;
            feeHistory.FrequencyID = productFee.FrequencyID;
            feeHistory.Name = productFee.Name;
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

