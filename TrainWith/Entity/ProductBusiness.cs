using TrainWith.Interfaces;

namespace TrainWith.Entity;

public class ProductBusiness : IBaseBusiness<Product>
{
    private readonly List<Product> _products = new();

    public Result<List<Product>> GetAll()
    {
        return Result<List<Product>>.SuccessResult(true, _products);
    }

    public Result<bool> Add(Product item)
    {
        if (item == null)
            return Result<bool>.FailureResult(false ,false, message: "Fail to Add Product");

        _products.Add(item);
        return Result<bool>.SuccessResult(true, true, message: "Success to Add Product");
    }

    // false , false =>  success that is from bool property ,data that is from Result<bool>
    public Result<bool> Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return Result<bool>.FailureResult(false, false, message: "Fail to Delete Product");

        _products.Remove(product);
        return Result<bool>.SuccessResult(true, true, message: "Success to Delete Product");

    }

    public Result<bool> Update(Product item)
    {
        var product = _products.FirstOrDefault(p => p.Id == item.Id);
        if (product == null)
            return Result<bool>.FailureResult(false, false, message: "Fail to Update Product");

        product.Name = item.Name;
        product.Price = item.Price;
        return Result<bool>.SuccessResult(false, false, message: "Success to Update Product");
    }

}
