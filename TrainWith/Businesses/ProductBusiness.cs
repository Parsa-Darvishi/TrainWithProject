using TrainWith.Entity;
using TrainWith.Interfaces;
using TrainWith.Wrappers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrainWith.Businesses;

public class ProductBusiness : IBaseBusiness<Product>
{
    private readonly List<Product> _products = new();

    //از ریزالت استفاده میکنم تا وضعیت .و پیام اختصاصی داشته باشم.

    public Result<List<Product>> GetAll()
    {
        return Result<List<Product>>.Success(Data: _products);
    }

    public Result<int> Add(Product item)
    {
        if (item == null)
            return Result<int>.Failure();

        _products.Add(item);
        return Result<int>.Success(item.Id);
    }

    // false , false =>  success that is from bool property ,data that is from Result<bool>
    public Result<bool> Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return Result<bool>.Failure();

        _products.Remove(product);
        return Result<bool>.Success(true);

    }

    public Result<bool> Update(Product item)
    {
        var product = _products.FirstOrDefault(p => p.Id == item.Id);
        if (product == null)
            return Result<bool>.Failure();

        product.Name = item.Name;
        product.Price = item.Price;
        return Result<bool>.Success(true);
    }

}
