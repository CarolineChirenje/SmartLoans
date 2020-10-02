

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
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

        public int ClientsOnProduct(int ProductID)
        {
            int result = _context.ClientProducts
                 .Where(r => r.ProductID == ProductID).ToList().Count();


            return result;
        }
        public async Task<Product> GetProduct(string name)
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

        public async Task<List<Product>> Products()
        {
            return await _context.Products

                        .Include(c => c.Company)
               .Include(m => m.Clients)
               .Include(p => p.ProductFees)
               .ThenInclude(p => p.Frequency)
               .Include(p => p.ProductAsserts)
               .ThenInclude(p => p.Assert)
               .ThenInclude(p => p.AssertCategories)
               .Include(p=>p.Country)
                .AsNoTracking()
            .ToListAsync();
        }


        public List<Product> GetProduct()
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


        public async Task<int> Update(Product update)
        {
            Product product = _context.Products.Find(update.ProductID);
            Product old_Product = product;
            product.IsActive = update.IsActive;
            product.CountryID = update.CountryID;
            product.CompanyID = update.CompanyID;
            product.Name = update.Name;
            product.IncreamentPercentage = update.IncreamentPercentage;
            product.DeductionPercentage = update.DeductionPercentage;
            product.ProductCode = update.ProductCode;
            product.LastChangedBy = UtilityService.CurrentUserName;
            product.LastChangedDate = DateTime.Now;
            _context.Update(product);

            // save history
            ProductHistory productHistory = new ProductHistory();
            productHistory.ProductID = old_Product.ProductID;
            productHistory.IncreamentPercentage = old_Product.IncreamentPercentage;
            productHistory.DeductionPercentage = old_Product.DeductionPercentage;
            productHistory.LastChangedBy = old_Product.LastChangedBy;
            productHistory.LastChangedDate = old_Product.LastChangedDate;
            _context.Add(productHistory);

            return await _context.SaveChangesAsync();

        }
        public async Task<int> Save(Product Product)
        {
            Product.LastChangedBy = UtilityService.CurrentUserName;
            Product.LastChangedDate = DateTime.Now;
            _context.Add(Product);
          await  _context.SaveChangesAsync();
            return  Product.ProductID;
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


        public List<Company> Companies()
        {
            return _context.Companies.Where(c => c.IsActive)
           .AsNoTracking()
             .ToList();
        }


        public async Task<Assert> FindAssert(int assertID)
        {
            return await _context.Asserts.Where(a =>a.AssertID==assertID)
            .Include(a=>a.AssertCategories)
            .AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<int> Save(Assert Assert)
        {

            Assert.LastChangedBy = UtilityService.CurrentUserName;
            Assert.LastChangedDate = DateTime.Now;
            _context.Add(Assert);
            await _context.SaveChangesAsync();
            return Assert.AssertID;
        }

        public async Task<bool> IsDuplicate(Assert Assert)
        {


            Assert assert = await _context.Asserts.Where(b => b.Name.Equals(Assert.Name)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(assert);
        }
        public async Task<int> Update(Assert Assert)
        {
            Assert assert = _context.Asserts.Find(Assert.AssertID);
            assert.IsActive = Assert.IsActive;
            assert.Name = Assert.Name;
            assert.Description = Assert.Description;
            assert.LastChangedBy = UtilityService.CurrentUserName;
            assert.LastChangedDate = DateTime.Now;
            _context.Update(assert);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> ActionAssert(int assertID, DatabaseAction action)
        {

            Assert Assert = await FindAssert(assertID);

            if (DatabaseAction.Remove == action)
                _context.Asserts.Remove(Assert);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                Assert.IsActive = DatabaseAction.Deactivate == action ? false : true;
                Assert.LastChangedBy = UtilityService.CurrentUserName;
                Assert.LastChangedDate = DateTime.Now;
                _context.Update(Assert);
            }

            return await _context.SaveChangesAsync();
        }


        public List<ProductAssert> GetProductAsserts(int productid) => _context.ProductAsserts.Where(p => p.ProductID == productid).ToList();
        public List<AssertCategory> GetAssertCategories(int assertid) => _context.AssertCategories
                  .Where(c => c.AssertID == assertid).ToList();

        public async Task<AssertCategory> FindAssertCategory(int id)
        {
            return await _context.AssertCategories.
                Include(c => c.Assert).
              Where(r => r.AssertCategoryID == id)
                 .AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<int> Save(AssertCategory AssertCategory)
        {
            AssertCategory.LastChangedBy = UtilityService.CurrentUserName;
            AssertCategory.LastChangedDate = DateTime.Now;
            _context.Add(AssertCategory);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Update(AssertCategory AssertCategory)
        {
            AssertCategory assertCategory = _context.AssertCategories.Find(AssertCategory.AssertCategoryID);
            assertCategory.IsActive = AssertCategory.IsActive;
            assertCategory.Name = AssertCategory.Name;
            assertCategory.LastChangedBy = UtilityService.CurrentUserName;
            assertCategory.LastChangedDate = DateTime.Now;
            _context.Update(assertCategory);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> ActionAssertCategory(int id, DatabaseAction action)

        {
            AssertCategory assertCategory = await FindAssertCategory(id);

            if (DatabaseAction.Remove == action)
                _context.AssertCategories.Remove(assertCategory);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                assertCategory.IsActive = DatabaseAction.Deactivate == action ? false : true;
                assertCategory.LastChangedBy = UtilityService.CurrentUserName;
                assertCategory.LastChangedDate = DateTime.Now;
                _context.Update(assertCategory);
            }

            return (await _context.SaveChangesAsync());

        }

        public async Task<bool> IsDuplicate(AssertCategory assertCategory)
        {


            AssertCategory _assertCategory = await _context.AssertCategories.Where(b => b.Name.Equals(assertCategory.Name)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(_assertCategory);
        }

        public List<ProductAssert> ProductAsserts(int ProductId)
        {
            return _context.ProductAsserts
            .Where(p => p.ProductID == ProductId).ToList();
        }

        public Task<List<Assert>> Asserts()
        {
            return _context.Asserts
            .Include(a=>a.AssertCategories)
            .ToListAsync();
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
                        LastChangedBy = UtilityService.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(productAssert);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<int> RemoveAssertFromProduct(int productid, List<int> asserts)
        {
            List<ProductAssert> productAsserts = await _context.ProductAsserts.Where(p => p.ProductID == productid).ToListAsync();
            var assertsToBeRemoved = productAsserts
                    .Where(x => asserts.Any(y => y == x.AssertID));
            _context.ProductAsserts.RemoveRange(assertsToBeRemoved);
            return (await _context.SaveChangesAsync());
        }

        IEnumerable<int> ProductAssertList(int productID)
        {

            return from c in _context.ProductAsserts
                   where c.ProductID == productID
                   select c.AssertID;
        }

        //Product 
        public async Task<ProductFee> FindProductFee(int id)
        {
            return await _context.ProductFees.
                 Include(p => p.Product).
                Where(p => p.ProductFeeID == id).FirstOrDefaultAsync();
        }
        public async Task<int> Save(ProductFee ProductFee)
        {
            ProductFee.LastChangedBy = UtilityService.CurrentUserName;
            ProductFee.LastChangedDate = DateTime.Now;
            _context.Add(ProductFee);
            return (await _context.SaveChangesAsync());

        }
        public async Task<int> Update(ProductFee ProductFee)
        {
            ProductFee update = _context.ProductFees.
            Where(t => t.ProductFeeID == ProductFee.ProductFeeID).FirstOrDefault();

            update.Name = ProductFee.Name;
            update.FrequencyID = ProductFee.FrequencyID;
            update.IsActive = ProductFee.IsActive;
            update.Amount = ProductFee.Amount;
            update.Description = ProductFee.Description;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Entry(update).State = EntityState.Modified;

            AddProductHistory(ProductFee);
            return await _context.SaveChangesAsync();
        }


        void AddProductHistory(ProductFee productFee)

        {  //Fee History
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
        public async Task<int> ActionProductFee(int id, DatabaseAction action)
        {

            ProductFee productFee = await FindProductFee(id);
            AddProductHistory(productFee);
            if (DatabaseAction.Remove == action)
            {

                _context.ProductFees.Remove(productFee);

            }
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                productFee.LastChangedBy = UtilityService.CurrentUserName;
                productFee.LastChangedDate = DateTime.Now;
                _context.Update(productFee);
            }

            return (await _context.SaveChangesAsync());
        }

    }
}

