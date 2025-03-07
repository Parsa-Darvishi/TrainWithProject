using TrainWith.Entity;

namespace TrainWith.Interfaces
{
    public interface IBaseBusiness<T> where T : class
    {
        Result<List<T>> GetAll();
        Result<bool> Add(T item);
        Result<bool> Delete(int id);
        Result<bool> Update(T item);
    }
}
