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
        List<Company> Companies();

        //Product Fee
        Task<ProductFee> FindProductFee(int id);
        Task<int> Save(ProductFee productFee);
        Task<int> Update(ProductFee productFee);
        Task<int> ActionProductFee(int id, DatabaseAction action);

        ProductFee GetProductFee(int productID, int feeID); 

        int GetProductType(int productID);

    }
}


