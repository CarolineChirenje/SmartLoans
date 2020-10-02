using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IProductService
    {

        Task<int> Delete(int id);
        Task<int> Save(Product Product);
        Task<int> Update(Product Product);
        Task<int> ActionProduct(int ProductId, DatabaseAction action);
        Task<Product> GetProduct(int ProductId);

        Task<Product> FindProduct(int ProductId);
        Task<List<Product>> Products();
        List<ProductAssert> ProductAsserts(int ProductId);
        List<Company> Companies();
        int ClientsOnProduct(int ProductID);

        //ProductAssert
             
        Task<int> UpdateProductAsserts(int productID, string[] selectedAsserts);
        
        //Asserts
        Task<List<Assert>> Asserts();
        Task<Assert> FindAssert(int assertID);
        Task<int> Save(Assert Assert);
        Task<bool> IsDuplicate(Assert Assert);
        Task<int> Update(Assert Assert);
        Task<int> ActionAssert(int assertID, DatabaseAction action);
        List<ProductAssert> GetProductAsserts(int productID);
        //Assert Categories
        List<AssertCategory> GetAssertCategories(int assertid);
        Task<AssertCategory> FindAssertCategory(int id);
        Task<int> Save(AssertCategory AssertCategory);
        Task<int> Update(AssertCategory AssertCategory);
        Task<int> ActionAssertCategory(int id, DatabaseAction action);
        Task<bool> IsDuplicate(AssertCategory assertCategory);


        //Product Fee
        Task<ProductFee> FindProductFee(int id);
        Task<int> Save(ProductFee productFee);
        Task<int> Update(ProductFee productFee);
        Task<int> ActionProductFee(int id, DatabaseAction action);



    }
}


